using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            //giaithua();
            tongchuso();
            //solonthuhai();
            //giaiphuongtrinh();
            //viethoa();
        }


        //bai 1: tinh giai thua
        static void giaithua()
        {
            try
            {
                int i, input;
                int output = 1;

                Console.Write("nhap so can tinh giai thua ");
                input = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= input; i++)
                {
                    output = output * i;
                }

                Console.Write("giai thua {0} la: {1}", input, output);

                Console.ReadKey();
            }



            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Application ends !!!");
            }
            Console.ReadKey();
        }


        // bai 2: đếm tổng các chữ số
        static void tongchuso()
        {
            try
            {
                string input = Console.ReadLine();
                int i;
                int result = 0;
                for (i = 0; i < input.Length; i++)
                {
                    result = result + (Convert.ToInt32(input[i]) - '0');
                }


                Console.WriteLine(result);
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Application ends !!!");
            }
            Console.ReadKey();
        }

        // bai 3 Viet hoa tu dau tien cua chuoi

        static void viethoa()
        {
            try
            {
                Console.WriteLine("Nhap chuoi vao duoi day");
                string a = Console.ReadLine();
                string[] d = a.Split(' ');
                string result = "";

                foreach (string c in d)
                {
                    if (c.Trim() != "")
                    {
                        if (d.Length > 1)
                            result = result + c.Substring(0, 1).ToUpper() + c.Substring(1).ToLower() + " ";
                        else
                            result = result + c.ToUpper() + " ";
                    }
                }
                Console.WriteLine(result.Trim());
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Application ends !!!");
            }
            Console.ReadKey();
        }
        // bai 4: Tim so lon thu 2 trong mang

        static void solonthuhai()
        {
            try
            {
                int n, i, j = 0, solonnhat, solonhai;
                int[] arr1 = new int[50];

                Console.Write("nhap so phan tu mang: ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhap so vao mang {0}", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("so {0}: ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                solonnhat = 0;

                for (i = 0; i < n; i++)
                {
                    if (solonnhat < arr1[i])
                    {
                        solonnhat = arr1[i];
                        j = i;
                    }
                }

                solonhai = 0;
                for (i = 0; i < n; i++)
                {
                    if (i == j)
                    {
                        i++;
                        i--;
                    }
                    else
                    {
                        if (solonhai < arr1[i])
                        {
                            solonhai = arr1[i];
                        }
                    }
                }

                Console.Write("So lon thu hai trong mang:  {0}", solonhai);

                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Application ends !!!");
            }
            Console.ReadKey();
        }

        // bai 5 giai phuong trinh

        static void giaiphuongtrinh()
        {
            try
            {
                Console.WriteLine("giai phuong trinh ax2 + bx + c = 0");
                Console.WriteLine("nhap he so a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhap he so b");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhap he so c");
                int c = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    if (c != 0)
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("vo nghiem");
                        }
                        else
                        {
                            Console.WriteLine("nghiem la {0}", (c * (-1)) / b);
                        }
                    }
                    else if (c == 0)
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("phuong trinh vo so nghiem");
                        }
                        else
                        {
                            Console.WriteLine("phuong trinh co ngiem la x = 0");
                        }
                    }

                }
                else if (a != 0)
                {
                    int d = b * b - 4 * a * c;
                    if (d < 0)
                    {
                        Console.WriteLine("phuong trinh vo nghiem");
                    }
                    else if (d == 0)
                    {
                        Console.WriteLine("phuong trinh co nghiem kep la x1 = x2 = {0}", (b * (-1)) / (2 * a));
                    }

                    else
                    {
                        Console.WriteLine("phuong trinh co nghiem x1 la {0}", (b * (-1) + Math.Sqrt(d)) / (2 * a));
                        Console.WriteLine("phuong trinh co nghiem x2 la {0}", (b * (-1) - Math.Sqrt(d)) / (2 * a));
                    }


                }

                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Application ends !!!");
            }
            Console.ReadKey();
        }

    }
}
