using Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface IGroupsRepository
{
	void Add(Group group);
	Group GetById(int id);
	List<Group> GetAll();
	void Update(Group group);
	void Delete(int id);
}