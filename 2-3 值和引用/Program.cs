using System;

namespace _2_3_值和引用
{
    class Character
    {
        public string name;
        public int hp;
        public int attack;
        public int def;

        public void CostHp(int cost)
        {
            this.hp -= cost;
            if (this.hp <= 0)
            { this.hp = 0; }
        }
    }

    class Program
    {
        static void Func(Character c3)
        {
            c3.name = "张四";

            Character cc = new Character();
            cc.name = "李四";

            return;
        }

        static Character Create()
        {
            Character cc = new Character();
            cc.name = "李四";

            return cc;
        }

        static void Main(string[] args)
        {
            Character c1 = new Character();
            c1.name = "张三";

            Func(c1);

            Character newCharacter = Create();

            Console.ReadKey();
        }
    }
}
