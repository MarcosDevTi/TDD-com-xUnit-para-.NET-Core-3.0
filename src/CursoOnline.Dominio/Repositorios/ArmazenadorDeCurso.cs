using CursoOnline.Dominio.Cursos;
using CursoOnline.Dominio.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoOnline.Dominio.Repositorios
{
    public class ArmazenadorDeCurso
    {
        private readonly ICursoRepositorio _cursoRepositorio;
        public ArmazenadorDeCurso(ICursoRepositorio cursoRepositorio)
        {
            _cursoRepositorio = cursoRepositorio;
        }
        public void Armazenar(CursoDto cursoDto)
        {
            var curso = new Curso(cursoDto.Nome, cursoDto.Descricao, cursoDto.CargaHoraria, (PublicoAlvo)cursoDto.PublicoAlvoId, cursoDto.Valor);
            _cursoRepositorio.Adicionar(curso);
        }
    }
}
