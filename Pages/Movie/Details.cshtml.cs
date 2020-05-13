using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movie
{
    public class DetailsModel : PageModel
    {
        private readonly IDataRepository context;

        public DetailsModel(IDataRepository context)
        {
            
            this.context = context;
        }

        public Addmovie Addmovie { get; set; }
        public Addmovie Movie { get; private set; }

        public void OnGetAsync(int id)
        {
            Movie = context.GetMoviesById(id);
            // if (id == null)
            // {
            //     return NotFound();
            // }

            // Addmovie = await context.Addmovie.FirstOrDefaultAsync(m => m.VID == id);

            // if (Addmovie == null)
            // {
            //     return NotFound();
            // }
            // return Page();
        }
        public IActionResult OnPost(int id)
        {
            
            var Name = HttpContext.Session.GetString("name");
            var  user = context.GetUserByUsername(Name);
            var Movie = context.GetMoviesById(id);
            if (string.IsNullOrEmpty(Name))
            {
                return RedirectToPage("/Login");
            }
            Record newRecord = new Record(){
                Adduser    = user,
                Addmovie   = Movie,
                TakenDate  = DateTime.Now ,
                ReturnDate = DateTime.Now.AddDays(20)  

            };
            context.AddRecord(newRecord);
            context.Commit(); 
            return RedirectToPage("/Dashbord");
        }
    }
}
