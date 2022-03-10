using System;
using Vimasistem.QueryFilter.Attributes;

namespace Vimasistem.QueryFilter
{
    public class QueryFilter
    {
        public string GetQuery(string[] tables = null)
        {
            string conditions = "";
            var properties = GetType().GetProperties();

            string prefix = "";
            
            foreach (var propertyInfo in properties)
            {
                try
                {
                    Filter attribute = (Filter) Attribute.GetCustomAttribute(propertyInfo, typeof(Filter));

                    if (propertyInfo.GetValue(this) != null)
                    {
                        if(propertyInfo.GetValue(this).GetType() == typeof(string) || propertyInfo.GetValue(this).GetType() == typeof(char))
                        {
                            conditions = conditions + $" {prefix} LOWER( " + (attribute.Group != null ? attribute.Group + "." : "") + $"{attribute.FieldName}) LIKE LOWER(:{propertyInfo.Name})";
                        } else
                        {
                            conditions = conditions + $" {prefix} " + (attribute.Group != null ? attribute.Group + "." : "") + $"{attribute.FieldName} = :{propertyInfo.Name}";
                        }

                        prefix = "AND";
                    }
                }
                catch
                {
                    // ignored
                }
            }

            if (tables is not {Length: > 0}) return conditions;

            for (var index = 0; index < tables.Length; index++)
            {
                var table = tables[index];
                var names = table.Split(":");
                conditions = conditions.Replace($" {names[0]}.", $" {names[1]}.");
            }

            return conditions;
        }
    }
}