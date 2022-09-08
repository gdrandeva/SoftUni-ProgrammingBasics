using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int patient = 0;
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int sumTr = 0;
            int sumUntr = 0;

            for (int i = 1; i <= period; i++)
            {

                patient = int.Parse(Console.ReadLine());

                if (patient < doctors)
                {
                    treatedPatients = patient;
                    sumTr += treatedPatients;
                }
                else if (patient >= doctors)
                {
                    if (sumUntr > sumTr && i % 3 == 0)
                    {
                        doctors++;
                    }
                    untreatedPatients = patient - doctors;
                    sumUntr += untreatedPatients;
                    sumTr += doctors;
                }

            }

            Console.WriteLine($"Treated patients: {sumTr}.");
            Console.WriteLine($"Untreated patients: {sumUntr}.");
        }
    }
}
