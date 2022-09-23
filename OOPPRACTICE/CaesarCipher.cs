using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPRACTICE
{
    public  class CaesarCipher
    {
        private char Cipher(char ch,int key)
        {
            if (!char.IsLetter(ch))
                return ch;
            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);
        }
        public string Encryption(string text,int key)
        {
            string output=string.Empty;
            foreach(char ch in text)
            {
                output += Cipher(ch,key);
            }
            return output;
        }
        public string Decryption(string text, int key)
        {
            return Encryption(text, 26-key);
        }
    }
}
