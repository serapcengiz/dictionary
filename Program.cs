using System;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.collections.generic
            Dictionary<int,string> kullanıcılar=new Dictionary<int, string>();

            kullanıcılar.Add(10,"Serap Cengiz");
            kullanıcılar.Add(12,"Seher Cefhs");
            kullanıcılar.Add(18,"Edanur ajsfjas");
            kullanıcılar.Add(20,"Fatma Cenjtjt");

            //Dizinin elamanlarına erişim
            Console.WriteLine("Elemanlara erişim");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }
            //Count
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Serap Cengiz"));

            //Remove
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item.Value);
            }

            //Keys
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }
            //Values
            foreach(var item in kullanıcılar.Values)
                Console.WriteLine(item);
            

        }
    }
}
