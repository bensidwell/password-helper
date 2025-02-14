namespace PasswordHelper;

public partial class Form1 : Form
{
    // Random generator with a random seed
    private static Random RANDOM = new Random(Guid.NewGuid().GetHashCode());

    // The alphabet for pulling letters from
    private static readonly char[] ALPHABET =
        {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

    // Some symbols to pull from (short to avoid tripping websites that don't allow certain symbols)
    private static readonly char[] SYMBOLS =
        {'!','?'};

    // Numbers 0-9 to pull numbers from
    private static readonly char[] NUMBERS =
        {'0','1','2','3','4','5','6','7','8','9'};


    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }


    private void generateButton_Click(object sender, EventArgs e)
    {
        generatePasswordTextBox.Text = "Reccommended Password";
    }

    

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private string generatePassword()
    {
        return "recommended password";
    }

    private void assessButton_Click(object sender, EventArgs e)
    {
        // Pull in the user's password and assess it's strength
        string userPassword = enterPasswordTextBox.Text;

    }
}
