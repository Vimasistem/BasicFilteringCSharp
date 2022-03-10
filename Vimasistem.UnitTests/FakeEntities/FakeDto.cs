using System;
using Vimasistem.QueryFilter.Attributes;

namespace Vimasistem.UnitTests.FakeEntities
{
    public class FakeDto : QueryFilter.QueryFilter
	{
		[Filter("ID")]
		public int Id { get; set; }

		[Filter("NOMBRE")]
		public string Nombre { get; set; }

		[Filter("DESCRIPCION")]
		public string Descripcion { get; set; }

		[Filter("FECHA")]
		public DateTime Fecha { get; set; }
	}
}

