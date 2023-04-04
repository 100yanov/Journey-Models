using Journey_Models.Enums;

namespace Journey_Models.Models
{
    public class Hex
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public HexType Type { get; set; }
    }
}
