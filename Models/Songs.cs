using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Song.Models
{
    public class Songs
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<SongCategory> SongCategories { get; set; }
    }
}
