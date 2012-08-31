using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechEdAu2012.Models
{
    public class Block
    {
        public static Block[] GetStandardSet()
        {
            return new[] {
		        new Block("12am", "8:15am"), // For Completeness
		
		        new Block("8:15am", "9:40am"),
		        new Block("9:45am", "11:00am"),
		        new Block("11:00am", "11:30am"),
		        new Block("11:30am", "12:45pm"),
		        new Block("12:45pm", "1:45pm"),
		        new Block("1:45pm", "3:00pm"),
		
		        new Block("3:00pm", "3:30pm"),
		        new Block("3:30pm", "4:45pm"),
		        new Block("5pm", "6:15pm"),
		        new Block("6:30pm", "7:45pm"),
		
		        new Block("7:45pm", "12am") // For completeness
	        };
        }

        public Block(string start, string end)
        {
            Start = DateTime.Parse(start).TimeOfDay;
            End = DateTime.Parse(end).TimeOfDay;
        }

        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }

        public bool Contains(DateTime? dt)
        {
            if (dt.HasValue == false)
                return false;
            return dt.Value.TimeOfDay >= Start && dt.Value.TimeOfDay < End;
        }

        public override string ToString()
        {
            return DateTime.Today.Add(Start).ToShortTimeString() + " to " + DateTime.Today.Add(End).ToShortTimeString();
        }

    }
}