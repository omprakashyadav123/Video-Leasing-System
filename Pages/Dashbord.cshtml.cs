using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class DashbordModel : PageModel
    {
        private readonly IDataRepository db;

        public DashbordModel(IDataRepository db)
        {
            this.db = db;
        }
        public IList<Record> RecordofUser  { get; set; }
        public void OnGet()
        {   var Username =  
            HttpContext.Session.GetString("user");
            
            RecordofUser = db.GetRecordByusername(Username).ToList();
        }
    }
}