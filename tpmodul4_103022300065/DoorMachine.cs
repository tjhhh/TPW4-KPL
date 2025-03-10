using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300065
{
    class DoorMachine
    {
        private enum State { TERKUNCI, TERBUKA }
        private State currentState;

        public DoorMachine()
        {
            currentState = State.TERKUNCI;
            Console.WriteLine("Pintu terkunci");
        }

        public void KunciPintu()
        {
            if (currentState == State.TERBUKA)
            {
                currentState = State.TERKUNCI;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }

        public void BukaPintu()
        {
            if (currentState == State.TERKUNCI)
            {
                currentState = State.TERBUKA;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }
    }
}
