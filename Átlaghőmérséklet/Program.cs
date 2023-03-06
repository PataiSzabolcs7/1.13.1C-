using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Átlaghőmérséklet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                const int nRows = 12;
                const int nCols = 30;
                double[,] temperatureMatrix = new double[nRows, nCols];

                // Fill matrix with random temperatures
                Random rand = new Random();
                for (int i = 0; i < nRows; i++)
                {
                    for (int j = 0; j < nCols; j++)
                    {
                        temperatureMatrix[i, j] = rand.NextDouble() * 30 - 10;
                    }
                }

                // Find hottest and coldest day
                double maxTemperature = double.MinValue;
                double minTemperature = double.MaxValue;
                int maxDay = 0;
                int minDay = 0;
                for (int i = 0; i < nRows; i++)
                {
                    for (int j = 0; j < nCols; j++)
                    {
                        if (temperatureMatrix[i, j] > maxTemperature)
                        {
                            maxTemperature = temperatureMatrix[i, j];
                            maxDay = i * nCols + j + 1;
                        }
                        if (temperatureMatrix[i, j] < minTemperature)
                        {
                            minTemperature = temperatureMatrix[i, j];
                            minDay = i * nCols + j + 1;
                        }
                    }
                }
                Console.WriteLine($"Hottest day was day {maxDay} with temperature {maxTemperature} degrees Celsius.");
                Console.WriteLine($"Coldest day was day {minDay} with temperature {minTemperature} degrees Celsius.");

                // Find hottest and coldest month
                double[] monthlyTemperatures = new double[nRows];
                for (int i = 0; i < nRows; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < nCols; j++)
                    {
                        sum += temperatureMatrix[i, j];
                    }
                    monthlyTemperatures[i] = sum / nCols;
                }
                double maxMonthlyTemperature = double.MinValue;
                double minMonthlyTemperature = double.MaxValue;
                int maxMonth = 0;
                int minMonth = 0;
                for (int i = 0; i < nRows; i++)
                {
                    if (monthlyTemperatures[i] > maxMonthlyTemperature)
                    {
                        maxMonthlyTemperature = monthlyTemperatures[i];
                        maxMonth = i + 1;
                    }
                    if (monthlyTemperatures[i] < minMonthlyTemperature)
                    {
                        minMonthlyTemperature = monthlyTemperatures[i];
                        minMonth = i + 1;
                    }
                }
                Console.WriteLine($"Hottest month was month {maxMonth} with average temperature {maxMonthlyTemperature} degrees Celsius.");
                Console.WriteLine($"Coldest month was month {minMonth} with average temperature {minMonthlyTemperature} degrees Celsius.");

                // Check if there were 5 consecutive days with negative temperature
                bool foundConsecutiveDays = false;
                for (int i = 0; i < nRows; i++)
                {
                    int countConsecutiveNegativeDays = 0;
                    for (int j = 0; j < nCols; j++)
                    {
                        if (temperatureMatrix[i, j] < 0)
                        {
                            countConsecutiveNegativeDays++;
                            if (countConsecutiveNegativeDays == 5)
                            {
                                foundConsecutiveDays = true;
                                break;
                            }
                        }
                        else
                        {
                            countConsecutiveNegativeDays = 0;
                        }
                    }
                    if (foundConsecutiveDays)
                    {
                        break;
                    }
                }
                if (foundConsecutiveDays)
                {
                    Console.WriteLine("There were 5 consecutive days with negative temperature.");
                }
                else
                {
                    Console.WriteLine("There were no 5 consecutive days with negative temperature.");
                }
                Console.ReadKey();
            }
        }
    }
}
