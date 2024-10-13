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
			var result = ConditionalHandler(data);
			if (await result == Status.Success)
			{
				await _context.MBInformation.AddAsync(data);

				await _context.SaveChangesAsync();
			}


		}
		private async Task<Status> ConditionalHandler(MembersBaseInfo data)
		{

			var information = _context.MBInformation.ToList();
			var FirstName = data.FirstName.ToString();
			var LastName = data.LastName.ToString();
			var UserName = data.UserName.ToString();
			var Email = data.Email.ToString();
			var Password = data.Password.ToString();
			var CPassword = data.ConfirmPassword.ToString();
			var error = 0;

			if (UserName.Length < 2) 
			{
				error += 1;
				TempData["SignInStatus"] = "Your Username is too Short!";
				return Status.Faild;
			}
			if (FirstName.Length < 2)
			{
				error += 1;
				TempData["SignInStatus"] = "Your FirstName is too Short!";
				return Status.Faild;
			}
			if (LastName.Length < 2)
			{
				error += 1;
				TempData["SignInStatus"] = "Your LastName is too Short!";
				return Status.Faild;
			}
			if (!Email.Contains("@") || !Email.Contains(".com"))
			{
				error += 1;
				TempData["SignInStatus"] = "Your email is not correct!";
				return Status.Faild;
			}
			if (Password.Length < 8 || CPassword.Length < 8 || !(Password == CPassword))
			{
				error += 1;
				TempData["SignInStatus"] = "Your password or Confirm password is not correct!";
				return Status.Faild;
			}
			foreach (var member in information)
			{
				if (member.Email == data.Email)
				{
					TempData["SignInStatus"] = "Your email is already registered!";
					error += 1;
					return Status.Faild;
				}
			}


			TempData["SignInStatus"] = "Your information is successfully saved!";
			return Status.Success;



		}



	}
}
