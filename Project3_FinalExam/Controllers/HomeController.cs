using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project3_FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetAbout _aboutRepository;
        private readonly IGetFaculty _facultyRepository;
        private readonly IGetUndergraduate _undergraduateRepository;
        private readonly IGetGraduate _graduateRepository;
        private readonly IGetUndergraduateMinors _undergraduateMinorsRepository;
        private readonly IGetEmployment _employmentRepository;
        private readonly IGetCoop _coopRepository;

        public HomeController(IGetAbout aboutRepository, IGetFaculty facultyRepository, IGetUndergraduate undergraduateRepository, IGetGraduate graduateRepository, IGetUndergraduateMinors undergraduateMinorsRepository, IGetEmployment employmentRepository, IGetCoop coopRepository)
        {
            _aboutRepository = aboutRepository;
            _facultyRepository = facultyRepository;
            _undergraduateRepository = undergraduateRepository;
            _graduateRepository = graduateRepository;
            _undergraduateMinorsRepository = undergraduateMinorsRepository;
            _employmentRepository = employmentRepository;
            _coopRepository = coopRepository;
        }


        public async Task<IActionResult> GetFaculty()
        {
            var allFaculty = await _facultyRepository.GetAllFaculty();
            var sortedFaculty = allFaculty.OrderBy(f => f.username);
            var homeViewModel = new HomeViewModel()
            {
                Faculty = allFaculty.ToList(),
                Title = "This is your Faculty"
            };
            return View(homeViewModel);
        }
        public async Task<IActionResult> Index()
        {
            var allAbouts = await _aboutRepository.GetAbouts();
            var aboutViewModel = new AboutViewModel()
            {
                about = allAbouts,
                Title = "This is your Faculty"
            };
            return View(aboutViewModel);
        }


        public async Task<IActionResult> Under()
        {
            var under = await _undergraduateRepository.GetUnderGradDegrees();
            var underViewModel = new UndergradViewModel()
            {
                UnderGrads = under,
                Title = "Undergraduate Programs"
            };
            return View(underViewModel);
        }


        public async Task<IActionResult> Graduate()
        {
            var grad = await _graduateRepository.GetGradDegrees();
            var gradViewModel = new GradViewModel()
            {
                Grads = grad,
                Title = "Graduate Programs"
            };
            return View(gradViewModel);
        }


        public async Task<IActionResult> Minors()
        {
            var minor = await _undergraduateMinorsRepository.GetUnderGradMinors();
            var minorsViewModel = new MinorsViewModel()
            {
                Minors = minor,
                Title = "Undergraduate Minors"
            };
            return View(minorsViewModel);
        }


        public async Task<IActionResult> Employment()
        {
            var emp = await _employmentRepository.GetEmploymentInfoEntries();
            var empViewModel = new EmploymentViewModel()
            {
                employment = emp,
                Title = "Employment"
            };
            return View(empViewModel);

        }

        public async Task<IActionResult> Coop()
        {
            var op = await _coopRepository.GetCoopEntries();
            var coopViewModel = new CoopViewModel()
            {
                coop = op,
                Title = "Co-op"
            };
            return View(coopViewModel);

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
