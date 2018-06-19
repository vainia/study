using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageWithSecretLibrary.Interfaces;
using ImageWithSecretLibrary.Modules;

namespace ImageWithSecretLibrary
{
    public class DNLC : ICompression
    {
        public DNLC()
        {
        }

        public static string CompressionName = "Deflane No Lost Compression";

        public byte[] ZipStr(String str)
        {
            using (MemoryStream output = new MemoryStream())
            {
                using (DeflateStream gzip =
                  new DeflateStream(output, CompressionMode.Compress))
                {
                    using (StreamWriter writer =
                      new StreamWriter(gzip, System.Text.Encoding.UTF8))
                    {
                        writer.Write(str);
                    }
                }

                return output.ToArray();
            }
        }

        public string UnZipStr(byte[] input)
        {
            using (MemoryStream inputStream = new MemoryStream(input))
            {
                using (DeflateStream gzip =
                  new DeflateStream(inputStream, CompressionMode.Decompress))
                {
                    using (StreamReader reader =
                      new StreamReader(gzip, System.Text.Encoding.UTF8))
                    {
                        try
                        {
                            return reader.ReadToEnd();
                        }
                        catch
                        {
                            return "Incorrect key!";
                        }
                    }
                }
            }
        }

        public byte[] Compression(byte[] plainText)
        {
            return ZipStr((new StringData()).ToObject(plainText));
        }
        public byte[] Recovery(byte[] plainText)
        {
            return (new StringData()).ToBytes(UnZipStr(plainText));
        }
        public byte GetID()
        {
            return 0b00000001;
        }
    }
}
