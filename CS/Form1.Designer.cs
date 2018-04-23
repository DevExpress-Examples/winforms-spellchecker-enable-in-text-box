namespace SpellCheckerExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            this.memoEditToCheck = new DevExpress.XtraEditors.MemoEdit();
            this.btnCheck = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.cmbDictionaryType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Form1layoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditToCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDictionaryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form1layoutControl1ConvertedLayout)).BeginInit();
            this.Form1layoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // spellChecker1
            // 
            this.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = true;
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("en-US");
            this.spellChecker1.ParentContainer = this;
            // 
            // memoEditToCheck
            // 
            this.memoEditToCheck.Location = new System.Drawing.Point(12, 12);
            this.memoEditToCheck.Name = "memoEditToCheck";
            this.memoEditToCheck.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoEditToCheck.Properties.Appearance.Options.UseFont = true;
            this.spellChecker1.SetShowSpellCheckMenu(this.memoEditToCheck, true);
            this.memoEditToCheck.Size = new System.Drawing.Size(383, 280);
            this.spellChecker1.SetSpellCheckerOptions(this.memoEditToCheck, optionsSpelling1);
            this.memoEditToCheck.StyleController = this.Form1layoutControl1ConvertedLayout;
            this.memoEditToCheck.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(222, 296);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(173, 22);
            this.btnCheck.StyleController = this.Form1layoutControl1ConvertedLayout;
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // cmbDictionaryType
            // 
            this.cmbDictionaryType.EditValue = "OpenOffice";
            this.cmbDictionaryType.Location = new System.Drawing.Point(91, 296);
            this.cmbDictionaryType.Name = "cmbDictionaryType";
            this.cmbDictionaryType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDictionaryType.Properties.DropDownRows = 3;
            this.cmbDictionaryType.Properties.Items.AddRange(new object[] {
            "ISpell",
            "OpenOffice",
            "HunSpell"});
            this.cmbDictionaryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbDictionaryType.Size = new System.Drawing.Size(127, 20);
            this.cmbDictionaryType.StyleController = this.Form1layoutControl1ConvertedLayout;
            this.cmbDictionaryType.TabIndex = 4;
            this.cmbDictionaryType.SelectedIndexChanged += new System.EventHandler(this.cmbDictionaryType_SelectedIndexChanged);
            // 
            // Form1layoutControl1ConvertedLayout
            // 
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.cmbDictionaryType);
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.memoEditToCheck);
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.btnCheck);
            this.Form1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form1layoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.Form1layoutControl1ConvertedLayout.Name = "Form1layoutControl1ConvertedLayout";
            this.Form1layoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.Form1layoutControl1ConvertedLayout.Size = new System.Drawing.Size(407, 330);
            this.Form1layoutControl1ConvertedLayout.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(407, 330);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbDictionaryType;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 284);
            this.layoutControlItem1.Name = "cmbDictionaryTypeitem";
            this.layoutControlItem1.Size = new System.Drawing.Size(210, 26);
            this.layoutControlItem1.Text = "Dictionary Type";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.memoEditToCheck;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "memoEditToCheckitem";
            this.layoutControlItem2.Size = new System.Drawing.Size(387, 284);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCheck;
            this.layoutControlItem3.Location = new System.Drawing.Point(210, 284);
            this.layoutControlItem3.Name = "btnCheckitem";
            this.layoutControlItem3.Size = new System.Drawing.Size(177, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 330);
            this.Controls.Add(this.Form1layoutControl1ConvertedLayout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "XtraSpellChecker Example";
            ((System.ComponentModel.ISupportInitialize)(this.memoEditToCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDictionaryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form1layoutControl1ConvertedLayout)).EndInit();
            this.Form1layoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
        private DevExpress.XtraEditors.MemoEdit memoEditToCheck;
        private DevExpress.XtraEditors.SimpleButton btnCheck;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDictionaryType;
        private DevExpress.XtraLayout.LayoutControl Form1layoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}

