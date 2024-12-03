using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class AddBookViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Kitap Adı")]
        [Required(ErrorMessage = "Kitap başlığı zorunludur.")]
        public string Title { get; set; }

        [Display(Name = "Yazar")]
        [Required(ErrorMessage = "Yazar seçmek zorunludur.")]
        [Range(1, int.MaxValue, ErrorMessage = "Geçerli bir yazar seçiniz.")]
        public int AuthorId { get; set; }

        [Display(Name = "Tür")]
        [Required(ErrorMessage = "Tür zorunludur.")]
        public string Genre { get; set; }

        [Display(Name = "Yayın Tarihi")]
        [Required(ErrorMessage = "Yayın tarihi zorunludur.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Geçerli bir tarih formatı giriniz.")]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "ISBN numarası gereklidir.")]
        public string ISBN { get; set; }

        [Display(Name = "Kopya Sayısı")]
        [Required(ErrorMessage = "Kopya sayısı zorunludur.")]
        [Range(1, int.MaxValue, ErrorMessage = "Kopya sayısı 1 veya daha fazla olmalıdır.")]
        public int CopiesAvailable { get; set; }

    }
}
