using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public interface ILibraryRepository
    {
        


        Library GetBook(int Id);
    }
}
