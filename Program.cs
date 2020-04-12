using System;

namespace PL
{
    class Program
    {
        
        static void Main(string[] args)
        {
          
        }
    
    }

    class Abonent
    {
        public string name;
        public string surname;
        public string Middlename;
        public int nomerTelefon;
        public string adress;
        public string pol;
        
        public Abonent(string name, string surname,string Middlename, int nomerTelefon, string adress, string pol)
        {
         this.name=name;
         this.surname=surname;
         this.Middlename=Middlename;
         this.nomerTelefon=nomerTelefon;
         this.adress=adress;
         this.pol=pol;
         
        }            
        public void getinfo(int i)
        {
            Console.WriteLine($"Client{i}");
            Console.WriteLine($"name:{this.name}");
            Console.WriteLine($"surname:{this.surname}");
            Console.WriteLine($"Middlename:{this.Middlename}");
            Console.WriteLine($"adress:{this.adress}");
            Console.WriteLine($"pol:{this.pol}");
            Console.WriteLine($"nomerTelefon:{this.nomerTelefon}");
            Console.WriteLine( );
        }


    }
}
