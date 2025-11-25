namespace Domain.Entities;

public class AcademicRecord
{
	public int Id { get; set; }
	public required string Subject { get; set; }
	public int Grade { get; set; }
	public DateOnly Date { get; set; }
	public int StudentId { get; set; }
	public required Student Student { get; set; }
}