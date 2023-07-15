using System;
namespace GeraPadroesNumericos.Functions.Interfaces
{
    public interface IMultiplyNumbers
    {
        List<long> GetList();
        void SetList(long firstNumber, int factor);
    }
}

