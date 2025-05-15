using System;

public class Worker
{
    public int WorkerId { get; set; }
    public string? Name { get; set; }
    public decimal? Overall { get; set; }

    public virtual ICollection<WorkerLocation> WorkerLocations { get; set; } = new List<WorkerLocation>();
    public virtual ICollection<TimeSlot> TimeSlots { get; set; } = new List<TimeSlot>();
    public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();
    public virtual ICollection<CanDo> CanDoTasks { get; set; } = new List<CanDo>();
    public virtual ICollection<Feedback> GivenFeedback { get; set; } = new List<Feedback>();
}