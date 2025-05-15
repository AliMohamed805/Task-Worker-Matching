public class Request
{
    public int RequestId { get; set; }
    public int TaskId { get; set; }
    public int ClientId { get; set; }
    public DateTime? RequestTime { get; set; }
    public string? RequestAddress { get; set; }
    public string? RequestStatus { get; set; } = "Pending";
    public string? PreferredTimeSlot { get; set; }
    public decimal? ActualTimeTaken { get; set; }

    public virtual Task Task { get; set; } = null!;
    public virtual Client Client { get; set; } = null!;
    public virtual ICollection<Feedback> Feedback { get; set; } = new List<Feedback>();
}