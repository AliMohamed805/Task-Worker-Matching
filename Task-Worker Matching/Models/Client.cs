using Azure.Core;

public class Client
{
    public int ClientId { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? PaymentInfo { get; set; }
    public decimal? Overall { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
    public virtual ICollection<Feedback> GivenFeedback { get; set; } = new List<Feedback>();
}