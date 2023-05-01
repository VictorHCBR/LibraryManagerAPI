using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

[Table("Person")]
public class Person
{
    public Guid? PersonId { get; set; }

    [Required(ErrorMessage = "Person Name is a required property!")]
    [StringLength(60, ErrorMessage = "Name should not be longer than 60 characters!")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "The Date of Birth is a required property!")]
    public DateTime? BirthDate { get; set; }

    [Required(ErrorMessage = "Address is a required attribute!")]
    public Address? Address { get; set; }
}