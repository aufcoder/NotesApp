namespace NotesApp.API.Models.DTO
{
    public class UpdateNoteRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ColorHex { get; set; }
    }
}
