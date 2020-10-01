using System;
using System.Collections.Generic;
using System.Text;

namespace NelsonProjects.Shared.Models
{
    public class JokeModel
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public string Setup { get; set; }

        public string Punchline { get; set; }

        public string Source { get; set; }

        public string Author { get; set; }
    }
}
