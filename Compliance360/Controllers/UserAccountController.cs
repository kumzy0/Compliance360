using Compliance360.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Compliance360.Controllers
{
  public class UserAccountController : Controller
  {
    private readonly ApplicationDbContext _context;

    public UserAccountController(ApplicationDbContext context)
    {
      _context = context;
    }

    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public IActionResult GetOTP(string email)
    {
      //check if user exist
      var user = _context.Users.Where(x => x.Email == email).FirstOrDefault();
      if (user == null)
      {
        //create user

      }

      //send otp to user





      return View();
    }

  }
}
