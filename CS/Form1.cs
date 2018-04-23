#region #usings
using DevExpress.XtraSpellChecker;
using System;
using System.Globalization;
#endregion #usings

namespace SpellCheckerExample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            memoEditToCheck.Text = @"This help system provides a a comprehansive information on using the XtraSpellChecker prodact (http://help.devexpress.com/#WindowsForms/CustomDocument2635). 
It contains a detailed description of the product's API, and also provides examples with step-by-step instractions, screenshot images and source code (both, C# and Visual Basic).

El asistete realiza automáticamente las modificacines en los ficheros de configuración. Si desea realizar una instalción manual siga estas instruciones:";

            LoadOpenOfficeDictionaries();

            //spellChecker1.Culture = new CultureInfo("en-US");
            //spellChecker1.Culture = new CultureInfo("es-ES");

            spellChecker1.Culture = CultureInfo.InvariantCulture;
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType;
        }

        private void LoadCustomDictionary() {
            #region #LoadCustomDictionary
            SpellCheckerCustomDictionary customDictionary = new SpellCheckerCustomDictionary();
            customDictionary.AlphabetPath = @"Dictionaries\EnglishAlphabet.txt";
            customDictionary.DictionaryPath = @"Dictionaries\CustomEnglish.dic";
            customDictionary.Culture = CultureInfo.InvariantCulture;
            spellChecker1.Dictionaries.Add(customDictionary);
            #endregion #LoadCustomDictionary
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            spellChecker1.Check(memoEditToCheck);
        }

        private void cmbDictionaryType_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cmbDictionaryType.SelectedIndex) {
                case 0:
                    LoadISpellDictionaries();
                    break;
                case 1:
                    LoadOpenOfficeDictionaries();
                    break;
                case 2:
                    LoadHunspellDictionaries();
                    break;
            }
        }

        private void LoadISpellDictionaries() {
            #region #LoadISpellDictionaries
            spellChecker1.Dictionaries.Clear();

            SpellCheckerISpellDictionary ispellDictionaryEnglish = new SpellCheckerISpellDictionary();
            ispellDictionaryEnglish.DictionaryPath = @"Dictionaries\ISpell\en_US\american.xlg";
            ispellDictionaryEnglish.GrammarPath = @"Dictionaries\ISpell\en_US\english.aff";
            ispellDictionaryEnglish.AlphabetPath = @"Dictionaries\EnglishAlphabet.txt";
            ispellDictionaryEnglish.Culture = new CultureInfo("en-US");
            ispellDictionaryEnglish.Load();
            spellChecker1.Dictionaries.Add(ispellDictionaryEnglish);
            #endregion #LoadISpellDictionaries

            SpellCheckerISpellDictionary ispellDictionarySpanish = new SpellCheckerISpellDictionary();
            ispellDictionarySpanish.DictionaryPath = @"Dictionaries\ISpell\es_ES\espanol.dic";
            ispellDictionarySpanish.GrammarPath = @"Dictionaries\ISpell\es_ES\espanol.aff";
            ispellDictionarySpanish.AlphabetPath = @"Dictionaries\SpanishAlphabet.txt";
            ispellDictionarySpanish.Culture = new CultureInfo("es-ES");
            ispellDictionarySpanish.Load();
            spellChecker1.Dictionaries.Add(ispellDictionarySpanish);

            LoadCustomDictionary();
        }

        private void LoadOpenOfficeDictionaries() {
            #region #LoadOpenOfficeDictionaries
            spellChecker1.Dictionaries.Clear();

            SpellCheckerOpenOfficeDictionary openOfficeDictionaryEnglish = new SpellCheckerOpenOfficeDictionary();
            openOfficeDictionaryEnglish.DictionaryPath = @"Dictionaries\OpenOffice\en_US\en_US.dic";
            openOfficeDictionaryEnglish.GrammarPath = @"Dictionaries\OpenOffice\en_US\en_US.aff";
            openOfficeDictionaryEnglish.Culture = new CultureInfo("en-US");
            spellChecker1.Dictionaries.Add(openOfficeDictionaryEnglish);
            #endregion #LoadOpenOfficeDictionaries

            SpellCheckerOpenOfficeDictionary openOfficeDictionarySpanish = new SpellCheckerOpenOfficeDictionary();
            openOfficeDictionarySpanish.DictionaryPath = @"Dictionaries\OpenOffice\es_ES\es_ES.dic";
            openOfficeDictionarySpanish.GrammarPath = @"Dictionaries\OpenOffice\es_ES\es_ES.aff";
            openOfficeDictionarySpanish.Culture = new CultureInfo("es-ES");
            spellChecker1.Dictionaries.Add(openOfficeDictionarySpanish);

            LoadCustomDictionary();
        }

        private void LoadHunspellDictionaries() {
            #region #LoadHunspellDictionaries
            spellChecker1.Dictionaries.Clear();

            HunspellDictionary hunspellDictionaryEnglish = new HunspellDictionary();
            hunspellDictionaryEnglish.DictionaryPath = @"Dictionaries\Hunspell\en_US\en_US.dic";
            hunspellDictionaryEnglish.GrammarPath = @"Dictionaries\Hunspell\en_US\en_US.aff";
            hunspellDictionaryEnglish.Culture = new CultureInfo("en-US");
            hunspellDictionaryEnglish.Load();
            spellChecker1.Dictionaries.Add(hunspellDictionaryEnglish);
            #endregion #LoadHunspellDictionaries

            HunspellDictionary hunspellDictionarySpanish = new HunspellDictionary();
            hunspellDictionarySpanish.DictionaryPath = @"Dictionaries\Hunspell\es_ES\es_ANY.dic";
            hunspellDictionarySpanish.GrammarPath = @"Dictionaries\Hunspell\es_ES\es_ANY.aff";
            hunspellDictionarySpanish.Culture = new CultureInfo("es-ES");
            hunspellDictionarySpanish.Load();
            spellChecker1.Dictionaries.Add(hunspellDictionarySpanish);

            LoadCustomDictionary();
        }
    }
}