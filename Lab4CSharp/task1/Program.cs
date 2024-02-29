using System;

namespace Task1
{
    class Money
    {
        private int nominal;
        private int num;

        public Money(int nominal, int num)
        {
            this.nominal = nominal;
            this.num = num;
        }

        public void Print() { Console.WriteLine($"Nominal: {nominal}, \tNum: {num}"); }

        public bool BuyGoods(double amount) { return amount <= nominal * num; }

        public int CalcQuantity(double amount) { return (int)(TotalAmount / amount); }

        public int Nominal
        {
            get { return nominal; }
            set { nominal = value; }
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public double TotalAmount
        {
            get { return nominal * num; }
        }

        public int this[int index]
        {
            get 
            {
                if (index == 0)
                    return nominal;
                else if (index == 1)
                    return num;
                else
                    throw new IndexOutOfRangeException("Index should be 0 or 1");
            }
            set 
            {
                if (index == 0)
                    nominal = value;
                else if (index == 1)
                    num = value;
                else throw new IndexOutOfRangeException("Index should be 0 or 1");
            }
        }

        public static Money operator ++(Money money)
        {
            money.nominal++;
            money.num++;
            return money;
        }

        public static Money operator --(Money money)
        {
            money.nominal--;
            money.num--;
            return money;
        }

        public static bool operator !(Money money)
        {
            return money.num != 0;
        }

        public static Money operator +(Money money, int scalar)
        {
            money.num += scalar;
            return money;
        }

        public static implicit operator string(Money money)
        {
            return $"Nominal: {money.nominal}, \tNum: {money.num}";
        }

        public static implicit operator Money(string str)
        {
            string[] parts = str.Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 4 || parts[0] != "Nominal" || parts[2] != "Num")
                throw new FormatException("Invalid string format");
            return new Money(int.Parse(parts[1]), int.Parse(parts[3]));
        }

        static void Main(string[] args)
        {
            Money[] wallet = new Money[]
            {
                new Money(1, 10),
                new Money(2, 5),
                new Money(5, 3),
                new Money(10, 7),
                new Money(20, 2)
            };

            Console.WriteLine("Your money: ");
            foreach (Money money in wallet)
            {
                money.Print();
            }

            Console.WriteLine("\nEnter a price of goods: ");
            double price = Convert.ToDouble(Console.ReadLine());
            foreach (Money money in wallet)
            {
                Console.WriteLine($"Nominal: {money.Nominal}, \tNum: {money.Num}, \tBuy possibility: {money.BuyGoods(price)}");
            }

            Console.WriteLine("\nEnter a price of goods for quantity search: ");
            double price2 = Convert.ToDouble(Console.ReadLine());
            foreach (Money money in wallet)
            {
                Console.WriteLine($"Nominal: {money.Nominal}, \tNum: {money.Num}, \tQuantity possibility: {money.CalcQuantity(price2)}");
            }

            //Use index
            Console.WriteLine("\nUsing index: ");
            Console.WriteLine($"Nominal of the first money object: {wallet[0][0]}");
            Console.WriteLine($"Num of the first money object: {wallet[0][1]}");

            //Operator overload
            Money test = new Money(5, 10);
            Console.WriteLine("\nUsing overload: ");
            Console.WriteLine($"Initial value: {test.Nominal}, {test.Num}");
            test++;
            Console.WriteLine($"After ++: {test.Nominal}, {test.Num}");
            test--;
            Console.WriteLine($"After --: {test.Nominal}, {test.Num}");
            Console.WriteLine($"! operator result: {!test}");

            //Type conversion
            Console.WriteLine("\nUsing type conversion: ");
            Money moneyFromString = "Nominal: 10, Num: 20";
            Console.WriteLine($"Money from string: {moneyFromString.Nominal}, {moneyFromString.Num}");
            string moneyToString = moneyFromString;
            Console.WriteLine($"Money to string: {moneyToString}");
        }
    }
}
