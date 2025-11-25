namespace Domain.Entities;

public class Group
{
	public int Id { get; set; }
	public required string GroupCode { get; set; }
	public int CourseNumber { get; set; }
	public List<Student> Students = new();
}