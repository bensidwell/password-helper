using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace PasswordHelper;

public partial class Form1 : Form
{
    // Random generator with a random seed
    private readonly Random RANDOM = new Random(Guid.NewGuid().GetHashCode());

    // Regex pattern to seperate numbers, "?", "!", uppercase, and lower case characters
    private readonly Regex PATTERN = new Regex(@"\d+|\?+|\!+|[A-Z]+");

    // The alphabet for pulling letters from
    private readonly char[] ALPHABET =
        {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

    // Numbers 0-9 to pull numbers from
    private readonly char[] NUMBERS =
        {'0','1','2','3','4','5','6','7','8','9'};

    // Some symbols to pull from (short to avoid tripping websites that don't allow certain symbols)
    private readonly char[] SYMBOLS =
        {'!','?'};

    // Default password length
    private readonly int DEFAULT_PASSWORD_LENGTH = 20;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        passwordLengthTextBox.Text = DEFAULT_PASSWORD_LENGTH.ToString();
    }


    private void generateButton_Click(object sender, EventArgs e)
    {
        generatePasswordTextBox.Text = generatePassword();
    }

    /// <summary>
    /// Generates a random password of given length or DEFAULT_PASSWORD_LENGTH 
    /// characters with letters (upper and lowercase), numbers, and a symbol or two.
    /// </summary>
    /// <returns>The randomly generated password</returns>
    private string generatePassword()
    {
        // Check for custom password length
        if (!int.TryParse(passwordLengthTextBox.Text, out int passwordLength))
        {
            passwordLength = DEFAULT_PASSWORD_LENGTH;
            passwordLengthTextBox.Text = "INVALID LENGTH\nLength reset to 15";
        }

        // Generate the password
        int numberOfUniqueCharacters = (ALPHABET.Length * 2) + NUMBERS.Length + SYMBOLS.Length;
        string password = "";
        for (int i = 0; i < passwordLength; i++)
        {
            int nextSymbol = RANDOM.Next(numberOfUniqueCharacters);
            if (nextSymbol < ALPHABET.Length) // lower case letter
            {
                password += ALPHABET[RANDOM.Next(ALPHABET.Length)];
            }
            else if (nextSymbol < ALPHABET.Length * 2) // capital letter
            {
                password += Char.ToUpper(ALPHABET[RANDOM.Next(ALPHABET.Length)]);
            }
            else if (nextSymbol == (ALPHABET.Length * 2) + NUMBERS.Length) // number
            {
                password += NUMBERS[RANDOM.Next(NUMBERS.Length)];
            }
            else // symbol
            {
                password += SYMBOLS[RANDOM.Next(SYMBOLS.Length)];
            }
        }

        return password;
    }


    private void assessButton_Click(object sender, EventArgs e)
    {
        // Pull in the user's password and assess it's strength
        string userPassword = enterPasswordTextBox.Text;

        // Check validity of the password
        if (passwordIsValid(userPassword))
        {
            strengthLabel.Text = "Password Strength: Invalid";
            errorLabel.Text = "Please remove all white space";
            passwordStrengthBar.Value = 0;
            return;
        }

        // Reset error label
        errorLabel.Text = "";

        // Assess the strength of the password
        int score = assessStrength(userPassword);
        string strength = score switch
        {
            > 80 => "Very Strong",
            > 60 => "Strong",
            > 20 => "Moderate",
            _ => "Weak",
        };

        // Display the strength to the user
        strengthLabel.Text = "Password Strength: " + strength;
        passwordStrengthBar.Value = score;
    }

    /// <summary>
    /// Checks the validity of the given string as a password.
    /// Password is invalid if it contains a space, newline character,
    /// or tab character. 
    /// </summary>
    /// <param name="password">The string to check the validity of as a password</param>
    /// <returns>True if the password is valid, false otherwise</returns>
    private bool passwordIsValid(string password)
    {
        return password.Contains(' ') 
            || password.Contains('\n')
            || password.Contains('\t');
    }

    /// <summary>
    /// Assess the strength of the given string based on
    /// three major categories:
    ///     Length                (35)
    ///     Character diversity   (35)
    ///     Order of characters   (30)
    /// </summary>
    /// <param name="password">The string to assess the strength of as a password</param>
    /// <returns>An int 1-100 describing the password's strength</returns>
    private int assessStrength(string password)
    {
        int score = 0;

        // Rate the length
        if (password.Length == 0)
            return 0;
        if (password.Length < 8)
            score += 10;
        else if (password.Length < 15)
            score += 25;
        else
            score += 35;

        // Rate the diversity of characters
        if (password.All(ch => char.IsLetter(ch)))
            score += 5; // Password is only letters
        else if (password.All(ch => char.IsDigit(ch)))
            score += 10; // Password is only numbers
        else if (password.All(ch => char.IsLetterOrDigit(ch)))
            score += 25; // Password is numbers and letters
        else
            score += 35; // Password has symbols in it

        // Rate the order of the characters
        string[] passwordParts = PATTERN.Split(password);
        if (passwordParts.Length * 5 - 5 > 30)
            score += 30;
        else
            score += passwordParts.Length * 5 - 5;

        return score;
    }
}
