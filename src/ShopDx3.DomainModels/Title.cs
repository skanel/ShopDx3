using ShopDx3.DomainModels.BaseTypes;

namespace ShopDx3.DomainModels
{
    public class Title : DocBase
    {
        public Title()
        {

        }
        public Title(string lang,string val)
        {
            this.lang = lang;
            this.val = val;
        }

        public string lang { get; set; }
        public string val { get; set; }
    }
}
