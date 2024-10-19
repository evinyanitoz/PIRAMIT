namespace PIRAMIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OLUŞTURULACAK PPİRAMİT YÜKSEKLİĞİ KAÇOLSUN? ");
            int sayi=Convert.ToInt32(Console.ReadLine());
            string yildiz=string.Empty;

            for(int i =0;i<sayi;i++)
            {
                yildiz += "*";
                Console.WriteLine(yildiz);
            
            
            
            }




        }
    }
}
