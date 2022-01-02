using System;

namespace TODO_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
             Board board = new Board();
            int input = MenuYaz();

            while (true)
            {
                switch (input)
                {
                    case 1: 
                        board.BoardListele();
                        input = MenuYaz();
                        break;

                    case 2: 
                        board.KartEkle();
                        input = MenuYaz();
                        break;
                    case 3: 
                        board.KartSil();
                        input = MenuYaz();
                        break;
                    case 4: 
                        board.KartTasi();
                        input = MenuYaz();
                        break;


                    default:
                        Console.WriteLine("hatalı seçim yaptınız, Cıkış yapılıyor.");
                        Environment.Exit(0);
                        break;
                }
            }
            
        }
        public static int MenuYaz()
        {
            Console.WriteLine();
            Console.WriteLine("Lutfen yapmak istediginiz islemi secin");
            Console.WriteLine("************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            return int.Parse(Console.ReadLine());
        }
    }
}
