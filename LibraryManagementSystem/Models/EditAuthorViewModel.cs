using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class EditAuthorViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Adı")]
        public string FirstName { get; set; }

        [Display(Name = "Soyadı")]
        public string LastName { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateTime DateOfBirth { get; set; }
    }
}
