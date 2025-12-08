namespace MireaLib.Models;

public record CreateDocumentRequest(string Id, int? StudentId, DateOnly Date, DocumentType DocumentType);