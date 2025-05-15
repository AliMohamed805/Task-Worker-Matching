public class TimeSlot
{
    public int TimeSlotId { get; set; }
    public int WorkerId { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? Day { get; set; }

    public virtual Worker Worker { get; set; } = null!;
}