using Microsoft.AspNetCore.Mvc;
using Pruebas.Contexts;
using Pruebas.DTO;
using Pruebas.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pruebas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ConexionSQL _conexionSQL;
        public UsuarioDTO _dto = new UsuarioDTO();

        public UserController(ConexionSQL conexionSQL)
        {
            _conexionSQL = conexionSQL;


        }

        //GET: api/<UserController>
        [HttpGet]
        public List<User> GetAll()
        {
            return _dto.LeerJson();
        }

        //GET api/<UserController>/5
        [HttpPost("ValidarUsuario")]
        public bool Validateuser(User usuario)
        {
            return _dto.ValidarUsuario(usuario);
        }

        /// <summary>
        /// Permite el registro de un nuevo usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        public List<User> AddUser(User usuario)
        {
            _dto.GuardarUsuario(usuario);
            return _dto.LeerJson();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put()
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}