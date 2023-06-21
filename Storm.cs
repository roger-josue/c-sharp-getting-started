using System;
namespace c_sharp_getting_started
{
	public class Storm
	{
        //Properties
        public string Essence
        { get; private set; }

        public bool IsStrong
        { get; private set; }

        public string Caster
        { get; private set; }
        //Constructor
        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }
        //Methods
        public string Announce()
        {
            string stormStrength = (IsStrong == true) ? "strong" : "weak";
            return $"{Caster} cast a {stormStrength} {Essence} storm!";
        }
    }
}

