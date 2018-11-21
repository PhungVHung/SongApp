using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Song.Models
{
    public class SongCategory
    {
        public int SongId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Songs Song { get; set; }
    }
}
