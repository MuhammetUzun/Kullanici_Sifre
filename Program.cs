namespace adminPanel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Kullanıcı adı : admin şifre : 123");
            // 3 hatalı girişten sonra daha giremezsin :)
            
            var name = "admin";
            var sifre = "123";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Kullanıcı adını giriniz : ");
                string ad=Console.ReadLine();

                Console.WriteLine("Şifre giriniz: ");
                string password = Console.ReadLine();

                if (ad == name && sifre == password)
                {
                    Console.WriteLine("Kullanıcı adı ve şifre doğrudur.\nHOŞGELDİN :)");
                    break;
                }
                else 
                {
                    Console.WriteLine("Girmiş olduğunuz kullanıcı adı ve şifre yanlıştır.");
                    if (i == 2)
                    {
                        Console.WriteLine("Deneme haklarınızı doldurdunuz .... \nLütfen bir yetkili ile iletişime geçiniz.");
                    }
                }

            }       
            

        }
    }
}