using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
       

        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> employersList { get; set; }

        public List<Skill> skillsList { get; set; }

        public int[] SkillId { get; set; }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            
            employersList = new List<SelectListItem>();
            foreach (var employer in employers)
            {
                employersList.Add(new SelectListItem
                {
                    Text = employer.Name,
                    Value = employer.Id.ToString()
                    
                });
            }
            skillsList = skills;

            
                
                
            
        }

        public AddJobViewModel()
        {
        }
    }


}
