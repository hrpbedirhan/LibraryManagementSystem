using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class AddBookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required(ErrorMessage = "Yazar seçmek zorunludur.")]
        public int AuthorId { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }

    }
}
