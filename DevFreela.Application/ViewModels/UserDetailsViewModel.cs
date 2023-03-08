using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserDetailsViewModel
    {
        public UserDetailsViewModel(string firtname, string lastname, string email)
        {
            Firtname = firtname;
            Lastname = lastname;
            Email = email;
        }

        public string Firtname { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }
    }
}
