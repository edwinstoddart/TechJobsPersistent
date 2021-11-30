using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "A Name is required for an Employer.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "A Location is required for an Employer.")]
        public string Location { get; set; }
    }
}
