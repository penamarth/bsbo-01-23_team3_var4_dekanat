namespace Domain.Entities;

public class Student
{
	public int Id { get; set; }
	public required string FirstName { get; set; }
	public required string LastName { get; set; }
	public string? MiddleName { get; set; }
	public int? GroupId { get; set; }
	public required string Code { get; set; }
	public int StatusId { get; set; }
	public Group? Group { get; set; }
	public required StudentStatus Status { get; set; }
	public List<AcademicRecord> AcademicRecords { get; set; } = new();
}