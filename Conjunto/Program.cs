using System;
using System.Collections.Generic;
using System.Globalization;

namespace Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("Digite o total de Alunos A: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os codigos dos alunos: ");
            for (int i=0; i<N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.Write("Digite o total de alunos do curso B: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o codigo dos alunos: ");
            for (int i=0; i<N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.Write("Digite o total de alunos C: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o codigo dos alunos: ");
            for (int i=0; i<N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            HashSet<int> Aluno = new HashSet<int>();
            Aluno.UnionWith(A);
            Aluno.UnionWith(B);
            Aluno.UnionWith(C);
            Console.WriteLine("Total de alunos matriculados: " + Aluno.Count);
            Console.ReadLine();
        }
    }
}
