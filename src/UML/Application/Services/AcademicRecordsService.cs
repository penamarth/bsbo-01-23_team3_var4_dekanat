using Application.Interfaces.Repositories;
using Application.Interfaces.Services;

namespace Application.Services;

public class AcademicRecordsService : IAcademicRecordsService
{
	private readonly IAcademicRecordsRepository _academicRecordsRepository;

	public AcademicRecordsService(IAcademicRecordsRepository academicRecordsRepository)
	{
		_academicRecordsRepository = academicRecordsRepository;
	}

	public void AddGrade(int studentId, int grade)
	{
		Console.WriteLine("AcademicRecordsService AddGrade");
	}

	public float CalculateGpa(int studentId)
	{
		Console.WriteLine("AcademicRecordsService CalculateGpa");
		return float.MinValue;
	}

	public string GetTranscript(int studentId)
	{
		Console.WriteLine("AcademicRecordsService GetTranscript");
		return string.Empty;
	}
}