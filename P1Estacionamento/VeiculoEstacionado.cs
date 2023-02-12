using System;

public class VeiculoEstacionado
{
    public string Placa { get; set; }
    public int HoraDeEntrada { get; set; }
    public VeiculoEstacionado(string placa, int horaDeEntrada)
    {
        Placa = placa;
        HoraDeEntrada = horaDeEntrada;
    }
    public int ValorAtual(int minimo, int valorporhora, int hora)
    {
        return (minimo + ((hora-HoraDeEntrada) * valorporhora));
    }
}

