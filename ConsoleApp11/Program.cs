using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Weapon weapon = new Weapon("Ak47",30,30,false);
            //Console.WriteLine(weapon.NowCap);
            //Console.WriteLine(weapon.Capacity);
            //Console.WriteLine(weapon.Shoot());
            //Console.WriteLine(weapon.Shoot());
            //Console.WriteLine(weapon.Shoot());

            //Console.WriteLine(weapon.Fire());
            //Console.WriteLine(weapon.GetRemainBulletCount());
            Console.WriteLine("Silahin adini daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Silahin capacity-ni daxil edin:");
            int capacity ;
            do
            {
                capacity = Convert.ToInt32(Console.ReadLine());
            } while (capacity<0);
            Console.WriteLine("Silahin cari gulle sayini daxil edin:");
            int nowCap;
            do
            {
                nowCap = Convert.ToInt32(Console.ReadLine());
            } while (nowCap < 0||capacity<nowCap);
            Weapon weapon = new Weapon(name, capacity, nowCap);
            Console.WriteLine(weapon.ShowInfo());
            Console.WriteLine("Atis modu(tekli yoxsa coxlu)");
            Console.WriteLine("1. Tekli mod");
            Console.WriteLine("2. Coxlu mod");
            string mode = Console.ReadLine();
            switch (mode)
            {
                case "1":
                    weapon.Mode = false;
                    weapon.Checkode();
                    break;
                case "2":
                    weapon.Mode = true;
                    weapon.Checkode();
                    break;
                default:
                    Console.WriteLine("Duzgun secim edin");
                    break;
            }
            

            bool check = true;

            do
            {
                Console.WriteLine("1. Info");
                Console.WriteLine("2. Shoot");
                Console.WriteLine("3. Fire");
                Console.WriteLine("4. GetReamin");
                Console.WriteLine("5. Reload");
                Console.WriteLine("6. ChangeFireMode");
                Console.WriteLine("7. Exit");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        Console.WriteLine(weapon.ShowInfo());
                        break;
                    case "2":
                        if (weapon.Mode == false)
                        {
                            Console.WriteLine(weapon.Shoot());
                        }
                        else
                        {
                            Console.WriteLine("Silah coxli moddadir");
                        }
                        break;
                    case "3":
                        if (weapon.Mode == true)
                        {
                           Console.WriteLine(weapon.Fire());
                        }
                        else
                        {
                            Console.WriteLine("Silah tekli moddadir");
                        }
                        
                        break;
                    case "4":
                        Console.WriteLine(weapon.GetRemainBulletCount());
                        break;
                    case "5":
                        if (weapon.NowCap != weapon.Capacity)
                        {
                            weapon.Reload();
                            Console.WriteLine(weapon.Capacity);
                        }
                        else
                        {
                            Console.WriteLine("Tam doludur");
                        }
                                                
                        break;
                    case "6":
                        bool wep = false;
                        do
                        {
                            Console.WriteLine("1. Single mode");
                            Console.WriteLine("2. Selective fire");
                            Console.WriteLine("0. Back");
                            string ch = Console.ReadLine();
                            switch (ch)
                            {
                                case "1":
                                    if(weapon.Mode == false)
                                    {
                                        Console.WriteLine("Silah onsuz tekli moddadir");
                                    }
                                    else
                                    {
                                        weapon.Mode = false;
                                    }
                                    break;
                                case "2":
                                    if (weapon.Mode == true)
                                    {
                                        Console.WriteLine("Silah onsuz coxlu moddadir");
                                    }
                                    else
                                    {
                                        weapon.Mode = true;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Duzgun secim edin");
                                    break;
                            }
                        } while (wep);
                        break;
                    case "7":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin");
                        break;
                }

            } while (check);
        }
    }
}
