using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo15.entities
{
    class Instrutor
    {
        public HashSet<Aluno> alunos { get; set; }

        public List<Curso> cursos { get; set; }

        public Instrutor(HashSet<Aluno> alunos, List<Curso> cursos)
        {
            this.alunos = alunos;
            this.cursos = cursos;
        }

        public override bool Equals(object obj)
        {
            return obj is Instrutor instrutor &&
                   EqualityComparer<List<Curso>>.Default.Equals(cursos, instrutor.cursos);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(cursos);
        }
    }
}
