using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwistedWheel.Models
{
    public class User
    {
        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public DateTime CreateDate { get; set; }
        public int UserID { get; set; }
        private static int nextId = 1;

        public User()
        {
            CreateDate = DateTime.Now;
            UserID = nextId;
            nextId++;
        }
    }
}
