using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    class Program
    {

        #region Fields

        string HorizontalLine;

        #endregion

        #region Methods

        /// <summary>
        /// Metoden ska instansiera objekt av klassen AlarmClock och testa konstruktorerna, egenskaperna och metoderna.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AlarmClock test = new AlarmClock(2, 3, 23, 5);

            Console.WriteLine(test.ToString());
        }

        /// <summary>
        /// Privat statisk metod som har två parametrar. Den första parametern är en referens till AlarmClock-objekt. 
        /// Den andra parametern är antalet minuter som AlarmClock-objektet ska gå (vilket lämpligen görs genom att 
        /// låta ett AlarmClock-objekt göra upprepade anrop av metoden TickTock()).
        /// </summary>
        /// <param name="ac"></param>
        /// <param name="minutes"></param>
        private static void Run(AlarmClock ac, int minutes)
        {

        }

        /// <summary>
        /// Privat statisk metoden som tar ett felmeddelande som argument och presenterar det.
        /// </summary>
        /// <param name="message"></param>
        private static void ViewErrorMessage(string message)
        {

        }

        /// <summary>
        /// Privat statisk metod som tar en sträng som argument och presenterar strängen.
        /// </summary>
        /// <param name="header"></param>
        private static void ViewTestHeader(string header)
        {

        }

        #endregion
    }
}
