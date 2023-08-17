// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

int num = 100;

while (num > 0)
{
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("                 0 - Sair");
    Console.WriteLine("                 1 - Adicionar curso");
    Console.WriteLine("                 2 - Pesquisar curso");
    Console.WriteLine("                 3 - Remover curso");
    Console.WriteLine("                 4 - Adicionar disciplina no curso");
    Console.WriteLine("                 5 - Pesquisar disciplina");
    Console.WriteLine("                 6 - Remover disciplina do curso");
    Console.WriteLine("                 7 - Matricular aluno na disciplina");
    Console.WriteLine("                 8 - Remover aluno da disciplina");
    Console.WriteLine("                 9 - Pesquisar aluno");
    Console.WriteLine("-------------------------------------------------------------");
    Console.Write("Digite uma opção desejada: ");
    num = Int32.Parse( Console.ReadLine());
    switch (num)
    {
        case 0:
            Console.WriteLine("SAINDO...");
            break;
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            break;
        case 8:
            break;
        case 9:
            break;
    }
}
