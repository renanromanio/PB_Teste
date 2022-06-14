using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClientesRepository
    {
        public ApplicationDbContext context { get; set; }

        public ClientesRepository()
        {
            context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>().Options);
        }

        public void Inserir(Cliente novoCliente)
        {
            context.Add(novoCliente);
            context.SaveChanges();
        }

        public IQueryable<Cliente> Listar()
        {
            return context.Clientes.OrderBy(x => x.Nome);
        }

        public Cliente? Listar(string email)
        {
            return context.Clientes.Where(x => x.Email.Equals(email)).FirstOrDefault();
        }

        public void Atualizar(Cliente cliente)
        {
            var clienteBanco = context.Clientes.Where(x => x.ClienteId == cliente.ClienteId).FirstOrDefault();
            clienteBanco.Nome = cliente.Nome;
            clienteBanco.Email = cliente.Email;

            context.Update(clienteBanco);
            context.SaveChanges();

        }

        public void Remover(string email)
        {
            var clienteBanco = context.Clientes.Where(x => x.Email.Equals(email)).FirstOrDefault();

            context.Remove(clienteBanco);
            context.SaveChanges();

        }
    }
}
