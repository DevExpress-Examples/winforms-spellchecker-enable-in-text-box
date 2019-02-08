#Region "#usings"
Imports DevExpress.XtraSpellChecker
Imports System
Imports System.Globalization
#End Region ' #usings

Namespace SpellCheckerExample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            memoEditToCheck.Text = "This help system provides a a comprehansive information on using the XtraSpellChecker prodact (http:
It contains a detailed description of the product's API, and also provides examples with step-by-step instractions, screenshot images and source code (both, C# and Visual Basic).

El asistete realiza automáticamente las modificacines en los ficheros de configuración. Si desea realizar una instalción manual siga estas instruciones:" 'help.devexpress.com/#WindowsForms/CustomDocument2635).

            LoadOpenOfficeDictionaries()

            'spellChecker1.Culture = new CultureInfo("en-US");
            'spellChecker1.Culture = new CultureInfo("es-ES");

            spellChecker1.Culture = CultureInfo.InvariantCulture
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType
        End Sub

        Private Sub LoadCustomDictionary()
'            #Region "#LoadCustomDictionary"
            Dim customDictionary As New SpellCheckerCustomDictionary()
            customDictionary.AlphabetPath = "Dictionaries\EnglishAlphabet.txt"
            customDictionary.DictionaryPath = "Dictionaries\CustomEnglish.dic"
            customDictionary.Culture = CultureInfo.InvariantCulture
            spellChecker1.Dictionaries.Add(customDictionary)
'            #End Region ' #LoadCustomDictionary
        End Sub

        Private Sub btnCheck_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCheck.Click
            spellChecker1.Check(memoEditToCheck)
        End Sub

        Private Sub cmbDictionaryType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbDictionaryType.SelectedIndexChanged
            Select Case cmbDictionaryType.SelectedIndex
                Case 0
                    LoadISpellDictionaries()
                Case 1
                    LoadOpenOfficeDictionaries()
                Case 2
                    LoadHunspellDictionaries()
            End Select
        End Sub

        Private Sub LoadISpellDictionaries()
'            #Region "#LoadISpellDictionaries"
            spellChecker1.Dictionaries.Clear()

            Dim ispellDictionaryEnglish As New SpellCheckerISpellDictionary()
            ispellDictionaryEnglish.DictionaryPath = "Dictionaries\ISpell\en_US\american.xlg"
            ispellDictionaryEnglish.GrammarPath = "Dictionaries\ISpell\en_US\english.aff"
            ispellDictionaryEnglish.AlphabetPath = "Dictionaries\EnglishAlphabet.txt"
            ispellDictionaryEnglish.Culture = New CultureInfo("en-US")
            ispellDictionaryEnglish.Load()
            spellChecker1.Dictionaries.Add(ispellDictionaryEnglish)
'            #End Region ' #LoadISpellDictionaries

            Dim ispellDictionarySpanish As New SpellCheckerISpellDictionary()
            ispellDictionarySpanish.DictionaryPath = "Dictionaries\ISpell\es_ES\espanol.dic"
            ispellDictionarySpanish.GrammarPath = "Dictionaries\ISpell\es_ES\espanol.aff"
            ispellDictionarySpanish.AlphabetPath = "Dictionaries\SpanishAlphabet.txt"
            ispellDictionarySpanish.Culture = New CultureInfo("es-ES")
            ispellDictionarySpanish.Load()
            spellChecker1.Dictionaries.Add(ispellDictionarySpanish)

            LoadCustomDictionary()
        End Sub

        Private Sub LoadOpenOfficeDictionaries()
'            #Region "#LoadOpenOfficeDictionaries"
            spellChecker1.Dictionaries.Clear()

            Dim openOfficeDictionaryEnglish As New SpellCheckerOpenOfficeDictionary()
            openOfficeDictionaryEnglish.DictionaryPath = "Dictionaries\OpenOffice\en_US\en_US.dic"
            openOfficeDictionaryEnglish.GrammarPath = "Dictionaries\OpenOffice\en_US\en_US.aff"
            openOfficeDictionaryEnglish.Culture = New CultureInfo("en-US")
            spellChecker1.Dictionaries.Add(openOfficeDictionaryEnglish)
'            #End Region ' #LoadOpenOfficeDictionaries

            Dim openOfficeDictionarySpanish As New SpellCheckerOpenOfficeDictionary()
            openOfficeDictionarySpanish.DictionaryPath = "Dictionaries\OpenOffice\es_ES\es_ES.dic"
            openOfficeDictionarySpanish.GrammarPath = "Dictionaries\OpenOffice\es_ES\es_ES.aff"
            openOfficeDictionarySpanish.Culture = New CultureInfo("es-ES")
            spellChecker1.Dictionaries.Add(openOfficeDictionarySpanish)

            LoadCustomDictionary()
        End Sub

        Private Sub LoadHunspellDictionaries()
'            #Region "#LoadHunspellDictionaries"
            spellChecker1.Dictionaries.Clear()

            Dim hunspellDictionaryEnglish As New HunspellDictionary()
            hunspellDictionaryEnglish.DictionaryPath = "Dictionaries\Hunspell\en_US\en_US.dic"
            hunspellDictionaryEnglish.GrammarPath = "Dictionaries\Hunspell\en_US\en_US.aff"
            hunspellDictionaryEnglish.Culture = New CultureInfo("en-US")
            hunspellDictionaryEnglish.Load()
            spellChecker1.Dictionaries.Add(hunspellDictionaryEnglish)
'            #End Region ' #LoadHunspellDictionaries

            Dim hunspellDictionarySpanish As New HunspellDictionary()
            hunspellDictionarySpanish.DictionaryPath = "Dictionaries\Hunspell\es_ES\es_ANY.dic"
            hunspellDictionarySpanish.GrammarPath = "Dictionaries\Hunspell\es_ES\es_ANY.aff"
            hunspellDictionarySpanish.Culture = New CultureInfo("es-ES")
            hunspellDictionarySpanish.Load()
            spellChecker1.Dictionaries.Add(hunspellDictionarySpanish)

            LoadCustomDictionary()
        End Sub
    End Class
End Namespace