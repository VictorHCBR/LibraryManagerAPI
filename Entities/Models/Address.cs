using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

[Table("Address")]
public class Address
{
    public Guid AddressId { get; set; }

    [Required(ErrorMessage = "Zip Code is Required!")]
    [StringLength(10, ErrorMessage = "Zip Code should not be longer than 10 characters")]
    public string? ZipCode { get; set; }

    [Required(ErrorMessage = "Street is Required!")]
    [StringLength(60, ErrorMessage = "Street Name should not be longer than 30 characters")]
    public string? Street { get; set; }

    [Required(ErrorMessage = "Number is Required!")]
    public short? Number { get; set; }

    public string? Complement { get; set; }

    [Required(ErrorMessage = "District is Required")]
    [StringLength(60, ErrorMessage = "District Name should not be longer than 60 characters")]
    public string? District { get; set; }

    [Required(ErrorMessage = "City is Required!")]
    [StringLength(60, ErrorMessage = "City Name should not be longer than 60 characters")]
    public string? City { get; set; }

    public string? State { get; set; }

    [Required(ErrorMessage = "Country is Required")]
    public string? Country { get; set; }
}
