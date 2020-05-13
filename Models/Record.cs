using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Record
    {
        [Key] public int RecordsId { get; set; }
        [Required] public Adduser Adduser { get; set; }
        [Required] public Addmovie Addmovie { get; set; }
        [Required] public DateTime TakenDate { get; set; }
        [Required] public DateTime ReturnDate { get; set; }
    }
}