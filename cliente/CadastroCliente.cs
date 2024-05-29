using System.ComponentModel;

public class CadastroCliente {
    private List<Cliente> clientes = new List<Cliente>();

    public void Add(Cliente cliente){
        clientes.Add(cliente);
    }

    public void Remove(Cliente cliente){
        clientes.Remove(cliente);
    }
    public void ListarCliente() {
        foreach(var cliente in clientes) {
            Console.WriteLine(cliente.ToString());
        }
    }

    public List<Cliente> BuscarClientePorNome(string nome) {
        return clientes.Where(x => x.getNome().Equals(nome, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
