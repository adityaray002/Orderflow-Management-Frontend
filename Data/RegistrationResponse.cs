using System.ComponentModel.DataAnnotations;

namespace OrderFlowManagementFrontend.Data
{
    public class RegistrationResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public string email { get; set; }
        public string phoneNo { get; set; }
        public string address { get; set; }
    }
}
