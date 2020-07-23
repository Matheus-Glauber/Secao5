using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo15.entities
{
    class Aluno
    {
        public int Codigo { get; set; }

        public Aluno(int codigo)
        {
            Codigo = codigo;
        }

        public override bool Equals(object obj)
        {
            return obj is Aluno aluno &&
                   Codigo == aluno.Codigo;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Codigo);
        }
    }
}
