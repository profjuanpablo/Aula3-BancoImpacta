﻿using System.Security.Cryptography;

namespace Aula3
{
    
    //Modificador de acesso internal - o acesso é limitado ao Assembly atual
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno();

            a1.Nome = "Vinicius";
            a1.Turma = "C#";
            a1.Idade = 25;
            a1.NMat = 1003;
            a1.Mensalidade = 500;


            a2.Nome = "Fernando";
            a2.Turma = "C#";
            a2.Idade = 22;

            //Console.WriteLine(new String('-',50));
            //Console.WriteLine($"Aluno: {a1.Nome} - Turma: {a1.Turma} - Idade: {a1.Idade} ");

            //Console.WriteLine(new String('-', 50));
            //Console.WriteLine($"Aluno: {a2.Nome} - Turma: {a2.Turma} - Idade: {a2.Idade} ");

            Console.WriteLine( new String('-', 50));
            a1.ExibirAluno();
            a1.TrocarTurma("ASP.Net Core");
            a1.ExibirAluno();
            a1.Desconto(10);
            a1.ExibirAluno();

        }
    }
}