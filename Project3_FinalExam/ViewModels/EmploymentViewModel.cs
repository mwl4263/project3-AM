using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;

namespace Project3_FinalExam.ViewModels
{
    public class EmploymentViewModel
    {
        public List<ProfessionalEmploymentInfoEntries> employment { get; set; }
        public string Title { get; set; }
    }
}
