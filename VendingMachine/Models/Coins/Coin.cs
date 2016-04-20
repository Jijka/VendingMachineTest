using System.Xml.Serialization;
using VendingMachine.Magic;

namespace VendingMachine.Models.Coins
{
    [Magic]
    public class Coin
    {
        public Coin() { }
        public Coin (int rating, bool isBlocked = false)
        {
            Rating = rating;
            IsBlocked = isBlocked;
        }
        [XmlElement]
        public int Rating { get; set; }
        [XmlElement]
        public bool IsBlocked { get; set; }
    }
}
