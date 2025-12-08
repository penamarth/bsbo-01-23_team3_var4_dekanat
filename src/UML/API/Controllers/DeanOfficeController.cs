using Application.Interfaces.Services;
using Domain.Entities.Documents;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
public class DeanOfficeController : ControllerBase
{
	private readonly IStudentsService _studentsService;
	private readonly IGroupsService _groupsService;
	private readonly IAcademicRecordsService _academicRecordsService;
	private readonly IDigitalDocumentManager _digitalDocumentManager;
	private readonly IEducationalDepartmentService _educationalDepartmentService;

	public DeanOfficeController(IStudentsService studentsService, IGroupsService groupsService,
		IAcademicRecordsService academicRecordsService, IDigitalDocumentManager digitalDocumentManager,
		IEducationalDepartmentService educationalDepartmentService)
	{
		_studentsService = studentsService;
		_groupsService = groupsService;
		_academicRecordsService = academicRecordsService;
		_digitalDocumentManager = digitalDocumentManager;
		_educationalDepartmentService = educationalDepartmentService;
	}

	[HttpPost("enrollStudent")]
	public void EnrollStudent()
	{
		Console.WriteLine("DeanOfficeController EnrollStudent");
	}

	[HttpPost("expellStudent/{id:int}")]
	public void ExpellStudent(int id, [FromBody] ExpulsionRequest request)
	{
		Console.WriteLine("DeanOfficeController ExpellStudent");
		var info = _studentsService.GetStudentInfo(id);
		_groupsService.RemoveStudent(id);
        _studentsService.ExpellStudent(id, request.Reason);
		_digitalDocumentManager.RegisterDocument(new ExpulsionDocument
		{
			Id = "123123",
			StudentId = id,
			Date = DateOnly.FromDateTime(DateTime.Now)
			Reason = reason
		});
		
	}

	[HttpPost("transferStudent")]
	public void TransferStudent(int studentId, int groupId)
	{
		Console.WriteLine("DeanOfficeController TransferStudent");
		_educationalDepartmentService.SendTransferRequest(studentId, groupId);
		if (_educationalDepartmentService.CheckRequestStatus(studentId) != "Success")
			return;
		_groupsService.TransferStudent(groupId, studentId);
	}

	[HttpPut("updateAcademicPerformance")]
	public void UpdateAcademicPerformance()
	{
		Console.WriteLine("DeanOfficeController UpdateAcademicPerformance");
	}
}

public class ExpulsionRequest
{
    public string Reason { get; set; }
}
