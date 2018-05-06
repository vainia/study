using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    // Shifting plaintext
    public static class SHI
    {
        public enum Operator
        {
            LEFT, RIGHT
        }

        public static byte[] Encrypt(byte[] plaintext, string key = "K", Operator mode = Operator.LEFT)
        {
            int offset = key.Length % 10;

            return ShiftBitArray(plaintext, offset, mode);
        }

        public static byte[] Decrypt(byte[] ciphertext, string key = "K")
        {
            return Encrypt(ciphertext, key, Operator.RIGHT);
        }

        public static byte[] ShiftBitArray(byte[] array, int offset, Operator mode)
        {
            switch (mode)
            {
                case Operator.LEFT:
                    for (int i = 0; i < 8 * offset; ++i)
                        RotateLeft(array);
                    break;
                case Operator.RIGHT:
                    for (int i = 0; i < 8 * offset; ++i)
                        RotateRight(array);
                    break;
            }
            return array;
        }

        // Rotates the bits in an array of bytes to the left.
        public static void RotateLeft(byte[] bytes)
        {
            bool carryFlag = ShiftLeft(bytes);

            if (carryFlag == true)
            {
                bytes[bytes.Length - 1] = (byte)(bytes[bytes.Length - 1] | 0x01);
            }
        }

        // Rotates the bits in an array of bytes to the right.
        public static void RotateRight(byte[] bytes)
        {
            bool carryFlag = ShiftRight(bytes);

            if (carryFlag == true)
            {
                bytes[0] = (byte)(bytes[0] | 0x80);
            }
        }

        // Shifts the bits in an array of bytes to the left.
        public static bool ShiftLeft(byte[] bytes)
        {
            bool leftMostCarryFlag = false;

            // Iterate through the elements of the array from left to right.
            for (int index = 0; index < bytes.Length; index++)
            {
                // If the leftmost bit of the current byte is 1 then we have a carry.
                bool carryFlag = (bytes[index] & 0x80) > 0;

                if (index > 0)
                {
                    if (carryFlag == true)
                    {
                        byte test1 = bytes[index - 1];
                        byte test2 = (byte)(bytes[index - 1] | 0x01);
                        byte test3 = bytes[index - 1] = (byte)(bytes[index - 1] | 0x01);
                        // Apply the carry to the rightmost bit of the current bytes neighbor to the left.
                        bytes[index - 1] = (byte)(bytes[index - 1] | 0x01);
                    }
                }
                else
                {
                    leftMostCarryFlag = carryFlag;
                }

                bytes[index] = (byte)(bytes[index] << 1);
            }

            return leftMostCarryFlag;
        }

        // Shifts the bits in an array of bytes to the right.
        public static bool ShiftRight(byte[] bytes)
        {
            bool rightMostCarryFlag = false;
            int rightEnd = bytes.Length - 1;

            // Iterate through the elements of the array right to left.
            for (int index = rightEnd; index >= 0; index--)
            {
                // If the rightmost bit of the current byte is 1 then we have a carry.
                bool carryFlag = (bytes[index] & 0x01) > 0;

                if (index < rightEnd)
                {
                    if (carryFlag == true)
                    {
                        // Apply the carry to the leftmost bit of the current bytes neighbor to the right.
                        bytes[index + 1] = (byte)(bytes[index + 1] | 0x80);
                    }
                }
                else
                {
                    rightMostCarryFlag = carryFlag;
                }

                bytes[index] = (byte)(bytes[index] >> 1);
            }

            return rightMostCarryFlag;
        }
    }
}

