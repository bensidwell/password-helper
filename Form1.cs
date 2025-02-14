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
        int numberOfUniqueCharacters = (ALPHABET.Length * 2) + NUMBERS.Length + SYMBOLS.Length;

        // Generate the password
        string password = "";
        for (int i = 0; i < DEFAULT_PASSWORD_LENGTH; i++)
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

    }
}
