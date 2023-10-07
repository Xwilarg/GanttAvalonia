using System;

namespace GanttAvalonia.Models
{
    public class GanttTask
    {
        public GanttTask(string name, string description, DateTime startDate, DateTime endDate)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string Name { set; get; }
        public string Description { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
    }
}
