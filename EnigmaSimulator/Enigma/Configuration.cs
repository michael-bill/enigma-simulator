using EnigmaSimulator.Enigma.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSimulator.Enigma
{
    class Configuration
    {
        /// <summary>
        /// Длина алфавита
        /// </summary>
        public const int ALPH_LENGTH = 26;

        /// <summary>
        /// Типы рефлекторов
        /// Источник: https://www.codesandciphers.org.uk/enigma/rotorspec.htm
        /// </summary>
        public static Reflector[] AllReflectors = new Reflector[] {
            new Reflector('B', new char[] { 'Y', 'R', 'U', 'H', 'Q', 'S', 'L', 'D', 'P', 'X', 'N', 'G', 'O', 'K', 'M',
            'I', 'E', 'B', 'F', 'Z', 'C', 'W', 'V', 'J', 'A', 'T' }),
            new Reflector('C', new char[] { 'F', 'V', 'P', 'J', 'I', 'A', 'O', 'Y', 'E', 'D', 'R', 'Z', 'X', 'W', 'G',
            'C', 'T', 'K', 'U', 'Q', 'S', 'B', 'N', 'M', 'H','L' })
        };

        /// <summary>
        /// Все возмодные типы роторов
        /// Источник: https://www.codesandciphers.org.uk/enigma/rotorspec.htm
        /// </summary>
        public static Rotor[] AllRotors = new Rotor[] {
            new Rotor(1, new char[] { 'E', 'K', 'M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O', 'W', 'Y',
            'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J' }, 17, 1),
            new Rotor(2, new char[] { 'A', 'J', 'D', 'K', 'S', 'I', 'R', 'U', 'X', 'B', 'L', 'H', 'W', 'T', 'M',
            'C', 'Q', 'G', 'Z', 'N', 'P', 'Y', 'F', 'V', 'O', 'E' }, 5, 1),
            new Rotor(3, new char[] { 'B', 'D', 'F', 'H', 'J', 'L', 'C', 'P', 'R', 'T', 'X', 'V', 'Z', 'N', 'Y',
            'E', 'I', 'W', 'G', 'A', 'K', 'M', 'U', 'S', 'Q', 'O' }, 22, 1),
            new Rotor(4, new char[] { 'E', 'S', 'O', 'V', 'P', 'Z', 'J', 'A', 'Y', 'Q', 'U', 'I', 'R', 'H', 'X',
            'L', 'N', 'F', 'T', 'G', 'K', 'D', 'C', 'M', 'W', 'B' }, 10, 1),
            new Rotor(5, new char[] { 'V', 'Z', 'B', 'R', 'G', 'I', 'T', 'Y', 'U', 'P', 'S', 'D', 'N', 'H', 'L',
            'X', 'A', 'W', 'M', 'J', 'Q', 'O', 'F', 'E', 'C', 'K' }, 26, 1)
        };

        /// <summary>
        /// Отсеки с соответствующими роторами и рефлектор
        /// </summary>
        public static Rotor[] Compartments = new Rotor[] { new Rotor(AllRotors[0]), new Rotor(AllRotors[1]), new Rotor(AllRotors[2]) };
        public static Reflector ReflectorСompartment = new Reflector(AllReflectors[0]);

        /// <summary>
        /// Ключ к расшифровке сообщения
        /// </summary>
        public static Key Key;

        /// <summary>
        /// Коммутационная панель
        /// </summary>
        public static char[] Plugboard = new char[] {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        
        /// <summary>
        /// Алфавит
        /// </summary>
        public static char[] Alphabet = new char[] {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        /// <summary>
        /// Сохранение шагов шифрования. При новом сообщении необходимо сбрасывать.
        /// </summary>
        public static List<EncryptionStep> EncryptionSteps = new List<EncryptionStep>();
    }
}
