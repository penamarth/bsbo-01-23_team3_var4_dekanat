using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Infrastructure.Persistence.Repositories;

public class AcademicRecordsRepository : IAcademicRecordsRepository
{
	private readonly DbContext _dbContext = new();

	public void Add(AcademicRecord academicRecord)
	{
		Console.WriteLine("AcademicRecordsRepository Add");
	}

	public AcademicRecord GetById(int id)
	{
		Console.WriteLine("AcademicRecordsRepository GetById");
		// return _dbContext.Records.Single(r => r.Id == id);
		return new AcademicRecord
		{
			Subject = "Алгоритмы",
			Student = new Student
			{
				FirstName = "Прошунин",
				LastName = "Николай",
				Code = "23БО177",
				Status = new StudentStatus
				{
					Name = "Активен"
				}
			}
		};
	}

	public List<AcademicRecord> GetAll()
	{
		Console.WriteLine("AcademicRecordsRepository GetAll");
		return _dbContext.Records;
	}

	public void Update(AcademicRecord academicRecord)
	{
		Console.WriteLine("AcademicRecordsRepository Update");
	}

	public void Delete(int id)
	{
		Console.WriteLine("AcademicRecordsRepository Delete");
	}
}