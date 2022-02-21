using System;

namespace Vimasistem.QueryFilter.Attributes
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class Filter : Attribute
    {
        private readonly string _fieldName;
        private readonly string _group;
        
        public Filter(string field)
        {
            _fieldName = field;
        }

        public Filter(string field, string group)
        {
            _fieldName = field;
            _group = group;
        }

        public string FieldName => _fieldName;

        public string Group => _group;
    }
}