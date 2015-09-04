namespace JsonSchemaV4
{
    using Newtonsoft.Json.Linq;

    public class JSchema : JObject
    {
        public JSchema() { }

        public JSchema(JSchema schema)
            :base(schema)
        {
        }

        public JSchema(JObject schema)
            : base(schema)
        {
        }

        public JSchema(object content)
            :base(content)
        {
        }

        public JSchema(params object[] content)
            : base(content)
        {
        }

        public override void Add(object content)
        {
            base.Add(content);
        }
    }
}
