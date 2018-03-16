using System;

namespace MachineLearning {

    class Program {
        private static double _val = 60000;
        private static double _expected;
        private static double _constant = 1;
        private static double _guess;

        static void Main(string[] args) {
            _expected = _val * 1.609344;


            Console.WriteLine($"I have a value of {_val}, and I expect a value of {_expected}. Let me calculate the constant for conversion.");
            Console.WriteLine("I'll compute this for you..");

            while (Math.Abs(_guess - _expected) > 0) {
                _guess = ComputeKilometres(_val);
                double error = _expected - _guess;
                double change = (error / _expected);
                _constant += change;
            }

            Console.WriteLine();
            Console.WriteLine("The approx constant for conversion is: " + _constant);
            Console.WriteLine(_val + " miles is approx equal to " + (_val * _constant) + "km");
            Console.WriteLine();
            DoConversions();
            Console.ReadLine();
        }

        public static void DoConversions() {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Input a value:");
                float toConvert = float.Parse(Console.ReadLine());
                Console.WriteLine($"{toConvert} miles is approx. " + (toConvert * _constant) + "km.");
                Console.WriteLine();
            }
        }
        public static double ComputeKilometres(double val) {
            return (val * _constant);
        }

    }
}
