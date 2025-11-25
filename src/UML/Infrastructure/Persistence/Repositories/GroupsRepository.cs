using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Infrastructure.Persistence.Repositories;

public class GroupsRepository : IGroupsRepository
{
	private readonly DbContext _dbContext = new();

	public void Add(Group group)
	{
		Console.WriteLine("GroupsRepository Add");
	}

	public Group GetById(int id)
	{
		Console.WriteLine("GroupsRepository GetById");
		return _dbContext.Groups.Single(g => g.Id == id);
	}

	public List<Group> GetAll()
	{
		Console.WriteLine("GroupsRepository GetAll");
		return _dbContext.Groups;
	}

	public void Update(Group group)
	{
		Console.WriteLine("GroupsRepository Update");
	}

	public void Delete(int id)
	{
		Console.WriteLine("GroupsRepository Delete");
	}
}