public class CanDo
{
    public int TaskId { get; set; }
    public int WorkerId { get; set; }

    public virtual Task Task { get; set; } = null!;
    public virtual Worker Worker { get; set; } = null!;
}