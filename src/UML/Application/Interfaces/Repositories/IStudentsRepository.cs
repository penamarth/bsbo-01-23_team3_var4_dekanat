using Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface IStudentsRepository
{
	void Add(Student student);
	Student GetById(int id);
	List<Student> GetAll();
	void Update(Student student);
	void Delete(int id);
}