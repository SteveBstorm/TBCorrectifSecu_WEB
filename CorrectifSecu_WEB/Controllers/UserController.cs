using CorrectifSecu_WEB.Models;
using CorrectifSecu_WEB.Tools;
using CorrectifSecu_WEB_DAL.Entities;
using CorrectifSecu_WEB_DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CorrectifSecu_WEB.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo;
        private readonly IBeerRepository _beerRepo;
        private readonly SessionManager _session;

        public UserController(IUserRepository userRepo, IBeerRepository beerRepo, SessionManager session)
        {
            _userRepo = userRepo;
            _beerRepo = beerRepo;
            _session = session;
        }

        public IActionResult Login()
        {
     
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginForm form)
        {
            if(!ModelState.IsValid) return View(form);

            AppUser currentUser = _userRepo.Login(form.Email, form.Password);
        
            _session.CurrentUser = currentUser;

            return RedirectToAction("GetAll");
        }

        public IActionResult Register()
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.selectBeers = _beerRepo.GetAll();
            return View(registerForm);
        }

        [HttpPost]
        public IActionResult Register(RegisterForm form)
        {
            form.selectBeers = _beerRepo.GetAll();
            if (!ModelState.IsValid)
            {

                return View(form);
            }
            _userRepo.Register(form.ToDal());

            return RedirectToAction("Login");
        }

        public IActionResult GetAll()
        {
            return View(_userRepo.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(_userRepo.GetById(id));
        }
        
    }
}
