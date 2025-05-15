public class Feedback
{
    public int ClientId { get; set; }
    public int WorkerId { get; set; }
    public int RequestId { get; set; }
    public bool FromClient { get; set; }
    public string? Comment { get; set; }
    public decimal? Rating { get; set; }

    public virtual Client Client { get; set; } = null!;
    public virtual Worker Worker { get; set; } = null!;
    public virtual Request Request { get; set; } = null!;
}