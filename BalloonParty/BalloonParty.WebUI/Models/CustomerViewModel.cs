using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BalloonParty.WebUI.Models
{
    public class CustomerViewModel
    {
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [DisplayName("First Name")]
        public string FirstName{get; set;}

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [DisplayName("Last Name")]
        public string LastName{get; set;}

        [Required]
        [DisplayName("Email Address")]
        public string EmailAddress{get; set;}

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [DisplayName("Password")]
        public string CustomerPw{get; set;}

        [Required]
        [DisplayName("Address")]
        public string Address{get; set;}

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [DisplayName("City")]
        public string City{get; set;}

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [DisplayName("State")]
        public string State{get; set;}

        [Required]
        [RegularExpression(@"^[0-9]*$")]
        [DisplayName("Zip Code")]
        public string ZipCode{get; set;}
    }
}