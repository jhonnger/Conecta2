
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Conecta2.Servicios;
using System.Web.Http.Description;
using Conecta2.Models;
using Conecta2.Repositorios;

namespace Conecta2.Controllers
{
    public class AuthController : ApiController
    {
        private AuthServicio authServicio = new AuthServicio();
        private AuthRepository authRepository = new AuthRepository();



        
        [AllowAnonymous]
        [HttpPost]
        [ResponseType(typeof(Models.usuario))]
        public async Task<IHttpActionResult> Register(LoginModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //IdentityResult result = await authRepository.RegisterUser(userModel);

            //IHttpActionResult errorResult = GetErrorResult(result);

            //if (errorResult != null)
            //{
            //    return errorResult;
            //}

            //return Ok();
            if (ModelState.IsValid)
            {
                var user = new MyUser() { UserName = model.email };
                var _context = new ApplicationDBContext();
                var UserManager = new UserManager<MyUser, long>(new UserStore<MyUser,MyRole, long, MyLogin, MyUserRole, MyClaim>(_context));
                var result = await UserManager.CreateAsync(user, model.password);
                if (result.Succeeded)
                {
                    return Ok("oki");
                }
                else
                {
                    return Ok("mal");
                }
            }

            // If we got this far, something failed, redisplay form
            return Ok("fatal");
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }


        [HttpPost]
        [ResponseType(typeof(Models.usuario))]
        public async Task<IHttpActionResult> Login([FromBody] Models.usuario usuario)
        {
            /**string email = "";
            string password = "";
            if(usuario != null)
            {
                email = usuario.email;
                password = usuario.password;
            }

            return  ( authServicio.Login(email,password));**/

            if (ModelState.IsValid)
            {
              var user =  await authRepository.FindUser(usuario.email, usuario.password);
                
                if (user != null)
                {
                    
                    return Ok(user);
                }
            }
            
            return Ok("Holi");


        }
    }
}
