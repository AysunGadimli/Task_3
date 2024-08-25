namespace TaskCode;

class Program
{
    static void Main(string[] args)
    {

        //A, B ededleri arasinda 3e tam bolunen ededleri tapan alqoritm
        for (int i = 0; i <=50; i++)
        {
            if (i%3==0&& i>0)
            {
                Console.WriteLine(i);
            }
        }



        //// Verilmish ededin 2-nin quvveti olub olmadigini tapan alqoritm misal: 8 quvvetidir, 6 quvveti deyil
        int data = 128, number = data;
        bool value = true;

        while (data > 0)
        {
            if (data % 2 != 0 && data != 1)
            {
                Console.WriteLine($"{number} ededi 2 quvveti deyil.");
                value = false;
                break;
            }
            data /= 2;
        }
        if (value)
        {
            Console.WriteLine($"{number} ededi 2 quvvetidir.");
        }




    }
}
