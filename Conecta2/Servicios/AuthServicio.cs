using BDSql;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.UI;

namespace Conecta2.Servicios
{
    public class AuthServicio : Page
    {
        private conectaDBEntities db = new conectaDBEntities();

        public async         Task<BDSql.usuario> Login(string email, string password)
        {
            //usuario usuario;

            //usuario = null;

            var output = db.usuario.FirstOrDefault(m => (m.email == email && (m.password == password)));

            if(output != null)
            {
                Session["Autenticacion"] = true;
                Session["id"] = output.id_usuario;
           
               // usuario = await db.usuario.FindAsync(output.id_usuario);
            }
            
            return (output);
        }
    }
}