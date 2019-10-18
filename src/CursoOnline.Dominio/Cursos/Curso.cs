using System;
using System.Collections.Generic;
using System.Text;

namespace CursoOnline.Dominio.Cursos
{
    public class Curso
    {
        public string Nome { get; private set; }
        public string Descricao { get; set; }
        public double CargaHoraria { get; private set; }
        public PublicoAlvo PublicoAlvo { get; private set; }
        public double Valor { get; private set; }

        public Curso(string nome, string descricao, double cargaHoraria, PublicoAlvo publicoAlvo, double valor)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Nome inválido");
            }
            if (cargaHoraria < 1)
            {
                throw new ArgumentException("Carga horária inválida");
            }
            if (valor < 1)
            {
                throw new ArgumentException("Valor inválido");
            }
            this.Nome = nome;
            this.Descricao = descricao;
            this.CargaHoraria = cargaHoraria;
            this.PublicoAlvo = publicoAlvo;
            this.Valor = valor;
        }
    }
}
