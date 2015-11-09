using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionarykeyvaluepair
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer() { ID = 1, Name = "Sowmya", Gender = "Female" };
            Customer cust2 = new Customer() { ID = 2, Name = "Mukund", Gender = "Male" };
            Customer cust3 = new Customer() { ID = 3, Name = "Vishnu", Gender = "Male" };
            Dictionary<int, Customer> dictioncustomers = new Dictionary<int, Customer>();
            dictioncustomers.Add(cust1.ID, cust1);
            dictioncustomers.Add(cust2.ID, cust2);
            dictioncustomers.Add(cust3.ID, cust3);

            Customer customer1 = dictioncustomers[1];
            Console.WriteLine("id = {0}, Name = {1}, Gender = {2}", customer1.ID, customer1.Name, customer1.Gender);
            foreach (KeyValuePair<int, Customer> custkeyvaluepair in dictioncustomers)
            {
                Console.WriteLine("key is {0}", custkeyvaluepair.Key);
                Customer cust = custkeyvaluepair.Value;
                Console.WriteLine("id = {0}, Name = {1}, Gender = {2}", cust.ID, cust.Name, cust.Gender);
                Console.WriteLine("_____________________________________________________________________");
            }

            foreach(int key in dictioncustomers.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (Customer custy in dictioncustomers.Values)
            {
                Console.WriteLine("id = {0}, Name = {1}, Gender = {2}", custy.ID, custy.Name, custy.Gender);
            }
            if (dictioncustomers.ContainsKey(5))
            {
                Customer cust5 = dictioncustomers[5];
            }
            Console.WriteLine("total items={0} ", dictioncustomers.Count(kvp => kvp.Value.ID > 0));
           // dictioncustomers.Remove(119); to remove item with key 119
            //dictioncustomers.clear(); to remove all items.

            Customer[] custs = new Customer[3];
            custs[0] = cust1;
            custs[1] = cust2;
            custs[2] = cust3;

            Dictionary<int, Customer> customers = custs.ToDictionary(cust => cust.ID, cust => cust);
            foreach (KeyValuePair<int, Customer> kvp in customers)
            {
                Console.WriteLine("key is {0}", kvp.Key);
                Customer custys = kvp.Value;
                Console.WriteLine("id is {0}, Name = {1}", custys.ID, custys.Name);

            }




        }
    }
    public class Customer
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }

     }
}
