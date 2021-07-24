using JasonJT_Web.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace JasonJT_Web.Models
{
    public class Contact
    {

        [Display(Name = "Name")]
        [StringLength(100, ErrorMessage = "To many charts")]
        [Required(ErrorMessage = "Please provide Name", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = "To many charts")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please provide Email", AllowEmptyStrings = false)]
        public string Email { get; set; }

        public string Age { get; set; }//?
        public Gender Gender { get; set; }
        public Sex Sex { get; set; }

        [Display(Name = "Text")]
        [StringLength(9999, ErrorMessage = "To many charts")]
        [Required(ErrorMessage = "Please provide a little Text", AllowEmptyStrings = false)]
        public string Text { get; set; }

    }

}