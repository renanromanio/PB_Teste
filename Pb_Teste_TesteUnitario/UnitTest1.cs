using Domain;
using Service;
using Xunit.Sdk;

namespace Pb_Teste_TesteUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        static public void Main()
        {
            var service = new ClienteService();


            // Create
            Console.WriteLine("Inserindo um novo cliente");
            service.Inserir(new Cliente() { Email = "almir@teste.com", Nome = "Almir" });

            // Read
            Console.WriteLine("Consultando um cliente");
            var cliente = service.Listar("almir@teste.com");

            // Update
            Console.WriteLine("Alterando um cliente");
            cliente = service.Listar("almir@teste.com");
            cliente.Nome = "Almir Santos";
            cliente.Email = "almir@santos.com";
            service.Atualizar(cliente);


            // Delete
            Console.WriteLine("Deletando um cliente");
            service.Remover("almir@santos.com");
        }

    }
}