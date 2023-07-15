using System;
using GeraPadroesNumericos.Functions.Interfaces;

namespace GeraPadroesNumericos.Functions
{
    public class MultiplyNumbers : IMultiplyNumbers
    {
        private List<long> numberList = new();

        public MultiplyNumbers()
        {
        }

        public List<long> GetList()
        {
            return numberList;
        }

        public void SetList(long firstNumber, int factor)
        {
            numberList.Clear();

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    numberList.Add(firstNumber);
                else
                {
                    numberList.Add(firstNumber * factor);
                    firstNumber = numberList[i];
                }
            }
        }
    }
}

