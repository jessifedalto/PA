public class Cliente {
    private String Nome { get; set; }
    private String codigo { get; set; }
    private String nascimento { get; set; }
    private String email { get; set; }

    public Cliente(String nome, String cod, String nascimento, String email) {
        this.Nome = nome;
        this.codigo = cod;
        this.nascimento = nascimento;
        this.email = email;
    }   
    
    public override string ToString() {
        return $"Nome: {this.Nome} \nEmail: {this.email} \nData de Nascimento: {this.nascimento}";
    }

    public string getNome(){
        return this.Nome;
    }
}
