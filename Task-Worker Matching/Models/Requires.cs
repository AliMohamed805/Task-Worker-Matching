public class Requires
{
    public int TaskId { get; set; }
    public int SpecialtyId { get; set; }

    public virtual Task Task { get; set; } = null!;
    public virtual WorkerSpecialty Specialty { get; set; } = null!;
}