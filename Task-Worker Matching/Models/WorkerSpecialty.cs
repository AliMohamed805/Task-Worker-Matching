public class WorkerSpecialty
{
    public int SpecialtyId { get; set; }
    public string? Specialty { get; set; }

    public virtual ICollection<Experience> WorkerExperiences { get; set; } = new List<Experience>();
    public virtual ICollection<Requires> RequiredForTasks { get; set; } = new List<Requires>();
}