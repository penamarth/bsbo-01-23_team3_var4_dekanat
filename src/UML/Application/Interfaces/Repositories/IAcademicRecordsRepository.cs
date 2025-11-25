using Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface IAcademicRecordsRepository
{
	void Add(AcademicRecord academicRecord);
	AcademicRecord GetById(int id);
	List<AcademicRecord> GetAll();
	void Update(AcademicRecord academicRecord);
	void Delete(int id);
}