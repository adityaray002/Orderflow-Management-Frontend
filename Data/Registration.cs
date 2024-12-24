using System.ComponentModel.DataAnnotations;

namespace OrderFlowManagementFrontend.Data
{
    public class Registration
    {
        public string token { get; set; }
        public int id { get; set; }
        [Required]
        public string name { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "Phone Number can't be more than 10 Digit.")]
        public string phoneNo { get; set; }
    }
}
