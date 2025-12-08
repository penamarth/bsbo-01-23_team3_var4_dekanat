namespace MireaLib.Models;

public record DocumentDetails(string Id, string Content, int? StudentId, DateOnly Date, DocumentType DocumentType);