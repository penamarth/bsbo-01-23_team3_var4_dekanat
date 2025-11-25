using Application.Interfaces.Services;
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

	[HttpPost("expelStudent/{id:int}")]
	public void ExpelStudent(int id)
	{
		Console.WriteLine("DeanOfficeController ExpelStudent");
	}

	[HttpPost("transferStudent")]
	public void TransferStudent(int studentId, int groupId)
	{
		Console.WriteLine("DeanOfficeController TransferStudent");
	}

	[HttpPut("updateAcademicPerformance")]
	public void UpdateAcademicPerformance()
	{
		Console.WriteLine("DeanOfficeController UpdateAcademicPerformance");
	}
}