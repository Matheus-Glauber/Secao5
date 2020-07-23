using Modulo15.entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Modulo15
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno _21 = new Aluno(21);
            Aluno _35 = new Aluno(35);
            Aluno _22 = new Aluno(22);
            Aluno _50 = new Aluno(50);
            Aluno _42 = new Aluno(42);
            Aluno _13 = new Aluno(13);

            Curso CursoA = new Curso("A", new HashSet<Aluno>());
            CursoA.Alunos.Add(_21);
            CursoA.Alunos.Add(_35);
            CursoA.Alunos.Add(_22);

            Curso CursoB = new Curso("B", new HashSet<Aluno>());
            CursoB.Alunos.Add(_21);
            CursoB.Alunos.Add(_50);

            Curso CursoC = new Curso("C", new HashSet<Aluno>());
            CursoC.Alunos.Add(_42);
            CursoC.Alunos.Add(_35);
            CursoC.Alunos.Add(_13);

            Instrutor instrutor = new Instrutor(new List<Curso>());
            instrutor.Cursos.Add(CursoA);
            instrutor.Cursos.Add(CursoB);
            instrutor.Cursos.Add(CursoC);

            Console.WriteLine("Total Students: " + instrutor.TotalAlunos());
        }
    }
}
