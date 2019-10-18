using System;
using System.Collections.Generic;
using System.Text;

namespace CursoOnline.Dominio.Dtos
{
    public class CursoDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double CargaHoraria { get; set; }
        public int PublicoAlvoId { get; set; }
        public double Valor { get; set; }
    }
}
