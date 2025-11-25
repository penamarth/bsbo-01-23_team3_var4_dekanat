using Domain.Entities;

namespace Application.Interfaces.Services;

public interface IStudentsService
{
	void CreateStudent(Student student);
	void ExpelStudent(int studentId);
	void TransferStudent(int studentId, int groupId);
	Student GetStudentInfo(int studentId);
}