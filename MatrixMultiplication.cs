using System;

namespace MatrixMultiplication {

    /* Takes two arrays of inputs and outputs, and multiplies each to create a new array of outputs,
     * which is then returned.
     */

    class MatrixMultiplication {
        
        static void Main(string[] args) {
            // In machine learning, we use these as our inputs to the matrix multiplication.
            double[] inputs = { 0.1, 0.8 };

            // Holds all of the weights we need to multiply our input matrix with.
            double[,] weights =
            {
                {0.1, 0.9},
                {0.6, 0.5}
            };

            // Calculate the new outputs.
            double[] outputs = MultiplyMatrices(inputs, weights);

            // Output the values.
            Console.WriteLine(String.Join(" ", outputs));

            Console.ReadLine();
        }

        static double[] MultiplyMatrices(double[] inputs, double[,] weights)
        {
            // New array to hold a new set of inputs, multiplied by the current weights.
            var outputs = new double[inputs.Length];

            // Iterate through each row of the weights.
            for (var row = 0; row < weights.GetLength(0); row++)
            {
                // Iterate through each column of the weights.
                for (var col = 0; col < weights.GetLength(1); col++)
                {
                    // Add the current input[row] multiplied by our current weight to the output row.
                    /* Example:
                     * As we iterate through every row of the weights, and weights have to contain the same
                     * Number of rows as the inputs contain columns ::
                     * Our weights contain 2 rows, and our inputs contain 2 columns, this can work.
                     * Given the first value of our test array of inputs, we can see we have the first value 0.1,
                     * This needs to be multiplied by every value in the current row of our weight array.
                     * So, every column of the inputs are multiplied by every row of the weights.
                     * */

                    outputs[row] += inputs[row] * weights[row, col];
                }
            }
            
            // After we finish our multiplications, we can return our newly constructed values.
            return outputs;
        }

    }
}
