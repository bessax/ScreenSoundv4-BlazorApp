namespace ScreenSound.API.Response;

public record MusicaResponse(int Id, string Nome, int ArtistaId, string NomeArtista, int? anoLancamento, ICollection<GeneroResponse> Generos = null);