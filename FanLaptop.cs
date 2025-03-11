using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022330059
{
    internal class FanLaptop
    {
        enum State { Quiet, Balanced, Performance, Turbo }
        private State currentState;
        public FanLaptop()
        {
            currentState = State.Quiet; 
        }
        public void ModeDown()
        {
            if (currentState == State.Turbo)
            {
                currentState = State.Performance;
                Console.WriteLine($"Fan Turbo berubah menjadi {currentState}");
            }
            else if (currentState == State.Performance)
            {
                currentState = State.Balanced;
                Console.WriteLine($"Fan Permonced berubah menjadi {currentState}");
            }
            else if (currentState == State.Balanced)
            {
                currentState = State.Quiet;
                Console.WriteLine($"Fan Balanced berubah menjadi {currentState}");
            }          
        }
        public void ModeUp()
        {
            if (currentState == State.Quiet)
            {
                currentState = State.Balanced;
                Console.WriteLine($"Fan Quiet berubah menjadi {currentState}");
            }
            else if (currentState == State.Balanced)
            {
                currentState = State.Performance;
                Console.WriteLine($"Fan Balanced berubah menjadi {currentState}");
            }
            else if (currentState == State.Performance)
            {
                currentState = State.Turbo;
                Console.WriteLine($"Fan Perfomance berubah menjadi {currentState}");
            }
        }
        
        public void TurboShortcut()
        {
            if (currentState == State.Quiet)
            {
                currentState = State.Turbo;
                Console.WriteLine($"Fan Quiet berubah menjadi {currentState}");
            }
            else if (currentState == State.Turbo)
            {
                currentState = State.Quiet;
                Console.WriteLine($"Fan Turbo berubah menjadi {currentState}");
            }
        }
    }
}
