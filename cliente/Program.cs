using System.ComponentModel.Design;
using System.Data;
using System.Runtime.CompilerServices;

class Program {
    public static void Main(string[] args) {
        CadastroCliente cadastro = new CadastroCliente();

        Program.menu();

        Cliente cliente = new Cliente("Maria", "1", "07/09/2002", "trola");
        Cliente cliente1 = new Cliente("Ana", "1", "07/09/2002", "cu");

        cadastro.Add(cliente);
        cadastro.Add(cliente1);

        cadastro.ListarCliente();

        Console.WriteLine("--------------------------------------");

        cadastro.Remove(cliente1);
        cadastro.ListarCliente();

        Console.WriteLine("--------------------------------------");

        List<Cliente> clientesEncontrados = cadastro.BuscarClientePorNome("Ana");
        foreach (var clientess in clientesEncontrados) {
            Console.WriteLine(clientess.ToString());
        }
    }

    public static void menu() {
        Console.WriteLine("****************** M E N U ******************\n\n");
        Console.WriteLine("1 - Cadastrar cliente\n");
        Console.WriteLine("2 - Remover cliente\n");
        Console.WriteLine("3 - Buscar cliente por nome\n");
        Console.WriteLine("4 - Listar todos os clientes\n");
        Console.WriteLine("0 - SAIR\n\n");
    }   
}