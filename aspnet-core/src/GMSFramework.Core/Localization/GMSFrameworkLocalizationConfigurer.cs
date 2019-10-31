using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace GMSFramework.Localization
{
    public static class GMSFrameworkLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(GMSFrameworkConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(GMSFrameworkLocalizationConfigurer).GetAssembly(),
                        "GMSFramework.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
