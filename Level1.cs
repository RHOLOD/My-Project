using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1Space
{
    public static class Level1
    {

        static int q = 2;
        static int q5 = 2;
        static string massivOper = "";
        static string massivDop = "";
        static string massivSave = "";
        static int flag = 0;
        static int flag5 = 0;
        static int flag5x = 0;
        static int flag05 = 0;
        static string otmenaS = "";
        static string otmenaN = "";


        static string SaveStr = "";
        static string Str = "";

            public static string BastShoe(string command)
            {
                int myInt;
                bool isNumerical = int.TryParse(command[0].ToString(), out myInt);
                if (isNumerical == true)
                {
                    if (myInt > 0 && myInt <6 || myInt == 4 && command.Length == 1 || myInt == 5 && command.Length == 1)
                    {
                        int myInt2;
                        bool isNumerical2 = false;
                        if (myInt != 4 && myInt != 5)
                        {
                            isNumerical2 = int.TryParse(command.Substring(2).ToString(), out myInt2);
                        }                        
                        if (myInt == 1 || myInt == 2 && isNumerical2 == true || myInt == 3 && isNumerical2 == true || myInt == 4 || myInt == 5)
                        {
                            int d = int.Parse(command[0].ToString());
                            if (d == 1)
                            {
                                if (flag5 == 1 )
                                {
                                    flag5x = 0;
                                }
                                else
                                {
                                    flag5x = 1;
                                }
                                if (flag == 1 && flag5 == 0)
                                {
                                    massivOper = " " + d;
                                    massivDop = "|" + command.Substring(2);
                                    massivSave = "|" + SaveStr;
                                    flag = 0;
                                    q = 2;
                                    otmenaS = "";
                                    otmenaN = "";
                                }
                                if (flag5 == 0)
                                {
                                    q5 = 1;
                                }
                                if (flag05 == 0)
                                {
                                    SaveStr = SaveStr + command.Substring(2);
                                    Str = SaveStr;
                                    massivOper += " " + d;
                                    massivDop += "|" + command.Substring(2);
                                    massivSave += "|" + SaveStr;
                                }
                                else
                                {
                                    flag05 = 0;
                                    Str = SaveStr;
                                }
                                flag5 = 0;
                            }
                            else if (d == 2)
                            {
                                if (flag5 == 1 )
                                {
                                    flag5x = 0;
                                }
                                else
                                {
                                    flag5x = 1;
                                }
                                int a = int.Parse(command.Substring(2));
                                if (flag == 1 && flag5 == 0)
                                {
                                    massivOper = " " + d;
                                    massivDop = "|" + command.Substring(2);
                                    massivSave = "|" + SaveStr;
                                    flag = 0;
                                    q = 2;
                                    otmenaS = "";
                                    otmenaN = "";
                                    
                                }
                                if (flag5 == 0)
                                {
                                    q5 = 1;
                                }
                                if (a > Str.Length)
                                {
                                    if (flag05 == 0)
                                    {
                                        SaveStr = "";
                                        Str = SaveStr;
                                    }
                                    else
                                    {
                                        flag05 = 0;
                                        Str = "";
                                    }


                                }
                                else
                                {
                                    if (flag05 == 0)
                                    {
                                        SaveStr = SaveStr.Substring(0, Str.Length - a);
                                        Str = SaveStr;
                                        massivOper += " " + d;
                                        massivDop += "|" + command.Substring(2);
                                        massivSave += "|" + SaveStr;
                                    }
                                    else
                                    {
                                        flag05 = 0;
                                        Str = SaveStr;
                                    }

                                }

                                flag5 = 0;
                            }
                            else if (d == 3)
                            {
                                int b = int.Parse(command.Substring(2));
                                if (b > Str.Length)
                                {
                                    SaveStr = "";
                                    Str = SaveStr;
                                }
                                else
                                {
                                    Str = SaveStr[b].ToString();
                                }
                            }
                            else if (d == 4)
                            {
                                flag5x = 0;
                                string[] mas = massivSave.Split('|');
                                string[] masO = massivOper.Split(' ');
                                string[] masD = massivDop.Split('|');
                                int k = mas.Length;


                                if (q >= k)
                                {
                                    Str = mas[1];
                                    SaveStr = Str;
                                    otmenaS += "|" + masD[1];
                                    otmenaN += " " + masO[1];
                                }
                                else
                                {
                                    Str = mas[k - q];
                                    SaveStr = Str;
                                    otmenaS += "|" + masD[k - q + 1];
                                    otmenaN += " " + masO[k - q + 1];
                                }
                                q++;
                                flag = 1;
                                flag5 = 0;
                                
                            }
                            else if (d == 5)
                            {
                                flag5 = 1;
                                if (flag5x == 1)
                                {
                                    Str = SaveStr;
                                }
                                else
                                {
                                    if (q != 2)
                                    {
                                        string[] mas = otmenaN.Split(' ');
                                        string[] masS = otmenaS.Split('|');
                                        int k = mas.Length;
                                        if (q5 >= k)
                                        {
                                            flag05 = 1;
                                            Str = BastShoe(mas[1] + " " + masS[1]);
                                        }
                                        else
                                        {
                                            SaveStr = Str;
                                            Str = BastShoe(mas[k - q5] + " " + masS[k - q5]);
                                        }
                                        q5++;
                                    }
                                    else
                                    {
                                        Str = SaveStr;
                                    }
                                    
                                }

                            }
                        }
                        else
                        {
                            Str = SaveStr;
                        }
                    }
                    else
                    {
                        Str = SaveStr;
                    }                    
                }    
                else
                {
                    Str = SaveStr;
                }
                return Str;
            }
    }
}
