using Domain.Entities;

namespace Infrastructure.Persistence;

public class DbContext
{
	public List<Student> Students { get; set; } = new();
	public List<Group> Groups { get; set; } = new();
	public List<AcademicRecord> Records { get; set; } = new();
}