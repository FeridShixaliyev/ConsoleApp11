using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Weapon
    {
        public Weapon(string name,int capacity,int nowCap)
        {
            Id = _id++;
            Name = name;
            Capacity = capacity;
            NowCap = nowCap;
        }
        private static int _id;
        private int _capacity;
        private int _nowCap;
        public int Id { get; }
        
        public string Name { get; set; }
        public int NowCap
        {
            get => _nowCap;
            set
            {
                if (value >= 0 && value <= Capacity)
                    _nowCap = value;
            }
        }


        public int Capacity
        {
            get => _capacity;
            set
            {
                if (value >= 0)
                    _capacity = value;
            }
        }
        public bool Mode = false;
        public int Shoot()
        {
            return --NowCap;
        }
        public int Fire()
        {
            NowCap = 0;
            Console.WriteLine($" Gulle bitti");
            return 0;
        }
        public int GetRemainBulletCount()
        {
            return  Capacity-NowCap;
        }
        public void Reload()
        {
            NowCap = 30;
        }
        public string ShowInfo()
        {
            return $"\nWeapon info:\nName: {Name}\nCapacity: {Capacity}\nNowCap: {NowCap}\nMode:{Mode}\n";
        }
        public void Checkode()
        {
            if (Mode)
            {
                Shoot();
            }
            else
            {
                Mode = true;
                Fire();
            }
        }
    }
}
