using AzTUChat.DAL;
using AzTUChat.Models;
using AzTUChat.Utilies.Extensions;
using AzTUChat.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AzTUChat.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _envo;
        private readonly AppDbContext _context;

        public AccountController(UserManager<AppUser> userManager, 
            SignInManager<AppUser> signInManager, 
            IWebHostEnvironment envo,
            AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _envo = envo;
            _context = context;
        }
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(SignInVM signIn)
        {
            AppUser user = _context.Users.SingleOrDefault(u => u.UserName == signIn.Username);
            var result = await _signInManager.PasswordSignInAsync(user, signIn.Password, true, true);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Login or Password is Wrong!");
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();

            if(register == null) return View();
            if (register.Image.CheckSize(50000))
            {
                ModelState.AddModelError("Image", "This cant be higher than 50000 kb");
            }
            if (!register.Image.CheckType("image/"))
            {
                ModelState.AddModelError("Image", "File Must be Image");
            }

            string savePath = Path.Combine(_envo.WebRootPath, "image", "profileimage");
            string fileName = await register.Image.SaveFileAsync(savePath);
            AppUser user = new AppUser
            {
                FullName=register.FullName,
                UserName=register.Username,
                
            };
            IdentityResult result = await _userManager.CreateAsync(user, register.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                    return View(register);
                }
            }
            UserImage ui = new UserImage
            {
                AppUser = user,
                Image = fileName
            };
            await _context.UserImages.AddAsync(ui);
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(LogIn));
        }
    }
}
