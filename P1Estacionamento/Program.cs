// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



public class Program
{
    public static int Minimo { get; set; }
    public static int ValorPorHora { get; set; }
    public static int NumeroDeVagas { get; set; }
    public static void GetConfig()
    {
        Console.WriteLine("Digite o valor mínimo:");
        Minimo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor por hora:");
        ValorPorHora = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o número de vagas:");
        NumeroDeVagas = Convert.ToInt32(Console.ReadLine());
    }
    public static bool TestConfig()
    {
        if (Minimo > 0 && ValorPorHora > 0 && NumeroDeVagas > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Pause()
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
    public static void Menu()
    {
        Console.WriteLine("Bem vindo ao estacionamento!");
        Console.WriteLine("Digite o número da opção desejada:");
        Console.WriteLine("1 - Entrada de veículo");
        Console.WriteLine("2 - Saída de veículo");
        Console.WriteLine("3 - Consulta de veículo");
        Console.WriteLine("4 - Consulta de vagas");
        Console.WriteLine("5 - Configurações");
        Console.WriteLine("6 - Sair");
    }

    public static void EntradaDeVeiculo(Vaga[] vagas)
    {
        Console.WriteLine("Digite a placa do veículo:");
        string placa = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Digite o horário de entrada:");
        int hora = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < vagas.Length; i++)
        {
            if (!vagas[i].Ocupada)
            {
                vagas[i].Veiculo = new VeiculoEstacionado(placa, hora);
                vagas[i].Ocupada = true;
                Console.WriteLine("Veículo estacionado com sucesso!");
                break;
            }
            else if (i == vagas.Length - 1)
            {
                Console.WriteLine("Não há vagas disponíveis!");
            }
        }
    }
    public static void ConsultaDeVagas(Vaga[] vagas)
    {
        Console.WriteLine($"Total de {vagas.Length} vagas.");
        for (int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i].Ocupada)
            {
                Console.WriteLine("Vaga " + (i + 1) + ": " + vagas[i].Veiculo.Placa);
            }
            else
            {
                Console.WriteLine("Vaga " + (i + 1) + ": Livre");
            }
        }
    }
    public static void ConsultaDeVeiculo(Vaga[] vagas)
    {
        Console.WriteLine("Digite a placa do veículo:");
        string placa = Convert.ToString(Console.ReadLine());
        for (int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i].Veiculo.Placa == placa)
            {
                Console.WriteLine("Veículo encontrado!");
                Console.WriteLine("Placa: " + vagas[i].Veiculo.Placa);
                Console.WriteLine("Hora de entrada: " + vagas[i].Veiculo.HoraDeEntrada);
                break;
            }
            else if (i == vagas.Length - 1)
            {
                Console.WriteLine("Veículo não encontrado!");
            }
        }
    }
    public static void SaidaDeVeiculo(Vaga[] vagas)
    {
        Console.WriteLine("Digite a placa do veículo:");
        string placa = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Digite o horário de saída:");
        int hora = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i].Veiculo.Placa == placa)
            {
                Console.WriteLine("Valor a pagar: " + vagas[i].Veiculo.ValorAtual(Minimo, ValorPorHora, hora));
                vagas[i].Ocupada = false;
                vagas[i].Veiculo = null;
                break;
            }
            else if (i == vagas.Length - 1)
            {
                Console.WriteLine("Veículo não encontrado!");
            }
        }
    }
    public static void Prompt(Vaga[] vagas)
    {
        int opcao = 0;
        do{
            Console.Clear();
            Menu();
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Entrada de veículo");
                    EntradaDeVeiculo(vagas);
                    break;
                case 2:
                    Console.WriteLine("Saída de veículo");
                    SaidaDeVeiculo(vagas);
                    break;
                case 3:
                    Console.WriteLine("Consulta de veículo");
                    ConsultaDeVeiculo(vagas);
                    break;
                case 4:
                    Console.WriteLine("Consulta de vagas");
                    ConsultaDeVagas(vagas);
                    break;
                case 5:
                    Console.WriteLine("Configurações");
                    break;
                case 6:
                    Console.WriteLine("Sair");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Pause();
        } while (opcao != 6);

    }
    public static void Main()
    {
        //VeiculoEstacionado veiculo = new VeiculoEstacionado("ABC1234", 10);
        //Console.WriteLine(veiculo.ValorAtual(10, 5, 12));
        do {
            GetConfig();
        } while (!TestConfig());
        Console.WriteLine("Valor mínimo: " + Minimo);
        Console.WriteLine("Valor por hora: " + ValorPorHora);
        Console.WriteLine("Número de vagas: " + NumeroDeVagas);
        Vaga[] vagas = new Vaga[NumeroDeVagas];
        for (int i = 0; i < NumeroDeVagas; i++)
        {
            vagas[i] = new Vaga();
        }
        Prompt(vagas);
    }
}