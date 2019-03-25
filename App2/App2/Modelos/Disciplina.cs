using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Modelos
{
    class Disciplina
    {
        // atributo nome
        public String nome;

        // atributo semestre
        public int semestre;

        // construtor da classe
        public Disciplina(String nome, int semestre)
        {
            this.nome = nome;
            this.semestre = semestre;
        }

    }
}