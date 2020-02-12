using LibraryManagement.Models;
using LibraryManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{

    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILibraryRepository _libRepo;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(ILibraryRepository libRepo, IHostingEnvironment hostingEnvironment)
        {
            _libRepo = libRepo;
            this.hostingEnvironment = hostingEnvironment;
        }


        [Route("")]
        [Route("~/")]
        [Route("[action]")]
        public ViewResult Index(int Id)
        {

            var model = _libRepo.GetAllBooks();
            return View(model);

        }

        [Route("[action]/{id?}")]
        public ViewResult Details(int? id)

        {

            HomeDetailsViewModels homeDetailsViewModels = new HomeDetailsViewModels()
            {
                Library = _libRepo.GetBook(id ?? 2),
                PageTitle = "Library Stocks Available"
            };

            return View(homeDetailsViewModels);

        }


        //[HttpGet]
        //[Route("[action]")]
        //public ViewResult Create()
        //{
        //    return View();
        //}


        //[HttpPost]
        //[Route("[action]")]
        //public RedirectToActionResult Create(Library library)
        //{
        //    Library newLibrary = _libRepo.Add(library);
        //    return RedirectToAction("details", new { id = newLibrary.Id });
        //}


        [HttpGet]
        [Route("[action]")]
        public ViewResult Created()
        {
            return View();
        }



        [HttpPost]
        [Route("[action]")]
        public RedirectToActionResult Created(LibraryCreatViewModel model)
        {

            string uniqueFileName = null;
            if (model.Photo != null)
            {
                string uploadsFile = Path.Combine(hostingEnvironment.WebRootPath, "Image");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFile, uniqueFileName);
                model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            }

                Library newLibrary = new Library
                {
                    NameofAuthor = model.NameofAuthor,
                    Title = model.Title,
                    Department = model.Department,
                    PhotoPath = uniqueFileName

                };
                _libRepo.Add(newLibrary);


                return RedirectToAction("details", new { id = newLibrary.Id });
            
            


















        }
    }
}
