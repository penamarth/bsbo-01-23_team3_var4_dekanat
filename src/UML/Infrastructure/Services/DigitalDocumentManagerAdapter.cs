using Application.Interfaces.Services;
using Domain.Entities.Documents;
using MireaLib.Models;
using MireaLib.Services;

namespace Infrastructure.Services;

public class DigitalDocumentManagerAdapter : IDigitalDocumentManager
{
	private readonly MireaDocumentsService _mireaDocumentsService;

	public DigitalDocumentManagerAdapter(MireaDocumentsService mireaDocumentsService)
	{
		_mireaDocumentsService = mireaDocumentsService;
	}

	public void RegisterDocument(Document document)
	{
		Console.WriteLine("DigitalDocumentManagerAdapter RegisterDocument");
		var documentType = document switch
		{
			EnrollmentDocument => DocumentType.Enrollment,
			ExpulsionDocument => DocumentType.Expulsion
		};
		_mireaDocumentsService.CreateDocument(
			new CreateDocumentRequest(document.Id, null, document.Date, documentType));
	}

	public Document GetById(string id)
	{
		Console.WriteLine("DigitalDocumentManagerAdapter GetById");
		var document = _mireaDocumentsService.GetDetailsById(id);
		return document.DocumentType switch
		{
			DocumentType.Enrollment => new EnrollmentDocument
			{
				Id = document.Id, Date = document.Date, StudentId = document.StudentId!.Value
			},
			DocumentType.Expulsion => new ExpulsionDocument
			{
				Id = document.Id, Date = document.Date, StudentId = document.StudentId!.Value
			}
		};
	}
}