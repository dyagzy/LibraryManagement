using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public interface ILibraryRepository
    {

        Library GetBook(int id);
        IEnumerable<Library> GetAllBooks();
        Library Add(Library library);
        Library Delete(int id);
        Library Update(Library librarychanges);
    }
}