using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public abstract class TicketAnalyzator
    {
        #region Properties

        public int StartNumberRange
        {
            get
            {
                return _startNumberRange;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("Value can`t be less than one");
                }
                else
                {
                    _startNumberRange = value;
                }
            }
        }
        public int FinishNumberRange
        {
            get
            {
                return _finishNumberRange;
            }
            set
            {
                if (value < 1 || value < StartNumberRange)
                {
                    throw new ArgumentOutOfRangeException( value < 0 ? "Value can`t be less than one" : "Finish number can`t be less than start");
                }
                else
                {
                    _finishNumberRange = value;
                }
            }
        }

        #endregion

        #region Fields

        protected int _startNumberRange;
        protected int _finishNumberRange;
        protected int _countLuckyTickets = 0;
        protected int _numberDigitsTicket = 6;

        #endregion

        #region Methods

        public abstract int CountLuckyTickets();
        public abstract bool IsTicketLucky(int number);
        protected int[] CreateArrayWithDigits(int number, int quantityDigitsInNumber)
        {
            int[] arrayDigits = new int[_numberDigitsTicket];

            for (int index = 0; index < _numberDigitsTicket - quantityDigitsInNumber; index++)
            {
                arrayDigits[index] = 0;
            }
            string stringNumber = Convert.ToString(number);
            for (int index = _numberDigitsTicket - quantityDigitsInNumber, digree = 0; index < _numberDigitsTicket; index++, digree++)
            {
                arrayDigits[index] = Convert.ToInt32(stringNumber[digree] - '0');
            }

            return arrayDigits;
        }
        protected int FindNumberDigit(int number)
        {
            int numberDigitInNumber = 0;

            while (number >= 1)
            {
                number /= 10;
                numberDigitInNumber++;
            }

            return numberDigitInNumber;
        }

        #endregion

    }
}
