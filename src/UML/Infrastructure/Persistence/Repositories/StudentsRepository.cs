using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Infrastructure.Persistence.Repositories;

public class StudentsRepository : IStudentsRepository
{
	private readonly DbContext _dbContext = new();

	public void Add(Student student)
	{
		Console.WriteLine("StudentsRepository Add");
	}

	public Student GetById(int id)
	{
		Console.WriteLine("StudentsRepository GetById");
		return _dbContext.Students.Single(s => s.Id == id);
	}

	public List<Student> GetAll()
	{
		Console.WriteLine("StudentsRepository GetAll");
		return _dbContext.Students;
	}

	public void Update(Student student)
	{
		Console.WriteLine("StudentsRepository Update");
	}

	public void Delete(int id)
	{
		Console.WriteLine("StudentsRepository Delete");
	}
}