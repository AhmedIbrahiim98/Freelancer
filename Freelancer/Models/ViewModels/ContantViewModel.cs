using System.ComponentModel.DataAnnotations;

using Freelancer.Validation;

namespace Freelancer.Models.ViewModels;

public class ContantViewModel
{
    [Display(Name = "Full name")]
    [Required(ErrorMessage = "A name is required.")]
    public string? Name { get; set; }

    [Display(Name = "Email address")]
    [EmailAddress(ErrorMessage = "You must enter a valid email address")]
    [Required(ErrorMessage = "An email is required.")]
    public string? Email { get; set; }

    [Display(Name = "Phone number")]
    public string? Phone { get; set; }

    [Display(Name = "Message")]
    [Required(ErrorMessage = "A message is required.")]
    public string? Message { get; set; }

    [Display(Name = "Yes, I give permition to store and process my data")]
    [Required(ErrorMessage = "A consent is required.")]
    [MustBeTrue(ErrorMessage = "You must give consent to us storing your details before you can send us a message")]
    public bool Consent { get; set; }
}