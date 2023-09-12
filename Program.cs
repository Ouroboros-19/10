class Program
{
    static void Main()
    {
        Random r = new Random();
        int a = 20, k;
        int[] array = new int[a];
        array[0] = r.Next(0, 20);
        Console.Write("{0,3}", array[0]);
        for (int i = 1; i < a; i++)
        {
            bool flag = true;
            while (flag)
            {
                array[i] = r.Next(0, 20);
                k = 0;
                for (int j = 0; j < i; j++)
                    if (array[j] == array[i])
                        k++;
                if (k == 0)
                    flag = false;
            }
            Console.Write("{0,3}", array[i]);
        }
        Console.WriteLine();
        Console.WriteLine("");
        Console.WriteLine("Повтор?( enter - да; люб. др. клавиша - нет )");
        string povtor = Convert.ToString(Console.ReadLine());
        if (povtor == "")
            Main();
    }
}