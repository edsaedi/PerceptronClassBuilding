using System;
using System.Collections.Generic;
using System.Text;

namespace PerceptronClassBuilding
{
    class Perceptron
    {
        double[] weights;
        double bias;

        public Perceptron(double[] initialWeightValues, double initialBiasValue)
        {
            /*initializes the weights array and bias*/
            weights = initialWeightValues;
            bias = initialBiasValue;
        }

        public Perceptron(int amountOfInputs)
        {
            /*Initializes the weights array given the amount of inputs*/
            weights = new double[amountOfInputs];
        }

        public void Randomize(Random random, double min, double max)
        {
            /*Randomly generates values for every weight including the bias*/
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = random.NextDouble(min, max);
            }

            bias = random.NextDouble(min, max);
        }

        public double Compute(double[] inputs)
        {
            /*computes the output with given input*/
            double result = bias;

            for (int i = 0; i <= inputs.Length - 1; i++)
            {
                result += (weights[i] * inputs[i]);
            }

            return result;
        }

        public double[] Compute(double[][] inputs)
        {
            /*computes the output for each row of inputs*/
            double[] results = new double[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                results[i] = Compute(inputs[i]);
            }
            return results;
        }

    }
}
