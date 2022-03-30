using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vimasistem.UnitTests.FakeEntities;

namespace Vimasistem.UnitTests
{
    [TestClass]
	public class QueryFilterTest
	{
		[TestMethod]
		public void FilterGenerationTest()
		{
			FakeDto dto = new FakeDto
			{
				codigoPersona = 1,
				nombre= "%NOMBRE%",
				nroIdentificacion = "0123456789",
				apellido = "%APELLIDO%"
			};

			string query = dto.GetQuery(new []{ "pers:pers", "PERS_PERSONAS:pp" }).Trim();

			string expectedQuery = "pp.CODIGO_PERSONA = :codigoPersona AND UPPER( pers.nombre) LIKE UPPER(:nombre) AND UPPER( pp.NUMERO_IDENTIFICACION) LIKE UPPER(:nroIdentificacion) AND UPPER( APELLIDO) LIKE UPPER(:apellido)";

			Assert.AreEqual(expectedQuery, query);
		}
	}
}

