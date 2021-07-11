using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace CodingChallenge.Utilities
{
    public static class XmlSerializer
    {
        public static string SerializeToXml<T>(this T contract)
        {
            var serializer = new DataContractSerializer(typeof(T));

            using (var textWriter = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(textWriter, new XmlWriterSettings { Indent = true }))
                    serializer.WriteObject(xmlWriter, contract);

                return textWriter.ToString();
            }
        }

        public static T DeserializeFromXml<T>(this string contract)
        {
            var serializer = new DataContractSerializer(typeof(T));

            using (var textReader = new StringReader(contract))
            using (var xmlReader = XmlReader.Create(textReader))
                return (T)serializer.ReadObject(xmlReader);
        }
    }
}
