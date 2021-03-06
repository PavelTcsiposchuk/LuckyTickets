﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public class PiterAlgorithm : ITicketAlgorithm
    {

        #region Methods
       
        public bool IsTicketLucky(Ticket ticket)
        {
            bool result = false;
            int evenNumbersSum = 0;
            int oddNumbersSum = 0;

            for (int index = 0; index < ticket.DigitsTicket.Length; index++)
            {
                if ((index + 1) % 2 == 0)
                {
                    evenNumbersSum += ticket[index];
                }
                else
                {
                    oddNumbersSum += ticket[index];
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
