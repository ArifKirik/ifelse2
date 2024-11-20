namespace else_if_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, indirim, odenecek;
            Console.WriteLine("alışveriş tutarını giriniz:");
            x=Convert.ToInt32(Console.ReadLine());

            if(x<100)
            {
                indirim = x * 10 / 100;
                odenecek = x - indirim;
                Console.WriteLine("toplam miktar"+odenecek);
            }
            if(x>=100&& x<150)
            {
                indirim=x*15 / 100;
                odenecek=x - indirim;
                Console.WriteLine("toplam miktar"+odenecek);
            }
            if (x >= 150 && x < 200) ;
            {
                indirim = x * 20 / 100;
                odenecek= x - indirim;
                Console.WriteLine("toplam miktar" + odenecek);
            }
            Console.ReadLine();
            

                
        }
    }
}
