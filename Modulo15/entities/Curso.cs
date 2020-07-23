using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Modulo15.entities
{
    class Curso
    {
        public String Nome { get; set; }

        public Curso(string nome)
        {
            Nome = nome;
        }

        public override bool Equals(object obj)
        {
            return obj is Curso cursos &&
                   Nome == cursos.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }
    }
}
