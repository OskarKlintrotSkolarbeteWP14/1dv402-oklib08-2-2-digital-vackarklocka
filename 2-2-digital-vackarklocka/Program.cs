﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    class Program
    {

        #region Methods

        /// <summary>
        /// Metoden ska instansiera objekt av klassen AlarmClock och testa konstruktorerna, egenskaperna och metoderna.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            AlarmClockTest();

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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
        }

        /// <summary>
        /// Privat statisk metod som tar en sträng som argument och presenterar strängen.
        /// </summary>
        /// <param name="header"></param>
        private static void ViewTestHeader(string header)
        {
            Console.ResetColor();
            Console.WriteLine(header);
        }

        private static void AlarmClockTest()
        {
            AlarmClock TestObject = new AlarmClock();

            Test1(TestObject);

            Test2(TestObject);

            Test3(TestObject);

            Test4(TestObject);

            Test5(TestObject);

            Test6(TestObject);

            Test7(TestObject);
        }

        private static void Test1(AlarmClock testObject)
        {
            testObject = new AlarmClock();

            string testResult = "empty";

            testResult = string.Format(Test.Test1, testObject.ToString() + Environment.NewLine + Strings.HorizontalLine); //.Replace("\\n", Environment.NewLine)

            ViewTestHeader(testResult);
        }

        private static void Test2(AlarmClock testObject)
        {
            testObject = new AlarmClock(9, 42);
            string testResult = "empty";

            testResult = string.Format(Test.Test2, testObject.ToString() + Environment.NewLine + Strings.HorizontalLine);

            ViewTestHeader(testResult);
        }

        private static void Test3(AlarmClock testObject)
        {
            testObject = new AlarmClock(13, 24, 7, 35);
            string testResult = "empty";

            testResult = string.Format(Test.Test3, testObject.ToString() + Environment.NewLine + Strings.HorizontalLine);

            ViewTestHeader(testResult);
        }

        private static void Test4(AlarmClock testObject)
        {
            testObject.Hour = 23;
            testObject.Minute = 58;
            string testResult = "empty";

            testResult = string.Format(Test.Test4);

            ViewTestHeader(testResult);

            for (int i = 0; i < 13; i++)
            {
                testObject.TickTock();

                ViewTestHeader(testObject.ToString());
            }
            ViewTestHeader(Strings.HorizontalLine);
        }

        private static void Test5(AlarmClock testObject)
        {
            testObject.Hour = 6;
            testObject.Minute = 12;
            testObject.AlarmHour = 6;
            testObject.AlarmMinute = 15;
            string testResult = "empty";

            testResult = string.Format(Test.Test5);

            ViewTestHeader(testResult);

            for (int i = 0; i < 6; i++)
            {
                bool larm = testObject.TickTock();

                if (larm)
                {
                    ViewTestHeader(testObject.ToString() + Strings.Larm);
                }
                else
                {
                    ViewTestHeader(testObject.ToString());
                }
            }
            ViewTestHeader(Strings.HorizontalLine);
        }

        private static void Test6(AlarmClock testObject)
        {
            ViewTestHeader(Test.Test6);

            try
            {
                testObject.Hour = 99;
            }
            catch (Exception)
            {
                ViewErrorMessage(Test.Error_Hour);
            }

            try
            {
                testObject.Minute = 99;
            }
            catch (Exception)
            {
                ViewErrorMessage(Test.Error_Minute);
            }

            try
            {
                testObject.AlarmHour = 99;
            }
            catch (Exception)
            {
                ViewErrorMessage(Test.Error_Hour);
            }

            try
            {
                testObject.AlarmMinute = 99;
            }
            catch (Exception)
            {
                ViewErrorMessage(Test.Error_Minute);
            }
            
            ViewTestHeader(Strings.HorizontalLine);
        }

        private static void Test7(AlarmClock testObject)
        {
            ViewTestHeader(Test.Test7);
            
            try
            {
                testObject = new AlarmClock(99, 99, 7, 35);
            }
            catch (Exception)
            {
                ViewErrorMessage(Test.Error_Hour);
            }

            try
            {
                testObject = new AlarmClock(13, 24, 99, 99);
            }
            catch (Exception)
            {
                ViewErrorMessage(Test.Error_Minute);
            }

            ViewTestHeader(Strings.HorizontalLine);
        }

        #endregion
    }
}
