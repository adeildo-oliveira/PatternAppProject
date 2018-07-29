using System.IO;
using System.Xml.Serialization;

namespace PatterAppProject.PatternAdapter
{
    public class GeradorDeXml<T>
    {
        public string GeraXml(T o)
        {
            var serializer = new XmlSerializer(o.GetType());
            var writer = new StringWriter();
            serializer.Serialize(writer, o);

            return writer.ToString();
        }
    }
}
