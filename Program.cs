﻿using System;
using System.Collections;

namespace KoleksiyonlarSoru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList PrimeNumberList = new ArrayList();
            ArrayList nonPrimeNumberList = new ArrayList();
            string input = "";
            int number;
            int i = 0;
            
            while(i != 20)
            {
                input = Console.ReadLine();

                if (!Int32.TryParse(input, out number)) {
                    Console.WriteLine("Sayi Giriniz: ");
                    continue;
                }
                else if (number <= 0) {
                    Console.WriteLine("Pozitif sayi girin:");
                    continue;
                }
                else if(!primeNumber(number)) {
                    nonPrimeNumberList.Add(number);
                    i++;
                }
                else {
                    PrimeNumberList.Add(number);
                    i++;
                }   
            }

            SortAndReverse(PrimeNumberList);
            SortAndReverse(nonPrimeNumberList);
            
            ScreenPrint(PrimeNumberList, "Asal Sayilar : ");
            ScreenPrint(nonPrimeNumberList, "Asal Olmayan Sayilar : ");

            Avarege(PrimeNumberList, "Asal Sayilarin Sayisi: ", " Ortalamasi: ");
            Avarege(nonPrimeNumberList, "Asal Sayilarin Sayisi: ", " Ortalamasi: ");
        }
        static bool primeNumber(int x)
        {
            if (x < 2 ) 
                return false;
            if (x == 2) 
                return true;
            if(x % 2 == 0)
                return false;

            int boundary = (int)Math.Floor(Math.Sqrt(x));
                    
            for (int i = 3; i <= boundary; i += 2) {
                if (x % i == 0) {
                    return false;
                }
            }     
            return true;
        }
        static void ScreenPrint(ArrayList list, string str)
        {
            Console.WriteLine(str);
            foreach (var item in list)
            {
                Console.Write(item + " - ");
            }
            Console.WriteLine();
        }
        static ArrayList SortAndReverse(ArrayList list)
        {
            list.Sort();
            list.Reverse();
            return list;
        }
        static void Avarege(ArrayList list, string str1, string str2)
        {
            int sum = 0;
            int avarege = 0;
            for (int j = 0; j < list.Count; j++)
            {
                sum += Convert.ToInt32(list[j]);
            }
            avarege = sum/list.Count;
            Console.WriteLine(str1 + list.Count + str2 + avarege);
        }
    }
}