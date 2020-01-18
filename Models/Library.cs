using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Library
    {
        public int Id  { get; set; }
        public string NameofAuthor { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
    }
}
