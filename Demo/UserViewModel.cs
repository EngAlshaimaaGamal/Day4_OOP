using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class UserViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }   
        public string? Email { get; set; }
        public string? Password { get; set; }


        public static explicit operator UserViewModel(User user)
        {
            string[]? names = user?.FullName?.Split(" ");
            return new UserViewModel()
            {
                Id = user?.Id ?? 0,
                Password = user?.Password ?? null,
                Email = user?.Email ?? null,
                FirstName = names?.Length > 0 ? names[0] : null,
                LastName = names?.Length > 1 ? names[1] : null


            };
           
        }





    }
}
