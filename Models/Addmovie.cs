using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Addmovie
    {
        [Key]
        public int VID { get; set; }
        public string Moviename { get; set; }

        
        public string Actor {get;set;}
        public string Director { get; set; }
        public string Language { get; set; }
    }
}