using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Adduser
    {
        [Key]
        public int UID { get; set; }
        public string Uname { get; set; }

        
        public string Address { get; set; }
        public int phone { get; set; }
        public string password { get; set; }
    }
}