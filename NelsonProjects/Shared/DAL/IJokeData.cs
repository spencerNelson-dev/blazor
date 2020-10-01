using NelsonProjects.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NelsonProjects.Shared.DAL
{
    public interface IJokeData
    {
        Task<List<JokeModel>> GetJokes();
        Task InsertJoke(JokeModel joke);
    }
}