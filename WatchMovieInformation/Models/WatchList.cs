using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchMovieInformation.Models
{
    public class WatchList
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public Language Language { get; set; }
        public Generic Generic { get; set; }
    }
    public class Language
    {
        public int Id { get; set; }
        public string LanguageName { get; set; }
    }
    public class Generic
    {
        public int Id { get; set; }
        public string GenericName { get; set; }
    }
}
