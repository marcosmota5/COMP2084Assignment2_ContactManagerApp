using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models;

public class Category
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the category name")]
    public string Name { get; set; }
}