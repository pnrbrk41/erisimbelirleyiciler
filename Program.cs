using System;

namespace erisimbelirleyiciler{

    class Program
    {
        public static void Main(string [] args){
            Calisan calisan1= new Calisan();
            calisan1.Ad= "Ayse";
            calisan1.Soyad="Kara";
            calisan1.No=1254;
            calisan1.Departman="ik";
            calisan1.CalisanBilgileri();
            Console.WriteLine("*****************");

            Calisan calisan2= new Calisan();
            calisan2.Ad= "Yeni";
            calisan2.Soyad="Liiste";
            calisan2.No=125466;
            calisan2.Departman="ik";
            calisan2.CalisanBilgileri();
            Console.WriteLine("*****************");

            Calisan calisan3=new Calisan("pınar","ak",12364,"Bilgisayar Mühendisi");




        }
    }

    class Calisan{
        public string Ad;
        public string Soyad;

        public int No;

        public string Departman;
        public Calisan(){

        }
        public Calisan(string ad, string soyad, int no, string departman){
            this.Ad=ad;
            this.Soyad= soyad;
            this.No= no;
            this.Departman= departman;
            Console.WriteLine("Calisan ad: {0}",ad);
            Console.WriteLine("Calisan soyad: {0}",soyad);
            Console.WriteLine("Calisan no: {0}",no);
            Console.WriteLine("Calisan departman: {0}",departman);
           
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın adı: {0}", Ad);
            
            Console.WriteLine("Çalışanın soyadı: {0}", Soyad);
            
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            
            Console.WriteLine("Çalışanın departmanı: {0}", Departman);
            
        }

    }
}