using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BioTranan.Models
{
    public class MovieModel
    {
        public string MovieName { get; set; }
        public string MovieInfo { get; set; }
        public int MovieSeats { get; set; }
        public int MovieShowings { get; set; }
        public int MovieTheater { get; set; }
        public List<DateTime> UpcomingFilmShowings { get; set; } = new List<DateTime>();
    }
}