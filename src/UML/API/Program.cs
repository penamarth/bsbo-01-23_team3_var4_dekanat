using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Services;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Services;
using MireaLib.Services;

namespace API;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddTransient<IAcademicRecordsRepository, AcademicRecordsRepository>();
		builder.Services.AddTransient<IGroupsRepository, GroupsRepository>();
		builder.Services.AddTransient<IStudentsRepository, StudentsRepository>();

		builder.Services.AddTransient<IDigitalDocumentManager, DigitalDocumentManagerAdapter>();
		builder.Services.AddTransient<IEducationalDepartmentService, EducationalDepartmentService>();

		builder.Services.AddTransient<IAcademicRecordsService, AcademicRecordsService>();
		builder.Services.AddTransient<IGroupsService, GroupsService>();
		builder.Services.AddTransient<IStudentsService, StudentsService>();

		builder.Services.AddTransient<MireaDocumentsService>();

		builder.Services.AddControllers();
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

		var app = builder.Build();

		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		app.UseHttpsRedirection();

		app.UseAuthorization();


		app.MapControllers();

		app.Run();
	}
}