using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSimulator.Enigma.Model
{
    class Rotor
    {
        public int Type;
        public char[] Replacements;
        public int ShiftPosition;
        public int Position;

        public Rotor(int type, char[] replacements, int shiftPosition, int currentRotorShift)
        {
            Type = type;
            Replacements = new char[Configuration.ALPH_LENGTH];
            for (int i = 0; i < Configuration.ALPH_LENGTH; i++)
                Replacements[i] = replacements[i];
            ShiftPosition = shiftPosition;
            Position = currentRotorShift;
        }

        public Rotor(Rotor rotor)
        {
            Type = rotor.Type;
            Replacements = new char[Configuration.ALPH_LENGTH];
            for (int i = 0; i < Configuration.ALPH_LENGTH; i++)
                Replacements[i] = rotor.Replacements[i];
            ShiftPosition = rotor.ShiftPosition;
            Position = rotor.Position;
        }
    }
}