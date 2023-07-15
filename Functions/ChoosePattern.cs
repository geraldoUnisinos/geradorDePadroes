using System;
using GeraPadroesNumericos.Functions.Interfaces;

namespace GeraPadroesNumericos.Functions
{
    public class ChoosePattern : IChoosePattern
    {
        private Random rnd = new();
        private IMultiplyNumbers _multiplyNumbers;

        public ChoosePattern(IMultiplyNumbers multiplyNumbers)
        {
            _multiplyNumbers = multiplyNumbers;
        }

        public void SetPattern()
        {
            long firstNumber = rnd.Next(2, 100);
            int factor = rnd.Next(2, 35);

            _multiplyNumbers.SetList(firstNumber, factor);
        }

        public List<long> GetPattern()
        {
            var result = _multiplyNumbers.GetList().OrderBy(item => rnd.Next()).ToList();

            return result;
        }

    }
}

