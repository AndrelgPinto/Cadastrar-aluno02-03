string[,] cadastrar = new string[5, 7];

int i = 0;
string nomealuno = " ";
int linha = 0;
int coluna = 0; 

for (i = 0; i <= 4; i++)
{
    Console.Clear();
    Console.WriteLine("Qual nome do Aluno");
    cadastrar[linha, coluna]= Console.ReadLine();

    Console.Clear();
    Console.WriteLine("Numero de aulas dadas");
    cadastrar[linha, coluna] = Console.ReadLine();


    Console.Clear();
    Console.WriteLine("Numero de Faltas");
    cadastrar[linha, coluna] = Console.ReadLine();
}
