string[,] cadastrar = new string[5, 7];
int  numerodeaulas = 0 , numerofaltas = 0;
int notaprova1 = 0, notadaprova2 = 0, notadaprova3 = 0, notadotrabalho = 0;
int i = 0;
string nomealuno = " ";

for (i = 0; i <= 4; i++)
{
    Console.Clear();
    Console.WriteLine("Qual nome do Aluno");
    nomealuno = Console.ReadLine();

    Console.Clear();
    Console.WriteLine("Numero de aulas dadas");
    numerodeaulas = int.Parse(Console.ReadLine());


    Console.Clear();
    Console.WriteLine("Numero de Faltas");
    numerodeaulas = int.Parse(Console.ReadLine());
}
