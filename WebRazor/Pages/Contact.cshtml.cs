using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebRazor.Pages
{
    [BindProperties]
    public class ContactModel : PageModel
    {
        [Display(Name = "Message"), Required(ErrorMessage = "Message Required")]
        public string Message { get; set; } = string.Empty;

        [Display(Name = "First Name"), Required(ErrorMessage = "First Name Required")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name"), Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Email"), Required(ErrorMessage = "Email Required"), DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
    }
}