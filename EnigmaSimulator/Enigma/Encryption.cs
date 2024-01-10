using EnigmaSimulator.Enigma.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSimulator.Enigma
{
    class Encryption
    {
        /// <summary>
        /// Основной метод, орагинзовывающий внутреннюю логику шифрования.
        /// Принимает в качестве аргументов все основные параметры для реализации одного прохода.
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="firstRotor"></param>
        /// <param name="secondRotor"></param>
        /// <param name="thirdRotor"></param>
        /// <param name="reflector"></param>
        /// <param name="plugboard"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static char Encrypt(char letter, Rotor firstRotor, Rotor secondRotor, Rotor thirdRotor, Reflector reflector, char[] plugboard, EncryptionStep step)
        {
            int letterIndex = Array.IndexOf(Configuration.Alphabet, letter);
            step.EncryptionSequence.Add(letterIndex);
            letterIndex = Array.IndexOf(Configuration.Alphabet, plugboard[letterIndex]);
            step.EncryptionSequence.Add(letterIndex);
            letterIndex = ForwardLetterСonversion(firstRotor.Replacements, letterIndex + (firstRotor.Position - 1), step.EncryptionSequence);
            letterIndex = ForwardLetterСonversion(secondRotor.Replacements, letterIndex + (secondRotor.Position - 1) - (firstRotor.Position - 1), step.EncryptionSequence);
            letterIndex = ForwardLetterСonversion(thirdRotor.Replacements, letterIndex + (thirdRotor.Position - 1) - (secondRotor.Position - 1), step.EncryptionSequence);
            letterIndex = ForwardLetterСonversion(reflector.Replacements, letterIndex - (thirdRotor.Position - 1), step.EncryptionSequence);
            letterIndex = BackwardLetterСonversion(thirdRotor.Replacements, letterIndex + (thirdRotor.Position - 1), step.EncryptionSequence);
            letterIndex = BackwardLetterСonversion(secondRotor.Replacements, letterIndex - ((thirdRotor.Position - 1) - (secondRotor.Position - 1)), step.EncryptionSequence);
            letterIndex = BackwardLetterСonversion(firstRotor.Replacements, letterIndex - ((secondRotor.Position - 1) - (firstRotor.Position - 1)), step.EncryptionSequence);
            letterIndex = BackwardLetterСonversion(plugboard, letterIndex - (firstRotor.Position - 1), step.EncryptionSequence);
            return Configuration.Alphabet[letterIndex];
        }

        /// <summary>
        /// Вспомогательный метод для прохода буквы до рефлектора.
        /// </summary>
        /// <param name="replacements"></param>
        /// <param name="index"></param>
        /// <param name="encrSeq"></param>
        /// <returns></returns>
        private static int ForwardLetterСonversion(char[] replacements, int index, List<int> encrSeq)
        {
            encrSeq.Add(index = Mod(index));
            int result = Array.IndexOf(Configuration.Alphabet, replacements[index]);
            encrSeq.Add(result);
            return result;
        }

        /// <summary>
        /// Вспомогательный метод для проходы буквы от рефлектора.
        /// </summary>
        /// <param name="replacements"></param>
        /// <param name="index"></param>
        /// <param name="encrSeq"></param>
        /// <returns></returns>
        private static int BackwardLetterСonversion(char[] replacements, int index, List<int> encrSeq)
        {
            encrSeq.Add(index = Mod(index));
            int result = Array.IndexOf(replacements, Configuration.Alphabet[index]);
            encrSeq.Add(result);
            return result;
        }

        /// <summary>
        /// Метод для работы с индексом по модулю длины алфавита, так как ротор круглый.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private static int Mod(int index)
        {
            if (index > Configuration.ALPH_LENGTH - 1)
                return index -= Configuration.ALPH_LENGTH;
            else if (index < 0)
                return index += Configuration.ALPH_LENGTH;
            return index;
        }
    }
}
