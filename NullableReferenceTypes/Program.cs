using System;
using System.Collections.Generic;
#nullable enable

namespace NullableReferenceType
{
    class Program
    {
        public static string ExibirDadosAluno(Aluno aluno)
        {
            return (aluno.Sobrenome != null)
            ? $"Nome: {aluno.Nome} Sobrenome: {aluno.Sobrenome[0]}., Idade: {aluno.Idade}"
            : $"Nome: {aluno.Nome}, Idade: {aluno.Idade}";
        }

        public static IEnumerable<string> ListarAlunos(IList<Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                yield return ExibirDadosAluno(aluno);
            }
        }


        static void Main(string[] args)
        {
            var alunos = new List<Aluno>()
            {
                new Aluno("Fernando", 38 ),
                new Aluno("Mariana", 32 ),
                new Aluno("Ana", 29 ),
            };

            var alunosMaticulados = ListarAlunos(alunos);

            foreach (var aluno in alunosMaticulados)
            {
                Console.WriteLine(aluno);
            }

            Console.ReadKey();
        }
    }

    public class Aluno
    {
        public string Nome { get; set; }
        public string? Sobrenome { get; set; }
        public int Idade { get; set; }

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Sobrenome = null;
            Idade = idade;
        }
    }
}
