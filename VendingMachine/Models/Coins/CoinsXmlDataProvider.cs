using System.IO;
using System.Xml.Serialization;

namespace VendingMachine.Models.Coins
{
    internal class CoinsXmlDataProvider : CoinsDataProvider
    {
        public CoinsXmlDataProvider()
        {
            // Construct an instance of the XmlSerializer with the type
            // of object that is being deserialized.
            var mySerializer = new XmlSerializer(typeof(CoinsDataProvider));
            // To read the file, create a FileStream.
            var myFileStream = new FileStream("Resources/CoinsData.xml", FileMode.Open);
            // Call the Deserialize method and cast to the object type.
            var myObject = mySerializer.Deserialize(myFileStream) as CoinsDataProvider;
            List = myObject?.GetData();
        }
    }
}
