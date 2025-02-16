namespace library.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthYear { get; set; }

        // Quan hệ 1-n: Một tác giả có thể viết nhiều sách
        public ICollection<Book> Books { get; set; }
    }

}
