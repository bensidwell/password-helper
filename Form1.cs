using System.Text.RegularExpressions;

namespace PasswordHelper;

public partial class Form1 : Form
{
    // Random generator with a random seed
    private Random RANDOM = new Random(Guid.NewGuid().GetHashCode());

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
    private readonly int DEFAULT_PASSWORD_LENGTH = 15;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        passwordLengthTextBox.Text = "15";
    }


    private void generateButton_Click(object sender, EventArgs e)
    {
        generatePasswordTextBox.Text = generatePassword();
    }

    /// <summary>
    /// Generates a random password of 15 characters with letters (upper and lowercase), 
    /// numbers, and a symbol or two.
    /// </summary>
    /// <returns>The randomly generated password</returns>
    private string generatePassword()
    {
        // Check for custom password length
        int passwordLength;
        if (!int.TryParse(passwordLengthTextBox.Text, out passwordLength))
        {
            passwordLength = DEFAULT_PASSWORD_LENGTH;
            passwordLengthTextBox.Text = "INVALID LENGTH\nLength reset to 15";
        }


        int numberOfUniqueCharacters = (ALPHABET.Length * 2) + NUMBERS.Length + SYMBOLS.Length;

        // Generate the password
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
            passwordStrengthBar.Value = 0;
        }
        else
        {
            // Assess the strength of the password
            int score = assessStrength(userPassword);
            strengthLabel.Text = "Password Strength: " + score;
            passwordStrengthBar.Value = score;
        }
    }

    private bool passwordIsValid(string password)
    {
        return password.Contains(' ') 
            || password.Contains('\n')
            || password.Contains('\t');
    }

    /// <summary>
    /// Assess the strength of the given string based on
    /// three major categories:
    ///     Length
    ///     Character diversity
    ///     Order of characters
    /// </summary>
    /// <param name="password"></param>
    /// <returns></returns>
    private int assessStrength(string password)
    {
        int score = 0;

        // Rate the length
        if (password.Length == 0)
            return 0;
        if (password.Length < 5)
            score += 5;
        else if (password.Length < 10)
            score += 15;
        else
            score += 30;

        // Rate the diversity of characters
        if (password.All(ch => char.IsLetter(ch)))
            score += 10; // Password is only letters
        else if (password.All(ch => char.IsDigit(ch)))
            score += 10; // Password is only numbers
        else if (password.All(ch => char.IsLetterOrDigit(ch)))
            score += 20; // Password is numbers and letters

        // Rate the order of the characters
        Regex numberRegex = new Regex(@"\d+||[A-Z]+||\?+||\!+");
        string[] passwordParts = numberRegex.Split(password);
        if (passwordParts.Length * 5 - 5 > 50)
            score += 50;
        else
            score += passwordParts.Length * 5 - 5;

        return score;
    }
}
