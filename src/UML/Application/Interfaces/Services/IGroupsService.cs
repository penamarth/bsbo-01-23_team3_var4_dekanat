using Domain.Entities;

namespace Application.Interfaces.Services;

public interface IGroupsService
{
	void CreateGroup(Group group);
	void DisbandGroup(int id);
	void TransferStudent(int studentId, int groupId);
	Group GetGroupInfo(int id);
	void AddStudent(int studentId, int groupId);
	void RemoveStudent(int studentId);
}