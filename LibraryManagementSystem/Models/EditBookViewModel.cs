using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class EditBookViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Kitap Adı")]
        public string Title { get; set; }

        [Display(Name = "Yazar")]
        public int AuthorId { get; set; }

        [Display(Name = "Tür")]
        public string Genre { get; set; }

        [Display(Name = "Yayın Tarihi")]
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }

        [Display(Name = "Kopya Sayısı")]
        public int CopiesAvailable { get; set; }

    }
}
