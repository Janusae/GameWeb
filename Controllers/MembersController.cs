using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using MyTestProject.ClassesEntity;
using MyTestProject.Models;
using System.Runtime.InteropServices;

namespace MyTestProject.Controllers
{
    public class MembersController : Controller
    {
        private readonly MyIndexInformation _context; // Use your DbContext type
        public MembersController(MyIndexInformation context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }
        public async Task<IActionResult> SignInChecker(MembersBaseInfo data)
        {
            await SingIngHandler(data); // Await the asynchronous method
            return View("SignIn");
        }

        private async Task SingIngHandler(MembersBaseInfo data)
        {
            var result =  ConditionalHandler(data);
            if(await result == Status.Success)
            {
                await _context.MBInformation.AddAsync(data);

                await _context.SaveChangesAsync();
            }

            
        }
        private async Task<Status> ConditionalHandler(MembersBaseInfo data)
        {
            var information = _context.MBInformation.ToList();
            var error = 0;
            foreach (var member in information) 
            {
                if(member.Email == data.Email)
                {
                    error += 1;
                }
            }
            if(error == 0)
            {
                return Status.Success;
            }
            else
            {
                return Status.Faild;
            }
           
            
        }



    }
}
