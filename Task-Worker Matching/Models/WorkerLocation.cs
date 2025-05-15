public class WorkerLocation
{
    public string Location { get; set; } = null!;
    public int WorkerId { get; set; }

    public virtual Worker Worker { get; set; } = null!;
}