namespace Application.Interfaces.Services;

public interface IEducationalDepartmentService
{
	string CheckRequestStatus(int id);
	void SendTransferRequest(int studentId, int groupId);
}