using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace JsonSchemaV4
{
    public class JValidator
    {
        public JValidator(JSchema jSchema)
        {
            if (jSchema == null)
            {
                throw new ArgumentNullException(nameof(jSchema));
            }

            this.Schema = jSchema;
        }

        public JSchema Schema { get; }

        public IList<string> Validate(JObject json)
        {
            var errorsList = new List<string>();



            return errorsList;
        }
    }
}
