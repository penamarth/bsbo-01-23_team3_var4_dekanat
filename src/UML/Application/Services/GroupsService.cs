using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;

namespace Application.Services;

public class GroupsService : IGroupsService
{
	private readonly IGroupsRepository _groupsRepository;

	public GroupsService(IGroupsRepository groupsRepository)
	{
		_groupsRepository = groupsRepository;
	}

	public void CreateGroup(Group group)
	{
		Console.WriteLine("GroupsService CreateGroup");
	}

	public void DisbandGroup(int id)
	{
		Console.WriteLine("GroupsService DisbandGroup");
	}

	public void TransferStudent(int groupId, int studentId)
	{
		Console.WriteLine("GroupsService TransferStudent");
	}

	public Group GetGroupInfo(int id)
	{
		Console.WriteLine("GroupsService GetGroupInfo");
		return _groupsRepository.GetById(id);
	}

	public void AddStudent(int studentId)
	{
		Console.WriteLine("GroupsService AddStudent");
	}

	public void RemoveStudent(int studentId)
	{
		Console.WriteLine("GroupsService RemoveStudent");
	}
}