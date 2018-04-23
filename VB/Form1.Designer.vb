Namespace SpellCheckerExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
            Me.memoEditToCheck = New DevExpress.XtraEditors.MemoEdit()
            Me.btnCheck = New DevExpress.XtraEditors.SimpleButton()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.cmbDictionaryType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Form1layoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.memoEditToCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cmbDictionaryType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.Form1layoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Form1layoutControl1ConvertedLayout.SuspendLayout()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spellChecker1
            ' 
            Me.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = True
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spellChecker1.ParentContainer = Me
            ' 
            ' memoEditToCheck
            ' 
            Me.memoEditToCheck.Location = New System.Drawing.Point(12, 12)
            Me.memoEditToCheck.Name = "memoEditToCheck"
            Me.memoEditToCheck.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10F)
            Me.memoEditToCheck.Properties.Appearance.Options.UseFont = True
            Me.spellChecker1.SetShowSpellCheckMenu(Me.memoEditToCheck, True)
            Me.memoEditToCheck.Size = New System.Drawing.Size(383, 280)
            Me.spellChecker1.SetSpellCheckerOptions(Me.memoEditToCheck, optionsSpelling1)
            Me.memoEditToCheck.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.memoEditToCheck.TabIndex = 3
            ' 
            ' btnCheck
            ' 
            Me.btnCheck.Location = New System.Drawing.Point(222, 296)
            Me.btnCheck.Name = "btnCheck"
            Me.btnCheck.Size = New System.Drawing.Size(173, 22)
            Me.btnCheck.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.btnCheck.TabIndex = 2
            Me.btnCheck.Text = "Check"
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' cmbDictionaryType
            ' 
            Me.cmbDictionaryType.EditValue = "OpenOffice"
            Me.cmbDictionaryType.Location = New System.Drawing.Point(91, 296)
            Me.cmbDictionaryType.Name = "cmbDictionaryType"
            Me.cmbDictionaryType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbDictionaryType.Properties.DropDownRows = 3
            Me.cmbDictionaryType.Properties.Items.AddRange(New Object() { "ISpell", "OpenOffice", "HunSpell"})
            Me.cmbDictionaryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmbDictionaryType.Size = New System.Drawing.Size(127, 20)
            Me.cmbDictionaryType.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.cmbDictionaryType.TabIndex = 4
            ' 
            ' Form1layoutControl1ConvertedLayout
            ' 
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.cmbDictionaryType)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.memoEditToCheck)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.btnCheck)
            Me.Form1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Form1layoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.Form1layoutControl1ConvertedLayout.Name = "Form1layoutControl1ConvertedLayout"
            Me.Form1layoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.Form1layoutControl1ConvertedLayout.Size = New System.Drawing.Size(407, 330)
            Me.Form1layoutControl1ConvertedLayout.TabIndex = 6
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(407, 330)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cmbDictionaryType
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 284)
            Me.layoutControlItem1.Name = "cmbDictionaryTypeitem"
            Me.layoutControlItem1.Size = New System.Drawing.Size(210, 26)
            Me.layoutControlItem1.Text = "Dictionary Type"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(75, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.memoEditToCheck
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "memoEditToCheckitem"
            Me.layoutControlItem2.Size = New System.Drawing.Size(387, 284)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.btnCheck
            Me.layoutControlItem3.Location = New System.Drawing.Point(210, 284)
            Me.layoutControlItem3.Name = "btnCheckitem"
            Me.layoutControlItem3.Size = New System.Drawing.Size(177, 26)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(407, 330)
            Me.Controls.Add(Me.Form1layoutControl1ConvertedLayout)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "Form1"
            Me.Text = "XtraSpellChecker Example"
            DirectCast(Me.memoEditToCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cmbDictionaryType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.Form1layoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Form1layoutControl1ConvertedLayout.ResumeLayout(False)
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
        Private memoEditToCheck As DevExpress.XtraEditors.MemoEdit
        Private WithEvents btnCheck As DevExpress.XtraEditors.SimpleButton
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private WithEvents cmbDictionaryType As DevExpress.XtraEditors.ComboBoxEdit
        Private Form1layoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

