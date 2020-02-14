using LibraryManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.ViewModels
{
    public class LibraryCreatViewModel
    {

        


        public string NameofAuthor { get; set; }

        public string Title { get; set; }

        [Required]
        public Dept? Department { get; set; }

        [Required]
        public string Email { get; set; }

        public IFormFile Photo { get; set; }
        
    }

    
}

