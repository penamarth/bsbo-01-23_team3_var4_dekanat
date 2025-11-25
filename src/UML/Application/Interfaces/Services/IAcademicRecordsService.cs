namespace Application.Interfaces.Services;

public interface IAcademicRecordsService
{
	void AddGrade(int studentId, int grade);
	float CalculateGpa(int studentId);
	string GetTranscript(int studentId);
}