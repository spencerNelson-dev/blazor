using NelsonProjects.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NelsonProjects.Shared.DAL
{
    public class JokeData : IJokeData
    {
        private readonly ISqlDataAccess _db;

        public JokeData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<JokeModel>> GetJokes()
        {
            string sql = "select * from joke";

            return _db.LoadData<JokeModel, dynamic>(sql, new { });
        }

        public Task InsertJoke(JokeModel joke)
        {
            string sql = @"insert into joke (date, joke, source, author)
                            values (@Date, @Joke, @Source, @Author;";

            return _db.SaveData(sql, joke);
        }
    }
}
