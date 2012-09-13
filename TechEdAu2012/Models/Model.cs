using System;

namespace TechEdAu2012.Models
{
    public class DayViewModel
    {
        public DayOfWeek Day { get; set; }
        public BlockViewModel[] Blocks { get; set; }
    }

    public class BlockViewModel
    {
        public string Name { get; set; }
        public SessionViewModel[] Sessions { get; set; }
    }

    public class SessionViewModel
    {
        public string Start { get; set; }
        public string End { get; set; }
        public string Title { get; set; }
        public string Room { get; set; }
        public string Abstract { get; set; }
        public string Code { get; set; }
        public string Track { get; set; }
        public string Level { get; set; }
        public string Speakers { get; set; }

        public int Id { get; set; }
    }
}