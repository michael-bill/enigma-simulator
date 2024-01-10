using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSimulator.Enigma.Model
{
    class Reflector
    {
        public char Type;
        public char[] Replacements;

        public Reflector(char type, char[] replacements)
        {
            Type = type;
            Replacements = new char[Configuration.ALPH_LENGTH];
            for (int i = 0; i < Configuration.ALPH_LENGTH; i++)
                Replacements[i] = replacements[i];
        }

        public Reflector(Reflector reflector)
        {
            Type = reflector.Type;
            Replacements = new char[Configuration.ALPH_LENGTH];
            for (int i = 0; i < Configuration.ALPH_LENGTH; i++)
                Replacements[i] = reflector.Replacements[i];
        }
    }
}