using ImageWithSecretLibrary;
using ImageWithSecretLibrary.Interfaces;
using ImageWithSecretLibrary.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageWithSecretForms
{
    public partial class MainForm : Form
    {
        private Bitmap dragImage = (Bitmap)Image.FromFile(System.IO.Path.GetFullPath(@"..\..\..\Images\") + "drag_n_drop_on_hover.png", true);
        private Bitmap imageHider = null;
        private Bitmap ImageOriginalHider { get { return imageHider; } set { imageHider = value == null ? null : ImageWithSecret<string>.ConvertTo32bpp(value); } }
        private Bitmap imageOriginalHide = null;
        private Bitmap imageHidden = null;
        private Bitmap droppedImage = null;

        double hiderSize;
        double hideSize;
        string droppedPath;

        private string dataToEncrypt = null;

        public MainForm()
        {
            InitializeComponent();
            InitializeCheckBoxesLists(this.listOfEncryptions, "EncryptionName", false);
            InitializeCheckBoxesLists(this.listOfCompressions, "CompressionName", true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void LimitCheckedListBoxMaxSelection(CheckedListBox checkedLB, int maxCount)
        {
            checkedLB.ItemCheck += (o, args) =>
            {

                if (checkedLB.CheckedItems.Count == maxCount)
                {
                    if (!checkedLB.GetItemChecked(checkedLB.SelectedIndex))
                        (args as ItemCheckEventArgs).NewValue = (args as ItemCheckEventArgs).CurrentValue;
                }
            };

        }

        private void InitializeCheckBoxesLists(CheckedListBox checkList, string fieldName, bool compression)
        {
            foreach (var encryptionClass in GetAllEntities(compression))
            {
                string name = (string)encryptionClass.GetField(fieldName).GetValue(null);
                checkList.Items.Add(name);
            }
        }

        public List<System.Type> GetAllEntities(bool compression)
        {
            Type method = compression ? typeof(ImageWithSecretLibrary.Interfaces.ICompression) : typeof(ImageWithSecretLibrary.Interfaces.IEncrypt);
            IEncrypt forCount = new ADD("simple_key");
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                 .Where(x => method.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                 .ToList();
        }

        private void HideModeSwitcher_Click(object sender, EventArgs e)
        {
            if (hideModeSwitcher.Text == "Text")
            {
                if (textKey.Text != "" && pictureHider.Image != null) buttonEncrypt.Enabled = true;
                pictureHide.Image = imageOriginalHide;
                HideModePicture("Picture");
            }
            else if (hideModeSwitcher.Text == "Picture To Reveal")
            {
                if(textKey.Text != "" && pictureHider.Image != null) buttonEncrypt.Enabled = true;
                hideModeSwitcher.Text = "Text";
                pictureHide.Visible = false;
                textToHide.Visible = true;
                buttonOpenDialogHide.Visible = false;
                labelDropHide.Visible = false;
            }
            else 
            {
                buttonEncrypt.Enabled = false;
                pictureHide.Image = null;
                HideModePicture("Picture To Reveal");
            }
        }

        private void HideModePicture(String name)
        {
            hideModeSwitcher.Text = name;
            pictureHide.Visible = true;
            textToHide.Visible = false;
            if (pictureHide.Image == null)
            {
                buttonOpenDialogHide.Visible = true;
                labelDropHide.Visible = true;
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
        }

        private void ButtonOpenDialog_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open Image";
            openFileDialog.Filter = "Image (*.png, *.jpg)|*.png; *.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (sender.Equals(buttonOpenDialogHide)) 
                {
                    if (hideModeSwitcher.Text == "Picture To Reveal")
                    {
                        imageHidden = new Bitmap(openFileDialog.FileName);
                        pictureHidden.Image = imageHidden;
                        labelHidden.Visible = true;
                        if (hideModeSwitcher.Text == "Picture To Reveal" && textKey.Text != "") buttonDecrypt.Enabled = true;
                    }
                    else
                    {
                        imageOriginalHide = new Bitmap(openFileDialog.FileName);
                        pictureHide.Image = imageOriginalHide;
                        DragElementsVisibility(true, false);
                        ShowMessageAboutSize(openFileDialog.FileName);
                    }
                }
                else
                {
                    ImageOriginalHider = new Bitmap(openFileDialog.FileName);
                    pictureHider.Image = ImageOriginalHider;
                    if (textKey.Text != "") buttonEncrypt.Enabled = true;
                    DragElementsVisibility(false, false);
                    ShowMessageAboutPixels();
                }
                if (hideModeSwitcher.Text == "Picture To Reveal") buttonEncrypt.Enabled = false;
            }
        }

        private void ShowMessageAboutPixels()
        {
            if (checkBoxTips.Checked)
                MessageBox.Show("In currently selected hider picture you can hide: " + (hiderSize = ((imageHider.Size.Width * imageHider.Size.Height) * 12) / 8 / 1024 / 1024.0) + "Megabytes", "Disclaimer", MessageBoxButtons.OK);
        }

        private void ShowMessageAboutSize(String path)
        {
            if (checkBoxTips.Checked)
                MessageBox.Show("Currently selected picture to hide have size: " + (hideSize = new System.IO.FileInfo(path).Length / 1024 / 1024.0) + "Megabytes", "Disclaimer", MessageBoxButtons.OK);
        }

        private void DragElementsVisibility(Boolean hide, Boolean visible)
        {
            if (hide)
            {
                labelDropHide.Visible = visible;
                buttonOpenDialogHide.Visible = visible;
            }
            else
            {
                buttonOpenDialogHider.Visible = visible;
                labelDropHider.Visible = visible;
            }
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            labelHidden.Visible = false;
            pictureHidden.Image = null;
            pictureHide.Image = null;
            pictureHider.Image = null;
            textToHide.Text = null;
            imageOriginalHide = null;
            ImageOriginalHider = null;
            droppedImage = null;
            textKey.Text = "";
            buttonEncrypt.Enabled = false;
            buttonDecrypt.Enabled = false;
            buttonOpenDialogHider.Visible = true;
            labelDropHider.Visible = true;
            if(hideModeSwitcher.Text != "Text")
            {
                buttonOpenDialogHide.Visible = true;
                labelDropHide.Visible = true;
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void MainForm_DragOver(object sender, DragEventArgs e)
        {
            Drop_Area_Checker(pictureHide, false, e);
            Drop_Area_Checker(pictureHider, false, e);
        }

        private void Drop_Area_Checker(PictureBox dropArea, Boolean dropped, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;
            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= dropArea.Location.X && x <= dropArea.Location.X + dropArea.Width && y >= dropArea.Location.Y && y <= dropArea.Location.Y + dropArea.Height)
            {
                if (dropped)
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    droppedPath = files[0];
                    droppedImage = (Bitmap)Image.FromFile(files[0]);
                    if (hideModeSwitcher.Text == "Picture To Reveal" && dropArea == pictureHide)
                    {
                        buttonEncrypt.Enabled = false;
                        pictureHidden.Image = droppedImage;
                        labelHidden.Visible = true;
                        pictureHide.Image = null;
                    }
                    else
                    {
                        dropArea.Image = droppedImage;
                        if (textKey.Text != "") buttonEncrypt.Enabled = true;
                    }
                }
                else if (dropArea.Image != dragImage)
                {
                    dropArea.Image = dragImage;
                }
                if (dropArea == pictureHide)
                {
                    DragElementsVisibility(true, false);
                    if (dropped)
                        if (hideModeSwitcher.Text == "Picture To Reveal")
                        {
                            DragElementsVisibility(true, true);
                            imageHidden = droppedImage;
                        }
                        else
                        {
                            imageOriginalHide = droppedImage;
                            ShowMessageAboutSize(droppedPath);
                        }
                }
                else
                {
                    if (dropped)
                    {
                        ImageOriginalHider = droppedImage;
                        ShowMessageAboutPixels();
                    }
                    DragElementsVisibility(false, false);
                }
            }
            else if (dropArea.Image == dragImage)
            {
                if (hideModeSwitcher.Text == "Picture To Reveal" && dropArea == pictureHide) dropArea.Image = null;
                else dropArea.Image = dropArea == pictureHide ? imageOriginalHide : ImageOriginalHider;
                if (dropArea == pictureHide && hideModeSwitcher.Text != "Text" && (dropArea.Image == dragImage || dropArea.Image == null)) DragElementsVisibility(true, true);
                else if (dropArea != pictureHide && (dropArea.Image == dragImage || dropArea.Image == null)) DragElementsVisibility(false, true);
            }
            if (hideModeSwitcher.Text == "Picture To Reveal")
            {
                buttonEncrypt.Enabled = false;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            Drop_Area_Checker(pictureHide, true, e);
            Drop_Area_Checker(pictureHider, true, e);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (pictureHidden.Image == null) return;
            saveFileDialog.Filter = "Png Image (.png)|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog.FileName)) File.Delete(saveFileDialog.FileName);
                pictureHidden.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }

        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            if (hideSize > hiderSize)
            {
                MessageBox.Show("Please, select another image!");
                return;
            }
            if (hideModeSwitcher.Text == "Text" && (dataToEncrypt = textToHide.Text.ToString()) == "")
                dataToEncrypt = "empty";
            else 
                if (hideModeSwitcher.Text == "Picture" && pictureHide.Image == null) dataToEncrypt = "empty";
                else if (hideModeSwitcher.Text == "Picture") dataToEncrypt = AES.Base64Encode(ImageWithSecret<string>.ImageToByteArray(pictureHide.Image));

            var lib = new ImageWithSecret<string>
            {
                ImageModifying = ImageOriginalHider,
                DataReader = new StringData(),
                WriteReadData = new EmptyWriteReadPixelData()
            };

            if (checkInteractive.Checked) lib.interactive = true;

            foreach (var checkedItems in listOfEncryptions.CheckedItems)
            {
                foreach (var encryptionClass in GetAllEntities(false))
                {
                    if ((string)encryptionClass.GetField("EncryptionName").GetValue(null) == checkedItems.ToString())
                        if (encryptionClass.Name == "SHI") lib.Encrypts.Add(new SHI(textKey.Text, SHI.Operator.LEFT));
                        else lib.Encrypts.Add((IEncrypt)Activator.CreateInstance(encryptionClass, new Object[] { textKey.Text }));
                }
            }
            foreach (var checkedItems in listOfCompressions.CheckedItems)
            {
                foreach (var compressionClass in GetAllEntities(true))
                {
                    if ((string)compressionClass.GetField("CompressionName").GetValue(null) == checkedItems.ToString())
                        lib.DataCompression = (ICompression)Activator.CreateInstance(compressionClass, null);
                }
            }
            imageHidden = lib.Encrypt(dataToEncrypt);
            pictureHidden.Image = imageHidden;
            buttonDecrypt.Enabled = true;
            labelHidden.Visible = true;
        }

        private void TextKey_TextChanged(object sender, EventArgs e)
        {
            if (textKey.Text == "" || textKey.Text == " " || pictureHider.Image == null) buttonEncrypt.Enabled = false;
            else buttonEncrypt.Enabled = true;
            if (textKey.Text == "" || textKey.Text == " " || pictureHidden.Image == null) buttonDecrypt.Enabled = false;
            else buttonDecrypt.Enabled = true;
            if (hideModeSwitcher.Text == "Picture To Reveal") buttonEncrypt.Enabled = false;
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            var lib = new ImageWithSecret<string>
            {
                ImageModifying = imageHidden,
                DataReader = new StringData(),
                WriteReadData = new EmptyWriteReadPixelData()
            };
            foreach (var encryptionClass in GetAllEntities(false))
            {
                if (encryptionClass.Name == "SHI") lib.Encrypts.Add(new SHI(textKey.Text, SHI.Operator.RIGHT));
                else lib.Encrypts.Add((IEncrypt)Activator.CreateInstance(encryptionClass, new Object[] { textKey.Text }));
            }
            foreach (var compressionClass in GetAllEntities(true))
            {
                lib.Compressions.Add((ICompression)Activator.CreateInstance(compressionClass, null));
            }
            var decryptedData = lib.Decrypt(null);
            textToHide.Text = decryptedData == "" ? "Incorrect key!" : decryptedData;
            imageOriginalHide = (Bitmap)ImageWithSecret<string>.ByteArrayToImage(AES.Base64Decode(decryptedData));
            hideModeSwitcher.Text = "Text";
            textToHide.Visible = true;
            pictureHide.Visible = false;
            buttonOpenDialogHide.Visible = false;
            labelDropHide.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LimitCheckedListBoxMaxSelection(listOfEncryptions, 2);
        }
    }
}
