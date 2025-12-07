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

    public void ExpellStudent(int studentId, string reason)
    {
        Console.WriteLine($"StudentsService ExpellStudent по причине: {reason}");
        
        var student = _studentsRepository.GetById(studentId);
        if (student != null)
        {
            Console.WriteLine($"Отчислен студент: {student.FirstName} {student.LastName} ({student.Code})");
        }
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