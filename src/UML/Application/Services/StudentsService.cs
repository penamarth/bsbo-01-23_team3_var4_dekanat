using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;

namespace Application.Services;

public class StudentsService : IStudentsService
{
	private readonly IStudentsRepository _studentsRepository;

	public StudentsService(IStudentsRepository studentsRepository)
	{
		_studentsRepository = studentsRepository;
	}

	public void CreateStudent(Student student)
	{
		Console.WriteLine("StudentsService CreateStudent");
	}

	public void ExpelStudent(int studentId)
	{
		Console.WriteLine("StudentsService ExpelStudent");
	}

	public void TransferStudent(int studentId, int groupId)
	{
		Console.WriteLine("StudentsService TransferStudent");
	}

	public Student GetStudentInfo(int studentId)
	{
		Console.WriteLine("StudentsService GetStudentInfo");
		return _studentsRepository.GetById(studentId);
	}
}