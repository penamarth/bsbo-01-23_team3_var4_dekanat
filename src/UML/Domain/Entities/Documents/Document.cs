namespace Domain.Entities.Documents;

public abstract class Document
{
	public required string Id { get; set; }
	public DateOnly Date { get; set; }
}