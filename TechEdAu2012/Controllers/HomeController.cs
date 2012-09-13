using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechEdAu2012.Models;

namespace TechEdAu2012.Controllers
{


    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [OutputCache(Duration=60*10)]
        public ActionResult Index()
        {
            var service = new TechEdAu.ODataTEEntities(new Uri("http://odata.msteched.com/teau12/sessions.svc"));

            var standardBlocks = Block.GetStandardSet();

            var schedule = (from sess in service.Sessions.Expand("Track").Expand("SessionType").Expand("Speakers").Expand("Level").AsEnumerable()
                            group sess by sess.Date into g
                            orderby g.Key.Value.Date
                            select new DayViewModel
                            {
                                Day = g.Key.Value.DayOfWeek,
                                Blocks = (
                                    from bl in
                                        (
                                            from s in g
                                            from b in standardBlocks
                                            where b.Contains(s.StartTime)
                                            select new { s, block = b }
                                        )
                                    group bl by bl.block into sessions
                                    orderby sessions.Key.Start
                                    select new BlockViewModel
                                    {
                                        Name = sessions.Key.ToString(),
                                        Sessions = (
                                            from session in sessions
                                            orderby session.s.StartTime.Value, 
                                                    session.s.EndTime.Value descending, 
                                                    session.s.Room
                                            select new SessionViewModel
                                            {
                                                Id = session.s.SessionID,
                                                Start = session.s.StartTime.Value.ToShortTimeString(),
                                                End = session.s.EndTime.Value.ToShortTimeString(),
                                                Code = session.s.Code,
                                                Title = session.s.Title,
                                                Abstract = session.s.Abstract,
                                                Room = session.s.Room, 
                                                Level = session.s.Level.Name,
                                                Track = session.s.Track != null 
                                                            ? session.s.Track.Name 
                                                            : (session.s.SessionType != null
                                                                    ? session.s.SessionType.Name
                                                                    : "?"
                                                              ), 
                                                Speakers = String.Join(", ", session.s.Speakers.Select(x => String.Format("{0} {1}", x.SpeakerFirstName, x.SpeakerLastName.ToUpper())))
                                            }
                                        ).ToArray()
                                    }
                                ).ToArray()
                            }).ToArray();

            return View(schedule);
        }

    }
}
