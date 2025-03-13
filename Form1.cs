using System.Text;

namespace FileIOAssignment;

public partial class Form1 : Form
{


    public Form1()
    {
        InitializeComponent();
    }

    private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
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
            // Display file content in the RichTextBox.
            rTxtBxContent.Text = fileContents;
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
            // Example content to save.
            string fileContents = "This is an example content to save in the file.";
            // Write the content to the file.
            File.WriteAllText(filePath, fileContents);
            MessageBox.Show("File saved successfully.", "Save File");
        }
    }



    /// <summary>
    /// Decrypts the input string that was encrypted using a Caesar cipher by shifting each letter backward.
    /// Non-letter characters remain unchanged.
    /// </summary>
    /// <param name="input">The encrypted text to decrypt.</param>
    /// <returns>The decrypted string.</returns>
    private string Decrypt(string input)
    {
        // Constant for the Caesar cipher shift value.
        const int CaesarShift = 3;

        // Constant for the number of letters in the English alphabet.
        const int AlphabetLength = 26;

        StringBuilder result = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                // Determine if the character is uppercase or lowercase.
                char offset = char.IsUpper(c) ? 'A' : 'a';
                // Shift the character back by subtracting the shift value. Adding AlphabetLength ensures a positive modulo result.
                result.Append((char)(((c - offset - CaesarShift + AlphabetLength) % AlphabetLength) + offset));
            }
            else
            {
                // Non-letter characters are added unchanged.
                result.Append(c);
            }
        }

        return result.ToString();
    }
    /// <summary>
    /// Encrypts the content of the RichTextBox using a Caesar cipher by shifting each letter forward.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnEncrypt_Click(object sender, EventArgs e)
    {
        // Constant for the Caesar cipher shift value.
        const int CaesarShift = 3;

        // Constant for the number of letters in the English alphabet.
        const int AlphabetLength = 26;
        StringBuilder result = new StringBuilder();

        foreach (char c in rTxtBxContent.Text)
        {
            if (char.IsLetter(c))
            {
                // Determine if the character is uppercase or lowercase.
                char offset = char.IsUpper(c) ? 'A' : 'a';
                // Shift the character and wrap around using the alphabet length.
                result.Append((char)(((c - offset + CaesarShift) % AlphabetLength) + offset));
            }
            else
            {
                // Non-letter characters are added unchanged.
                result.Append(c);
            }
        }

        rTxtBxEncrypted.Text = result.ToString();
    }
}
