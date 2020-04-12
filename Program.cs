using System;

namespace PL
{
    class Program
    {
        
        static void Main(string[] args)
        {
          string[]  name={"Алишер","Бахтиёр","Абубакр","Фируза"};
          string[]  surname={"Аброров","Акрамов","Анваров","Усмонова"};
          string[] Middlename={"Довудович","Ахмадович","Джамшедович","Олимович"};
          string[] pol={"муж","муж","муж","жен"};
          int[] nomerTelefon = new int[4]{918123456,907907907,908111111,909909909};
          string[] adress = {"г.Кулоб ул Борбад дом 214","г Бохтар ул Маърифат дом 56","р.Рудаки городок Сомониён ул С.Давлатов дом 89/27","г.Душанбе Алишер Навои дом 78/56"};
          for(int i=0;i<4;i++)
          {

           Abonent  client = new Abonent (surname[i],name[i],Middlename[i],nomerTelefon[i],adress[i],pol[i]);
           client.getinfo(i+1);
          }
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
