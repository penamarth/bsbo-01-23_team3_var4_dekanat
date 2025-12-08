namespace Domain.Entities.Documents;

public class ExpulsionDocument : Document
{
    public int StudentId { get; set; }
    public DateOnly Date { get; set; }
    public string Reason { get; set; }
}