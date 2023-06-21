using System;
namespace c_sharp_getting_started
{
	public class Pupil
	{
        //Properties
        public string Title
        { get; private set; }
        //Contructor
        public Pupil(string title)
        {
            Title = title;
        }
        //Methods
        public Storm CastWindStorm()
        {
            Storm castStorm = new Storm("wind", false, Title);
            return castStorm;
        }
    }
}

