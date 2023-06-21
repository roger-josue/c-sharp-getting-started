using System;
namespace c_sharp_getting_started
{
	public class Mage : Pupil
    {
        //Constructor
        public Mage(string title) : base(title)
        { }
        //Methods
        public virtual Storm CastRainStorm()
        {
            Storm castStorm = new Storm("rain", false, Title);
            return castStorm;
        }
    }
}

