using Bogus;
using CursoOnline.Dominio.Cursos;
using CursoOnline.Dominio.Dtos;
using CursoOnline.Dominio.Repositorios;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoOnline.DominioTest.Cursos
{
    public class ArmazenadorDeCursoTest
    {
        [Fact]
        public void DeveAdicionarCurso()
        {
            var faker = new Faker();
            var cursoDto = new CursoDto
            {
                Nome = faker.Random.Word(),
                Descricao = faker.Lorem.Paragraph(),
                CargaHoraria = faker.Random.Double(1, 50),
                PublicoAlvoId = faker.Random.Int(0, 60000),
                Valor = faker.Random.Double(0.1, 50000)
            };

            var cursorepositorioMock = new Mock<ICursoRepositorio>();
            var armazenadorDeCurso = new ArmazenadorDeCurso(cursorepositorioMock.Object);
            armazenadorDeCurso.Armazenar(cursoDto);
            cursorepositorioMock.Verify(r => r.Adicionar(It.Is<Curso>(c => 
            c.Nome == cursoDto.Nome &&
            c.Descricao == cursoDto.Descricao
            )));
        }

        [Fact]

    }
}
