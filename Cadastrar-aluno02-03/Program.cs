string[,] aluno = new string[5, 7];
int aulas = 0;
int falta = 0;
int linha, coluna = 0;
double prova1, prova2, prova3, trabalho;
int i = 0;
string resultado = "";

for (linha = 0; linha <= 4; linha++)
{
    Console.Clear();
    Console.WriteLine("Nome do Aluno");
    aluno[linha, coluna++] = Console.ReadLine();

    Console.WriteLine("Numero de Aulas");
    aulas = int.Parse(Console.ReadLine());

    Console.WriteLine("Numero de Faltas");
    falta = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual nota da prova 1"  );
    prova1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual nota da prova 2" );
    prova2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual nota da prova 3" );
    prova3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual nota do Trabalho");
    trabalho = int.Parse(Console.ReadLine());

    Console.WriteLine(  aluno + "resultado " + linha, coluna == aulas + falta + prova1 + prova2 + prova3);
}

 