using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        private ILibraryRepository _libraryRepository;

        public HomeController(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }



        public string Index ()
        {
            return _libraryRepository.GetBook(1).NameofAuthor; 
        }
    }
}
