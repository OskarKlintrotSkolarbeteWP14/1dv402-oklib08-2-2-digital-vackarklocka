using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    public class ClockDisplay
    {
        #region Fields

        /// <summary>
        /// Privat fält som i innehåller referens till ett NumberDisplay-objekt som ansvarar 
        /// för timmarna. Kapslas in av egenskapen Hour.
        /// </summary>
        private NumberDisplay _hourDisplay;

        /// <summary>
        /// Privat fält som i innehåller referens till ett NumberDisplay-objekt som 
        /// ansvarar för minuterna. Kapslas in av egenskapen Minute.
        /// </summary>
        private NumberDisplay _minuteDisplay;

        #endregion

        #region Properties

        /// <summary>
        /// Publik egenskap, som kapslar in det privata fältet _hourDisplay och dess egenskap Number.
        /// </summary>
        public int Hour
        {
            get { return 0; }

            set { }
        }

        /// <summary>
        /// Publik egenskap, som kapslar in det privata fältet _minuteDisplay och dess egenskap Number.
        /// </summary>
        public int Minute
        {
            get { return 0; }

            set { }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Standardkonstruktorn ClockDisplay() ska se till att fälten initieras så de 
        /// refererar till NumberDisplay-objekt men ingen tilldelning får ske i 
        /// konstruktorns kropp, som måste vara tom. Denna konstruktor måste därför 
        /// anropa den konstruktor i klassen som har två parametrar.
        /// </summary>
        public ClockDisplay()
        {

        }

        /// <summary>
        /// Med konstruktorn ClockDisplay(int hour, int minute) ska ett objekt initieras 
        /// så att objektet ställs på den tid som parametrarna anger. Detta är den enda 
        /// av konstruktorerna som får innehålla kod som leder till att fält i klassen 
        /// tilldelas värden.
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        public ClockDisplay(int hour, int minute)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Publik metod som anropas för att få ClockDisplay-objektet att gå en minut. Metoden ansvarar 
        /// för att öka minuternas värde med 1. Då värdet för minuterna blir 0 ökas lämpligen timmarnas 
        /// värde med 1. Inga utskrifter till konsolfönstret får göras av metoden.
        /// </summary>
        public void Increment()
        {

        }

        /// <summary>
        /// Publik metod som har som uppgift att returnera en sträng representerande värdet av en 
        /// instans av klassen ClockDisplay. Strängen ska innehålla tiden på formatet HH:mm. Inga 
        /// utskrifter till konsolfönstret får göras av metoden.
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return "Empty!";
        }

        #endregion
    }
}
