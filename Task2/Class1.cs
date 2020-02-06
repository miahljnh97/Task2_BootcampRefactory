using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class Class1
    {
        public int Satu(string str)
        {
            return str.Length;
        }

        public string Dua(int grade)
        {
            if(grade >= 90)
            {
                return "A";
            }
            else if(grade >= 80 && grade < 90)
            {
                return "B";
            }
            else if (grade >= 70 && grade < 80)
            {
                return "C";
            }
            else if (grade >= 60 && grade < 70)
            {
                return "D";
            }
            else
            {
                return "E";
            }
        }

        public string Tiga(int angka)
        {
            if(angka % 2 == 0)
            {
                return "Genap";
            }
            else
            {
                return "Ganjil";
            }
        }

        public string Empat(int n)
        {

            //            string str = "";
            //            if(n % 4 == 0)
            //            {
            //                if(n % 100 == 0)
            //                {
            //                    if(n % 400 == 0)
            //                    {
            //                        str = "Kabisat";
            //;                    }
            //                    else
            //                    {
            //                        str = "Bukan Kabisat";
            //                    }
            //                }
            //                else
            //                {
            //                    str = "Kabisat";
            //                }
            //            }
            //            else
            //            {
            //                str = "Bukan Kabisat";
            //            }
            //            return str;
            bool y = DateTime.IsLeapYear(n);
            var str = "";
            if(y == true)
            {
                str = "Kabisat";
            }
            else
            {
                str = "Bukan Kabisat";
            }
            return str;

        }

        public string Lima(int umur)
        {
            if(umur >= 21)
            {
                return "Dewasa";
            }
            else if(umur >= 13 && umur < 21)
            {
                return "Remaja";
            }
            else if (umur >= 9 && umur < 13)
            {
                return "Bimbingan Orang Tua";
            }
            else
            {
                return "Semua Usia";
            }
        }

        public List<int> Enam(int a, int b)
        {
            //int[] arr = new int[b-a+1];
            //for(int i = a; i<=b; i++)
            //{
            //    for(int j=0; j<= b-a+1; j++)
            //    {
            //        arr[j] = i;
            //    }
            //}
            //return arr;

            List<int> Lisa = new List<int>();
            for(int i = a; i<= b; i++)
            {
                Lisa.Add(i);
            }
            return Lisa;
        }

        public List<int> Tujuh()
        {
            //int[] ar = new int[50];
            //for(int i = 1; i<101; i++)
            //{
            //    if (ar[i] % 2 != 0)
            //    {
            //        ar[i] = i;
            //    }
            //}
            //return ar;

            List<int> Lisa2 = new List<int>();
            for(int i = 0; i<=100; i++)
            {
                if(i % 2 != 0)
                {
                    Lisa2.Add(i);
                }
            }
            return Lisa2;

        }

        public List<string> Delapan()
        {
            //string[] ars = new string[1000];
            List<string> Lisa3 = new List<string>();
            for(int i = 1; i<1001; i++)
            {
                if (i % 100 == 0)
                {
                    Lisa3.Add($"{i}. Kelipatan Seratus");
                }
                else if (i % 2 == 0 && i % 5 == 0)
                {
                    Lisa3.Add($"{i}. Genap Kelipatan Lima");
                }
                else if (i % 2 != 0 && i % 5 == 0)
                {
                    Lisa3.Add($"{i}. Ganjil Kelipatan Lima");
                }
                else if (i % 2 == 0)
                {
                    Lisa3.Add($"{i}. Genap");
                }
                else
                {
                    Lisa3.Add($"{i}. Ganjil");
                }
            }
            return Lisa3;
            
        }

        public string Sembilan(string words)
        {
            string[] str = words.Split(" ");
            Array.Reverse(str);
            return string.Join(" ", str);
        }

        public string[] Sepuluh(string[] arr, string a, string b)
        {
            string[] newArr = new string[arr.Length + 2];
            for(int i = 0; i < newArr.Length; i++)
            {
                if(i == 0)
                {
                    newArr[i] = a;
                }
                else if(i == newArr.Length - 1)
                {
                    newArr[i] = b;
                }
                else
                {
                    newArr[i] = arr[i - 1];
                }
            }
            return newArr;
        }
    }
}
