using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace bankAPIApp
{
    internal class LoginRequestClass
    {
        public string login { get; set; }

        public string password { get; set; }
        public LoginRequestClass(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
