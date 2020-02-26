using LibraryManagement.Models;
using LibraryManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger logger;

        public HomeController(ILibraryRepository libRepo, IHostingEnvironment hostingEnvironment
            ,ILogger<HomeController> logger)
        {
            _libRepo = libRepo;
            this.hostingEnvironment = hostingEnvironment;
            this.logger = logger;
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
            //throw new Exception("Error in Details View");
            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Information Log");
            logger.LogWarning("Warning Log");
            logger.LogCritical("Critical Log");



            Library library = _libRepo.GetBook(id.Value);
            if(library== null)
            {

                Response.StatusCode = 404;
                return View("LibraryNotFound" , id.Value);
            }

            HomeDetailsViewModels homeDetailsViewModels = new HomeDetailsViewModels()
            {
                Library = library,
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
            
            string uniqueFileName = ProcessUploadedFiles(model);
            

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

             [HttpGet]
        [Route("[action]")]
        public ViewResult Edit(int id)
        {

            Library library = _libRepo.GetBook(id);
            
            LibraryEditViewModel libraryEditViewModel = new LibraryEditViewModel
            {
                Id = library.Id,
                NameofAuthor = library.NameofAuthor,
                Title = library.Title,
                Department= library.Department,
                ExistingPhotoPath = library.PhotoPath
                
                
            };
            return View(libraryEditViewModel);
        }



        [HttpPost]
        [Route("[action]")]
        public RedirectToActionResult Edit(LibraryEditViewModel model)
        {
            Library library = _libRepo.GetBook(model.Id);
            library.NameofAuthor = model.NameofAuthor;
            library.Title = model.Title;
            library.Department = model.Department;


            if(model.Photo != null)
            {
                if(model.ExistingPhotoPath != null)
                {
                  string filePath =   Path.Combine(hostingEnvironment.WebRootPath, 
                      "Image" , model.ExistingPhotoPath);

                    System.IO.File.Delete(filePath);
                }
                library.PhotoPath = ProcessUploadedFiles(model);
            }

            _libRepo.Update(library);


            return RedirectToAction("index");
        }


        private string ProcessUploadedFiles(LibraryCreatViewModel model)
        {
            string uniqueFileName = null;
            if (model.Photo != null)
            {
                string uploadsFile = Path.Combine(hostingEnvironment.WebRootPath, "Image");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFile, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
                
            }

            return uniqueFileName;
        }
    }
    
}
