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
				Id = 1,
				Nombre = "%NOMBRE%",
				Descripcion = "DESCRIPCION"
			};

			string query = dto.GetQuery();
			string expectedQuery = "  ID = :Id AND LOWER(NOMBRE) LIKE LOWER(:Nombre) AND LOWER(DESCRIPCION) LIKE LOWER(:Descripcion) AND FECHA = :Fecha";

			Assert.AreEqual(expectedQuery, query);
		}
	}
}

