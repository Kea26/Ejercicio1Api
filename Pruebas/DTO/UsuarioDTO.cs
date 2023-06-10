using Newtonsoft.Json;
using Pruebas.Models;

namespace Pruebas.DTO
{
    public class UsuarioDTO
    {
        public List<User> LeerJson()
        {
            if (!File.Exists("..\\Pruebas\\Archivos\\usuarios.json"))
            {
                return new List<User>();
            }
            string json = File.ReadAllText("..\\Pruebas\\Archivos\\usuarios.json");

            return JsonConvert.DeserializeObject<List<User>>(json);
        }

        public void GuardarUsuario(User user)
        {
            List<User> users = LeerJson();
            users.Add(user);

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText("..\\Pruebas\\Archivos\\usuarios.json", json);
        }

        public bool ValidarUsuario(User user)
        {
            List<User> users = LeerJson();

            var userGet = users.Find(x => x.Name == user.Name && x.Password==user.Password);
            if (userGet is not null)
            {
                return true;
            }

            return false;
        }
    }
}