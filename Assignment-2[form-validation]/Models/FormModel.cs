using System.ComponentModel.DataAnnotations;

namespace Assignment_2_form_validation_.Models
{
    public class FormModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter valid email address")]
        public required string Email { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Address should not be more than 100 characters")]
        public required string BillingAddress { get; set; }

        [Required]
        public required string CountryCode { get; set; }

        [Required(ErrorMessage = "Contact number is required")]
        public required string Contact { get; set; }

        [Required]
        public required string Service { get; set; }

        [Required]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "Invalid Zip Code")]
        public required string ZipCode { get; set; }

        [Required]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "Invalid VAT Code")]
        public required string VATNumber { get; set; }


    }

}
