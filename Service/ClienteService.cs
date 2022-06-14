using Domain;
using Repository;

namespace Service
{
    public class ClienteService
    {
        public ClientesRepository repositorio { get; set; }

        public ClienteService()
        {
            repositorio = new ClientesRepository();
        }

        public void Inserir(Cliente novoCliente)
        {
            repositorio.Inserir(novoCliente);
        }

        public IQueryable<Cliente> Listar()
        {
            return repositorio.Listar();
        }

        public Cliente? Listar(string email)
        {
            return repositorio.Listar(email);
        }

        public void Atualizar(Cliente cliente)
        {
            repositorio.Atualizar(cliente);

        }

        public void Remover(string email)
        {
            repositorio.Remover(email);

        }


    }
}