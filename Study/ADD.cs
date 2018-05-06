using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public static class ADD
    {
        // XOR'es every plaintext with repeating key pattern
        public static byte[] Encrypt(byte[] plaintext, string key = "Key")
        {
            BitArray arr = new BitArray(plaintext);
            BitArray keyRepeat = new BitArray(plaintext);
            BitArray keyArr = new BitArray(Encoding.UTF8.GetBytes(key));
            int keyArrLen = keyArr.Length;

            for (int i = 0; i < keyRepeat.Length; i++)
            {
                keyRepeat[i] = keyArr[i % keyArrLen];
            }

            byte[] result = new byte[plaintext.Length];
            arr.Xor(keyRepeat).CopyTo(result, 0);
            return result;
        }

        public static byte[] Decrypt(byte[] ciphertext, string key = "Key")
        {
            return Encrypt(ciphertext, key);
        }
    }
}
