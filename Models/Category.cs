namespace library.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Quan hệ 1-n: Một thể loại có nhiều sách
        public ICollection<Book> Books { get; set; }
    }

}
