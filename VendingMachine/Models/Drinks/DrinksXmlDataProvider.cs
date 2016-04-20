using System.IO;
using System.Xml.Serialization;

namespace WildBerriesTask.Models.Drinks
{
    internal class DrinksXmlDataProvider : DrinksDataProvider
    {
        public DrinksXmlDataProvider()
        {
            // Construct an instance of the XmlSerializer with the type
            // of object that is being deserialized.
            var mySerializer = new XmlSerializer(typeof (DrinksDataProvider));
            // To read the file, create a FileStream.
            var myFileStream = new FileStream("Resources/DrinksData.xml", FileMode.Open);
            // Call the Deserialize method and cast to the object type.
            var myObject = mySerializer.Deserialize(myFileStream) as DrinksDataProvider;
            List = myObject?.GetData();
        }
    }
}
