using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace Dictionarywebapplication
{
    public class Class1
    {
        static void Main(string[] args)
        {
            string struserchoice = string.Empty;

            Country country1 = new Country() { Code = "IND", Name = "India", Capital = "Delhi" };
            Country country2 = new Country() { Code = "USA", Name = "United States", Capital = "Washington" };
            Country country3 = new Country() { Code = "UK", Name = "United Kingdom", Capital = "Londom" };
            Country country4 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };
            Dictionary<string, Country> dictionarycountries = new Dictionary<string, Country>();

            dictionarycountries.Add(country1.Code, country1);
            dictionarycountries.Add(country2.Code, country2);
            dictionarycountries.Add(country3.Code, country3);
            dictionarycountries.Add(country4.Code, country4);

            do
            {
                Console.WriteLine("Please enter the country code");
                string strcountrycode = Console.ReadLine().ToUpper();
                Country selectedcountry = dictionarycountries.ContainsKey(strcountrycode) ? dictionarycountries[strcountrycode] : null;
                if (selectedcountry == null)
                {
                    Console.WriteLine("Please enter proper code");
                }
                else
                {
                    Console.WriteLine("Code={0}, Name={1},Capital={2}", selectedcountry.Code, selectedcountry.Name, selectedcountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you wanna continue YES or NO");
                    struserchoice = Console.ReadLine().ToUpper();
                } while (struserchoice != "YES" && struserchoice != "NO");

            } while (struserchoice == "YES");

        }
    }

    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }

    }
}