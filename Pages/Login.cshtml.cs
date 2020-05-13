using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;
namespace RazorPagesMovie.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IDataRepository db;

        public LoginModel(IDataRepository db)
        {
            this.db = db;
        }
        [BindProperty]
        public Login obj{get;set;}

        public void OnGet()
        {
         obj= new Login(); 
        }
        public string Message {get;set;}
        public IActionResult OnPost()
        {
           Message = db.GetUserLogin(obj.Uname ,obj.password);  

           if(Message == "found")
           {
               HttpContext.Session.SetString("name", obj.Uname);
               return RedirectToPage("/Movie/Index");
           }
           return Page();
        }

    }
}