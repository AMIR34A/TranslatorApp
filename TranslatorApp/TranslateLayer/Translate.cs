using GoogleTranslateApi;

namespace TranslatorApp.TranslateLayer;

public class Translate
{
    GoogleApi googleApi;
    public Translate()
    {
        googleApi = new GoogleApi();
    }

    public List<LanguagesType> GetAllLanguages()
    {
        List<LanguagesType> languages = new List<LanguagesType>();

        foreach (var language in Enum.GetValues<LanguagesType>())
        {
            languages.Add(language);
        }
        return languages;
    }

    public async Task<string> TranslateContent(LanguagesType from,LanguagesType to,string content)
    {
        TranslatSetting translatSetting = new TranslatSetting() { FromLanguage = from, ToLanguage = to, Content = content };
        string result = await googleApi.TranslateAsync(translatSetting);
        return result;
    }
}

