namespace adminProje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Doğru giremezsen asla bitmem 8)  


            var ad = "admin";
            var sifre = "123";


            Console.WriteLine("Kullanıcı adını giriniz : ");
            string name = Console.ReadLine();

            Console.WriteLine("Şifre giriniz: ");
            string password = Console.ReadLine();


            while (ad != name || sifre != password)
            {
                Console.WriteLine($"Kullanıcı adı veya şifreniz hatalıdır ");

                Console.WriteLine("Kullanıcı adınızı tekrar giriniz : ");
                name = Console.ReadLine();

                Console.WriteLine("Şifrenizi tekrar giriniz: ");
                password = Console.ReadLine();

            }
            Console.WriteLine("Hoşgeldin :)");
        }
    }
}