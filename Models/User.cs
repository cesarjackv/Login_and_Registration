#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int UserId {get; set;}

    [Required(ErrorMessage = "is required.")]
    [MinLength(2, ErrorMessage = "nust be at least 2 characters.")]
    [Display(Name = "First Name")]
    public string FirstName {get; set;}

    [Required(ErrorMessage = "is required.")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
    [Display(Name = "Last Name")]
    public string LastName {get; set;}

    [Required(ErrorMessage = "is required.")]
    [DataType(DataType.EmailAddress)]
    public string Email {get; set;}
    
    [Required(ErrorMessage = "is required.")]
    [MinLength(8, ErrorMessage = "nust be at least 8 characters.")]
    [DataType(DataType.Password)]
    public string Password {get; set;}

    [NotMapped]
    [Required(ErrorMessage = "is required.")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "doesn't match password.")]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword {get; set;}

    public DateTime CreatedAt {get; set;} = DateTime.Now;

    public DateTime UpdatedAt {get; set;} = DateTime.Now;
}