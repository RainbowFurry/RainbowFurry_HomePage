using JasonJT_Web.Models.Enum;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace JasonJT_Web.Models
{
    public class Account
    {

        [BsonId]
        public string UserID { get; set; }//

        [Display(Name = "NickName")]
        [StringLength(100, ErrorMessage = "To many charts")]
        [Required(ErrorMessage = "Please provide NickName", AllowEmptyStrings = false)]
        public string NickName { get; set; }

        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = "To many charts")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please provide Email", AllowEmptyStrings = false)]
        public string Email { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }//
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string Age { get; set; }//
        public string ProfilePicture { get; set; }//
        public string ProfileBanner { get; set; }//
        public Gender Gender { get; set; }//
        public Sex Sex { get; set; }//
        public Roles Role { get; set; }

        /*
         Street
    HouseNumber
    City
    PostCode
         */

    }

}