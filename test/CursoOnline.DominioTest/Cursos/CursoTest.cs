using Bogus;
using CursoOnline.Dominio.Cursos;
using CursoOnline.DominioTest._Utils;
using CursoOnline.DominioTest.Buiders;
using ExpectedObjects;
using System;
using Xunit;

namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTest: IDisposable
    {
        private string _nome;
        private string _descricao;
        private double _cargaHoraria;
        private PublicoAlvo _publicoAlvo;
        private double _valor;
        public CursoTest()
        {
            var faker = new Faker();

            _nome = faker.Random.Word();
            _descricao = faker.Lorem.Paragraph();
            _cargaHoraria = faker.Random.Double(5, 50000);
            _publicoAlvo = PublicoAlvo.Estudantes;
            _valor = faker.Random.Double(5, 50000);
        }

        public void Dispose()
        {
           
        }

        [Fact]
        public void DeveCriarCurso()
        {
            var cursoEsperado = new
            {
                Nome = "Informática Básica",
                Descricao = "Descrição",
                CargaHoraria = 80D,
                PublicoAlvo = PublicoAlvo.Estudantes,
                Valor = 950D
            };

            var curso = new Curso(cursoEsperado.Nome, cursoEsperado.Descricao, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);
            cursoEsperado.ToExpectedObject().ShouldMatch(curso);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("  ")]
        public void NaoDeveCursoTerUmNomeInvalido(string nomeInvalido) =>
            Assert.Throws<ArgumentException>(() =>
                new CursoBuilder().ComNome(nomeInvalido).Build())
                .ComMensagem("Nome inválido");

        [Theory]
        [InlineData(0)]
        [InlineData(0.25)]
        [InlineData(-1)]
        public void NaoDeveCursoTerCargaHorariaMenorQue1(double cargaHorariaInvalida) =>
            Assert.Throws<ArgumentException>(() =>
            new CursoBuilder().ComCargaHoraria(cargaHorariaInvalida).Build())
                .ComMensagem("Carga horária inválida");

        [Theory]
        [InlineData(0)]
        [InlineData(0.25)]
        [InlineData(-5)]
        public void NaoPodeCursoTerValorMenorQue1(double valorInvalido) =>
            Assert.Throws<ArgumentException>(() =>
            new CursoBuilder().ComValor(valorInvalido).Build())
                .ComMensagem("Valor inválido");
    }
   
    
}
