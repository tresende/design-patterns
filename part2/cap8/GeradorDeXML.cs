using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns.Cap8
{
    public class GeradorDeXML
    {
        public string GeraXML(object o)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(o.GetType());
            StringWriter stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, o);
            return stringWriter.ToString();
        }
    }
}