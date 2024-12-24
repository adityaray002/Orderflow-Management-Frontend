using System.ComponentModel.DataAnnotations;

namespace OrderFlowManagementFrontend.Data
{
    public class AdminSignin
    {
        public string token { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
