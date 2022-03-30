using Vimasistem.QueryFilter.Attributes;

namespace Vimasistem.UnitTests.FakeEntities
{
    public class FakeDto : QueryFilter.QueryFilter
	{
        [Filter("CODIGO_PERSONA", "PERS_PERSONAS")]
        public int? codigoPersona { get; set; }

        [Filter("nombre", "pers")]
        public string nombre { get; set; }

        [Filter("NUMERO_IDENTIFICACION", "PERS_PERSONAS")]
        public string nroIdentificacion { get; set; }

        [Filter("APELLIDO")]
        public string apellido { get; set; }
    }
}

