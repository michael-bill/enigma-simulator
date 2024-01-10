using EnigmaSimulator.Enigma.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSimulator.Enigma
{
    class EncryptionManagement
    {
        /// <summary>
        /// Организовывает логику передвижения роторов.
        /// Выполняется перед каждой новой буквой.
        /// </summary>
        /// <param name="rot1"></param>
        /// <param name="rot2"></param>
        /// <param name="rot3"></param>
        public static void RotorMovement(Rotor rot1, Rotor rot2, Rotor rot3)
        {
            if (rot1.Position == rot1.ShiftPosition)
            {
                rot2.Position++;
                if (rot2.Position == rot2.ShiftPosition) rot3.Position++;
            }
            else if (rot2.Position == rot2.ShiftPosition)
            {
                rot2.Position++;
                rot3.Position++;
            }
            rot1.Position++;
            if (rot1.Position > Configuration.ALPH_LENGTH) rot1.Position = 1;
            if (rot2.Position > Configuration.ALPH_LENGTH) rot2.Position = 1;
            if (rot3.Position > Configuration.ALPH_LENGTH) rot3.Position = 1;
        }

        /// <summary>
        /// Основной метод для отправки буквы на шифрование.
        /// Метод реализовывает дополнительную логику работы машины.
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        public static char StartEncryption(char letter)
        {
            if (Configuration.EncryptionSteps.Count == 0)
                Configuration.Key = new Key(Configuration.Compartments, Configuration.Plugboard);
            RotorMovement(Configuration.Compartments[0], Configuration.Compartments[1], Configuration.Compartments[2]);
            EncryptionStep step = new EncryptionStep(new int[] {
                Configuration.Compartments[0].Position,
                Configuration.Compartments[1].Position,
                Configuration.Compartments[2].Position
            });
            char encrLetter = Encryption.Encrypt(
                letter,
                Configuration.Compartments[0],
                Configuration.Compartments[1],
                Configuration.Compartments[2],
                Configuration.ReflectorСompartment,
                Configuration.Plugboard,
                step
                );
            Configuration.EncryptionSteps.Add(step);
            return encrLetter;
        }

        /// <summary>
        /// Откат на одну букву.
        /// </summary>
        public static void StepBack()
        {
            if (Configuration.EncryptionSteps.Count > 1) {
                for (int i = 0; i < Configuration.Compartments.Length; i++)
                    Configuration.Compartments[i].Position = Configuration.EncryptionSteps[Configuration.EncryptionSteps.Count - 2].RotorPositions[i];
            } else {
                for (int i = 0; i < Configuration.Compartments.Length; i++)
                    Configuration.Compartments[i].Position = Configuration.Key.Compartments[i].Position;
                Configuration.Key = null;

            }
            Configuration.EncryptionSteps.RemoveAt(Configuration.EncryptionSteps.Count - 1);
        }

        /// <summary>
        /// Тотальный откат.
        /// </summary>
        public static void RollBack()
        {
            for (int i = 0; i < Configuration.Compartments.Length; i++)
                Configuration.Compartments[i].Position = Configuration.Key.Compartments[i].Position;
            Configuration.Key = null;
            Configuration.EncryptionSteps.Clear();
        }

        /// <summary>
        /// Переставляет местами две буквы на коммутационной панели
        /// </summary>
        /// <param name="plugboard"></param>
        /// <param name="letter1"></param>
        /// <param name="letter2"></param>
        public static void PlugboardPermutation(char[] plugboard, char letter1, char letter2)
        {
            int index1 = Array.IndexOf(Configuration.Plugboard, letter1), index2 = Array.IndexOf(Configuration.Plugboard, letter2);
            plugboard[index1] = letter2;
            plugboard[index2] = letter1;
        } 
    }
}
