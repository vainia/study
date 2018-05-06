using LibConvert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study
{
    public partial class Form1 : Form
    {
        private Bitmap imageOriginal;
        private Bitmap imageEncrypted;
        private Aes AesKeys = Aes.Create();

        //private int countBitsToWrite = 4;
        private bool R_Available = true;
        private bool G_Available = true;
        private bool B_Available = true;


        public Form1()
        {
            InitializeComponent();
            AesKeys.Padding = PaddingMode.PKCS7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Image";
            openFileDialog1.Filter = "Image (*.png, *.jpg)|*.png; *.jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var upload = new Bitmap(openFileDialog1.FileName);
                imageOriginal = new Bitmap(upload.Width, upload.Height, PixelFormat.Format32bppPArgb);
                using (Graphics gr = Graphics.FromImage(imageOriginal)) {
                    gr.DrawImage(upload, new Rectangle(0, 0, imageOriginal.Width, imageOriginal.Height));
                }
                pictureBox1.Image = imageOriginal;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxKey.Text = Convert.ToBase64String(AesKeys.Key);
            //textBoxKey2.Text = Convert.ToBase64String(AesKeys.Key);
            textBoxIV.Text = Convert.ToBase64String(AesKeys.IV);
            //textBoxIV2.Text = Convert.ToBase64String(AesKeys.IV);

            var obj = new LibConverter(imageOriginal)
                .SetR(R_Available)
                .SetG(G_Available)
                .SetB(B_Available);
            obj = obj.SetDataToEncrypt(textBox1.Text);
            obj = obj.AESEncryptData(AesKeys.Key, AesKeys.IV);

            imageEncrypted = new Bitmap(obj.Do());
            pictureBox2.Image = imageEncrypted;
        }

        private void buttonSaveEnc_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Png Image (.png)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                imageEncrypted.Save(saveFileDialog1.FileName, ImageFormat.Png);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var obj = new LibConverter(imageOriginal).SetEncodedImage(imageEncrypted);
            var a = obj.Decrypt(AesKeys.Key, AesKeys.IV);
            textBoxEnc2.Text = a.ToString();
        }

        bool side = true;
        private void testBTN_Click(object sender, EventArgs e)
        {
            int keylen = (int)offsetTEST.Value;
            byte[] text = Encoding.UTF8.GetBytes(testBOX.Text.ToString());

            offsetTEST.Visible = false;
            testKEY.Visible = false;

            if (side)
            {
                if (radioButton1.Checked)
                {
                    text = ADD.Encrypt(text, testKEY.Text);
                    testKEY.Visible = true;
                }
                else if (radioButton2.Checked)
                {
                    SHI.Encrypt(text, (new String('K', keylen)));
                    offsetTEST.Visible = true;
                }
                else if (radioButton3.Checked)
                    text = INV.Encrypt(text);
            }
            else
            {
                if (radioButton1.Checked)
                {
                    byte[] data = testBOX.Text.Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();
                    text = ADD.Decrypt(data, testKEY.Text);
                    testKEY.Visible = true;
                }
                else if (radioButton2.Checked)
                {
                    SHI.Decrypt(text, (new String('K', keylen)));
                    offsetTEST.Visible = true;
                }
                else if (radioButton3.Checked)
                {
                    // Return string of HEX to normal byte state
                    byte[] data = testBOX.Text.Split('-').Select(b => Convert.ToByte(b, 16)).ToArray(); 
                    text = INV.Decrypt(data);
                }
            }
            if((radioButton3.Checked || radioButton1.Checked) && side)
                // Converting byte array into string of HEX with '-' separator, because UTF8 deforms it
                testBOX.Text = BitConverter.ToString(text);
            else
                testBOX.Text = Encoding.UTF8.GetString(text);
            side = !side;
        }
    }
}
