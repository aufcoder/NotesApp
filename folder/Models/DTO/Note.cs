namespace NotesApp.API.Models.DTO
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ColorHex { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
