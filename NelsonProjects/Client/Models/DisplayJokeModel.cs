using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NelsonProjects.Client.Models
{
    public class DisplayJokeModel
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Setup { get; set; }

        [Required]
        public string Punchline { get; set; }

        [Required]
        public string Source { get; set; }

        [Required]
        public string Author { get; set; }
    }
}
