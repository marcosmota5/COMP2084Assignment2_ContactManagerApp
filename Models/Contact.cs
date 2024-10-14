using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models;

public class Contact
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the first name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Please enter the last name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Please enter the phone number")]
    [Length(12, 12, ErrorMessage = "The phone number must be in the format 000-000-0000")]
    public string Phone { get; set; }

    [Required(ErrorMessage = "Please enter the email")]
    [EmailAddress(ErrorMessage = "The typed value is not a valid email address")]
    public string Email { get; set; }

    [ValidateNever]
    public DateTime DateAdded { get; set; }

    [Required(ErrorMessage = "Please select a category.")]
    public int CategoryId { get; set; }

    [ValidateNever]
    public Category? Category { get; set; }

    public Contact()
    {
        this.DateAdded = DateTime.UtcNow;
    }
}