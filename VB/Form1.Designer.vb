Imports Microsoft.VisualBasic
Imports System
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
			Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' spellChecker1
			' 
			Me.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = True
			Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spellChecker1.ParentContainer = Me
			' 
			' textBox1
			' 
			Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.textBox1.Location = New System.Drawing.Point(12, 12)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.textBox1, False)
			Me.textBox1.Size = New System.Drawing.Size(454, 200)
			Me.spellChecker1.SetSpellCheckerOptions(Me.textBox1, optionsSpelling1)
			Me.textBox1.TabIndex = 1
			Me.textBox1.Text = resources.GetString("textBox1.Text")
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(201, 231)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 29)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Check"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(477, 277)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.textBox1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents button1 As System.Windows.Forms.Button
	End Class
End Namespace

