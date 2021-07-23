using System;
using System.Resources;

namespace JasonJT_Web.Resources.Gender.Result.Sex
{
    public class LanguageHandler
    {

        private static String language = "de-DE";//ConfigManager.language;
        private static ResourceManager resourceManager;

        public static String loadDBValue(String searchWord)
        {
            if (language == "de-DE")
            {
                resourceManager = new ResourceManager(typeof(DE));
            }
            else if (language == "en-EN")
            {
                resourceManager = new ResourceManager(typeof(EN));
            }

            if (resourceManager.GetString(searchWord) != null)
                return resourceManager.GetString(searchWord);
            else
                return "NULL";

        }

    }
}