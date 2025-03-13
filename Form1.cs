using FileIOAssignment.Controller;
using System.Text;

namespace FileIOAssignment;

public partial class Form1 : Form
{
    private readonly LogicController _logicController;
    public Form1()
    {
        InitializeComponent();
        _logicController = new LogicController();
    }

    private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ClearForm();
        using OpenFileDialog openFileDialog = new();
        // Start in the "My Documents" folder.
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        openFileDialog.Filter = "Text files (*.txt)|*.txt";
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            // Code to handle the file open.
            string filePath = openFileDialog.FileName;
            // Read the file content into a string.
            string fileContents = File.ReadAllText(filePath);
            DetectEncryption(fileContents);
        }
    }

    private void DetectEncryption(string fileContents)
    {
        bool caesarEncrypted = _logicController.IsCaesarCipherEncrypted(fileContents);
        bool likelyEncrypted = _logicController.IsLikelyEncrypted(fileContents);
        bool naturalText = _logicController.HasNaturalLanguageDistribution(fileContents);

        if (caesarEncrypted)
        {
            // If Encrypted with CeaserCipher, display in EncrytedInput
            rTxtBxEncryptedInput.Text = fileContents;
        }
        else if(naturalText)
        {
            // If not encrypted, display in UnEncryptedInput
            rTxtBxUnEncryptedInput.Text = fileContents;
        }

        else if (likelyEncrypted && !naturalText)
        {
            MessageBox.Show("This file may be encrypted with an unknown method.",
                "Possible Encrypted File", MessageBoxButtons.OK);
        }
    }

    private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using SaveFileDialog saveFileDialog = new();
        // Start in the "My Documents" folder.
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        saveFileDialog.Filter = "Text files (*.txt)|*.txt";
        saveFileDialog.RestoreDirectory = true;

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            // Code to handle the file save.
            string filePath = saveFileDialog.FileName;

            // Get the content from the appropriate text box with null-coalescing operator.
            // if rTxtBxEncryptedOutput is null, then use rTxtBxDecryptOutput.
            string fileContents = rTxtBxEncryptedOutput?.Text ?? rTxtBxDecryptOutput.Text;

            // Write the content to the file.
            File.WriteAllText(filePath, fileContents);
            MessageBox.Show("File saved successfully.", "Save File");
            ClearForm();
        }
    }

    private void BtnEncrypt_Click(object sender, EventArgs e)
    {
        StringBuilder result = _logicController.Encrypt(rTxtBxUnEncryptedInput.Text);

        rTxtBxEncryptedOutput.Text = result.ToString();
    }

    private void BtnDecrypt_Click(object sender, EventArgs e)
    {
        StringBuilder result = _logicController.Decrypt(rTxtBxEncryptedInput.Text);

        rTxtBxDecryptOutput.Text = result.ToString();
    }

    private void ClearForm()
    {
        rTxtBxUnEncryptedInput.Clear();
        rTxtBxEncryptedOutput.Clear();
        rTxtBxEncryptedInput.Clear();
        rTxtBxDecryptOutput.Clear();
    }
}
