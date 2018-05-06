using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public static class INV
    {
        public static byte[] Encrypt(byte[] plaintext)
        {
            byte[] encrypted = new byte[plaintext.Length];

            // Apply NOR operation for every bit of plaintext
            ((new BitArray(plaintext)).Not()).CopyTo(encrypted, 0);

            return encrypted;
        }

        public static byte[] Decrypt(byte[] ciphertext)
        {
            return Encrypt(ciphertext);
        }
    }
}
