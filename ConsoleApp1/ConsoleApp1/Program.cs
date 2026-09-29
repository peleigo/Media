using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("escreva sua nota do primeiro semestre");
        float atividade1 = float.Parse(Console.ReadLine());
        float atividade2 = float.Parse(Console.ReadLine());
        float prova1 = float.Parse(Console.ReadLine());
        float atividadeN1 = (atividade1 + atividade2) / 2;
        float nota1 = atividadeN1 * 0.5f + prova1 * 0.5f;

        Console.WriteLine("escreva sua nota do segundo semestre");
        float atividade3 = float.Parse(Console.ReadLine());
        float atividade4 = float.Parse(Console.ReadLine());
        float prova2 = float.Parse(Console.ReadLine());
        float atividadeN2 = (atividade3 + atividade4) / 2;
        float nota2 = atividadeN2 * 0.5f + prova2 * 0.5f;
        float mediaFinal = nota1 * 0.4f + nota2 * 0.6f;
        Console.WriteLine("sua média final é: " + mediaFinal);
        if (mediaFinal >= 6)
        {
            Console.WriteLine("Parabéns, você foi aprovado!");
        }
        else
        {
            Console.WriteLine("coloque o valor da prova de recuperação:");
            float provaRecuperacao = float.Parse(Console.ReadLine());
            float mediaRecuperacao = (mediaFinal + provaRecuperacao) / 2;
            if(nota1> nota2)
            {
                mediaRecuperacao = (nota1 + provaRecuperacao) / 2;
            }
            else
            {
                mediaRecuperacao = (nota2 + provaRecuperacao) / 2;
            }
            Console.WriteLine("sua média final com a prova de recuperação é: " + mediaRecuperacao);
        }
    }
}