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
            get { return Convert.ToInt32(_hourDisplay.ToString("0")); }

            set { _hourDisplay.Number = value; }
        }

        /// <summary>
        /// Publik egenskap, som kapslar in det privata fältet _minuteDisplay och dess egenskap Number.
        /// </summary>
        public int Minute
        {
            get { return Convert.ToInt32(_minuteDisplay.ToString("00")); }

            set { _minuteDisplay.Number = value; }
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
            :this(0, 0)
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
            _hourDisplay = new NumberDisplay(23, hour);
            _minuteDisplay = new NumberDisplay(59, minute);
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
            _minuteDisplay.Increment();
            if (_minuteDisplay.Number == 0)
            {
                _hourDisplay.Increment();
            }
        }

        /// <summary>
        /// Publik metod som har som uppgift att returnera en sträng representerande värdet av en 
        /// instans av klassen ClockDisplay. Strängen ska innehålla tiden på formatet HH:mm. Inga 
        /// utskrifter till konsolfönstret får göras av metoden.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Hour + ":" + Minute;
        }

        #endregion
    }
}
