using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly RazorPagesMovieContext db;
        public DataRepository(RazorPagesMovieContext db)
        {
            this.db = db;
        }

        public bool AddRecord(Record newRecord)
        {
         db.Record.Add(newRecord);
         return true;
        }

       
        public bool DeleteRecord(Record Record)
        {
            if (Record != null)
            {
                 db.Record.Remove(Record);
                 return true;
            }
            return false;
        }

        public Record GetRecordById(int recordId)
        {
            var query = from r in  db.Record.Include("Movie")
              where r.RecordsId.Equals(recordId)
              select r;
              if (query.Count() >0)
              {
                  return query.SingleOrDefault();
              }
              return null;
        }
        

        public string GetUserLogin(string Uname ,string password )
        {
            var  result= from r in db.Adduser where r.Uname.Equals(Uname) && 
              r.password.Equals(password)
              select r ;
              if(result.Count() > 0)
              {
                  return "found";
              }
              return "Not found";
        }

       
        public IEnumerable<Addmovie> GetMovies()
        {
          var query = from m in db.Addmovie 
          orderby m.VID
          select m;
          if (query.Count() >0)
          {
              return query;
          }   
          return null;
        }

        public Addmovie GetMoviesById(int Id)
        {
            return db.Addmovie.Find(Id);
        }

        public IEnumerable<Adduser> GetUsers()
        {
          var query = from u in db.Adduser 
          select u;
          return query;
        }

        public Adduser GetUserByUsername(string Uname)
        {
            var query = from u in db.Adduser where u.Uname.Equals(Uname) select u;
            return query.FirstOrDefault();
        }

        public IEnumerable<Record> GetRecordByusername(string user)
        {
            var query = from r in db.Record.Include("Addmovie") 
            where r.Adduser.Uname.Equals(user)
            select r;
            return query; 
        }
        public int Commit()
        {
            return db.SaveChanges();
        }

    }
    
}