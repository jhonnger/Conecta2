using BDSql;
using Conecta2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Conecta2.Repositorios
{
    public class AuthRepository : IDisposable
    {
        private ApplicationDBContext _ctx;

        private UserManager<MyUser, long> _userManager;

        public AuthRepository()
        {
            _ctx = new ApplicationDBContext();
            _userManager = new UserManager<MyUser, long>(new UserStore<MyUser, MyRole, long, MyLogin, MyUserRole, MyClaim>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(Models.usuario userModel)
        {
            MyUser user = new MyUser
            {
                Email = userModel.email,
                UserName = userModel.email
            };

            var result = await _userManager.CreateAsync(user, userModel.password);

            return result;
        }

        public async Task<MyUser> FindUser(string userName, string password)
        {
            MyUser user = await _userManager.FindAsync(userName, password);

            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}