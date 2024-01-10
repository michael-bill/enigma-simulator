using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSimulator.Enigma.Model
{
    class Key
    {
        public Rotor[] Compartments;
        public char[] Plugboard;

        public Key(Rotor[] compartments, char[] plugboard)
        {
            Compartments = new Rotor[compartments.Length];
            Plugboard = new char[Configuration.ALPH_LENGTH];
            for (int i = 0; i < compartments.Length; i++)
                Compartments[i] = new Rotor(compartments[i]);
            for (int i = 0; i < Configuration.ALPH_LENGTH; i++)
                Plugboard[i] = plugboard[i];
        }
    }
}
