using Domain.Entities;

namespace Application.Interfaces.Services;

public interface IStudentsService
{
	void CreateStudent(Student student);
	void ExpellStudent(int studentId, string reason);
	void TransferStudent(int studentId, int groupId);
	Student GetStudentInfo(int studentId);
}