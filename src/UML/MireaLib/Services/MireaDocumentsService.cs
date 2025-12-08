using MireaLib.Models;

namespace MireaLib.Services;

public class MireaDocumentsService
{
	public void CreateDocument(CreateDocumentRequest createDocumentRequest)
	{
		Console.WriteLine("MireaDocumentsService CreateDocument");
	}

	public DocumentDetails GetDetailsById(string id)
	{
		Console.WriteLine("MireaDocumentsService GetDetailsById");
		return new DocumentDetails(id, string.Empty, null, DateOnly.MinValue, DocumentType.Enrollment);
	}
}