using GoogleTranslateApi;
using System.Speech.Synthesis;
using TranslatorApp.TranslateLayer;
namespace TranslatorApp
{
    public partial class TranslatorApp : Form
    {
        Translate translate;
        public TranslatorApp()
        {
            translate = new Translate();
            InitializeComponent();
        }

        private void TranslatorApp_Load(object sender, EventArgs e)
        {
            var languages = translate.GetAllLanguages();
            FromComboBox.DataSource = translate.GetAllLanguages();
            ToComboBox.DataSource = translate.GetAllLanguages();

        }

        private async void TranslateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ContentTextBox.Text))
            {
                MessageBox.Show("Write a text for translating", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string translatedContent = await translate.TranslateContent((LanguagesType)FromComboBox.SelectedValue, (LanguagesType)ToComboBox.SelectedValue, ContentTextBox.Text);
            ResultTextBox.Text = translatedContent;
            PlaySoundLabel.Visible = true;
        }

        private void PlaySoundLabel_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SpeakAsync(ResultTextBox.Text);
        }

        private void TransferLabel_Click(object sender, EventArgs e)
        {
            var fromLanguge = FromComboBox.SelectedValue;
            var toLanguage = ToComboBox.SelectedValue;
            FromComboBox.SelectedItem = toLanguage;
            ToComboBox.SelectedItem = fromLanguge;
            if (!string.IsNullOrEmpty(ContentTextBox.Text) && !string.IsNullOrEmpty(ResultTextBox.Text))
            {
                string temp = ContentTextBox.Text;
                ContentTextBox.Text = ResultTextBox.Text;
                ResultTextBox.Text = temp;
            }
        }
    }
}