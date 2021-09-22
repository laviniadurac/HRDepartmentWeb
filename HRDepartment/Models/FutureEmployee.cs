using System.ComponentModel.DataAnnotations;

namespace HRDepartment.Models
{
    public enum StatusEnum
    {
        New,
        Waiting,
        Rejected,
        Accepted
    }

    public class FutureEmployee
    {
        public FutureEmployee()
        {
            Status = StatusEnum.Waiting;
        }

        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Please enter your name!")]
        [Display(Name = "Name")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Please enter your phone number!")]
        [Display(Name = "Phone number")]
        [Phone]
        [RegularExpression(@"^\(?([07]{2})\)?([0-9]{8})$", ErrorMessage = "Numarul introdus nu respecta formatul 07xx xxx xxx.")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your email address!")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your address!")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        public StatusEnum Status { get; set; }

        [Required(ErrorMessage = "Please enter your details!")]
        [Display(Name = "Details")]
        public string OtherDetails { get; set; }

        [Display(Name = "Upload your CV")]
        public string CV { get; set; }

        [Display(Name = "Select technologies")]
        public string Technologies { get; set; }
        public int Experience { get; set; }
    }
}