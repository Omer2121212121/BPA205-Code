namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //int[] arr = [1, 2, 3, 4, 5, 6, 7, 8];
            //int max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (max < arr[i])
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Task2
            //string ad = "Omer";
            //char herf = 'a';
            //bool tapildi = false;
            //for (int i = 0; i < ad.Length; i++)
            //{
            //    if (herf == ad[i])
            //    {
            //        tapildi = true;
            //        break;
            //    }
            //    else 
            //    {
            //        tapildi = false;
            //    }
            //}
            //Console.WriteLine(tapildi);
            //Task3
            //string sayt = Console.ReadLine();
            //bool duzdur = false;
            //for (int i = 0; i < sayt.Length - 2; i++)
            //{
            //    if (sayt[i] == '.' && sayt[i + 1] == 'a' && sayt[i + 2] == 'z')
            //    {
            //        duzdur = true;
            //        break;
            //    }
            //    else
            //    {
            //        duzdur = false;
            //    }
            //}
            //Console.WriteLine(duzdur);
            //Task4
            //string cumle = Console.ReadLine();
            //string soz = Console.ReadLine();
            //bool tapildi = false;
            //string bosluq = "";
            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    if (cumle[i] != ' ')
            //    {
            //        bosluq = bosluq + cumle[i];
            //    }
            //    else
            //    {
            //        if(bosluq == soz)
            //        {
            //            tapildi = true;
            //            break;
            //        }
            //        bosluq = "";
            //    }
            //}
            //if (soz == bosluq)
            //{
            //    tapildi = true;
            //}
            //Console.WriteLine(tapildi);
            //Task5
            //string cumle = Console.ReadLine();
            //string bosluq = "";
            //string cavab = "";

            //// Cümləni sonuna qədər gəzirik
            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    if (cumle[i] != ' ')
            //    {
            //        bosluq = bosluq + cumle[i];
            //    }
            //    else
            //    {
            //        if (bosluq.Length > 0)
            //        {
            //            string yeniSoz = "";
            //            yeniSoz += char.ToUpper(bosluq[0]);

            //            for (int j = 1; j < bosluq.Length; j++)
            //            {
            //                yeniSoz += bosluq[j];
            //            }

            //            cavab = cavab + yeniSoz + " ";
            //            bosluq = "";
            //        }
            //    }
            //}
            //if (bosluq.Length > 0)
            //{
            //    string yeniSoz = "";
            //    yeniSoz += char.ToUpper(bosluq[0]);
            //    for (int j = 1; j < bosluq.Length; j++)
            //    {
            //        yeniSoz += bosluq[j];
            //    }
            //    cavab = cavab + yeniSoz;
            //}

            //Console.WriteLine(cavab);
            //Task6
            //int[] arr = [1, 2, 3, 4, 5, 6, 7, 8];
            //int max = arr[0];
            //int min = arr[0];
            //float median = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (max < arr[i])
            //    {
            //        max = arr[i];
            //    }
            //    else if (min > arr[i])
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Task7
            //string cumle = Console.ReadLine();
            //string bosluq = "";
            //string cavab = "";
            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    if (cumle[i] != ' ')
            //    {
            //        bosluq += cumle[i];
            //    }
            //    else
            //    {
            //        if (bosluq.Length > 0)
            //        {
            //            cavab = cavab + bosluq + "%20";
            //            bosluq = "";
            //        }
            //    }
            //}
            //if (bosluq.Length > 0)
            //{
            //    cavab = cavab + bosluq;
            //}
            //Console.WriteLine(cavab);
        }
    }
}
