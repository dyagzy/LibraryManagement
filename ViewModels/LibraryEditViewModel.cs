using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.ViewModels
{
    public class LibraryEditViewModel : LibraryCreatViewModel
    {
        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
