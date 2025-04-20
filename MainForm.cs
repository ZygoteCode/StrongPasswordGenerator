using System.Windows.Forms;

public partial class MainForm : MetroSuite.MetroForm
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void guna2Button1_Click(object sender, System.EventArgs e)
    {
        if (!Microsoft.VisualBasic.Information.IsNumeric(guna2TextBox1.Text))
        {
            MessageBox.Show("Please, insert a valid number for the password length to generate.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int length = 0;

        try
        {
            length = int.Parse(guna2TextBox1.Text);
        }
        catch
        {
            MessageBox.Show("Please, insert a valid number for the password length to generate.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string characters = "";

        if (guna2CheckBox1.Checked)
        {
            characters += "abcdefghijklmnopqrstuvwxyz";
        }

        if (guna2CheckBox2.Checked)
        {
            characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        if (guna2CheckBox3.Checked)
        {
            characters += "0123456789";
        }

        if (guna2CheckBox4.Checked)
        {
            characters += "\"!\\£$%&/()=?ì'{}[]<>,;.:-_@#§";
        }

        if (characters == "")
        {
            MessageBox.Show("Please, select at least one checkbox.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ProtoRandom.ProtoRandom random = new ProtoRandom.ProtoRandom(100);
        guna2TextBox2.Text = random.GetRandomString(characters.ToCharArray(), int.Parse(guna2TextBox1.Text));
    }

    private void guna2Button2_Click(object sender, System.EventArgs e)
    {
        if (guna2TextBox2.Text != "")
        {
            try
            {
                Clipboard.SetText(guna2TextBox2.Text);
            }
            catch
            {

            }
        }
    }
}