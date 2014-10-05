using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    public class NumberDisplay
    {
        #region Fields

        /// <summary>
        /// Privat fält som innehåller maxvärdet numret kan anta. Kapslas in av egenskapen MaxNumber.
        /// </summary>
        private int _maxNumber;

        /// <summary>
        /// Privat fält som innehåller själva numrets värde. Kapslas in av egenskapen Number.
        /// </summary>
        private int _number;

        #endregion

        #region Properties

        /// <summary>
        /// Publik egenskap, som kapslar in det privata fältet _maxNumber. set-metoden måste validera 
        /// att värdet som ska tilldelas _maxNumber är större än 0. Är värdet inte det ska ett 
        /// undantag av typen ArgumentException kastas.
        /// </summary>
        public int MaxNumber
        {
            get { return 0; }

            set { }
        }

        /// <summary>
        /// Publik egenskap, som kapslar in det privata fältet _number. set-metoden måste validera att 
        /// värdet som ska tilldelas _number är i det slutna intervallet mellan 0 och maxvärdet. Är 
        /// värdet inte i intervallet ska ett undantag av typen ArgumentException kastas.
        /// </summary>
        public int Number
        {
            get { return 0; }

            set { }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Konstruktorn NumberDisplay(int maxNumber) ska se till att fälten initieras så de refererar 
        /// till NumberDisplay-obejkt men ingen tilldelning får ske i konstruktorns kropp, som måste 
        /// vara tom. Denna konstruktor måste därför anropa den konstruktor i klassen som har två parametrar.
        /// </summary>
        /// <param name="maxNumber"></param>
        public NumberDisplay(int maxNumber)
        {

        }

        /// <summary>
        /// Med konstruktorn NumberDisplay(int maxNumber, int number) ska ett objekt initieras så att 
        /// objektets fält tilldelas värdena parametrarna har. Detta är den enda av konstruktorerna 
        /// som får innehålla kod som tilldelar fält i klassen värden.
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <param name="number"></param>
        public NumberDisplay(int maxNumber, int number)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Publik metod som anropas för att få NumberDisplay-objektet att öka numret med 1. Då värdet 
        /// fältet _number har ska passera värdet fältet _maxNumber har ska fältet _number tilldelas 
        /// värdet 0. Inga utskrifter till konsolfönstret får göras av metoden.
        /// </summary>
        public void Increment()
        {

        }

        /// <summary>
        /// ToString() ska överlagras, d.v.s. det ska finnas två metoder med samma namn men med olika paramterlistor. 
        /// 
        /// Den publika metoden ToString() har som uppgift att returnera en sträng representerande värdet av en instans 
        /// av klassen NumberDisplay. Strängen ska innehålla numret, utan att nummer mindre än tio inleds med 0. Inga 
        /// utskrifter till konsolfönstret får göras av metoden.
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return "Empty!";
        }

        /// <summary>
        /// Den publika metoden ToString(string format) har som uppgift att returnera en sträng representerande värdet 
        /// av en instans av klassen NumberDisplay. Formatsträngen ska bestämma om nummer mindre än tio ska inledas med 0. 
        /// 
        /// Är formatsträngen ”0” eller ”G” ska numret inte inledas med 0. Är formatsträngen ”00” ska numret inleda med 0 
        /// om numret är mindre än tio. Alla övriga värden på formatsträngen ska leda till att ett undantag av typen 
        /// FormatException kastas.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public string ToString(string format)
        {
            return "Empty!";
        }

        #endregion
    }
}
