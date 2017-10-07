using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DealsAllAround.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using DealsAllAround.Data;
using Microsoft.AspNetCore.Authorization;
using System.Net.NetworkInformation;
namespace DealsAllAround.Controllers.Home
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET: /Account/ConfirmEmail 
        //[AllowAnonymous]
        //public async Task<ActionResult> ConfirmEmail(string Token, string Email)
        //{
        //    ApplicationUser user = this.UserManager.FindById(Token);
        //    if (user != null)
        //    {
        //        if (user.email == Email)
        //        {
        //            user.confirmedemail = true;
        //            await UserManager.UpdateAsync(user);
        //            await SignInAsync(user, isPersistent: false);
        //            return RedirectToAction("Index", "Home", new { ConfirmedEmail = user.Email });
        //        }
        //        else
        //        {
        //            return RedirectToAction("Confirm", "Account", new { Email = user.Email });
        //        }
        //    }
        //    else
        //    {
        //        return RedirectToAction("Confirm", "Account", new { Email = "" });
        //    }

        //}

        ////// POST: /Account/Register 
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Register(UserProvider model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new ApplicationUser() { Username = model.name };
        //        user.email = model.email;
        //        user.confirmedemail = false;
        //        var result = await UserManager.CreateAsync(user, model.password);
        //        if (result.Succeeded)
        //        {
        //            System.Net.Mail.MailMessage m = new System.Net.Mail.MailMessage(
        //                new System.Net.Mail.MailAddress("sender@mydomain.com", "Web Registration"),
        //                new System.Net.Mail.MailAddress(user.Email));
        //            m.Subject = "Email confirmation";
        //            m.Body = string.Format("Dear {0}<BR/>Thank you for your registration, please click on the below link to comlete your registration: <a href=\"{1}\" title=\"User Email Confirm\">{1}</a>", user.UserName, Url.Action("ConfirmEmail", "Account", new { Token = user.Id, Email = user.Email }, Request.Url.Scheme));
        //            m.IsBodyHtml = true;
        //            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.mydomain.com");
        //            smtp.Credentials = new System.Net.NetworkCredential("sender@mydomain.com", "password");
        //            smtp.EnableSsl = true;
        //            smtp.Send(m);
        //            return RedirectToAction("Confirm", "Account", new { Email = user.Email });
        //        }
        //        else
        //        {
        //            AddErrors(result);
        //        }
        //    }

        //    // If we got this far, something failed, redisplay formreturn View(model); 
        //}

        ////// POST: /Account/Login 
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await UserManager.FindAsync(model.UserName, model.Password); if (user != null)
        //        {
        //            if (user.ConfirmedEmail == true)
        //            {
        //                await SignInAsync(user, model.RememberMe); return RedirectToLocal(returnUrl);
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "Confirm Email Address.");
        //            }
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Invalid username or password.");
        //        }
        //    }// If we got this far, something failed, redisplay formreturn View(model); 
        //}

    }
}