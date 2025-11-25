using Domain.Entities;

namespace Application.Interfaces.Services;

public interface IGroupsService
{
	void CreateGroup(Group group);
	void DisbandGroup(int id);
	void TransferStudent(int groupId, int studentId);
	Group GetGroupInfo(int id);
	void AddStudent(int studentId);
	void RemoveStudent(int studentId);
}