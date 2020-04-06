using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BalloonParty.Core.Models;
using BalloonParty.WebUI.Models;


namespace BalloonParty.WebUI.Models
{
    public class AllCustomersViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName {get; set;}

        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        [Display(Name = "Email Address")]
        public string EmailAddress {get; set;}
    }
}