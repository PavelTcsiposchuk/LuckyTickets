using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LuckyTickets
{
    public class MoscowTicketAnalyzator : TicketAnalyzator
    {
        
        #region Constructors

        public MoscowTicketAnalyzator(int startNumberRange, int finishNumberRange)
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
            int firstNumbersSum = 0;
            int secondNumbersSum = 0;

            for (int index = 0; index < _numberDigitsTicket / 2; index++)
            {
                firstNumbersSum += arrayDigits[index];
                secondNumbersSum += arrayDigits[(_numberDigitsTicket - 1) - index];
            }
            if (firstNumbersSum == secondNumbersSum)
            {
                result = true;
            }

            return result;
        }
       

        #endregion

    }
}
