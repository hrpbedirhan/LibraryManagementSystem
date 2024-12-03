using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class AddAuthorViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Adı")]
        [Required(ErrorMessage = "Yazar adı zorunludur.")]
        public string FirstName { get; set; }

        [Display(Name = "Soyadı")]
        [Required(ErrorMessage = "Yazar soyadı zorunludur.")]
        public string LastName { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [Required(ErrorMessage = "Doğum tarihi zorunludur.")]
        public DateTime? DateOfBirth { get; set; }
    }
}
