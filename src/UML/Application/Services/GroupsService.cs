using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;

namespace Application.Services;

public class GroupsService : IGroupsService
{
	private readonly IGroupsRepository _groupsRepository;
	private readonly IStudentsRepository _studentsRepository;

	public GroupsService(IGroupsRepository groupsRepository, IStudentsRepository studentsRepository)
	{
		_groupsRepository = groupsRepository;
		_studentsRepository = studentsRepository;
	}

	public void CreateGroup(Group group)
	{
		Console.WriteLine("GroupsService CreateGroup");
	}

	public void DisbandGroup(int id)
	{
		Console.WriteLine("GroupsService DisbandGroup");
	}

	public void TransferStudent(int studentId, int groupId)
	{
		Console.WriteLine("GroupsService TransferStudent");
		RemoveStudent(studentId);
		AddStudent(studentId, groupId);
	}

	public Group GetGroupInfo(int id)
	{
		Console.WriteLine("GroupsService GetGroupInfo");
		return _groupsRepository.GetById(id);
	}

	public void AddStudent(int studentId, int groupId)
	{
		Console.WriteLine("GroupsService AddStudent");
		var student = _studentsRepository.GetById(studentId);
		student.GroupId = groupId;
		_studentsRepository.Update(student);
	}

	public void RemoveStudent(int studentId)
	{
		Console.WriteLine("GroupsService RemoveStudent");
		var student = _studentsRepository.GetById(studentId);
		student.GroupId = null;
		_studentsRepository.Update(student);
	}
}