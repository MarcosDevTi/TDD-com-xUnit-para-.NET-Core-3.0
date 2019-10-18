using CursoOnline.Dominio.Cursos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoOnline.Dominio.Repositorios
{
    public interface ICursoRepositorio
    {
        void Adicionar(Curso curso);
    }
}
