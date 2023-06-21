using System;
namespace c_sharp_getting_started
{
    public class ArchMage : Mage
    {
        //Constructor
        public ArchMage(string title) : base(title)
        { }
        //Methods
        public override Storm CastRainStorm()
        {
            Storm castStorm = new Storm("rain", true, Title);
            return castStorm;
        }
        public Storm CastLightningStorm()
        {
            Storm castStorm = new Storm("lightning", true, Title);
            return castStorm;
        }
    }
}

