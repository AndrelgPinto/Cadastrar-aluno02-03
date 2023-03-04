string aluno;
int faltasfinais = 0;
int aulas = 0;
int falta = 0;
double media = 0;
double prova1, prova2, prova3, trabalho;
double vale1 = 0.3;
double vale2 = 0.25;
double vale3 = 0.35;
double presenca = 0;
int i;
string resultado = "";

for (i = 1; i <= 5; i++)
{
    Console.Clear();
    Console.WriteLine("Nome do " + i + "º Aluno");
    aluno = Console.ReadLine();

    Console.WriteLine("Numero de Aulas");
    aulas = int.Parse(Console.ReadLine());

    Console.WriteLine("Numero de Faltas");
    falta = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual nota da prova 1"  );
    prova1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Qual nota da prova 2" );
    prova2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Qual nota da prova 3" );
    prova3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Qual nota do Trabalho");
    trabalho = double.Parse(Console.ReadLine());

    media = (prova1 * vale1 + prova2 * vale2 + prova3 * vale3) + trabalho;
    faltasfinais = (falta * 100) / aulas;
    presenca = 100 - faltasfinais;


    if (media >= 6 && presenca > 25)
    {
        Console.WriteLine(aluno + " Aprovado com " + media.ToString("F") + "de media e " + presenca + " de presenca");
    }
    if (media < 6 && presenca >= 25)
    {
        Console.WriteLine(aluno + " Reprovado por menção com " + media.ToString("F") + " de media");
    }
    if (media > 6 && presenca < 25)
    {
       Console.WriteLine(aluno + " Reprovado por menção com " + presenca + " de presença");
    }
    if (media < 6 && presenca < 25)
    {
        Console.WriteLine(aluno + " Reprovadopor menção e faltas com " + media.ToString("F") + " de media e " + presenca + " de menção");
    }

    Console.WriteLine("Pressione ENTER para continuar");
    Console.ReadLine();
}

 