using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOAssignment.Controller;

class LogicController
{
    public StringBuilder Encrypt(string input)
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
                // Shift the character and wrap around using the alphabet length.
                result.Append((char)(((c - offset + CaesarShift) % AlphabetLength) + offset));
            }
            else
            {
                // Non-letter characters are added unchanged.
                result.Append(c);
            }
        }

        return result;
    }

    /// <summary>
    /// Decrypts the input string that was encrypted using a Caesar cipher by shifting each letter backward.
    /// Non-letter characters remain unchanged.
    /// </summary>
    /// <param name="input">The encrypted text to decrypt.</param>
    /// <returns>The decrypted string.</returns>
    public StringBuilder Decrypt(string input)
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

        return result;
    }

    /// <summary>
    /// Attempts to detect if text is encrypted by calculating its entropy
    /// </summary>
    public bool IsLikelyEncrypted(string text)
    {
        if (string.IsNullOrEmpty(text))
            return false;

        // Calculate character frequency
        Dictionary<char, int> charFrequency = new Dictionary<char, int>();
        foreach (char c in text)
        {
            if (charFrequency.ContainsKey(c))
                charFrequency[c]++;
            else
                charFrequency[c] = 1;
        }

        // Calculate entropy
        double entropy = 0;
        int textLength = text.Length;
        foreach (var freq in charFrequency.Values)
        {
            double probability = (double)freq / textLength;
            entropy -= probability * Math.Log(probability, 2);
        }

        // Higher entropy often indicates encryption or compression
        // This threshold may need adjustment based on your specific use case
        return entropy > 4.0;
    }

    /// <summary>
    /// Checks if the text has a character distribution typical of natural language
    /// </summary>
    public bool HasNaturalLanguageDistribution(string text)
    {
        if (text.Length < 100) // Need enough text for meaningful analysis
            return true; // Can't determine with short text

        // English letter frequency in normal text (approximate)
        Dictionary<char, double> englishFreq = new Dictionary<char, double>
    {
        {'e', 0.12}, {'t', 0.09}, {'a', 0.08}, {'o', 0.07}, {'i', 0.07},
        {'n', 0.07}, {'s', 0.06}, {'h', 0.06}, {'r', 0.06}, {'d', 0.04}
    };

        // Calculate letter distribution in the text
        Dictionary<char, int> letterCount = new Dictionary<char, int>();
        int totalLetters = 0;

        foreach (char c in text.ToLower())
        {
            if (char.IsLetter(c))
            {
                if (letterCount.ContainsKey(c))
                    letterCount[c]++;
                else
                    letterCount[c] = 1;

                totalLetters++;
            }
        }

        // Calculate deviation from expected English distribution
        double deviationSum = 0;
        foreach (var pair in englishFreq)
        {
            double observed = letterCount.ContainsKey(pair.Key) ?
                (double)letterCount[pair.Key] / totalLetters : 0;
            deviationSum += Math.Abs(observed - pair.Value);
        }

        // Lower deviation suggests natural language
        // Higher suggests possible encryption
        return deviationSum < 0.3; // Threshold needs tuning
    }

    /// <summary>
    /// Attempts to determine if a file is encrypted with Caesar cipher
    /// </summary>
    public bool IsCaesarCipherEncrypted(string text)
    {
        // Try to decrypt with your known Caesar shift
        string decrypted = Decrypt(text).ToString();

        // Check if decrypted text has more common English words than the original
        return CountCommonEnglishWords(decrypted) > CountCommonEnglishWords(text);
    }

    public int CountCommonEnglishWords(string text)
    {
        // List of common English words
        HashSet<string> commonWords = new HashSet<string> {
        "the", "be", "to", "of", "and", "a", "in", "that", "have", "I",
        "it", "for", "not", "on", "with", "he", "as", "you", "do", "at"
    };

        string[] words = text.ToLower().Split(new[] { ' ', '.', ',', '!', '?', ';', ':', '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries);

        int count = 0;
        foreach (string word in words)
        {
            if (commonWords.Contains(word))
                count++;
        }

        return count;
    }

}
