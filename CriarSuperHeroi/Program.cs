
using CriarSuperHeroi.Dados;
using CriarSuperHeroi.Entidades;
using CriarSuperHeroi.Enum;

Console.Write("Digite o nome do herói: ");
string nomeHeroi = Console.ReadLine();

Console.WriteLine("Escolha os poderes do herói (digite  um numero por vez):");
List<Poder> poderesHeroi = new List<Poder>();

bool continuarEscolhendo = true;

while (continuarEscolhendo)
{
    Console.WriteLine("Poderes disponíveis: ");
    for (int i = 1; i < Enum.GetValues(typeof(Poder)).Length; i++)
    {
        Console.WriteLine($"{i}. {Enum.GetName(typeof(Poder), i)}");
    }

    if (int.TryParse(Console.ReadLine(), out int escolha) && escolha >= 1 && escolha <= 12)
    {
        Poder poderEscolhido = (Poder)(escolha);
        if (!poderesHeroi.Contains(poderEscolhido))
        {
            poderesHeroi.Add(poderEscolhido);
            Console.WriteLine($"Poder '{Enum.GetName(typeof(Poder), escolha)}' adicionado.");
        }
        else
        {
            Console.WriteLine("Você já escolheu este poder. Escolha outro ou pressione Enter para continuar.");
        }
    }

    else
    {
        Console.WriteLine("Opção inválida. Escolha um número entre 1 e 12 ou pressione Enter para continuar.");
    }

    Console.Write("Pressione Enter para continuar ou digite 'S' para sair: ");
    string resposta = Console.ReadLine().Trim().ToUpper();
    if (resposta == "S")
    {
        continuarEscolhendo = false;
    }
}


Heroi heroi = new Heroi
{
    Nome = nomeHeroi,
    Poderes = poderesHeroi
};
var servico = new ArquivoTextoDados();
servico.SalvarEmArquivo(heroi);


