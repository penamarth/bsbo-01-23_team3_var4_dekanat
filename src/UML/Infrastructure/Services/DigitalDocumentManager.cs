using Application.Interfaces.Services;
using Domain.Entities.Documents;

namespace Infrastructure.Services;

public class DigitalDocumentManager : IDigitalDocumentManager
{
	public void RegisterDocument(Document document)
	{
		Console.WriteLine("DigitalDocumentManager RegisterDocument");
	}

	public Document GetById(int id)
	{
		Console.WriteLine("GroupsService GetById");
		return new EnrollmentDocument
		{
			Id = "123123"
		};
	}
}