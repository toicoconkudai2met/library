namespace library.Models
{
    public class BookViewModel
    {
        public int Id { get; set; } // Mã sách
        public string Title { get; set; } // Tên sách
        public int PublishYear { get; set; } // Năm xuất bản
        public string AuthorName { get; set; } // Tên tác giả
        public string CategoryName { get; set; } // Tên thể loại
    }

}
