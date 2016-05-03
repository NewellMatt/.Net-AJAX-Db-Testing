using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxDemo.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Person(string email, string password, int id = 0)
        {
            Email = email;
            Password = password;
            Id = id;
        }

        public Person() { }  //whats this
    }
}
