using Application.Interfaces.Services;

namespace Infrastructure.Services;

public class EducationalDepartmentService : IEducationalDepartmentService
{
	public string CheckRequestStatus(int id)
	{
		Console.WriteLine("EducationalDepartmentService CheckRequestStatus");
		return string.Empty;
	}

	public void SendTransferRequest(int studentId, int groupId)
	{
		Console.WriteLine("EducationalDepartmentService SendTransferRequest");
	}
}