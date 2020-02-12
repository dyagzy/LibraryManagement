using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    //public class Library
    //{
    //    public int Id { get; set; }


    //    public string NameofAuthor { get; set; }

    //    public string Title { get; set; }

    //    public Dept? Department { get; set; }

    //    public string Email { get; set; }

    //}

    public class Library
    {
        public int Id { get; set; }


        public string NameofAuthor { get; set; }

        public string Title { get; set; }

        public Dept? Department { get; set; }
        public string PhotoPath { get; set; }
       

    }




















}
