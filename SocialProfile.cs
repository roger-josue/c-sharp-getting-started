using System;
namespace c_sharp_getting_started
{
	public class SocialProfile
	{
        //Fields
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;
        //Constructors
        public SocialProfile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[] {"No hobbies"};
        }
        //Methods
        public string ViewProfile()
        {
            string hobbies = String.Empty;
            foreach (string hobbie in this.hobbies)
            {
                hobbies += $"{hobbie}, ";
            }
            hobbies = hobbies.Substring(0, hobbies.Length - 2) + ".";
            return $"Name: {this.name}\nAge: {this.age}\nCity: {this.city}\nCountry: {this.country}\nPronouns: {this.pronouns}\nHobbies: {hobbies}";
        }
        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}

