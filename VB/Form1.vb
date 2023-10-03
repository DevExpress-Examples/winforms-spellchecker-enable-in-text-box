Imports System
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.XtraSpellChecker

Namespace SpellCheckerExample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            LoadDictionaries()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            spellChecker1.Check(textBox1)
        End Sub

        Private Sub LoadDictionaries()
            Dim currentDirectory As String = IO.Directory.GetCurrentDirectory()
            Dim openOfficeDictionaryEnglish As SpellCheckerOpenOfficeDictionary = New SpellCheckerOpenOfficeDictionary()
            openOfficeDictionaryEnglish.DictionaryPath = currentDirectory & "\..\..\Dictionaries\en_US\en_US.dic"
            openOfficeDictionaryEnglish.GrammarPath = currentDirectory & "\..\..\Dictionaries\en_US\en_US.aff"
            openOfficeDictionaryEnglish.Culture = New CultureInfo("en-US")
            spellChecker1.Dictionaries.Add(openOfficeDictionaryEnglish)
            Dim openOfficeDictionarySpanish As SpellCheckerOpenOfficeDictionary = New SpellCheckerOpenOfficeDictionary()
            openOfficeDictionarySpanish.DictionaryPath = currentDirectory & "\..\..\Dictionaries\es_ES\es_ES.dic"
            openOfficeDictionarySpanish.GrammarPath = currentDirectory & "\..\..\Dictionaries\es_ES\es_ES.aff"
            openOfficeDictionarySpanish.Culture = New CultureInfo("es-ES")
            spellChecker1.Dictionaries.Add(openOfficeDictionarySpanish)
            Dim customDictionary As SpellCheckerCustomDictionary = New SpellCheckerCustomDictionary()
            customDictionary.AlphabetPath = currentDirectory & "\..\..\Dictionaries\EnglishAlphabet.txt"
            customDictionary.DictionaryPath = currentDirectory & "\..\..\Dictionaries\CustomEnglish.dic"
            customDictionary.Culture = CultureInfo.InvariantCulture
            spellChecker1.Dictionaries.Add(customDictionary)
            'spellChecker1.Culture = new CultureInfo("en-US");
            'spellChecker1.Culture = new CultureInfo("es-ES");
            spellChecker1.Culture = CultureInfo.InvariantCulture
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType
        End Sub
    End Class
End Namespace
