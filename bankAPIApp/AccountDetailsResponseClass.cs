using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bankAPIApp
{
    internal class AccountDetailsResponseClass
    {
        public string error { get; set; }
        public AccountRequestClass account { get; set; }
    }
}
