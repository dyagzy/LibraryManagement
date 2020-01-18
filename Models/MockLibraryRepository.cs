using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class MockLibraryRepository : ILibraryRepository
    {

        private List<Library> _bookList;
        public MockLibraryRepository()
        {
            _bookList = new List<Library>();
            {

                new Library() { Id = 1, Department = "Electrical", NameofAuthor = "A.A Ijayi", Title = "Electric Circuit Systems" };
                new Library() { Id = 2, Department = "Physics", NameofAuthor = "Francis Idogun", Title = "Phasor Systems" };
                new Library() { Id = 3, Department = "Mechanical Eneigeering", NameofAuthor = "Engr. Lucky Imoeze", Title = "Vector Analysis" }; 
                new Library() { Id = 4, Department = "Civil Engineeering", NameofAuthor = "Engr. Anyasi Francis", Title = "Polymer Series" };
                new Library() { Id = 5, Department = "Avionics", NameofAuthor = "Daniel Oyagha", Title = "Photovolatics" };
            }

        }
        public Library GetBook(int Id)
        {
            return _bookList.FirstOrDefault(b => b.Id == Id);
        }
    }
}
