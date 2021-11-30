using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public AddJobViewModel() { }
        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            SkillList = skills;
            EmployerList = new List<SelectListItem>();
            
            foreach (Employer employer in employers)
            {
                EmployerList.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }

        [Required(ErrorMessage = "A name is required for a Job.")]
        public string Name { get; set; }

        public int EmployerId { get; set; }
        public List<SelectListItem> EmployerList { get; set; }
        public List<Skill> SkillList { get; set; } = new List<Skill>();
    }
}
