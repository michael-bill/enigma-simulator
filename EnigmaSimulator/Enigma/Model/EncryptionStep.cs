using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSimulator.Enigma.Model
{
    class EncryptionStep
    {
        public List<int> EncryptionSequence;
        public int[] RotorPositions;

        public EncryptionStep(int[] rotorPositions)
        {
            EncryptionSequence = new List<int>();
            RotorPositions = new int[3];
            for (int i = 0; i < rotorPositions.Length; i++)
                RotorPositions[i] = rotorPositions[i];
        }
    }
}
