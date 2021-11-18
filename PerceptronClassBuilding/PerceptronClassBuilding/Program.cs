using System;

namespace PerceptronClassBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            double bias = 0.5;
            double[] initialWeightValues = { 0.75, -1.25};
            Perceptron perceptron = new Perceptron(initialWeightValues, bias);
            
            //5 rows of inputs
            double[][] inputs = new double[5][];
            
            for(int row = 0; row < inputs.Length; row++)
            {
                //2 columns for each row
                inputs[row] = new double[2];
            }

            inputs = new double[][]
            {
                new double[] { 0, 0 },
                new double[] { 0.3, -0.7},
                new double[] { 1, 1},
                new double[] {-1, -1},
                new double[] {-0.5, 0.5},
            };
            
            var temp = perceptron.Compute(inputs);
             
        }
    }
}