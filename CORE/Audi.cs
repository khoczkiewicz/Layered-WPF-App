using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

namespace Hoczkiewicz.Audi.CORE
{
    public class Audi: IAudi
    {
        private string _Type { get; set; }
        private int _PS { get; set; }
        private int _Price { get; set; }
        private int _Model{ get; set; }
        //private bool IsCar { get; set; }

        public string Type { get => _Type; set => _Type = value; }
        public int PS { get => _PS; set => _PS = value; }
        public int Price { get => _Price; set => _Price = value; }
        public int Model { get => _Model; set => _Model= value; }

        public Audi(string Type,int Model,int PS,int Price)
        {
            _Type = Type;
            _Model = Model;
            _PS = PS;
            _Price = Price;
        }
        
        public override string ToString() => "Audi " + Type + Model + " has " + PS + "PS and costs " + Price + " euro.";
    }
}
