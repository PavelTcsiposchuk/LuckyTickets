using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public class PiterTicketAnalyzator : TicketAnalyzator
    {
        #region Constructors

        public PiterTicketAnalyzator(int startNumberRange, int finishNumberRange)
        {
            StartNumberRange = startNumberRange;
            FinishNumberRange = finishNumberRange;
        }

        #endregion

        #region Methods

        public override int CountLuckyTickets()
        {
            _countLuckyTickets = 0;

            for (int indexer = StartNumberRange; indexer <= FinishNumberRange; indexer++)
            {
                if (IsTicketLucky(indexer))
                {
                    _countLuckyTickets++;
                }
            }

            return _countLuckyTickets;
        }

        public override bool IsTicketLucky(int number)
        {
            bool result = false;
            int quantityDigitsInNumber = FindNumberDigit(number);
            int[] arrayDigits = CreateArrayWithDigits(number, quantityDigitsInNumber);
            int evenNumbersSum = 0;
            int oddNumbersSum = 0;

            for (int index = 0; index < _numberDigitsTicket; index++)
            {
                if((index + 1) % 2 == 0)
                {
                    evenNumbersSum += arrayDigits[index];
                }
                else
                {
                    oddNumbersSum += arrayDigits[index];
                }
            }
            if (evenNumbersSum == oddNumbersSum)
            {
                result = true;
                //Console.WriteLine(number);
            }

            return result;

        }

            #endregion
    }
}
