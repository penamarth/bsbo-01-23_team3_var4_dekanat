using Domain.Entities.Documents;

namespace Application.Interfaces.Services;

public interface IDigitalDocumentManager
{
	void RegisterDocument(Document document);
	Document GetById(string id);
}