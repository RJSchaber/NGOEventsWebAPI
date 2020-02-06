namespace NGOEventsWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Web;
    using System.Runtime.Serialization;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserNGO
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string token { get; set; }
    }

    public class LoginRequest
    {
        public string UserID { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponse
    {
        public LoginResponse()
        {

            this.Token = "";
            this.responseMsg = new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.Unauthorized };
        }

        [NotMapped]
        public string Token { get; set; }
        public HttpResponseMessage responseMsg { get; set; }

    }


}
