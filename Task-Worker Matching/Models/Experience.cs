public class Experience
{
    public int WorkerId { get; set; }
    public int SpecialtyId { get; set; }
    public int? Year { get; set; }

    public virtual Worker Worker { get; set; } = null!;
    public virtual WorkerSpecialty Specialty { get; set; } = null!;
}