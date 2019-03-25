using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Modelos
{
    class Aluno
    {
        // atributo matrícula
        public String matricula;

        // atributo período
        public int periodo;

        // método para verificar se é possível a matrícula do aluno na disciplina
        bool Matricular(Disciplina disciplina)
        {
            // retorna se o período é igual ao semestre da disciplina
            return this.periodo == disciplina.semestre;
        }

    }
}
