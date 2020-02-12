using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class MockLibraryRepository : ILibraryRepository
    {

        private List<Library> _libraryList;
        public MockLibraryRepository()
        {
            //_libraryList = new List<Library>()
            //{

            //    new Library() { Id = 1, Department = Dept.ElectricalEngineering, NameofAuthor = "A.A Ijayi", Title = "Electric Circuit Systems",
            //        Email= "aa@gmail.com" },
            //    new Library() { Id = 2, Department = Dept.Physics, NameofAuthor = "Francis Idogun", Title = "Phasor Systems" ,  Email= "bb@gmail.com" },
            //    new Library() { Id = 3, Department = Dept.MechanicalEngineering, NameofAuthor = "Engr. Lucky Imoeze", Title = "Vector Analysis",  Email= "Ca@gmail.com"  },
            //    new Library() { Id = 4, Department = Dept.CivilEngineering, NameofAuthor = "Engr. Anyasi Francis", Title = "Polymer Series" , Email= "Da@gmail.com" },
            //    new Library() { Id = 5, Department = Dept.Account, NameofAuthor = "Daniel Oyagha", Title = "Photovolatics" , Email= "Maa@gmail.com" }
            //};



            _libraryList = new List<Library>()
            {

                new Library() { Id = 1, Department = Dept.ElectricalEngineering, NameofAuthor = "A.A Ijayi", Title = "Electric Circuit Systems",
                    },
                new Library() { Id = 2, Department = Dept.Physics, NameofAuthor = "Francis Idogun", Title = "Phasor Systems" },
                new Library() { Id = 3, Department = Dept.MechanicalEngineering, NameofAuthor = "Engr. Lucky Imoeze", Title = "Vector Analysis"},
                new Library() { Id = 4, Department = Dept.CivilEngineering, NameofAuthor = "Engr. Anyasi Francis", Title = "Polymer Series" },
                new Library() { Id = 5, Department = Dept.Account, NameofAuthor = "Daniel Oyagha", Title = "Photovolatics" }
            };


        }

        public Library Add(Library library)
        {
            library.Id =_libraryList.Max(lb => lb.Id) + 1 ;
            _libraryList.Add(library);

            return library;

        }

        public Library Delete(int id)
        {
            Library library = _libraryList.FirstOrDefault(lb => lb.Id == id);
            if(library != null)
            {
                _libraryList.Remove(library);
            }
            return library;
        }

        public IEnumerable<Library> GetAllBooks()
        {
            return _libraryList;
        }

        public Library GetBook(int id)
        {
            return _libraryList.FirstOrDefault(x => x.Id == id);
        }

        public Library Update(Library librarychanges)
        {
            Library library = _libraryList.FirstOrDefault(lb => lb.Id == librarychanges.Id);
            if (library != null)
            {
                library.Department = librarychanges.Department;
                library.NameofAuthor = librarychanges.NameofAuthor;
                librarychanges.Title = librarychanges.Title;
            }
            return library;
        }
    }   
    
}

