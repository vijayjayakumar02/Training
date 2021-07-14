using System;
using System.Threading;

namespace Demo
{
    public class Stopwatch
    {
        private static DateTime start_time;
        private static DateTime stop_time;
        private static bool isStart = false;
        private static bool isStop = false;
        private static DateTime elapsed;

        //props for start time
        private static DateTime Start_time
        {
            get { return start_time; }
            set { start_time = value; }
        }
        //props for stop time
        private static DateTime Stop_time
        {
            get { return stop_time; }
            set { stop_time = value; }
        }

        //assigning start to starttime props when isStart variable is false
        private static void Start(DateTime start)
        {
            if (isStart)
            {
                Console.WriteLine("Cannot start the timer twice");
            }
            else
            {
                isStart = true;
                isStop = false;
                Start_time = start;
            }
        }

        //assigning stop to stoptime props when isstop variable is false
        private static void Stop(DateTime stop)
        {
            if (isStop)
            {
                Console.WriteLine("Cannot stop the timer twice");
            }
            else
            {
                isStart = false;
                isStop = true;
                stop_time = stop;
            }
        }
        //printing the elapsed time between start and stop
        private static void GetInterval()
        {
            if (elapsed == null)
            {
                Console.WriteLine("your timer is not start or stopped yet.");
            }
            else
            {
                TimeSpan elapsed = stop_time - start_time;
                string elapsedTime = (elapsed).ToString();
                Console.WriteLine(elapsedTime);
            }
        }

        //getting user input to control the application
        public void runProgram()
        {
            Thread.Sleep(2000);//sleep for 2sec
            Console.WriteLine("Type \"start\" to start the timer Or Type \"Stop\" to stop the timer Or Type \"get\" to get the output Or type \"exit\" to close the application.");
            while (true)
            {
                String EnterKey = Console.ReadLine();
                if (EnterKey == "start")
                {
                    begin_timer();
                }
                else if (EnterKey == "stop")
                {
                    end_timer();
                }
                else if (EnterKey == "get")
                {
                    GetInterval();
                }
                else if (EnterKey == "exit")
                {
                    Console.WriteLine("Application is closing...");
                    Thread.Sleep(1000);
                    Console.WriteLine("closed");
                    return;
                }
            }
        }
        //assigning the time to starttime when user enters start (DateTime.Now is the current time)
        private static void begin_timer()
        {
            Start_time = DateTime.Now;
            Console.WriteLine("Timer is started.....");
        }

        //assigning the time to stoptime when user enters stop (DateTime.Now is the current time)
        private static void end_timer()
        {
            Stop_time = DateTime.Now;
            Console.WriteLine("Timer is started.....");
        }
    }
}