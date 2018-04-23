using System;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraSpellChecker;

namespace SpellCheckerExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            LoadDictionaries();
        }

        private void button1_Click(object sender, EventArgs e) {
            spellChecker1.Check(textBox1);
        }

        private void LoadDictionaries() {
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            
            SpellCheckerOpenOfficeDictionary openOfficeDictionaryEnglish = new SpellCheckerOpenOfficeDictionary();
            openOfficeDictionaryEnglish.DictionaryPath = currentDirectory + @"\..\..\Dictionaries\en_US\en_US.dic";
            openOfficeDictionaryEnglish.GrammarPath = currentDirectory + @"\..\..\Dictionaries\en_US\en_US.aff";
            openOfficeDictionaryEnglish.Culture = new CultureInfo("en-US");
            spellChecker1.Dictionaries.Add(openOfficeDictionaryEnglish);

            SpellCheckerOpenOfficeDictionary openOfficeDictionarySpanish = new SpellCheckerOpenOfficeDictionary();
            openOfficeDictionarySpanish.DictionaryPath = currentDirectory + @"\..\..\Dictionaries\es_ES\es_ES.dic";
            openOfficeDictionarySpanish.GrammarPath = currentDirectory + @"\..\..\Dictionaries\es_ES\es_ES.aff";
            openOfficeDictionarySpanish.Culture = new CultureInfo("es-ES");
            spellChecker1.Dictionaries.Add(openOfficeDictionarySpanish);

            SpellCheckerCustomDictionary customDictionary = new SpellCheckerCustomDictionary();
            customDictionary.AlphabetPath = currentDirectory + @"\..\..\Dictionaries\EnglishAlphabet.txt";
            customDictionary.DictionaryPath = currentDirectory + @"\..\..\Dictionaries\CustomEnglish.dic";
            customDictionary.Culture = CultureInfo.InvariantCulture;
            spellChecker1.Dictionaries.Add(customDictionary);

            //spellChecker1.Culture = new CultureInfo("en-US");
            //spellChecker1.Culture = new CultureInfo("es-ES");

            spellChecker1.Culture = CultureInfo.InvariantCulture;
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType;
        }
    }
}