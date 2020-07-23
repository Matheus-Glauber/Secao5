using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo15.entities
{
    class Instrutor
    {
        

        public List<Curso> Cursos { get; set; }

        public Instrutor(List<Curso> cursos)
        {
            Cursos = cursos;
        }

        public override bool Equals(object obj)
        {
            return obj is Instrutor instrutor &&
                   EqualityComparer<List<Curso>>.Default.Equals(Cursos, instrutor.Cursos);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Cursos);
        }
    }
}
