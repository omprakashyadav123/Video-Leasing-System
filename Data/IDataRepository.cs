using RazorPagesMovie.Data;
using System.Collections.Generic;
using RazorPagesMovie.Models;



namespace RazorPagesMovie.Data
{
    public interface IDataRepository
    {

        IEnumerable<Addmovie> GetMovies();
        Addmovie GetMoviesById(int Id);

        IEnumerable<Adduser> GetUsers();
        Adduser GetUserByUsername(string Uname);
      string GetUserLogin(string Uname ,string password);
       
       Record GetRecordById(int RecordId);

        bool DeleteRecord(Record Record);
        bool AddRecord(Record newRecord);

        IEnumerable<Record> GetRecordByusername(string user);
        int Commit();
       
    }
}
