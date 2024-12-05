using System.ComponentModel.DataAnnotations;

namespace OrderFlowManagementFrontend.Data
{
    public class AdminSignup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
    }
}
