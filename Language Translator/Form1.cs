namespace Language_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonItalian_Click(object sender, EventArgs e)
        {
            labelTranslation.Text = "Buongiorno";
        }

        private void buttonSpanish_Click(object sender, EventArgs e)
        {
            labelTranslation.Text = "Buenos Dias";
        }

        private void buttonGerman_Click(object sender, EventArgs e)
        {
            labelTranslation.Text = "Guten Morgen";
        }
    }
}