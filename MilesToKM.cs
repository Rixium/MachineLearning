using System;

namespace MachineLearning {

    class Program
    {
        private static double _val = 60000;
        private static double _expected;
        private static double _constant = 1;
        private static double _guess;

        static void Main(string[] args) {
            _expected = _val * 1.609347;


            Console.WriteLine($"I have a value of {_val}, and I expect a value of {_expected}. Let me calculate the constant for conversion.");
            Console.WriteLine("I'll compute this for you..");

            while (Math.Abs(_guess - _expected) > 0.0000001)
            {
                _guess = ComputeKilometres(_val);
                if (_guess < _expected)
                {
                    _constant *= 1.0001f;
                    
                }
                else if (_guess > _expected)
                {
                    _constant *= 0.9999f;
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("The approx constant for conversion is: " + Math.Round(_constant, 2));
            Console.WriteLine(_val + " miles is approx equal to " + Math.Round(_val * _constant, 2) + "km");
            Console.WriteLine();
            DoConversions();
            Console.ReadLine();
        }

        public static void DoConversions()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input a value:");
                float toConvert = float.Parse(Console.ReadLine());
                Console.WriteLine($"{toConvert} miles is approx. " + Math.Round(toConvert * _constant, 2) + "km.");
                Console.WriteLine();
            }
        }
        public static double ComputeKilometres(double val)
        {
            return (val * _constant);
        }

    }
}
