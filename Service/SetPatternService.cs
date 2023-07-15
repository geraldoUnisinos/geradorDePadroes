using System;
using GeraPadroesNumericos.Functions.Interfaces;

namespace GeraPadroesNumericos.Service
{
    public class SetPatternService
    {
        private readonly IChoosePattern _choosePattern;

        public SetPatternService(IChoosePattern choosePattern)
        {
            _choosePattern = choosePattern;
        }

        public void SetPatternToSend()
        {
            _choosePattern.SetPattern();

            var list = _choosePattern.GetPattern();

            HttpService.SendResult(list);
        }

    }
}

