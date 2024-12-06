namespace CREAR_API.Data.Models
{
    public class Book_Author
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Books Books { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
