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

        public string Name { init; get; }
        public string Description { init; get; }
        public DateTime StartDate { init; get; }
        public DateTime EndDate { init; get; }
    }
}
