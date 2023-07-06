using GoogleTranslateApi;
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
            string translatedContent = await translate.TranslateContent((LanguagesType)FromComboBox.SelectedValue, (LanguagesType)ToComboBox.SelectedValue, ContentTextBox.Text);
            ResultTextBox.Text = translatedContent;
        }
    }
}