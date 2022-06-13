using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PB_Teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public ClienteService service { get; set; }

        public ClienteController()
        {
            service = new ClienteService();
        }



        // GET: api/<ClienteController>
        [HttpGet]
        public IEnumerable<Cliente> Listar()
        {
            return service.Listar();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{email}")]
        public Cliente Get(string email)
        {
            return service.Listar(email);
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Inserir(Cliente novo)
        {
            service.Inserir(novo);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, Cliente cliente)
        {
            cliente.ClienteId = id;
            service.Atualizar(cliente);
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{email}")]
        public void Delete(string email)
        {
            service.Remover(email);
        }
    }
}
