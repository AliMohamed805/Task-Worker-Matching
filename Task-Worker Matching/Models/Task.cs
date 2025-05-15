using System;
using System.Collections.Generic;

namespace Task_Worker_Matching.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? RequiredSpeciality { get; set; }
        public decimal? AverageTime { get; set; }
        public decimal? AverageFee { get; set; }
        
        // Fix: Only ONE declaration per property
        public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
        public virtual ICollection<CanDo> CanDoWorkers { get; set; } = new List<CanDo>();
        public virtual ICollection<Requires> RequiredSpecialties { get; set; } = new List<Requires>();
    }
}