﻿using System;
using Xunit;

namespace CursoOnline.DominioTest._Utils
{
    public static class ArgumentExceptionExtensions
    {
        public static void ComMensagem(this ArgumentException exception, string mensagem)
        {
            if (exception.Message == mensagem)
                Assert.True(true);
            else
            Assert.False(true, $"Esperava a mensagem '{mensagem}'");
        }
    }
}