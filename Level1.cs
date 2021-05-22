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
        static string otmenaSave = "";
        static int flagok5 = 0;


        static string SaveStr = "";
        static string Str = "";

        public static string BastShoe(string command)
        {
            int myInt;
            bool isNumerical = int.TryParse(command[0].ToString(), out myInt);
            if (isNumerical == true)
            {
                if (myInt > 0 && myInt < 6 || myInt == 4 && command.Length == 1 || myInt == 5 && command.Length == 1)
                {
                    int myInt2;
                    bool isNumerical2 = false;
                    if (myInt != 4 && myInt != 5)
                    {
                        try
                        {
                            isNumerical2 = int.TryParse(command.Substring(2).ToString(), out myInt2);
                        }
                        catch
                        {
                            isNumerical2 = false;
                        }
                    }
                    if (myInt == 1 || myInt == 2 && isNumerical2 == true || myInt == 3 && isNumerical2 == true || myInt == 4 || myInt == 5)
                    {
                        int d = int.Parse(command[0].ToString());
                        if (d == 1)
                        {
                            if (flag5 == 1)
                            {
                                flag5x = 0;
                            }
                            else
                            {
                                flag5x = 1;
                            }
                            if (flag == 1 && flag5 == 0)
                            {
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
                                massivSave += "|" + SaveStr;

                            }
                            else
                            {
                                flag05 = 0;
                                Str = SaveStr;
                            }
                            flag5 = 0;
                            otmenaSave = "";
                            flagok5 = 0;
                        }
                        else if (d == 2)
                        {
                            if (flag5 == 1)
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
                                    massivSave += "|" + SaveStr;
                                }
                                else
                                {
                                    flag05 = 0;
                                    Str = SaveStr;
                                }

                            }

                            flag5 = 0;
                            otmenaSave = "";
                            flagok5 = 0;
                        }
                        else if (d == 3)
                        {
                            int b = int.Parse(command.Substring(2));
                            if (b > SaveStr.Length)
                            {
                                Str = "";
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
                            int k = mas.Length;


                            if (q >= k)
                            {

                                if (flagok5 == 1)
                                {
                                    Str = mas[1];
                                    SaveStr = Str;
                                }
                                else
                                {
                                    Str = mas[1];
                                    otmenaSave += "|" + SaveStr;
                                    SaveStr = Str;
                                }

                            }
                            else
                            {

                                if (flagok5 == 1)
                                {

                                    Str = mas[k - q];
                                    SaveStr = Str;

                                }
                                else
                                {
                                    Str = mas[k - q];
                                    otmenaSave += "|" + SaveStr;
                                    SaveStr = Str;
                                }

                            }
                            q++;
                            flag = 1;
                            flag5 = 0;
                            q5 = 1;

                        }
                        else if (d == 5)
                        {
                            flagok5 = 1;
                            flag5 = 1;
                            if (flag5x == 1)
                            {
                                Str = SaveStr;
                            }
                            else
                            {
                                if (q != 2)
                                {
                                    string[] mis = otmenaSave.Split('|');
                                    int k = mis.Length;
                                    if (q5 >= k)
                                    {
                                        flag05 = 1;
                                        Str = mis[1];
                                        SaveStr = Str;
                                    }
                                    else
                                    {
                                        Str = mis[k - q5];
                                        SaveStr = Str;
                                    }
                                    q5++;
                                }
                                else
                                {
                                    Str = SaveStr;
                                }
                                if (q > 2)
                                {
                                    q = q - 1;
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
