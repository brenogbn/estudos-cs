public class Vaga{
    public bool Ocupada { get; set; }
    public VeiculoEstacionado? Veiculo { get; set; }
    public Vaga()
    {
        Ocupada = false;
        Veiculo = null;
    }
}