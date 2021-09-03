using System;

namespace FluentValidation.API.Models
{
    public class User
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}