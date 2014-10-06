using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    public class AlarmClock
    {
        #region Fields

        /// <summary>
        /// Privat fält som i innehåller referens till ett ClockDisplay-objekt som ansvarar för alarmtiden. 
        /// Kapslas in av egenskaperna AlarmHour och AlarmMinute.
        /// </summary>
        private ClockDisplay _alarmTime;

        /// <summary>
        /// Privat fält som i innehåller referens till ett ClockDisplay-objekt som ansvarar för väckarklockans aktuella tid. 
        /// Kapslas in av egenskaperna Hour och Minute.
        /// </summary>
        private ClockDisplay _time;

        #endregion

        #region Properties

        /// <summary>
        /// Publik egenskap, som kapslar in det privata fältet _alarmTime och dess egenskap Hour.
        /// </summary>
        public int AlarmHour
        {
            get { return _alarmTime.Hour; }

            set { _alarmTime.Hour = value; }
        }
        /// <summary>
        /// Publik egenskap, som kapslar in det privata fältet _alarmTime och dess egenskap Minute.
        /// </summary>
        public int AlarmMinute
        {
            get { return _alarmTime.Minute; }

            set { _alarmTime.Minute = value; }
        }
        /// <summary>
        /// Publik egenskap, som kapslar in det privata fältet _time och dess egenskap Hour.
        /// </summary>
        public int Hour
        {
            get { return _time.Hour; }

            set { _time.Hour = value; }

        }
        /// <summary>
        /// Publik egenskap, som kapslar in det privata fältet _time och dess egenskap Minute.
        /// </summary>
        public int Minute
        {
            get { return _time.Minute; }

            set { _time.Minute = value; }

        }

        #endregion

        #region Constructor

        /// <summary>
        /// Standardkonstruktorn AlarmClock() ska initiera fälten till deras standardvärden. Ingen 
        /// tilldelning får ske i konstruktorns kropp, som måste vara tom. Denna konstruktor måste 
        /// därför anropa den konstruktor i klassen som har två parametrar.
        /// </summary>
        public AlarmClock()
            :this(0, 0)
        {

        }
        /// <summary>
        /// Med konstruktorn AlarmClock(int hour, int minute) ska ett objekt kunna initieras så att alarmklockan ställs 
        /// på den tid som parametrarna för timme respektive minut anger. Ingen tilldelning får ske i konstruktorns kropp, 
        /// som måste vara tom. Denna konstruktor måste därför anropa den konstruktor i klassen som har fyra parametrar.
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        public AlarmClock(int hour, int minute)
            : this(hour, minute, 0, 0)
        {

        }
        /// <summary>
        /// Med konstruktorn AlarmClock(int hour, int minute , int alarmHour, int alarmMinute) ska ett objekt kunna 
        /// initieras så att alarmklockan ställs på den tid och alarmtid som parametrarna anger. Detta är den enda av 
        /// konstruktorerna som får innehålla kod som leder till att fält i klassen tilldelas värden
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <param name="alarmHour"></param>
        /// <param name="alarmMinute"></param>
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            _alarmTime = new ClockDisplay(alarmHour, alarmMinute);
            _time = new ClockDisplay(hour, minute);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Publik metod som anropas för att få klockan att gå en minut. Om den nya tiden överensstämmer med alarmtiden 
        /// ska metoden returnera true, annars false. Inga utskrifter till konsolfönstret får göras av metoden.
        /// </summary>
        /// <returns></returns>
        public bool TickTock()
        {
            _time.Increment();
            _alarmTime.Increment();

            if (_alarmTime.ToString() == _time.ToString())
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Publik metod som har som uppgift att returnera en sträng representerande värdet av en instans 
        /// av klassen AlarmClock. Strängen ska innehålla aktuell tid samt alarmtiden inom parenteser. Inga 
        /// utskrifter till konsolfönstret får göras av metoden.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _time.ToString() + " (" + _alarmTime.ToString() + ")";
        }

        #endregion
    }
}
