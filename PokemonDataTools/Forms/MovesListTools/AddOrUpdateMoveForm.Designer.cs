namespace Forms.MovesListTools
{
    partial class AddOrUpdateMoveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.labelEffectProbability = new System.Windows.Forms.Label();
            this.numericUpDownEffectProbability = new System.Windows.Forms.NumericUpDown();
            this.labelEffectCode = new System.Windows.Forms.Label();
            this.checkBoxContact = new System.Windows.Forms.CheckBox();
            this.numericUpDownPP = new System.Windows.Forms.NumericUpDown();
            this.labelPP = new System.Windows.Forms.Label();
            this.labelRecover = new System.Windows.Forms.Label();
            this.numericUpDownRecover = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRepetitionsInTurn = new System.Windows.Forms.NumericUpDown();
            this.labelRepetitionsInTurn = new System.Windows.Forms.Label();
            this.labelRepetitions = new System.Windows.Forms.Label();
            this.numericUpDownRepetitions = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPriority = new System.Windows.Forms.NumericUpDown();
            this.labelPriority = new System.Windows.Forms.Label();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.numericUpDownAccuarcy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPower = new System.Windows.Forms.NumericUpDown();
            this.labelAccuarcy = new System.Windows.Forms.Label();
            this.labelPower = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAddMove = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxEffectCode = new System.Windows.Forms.ComboBox();
            this.groupBoxGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEffectProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetitionsInTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuarcy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGeneral.Controls.Add(this.comboBoxEffectCode);
            this.groupBoxGeneral.Controls.Add(this.labelEffectProbability);
            this.groupBoxGeneral.Controls.Add(this.numericUpDownEffectProbability);
            this.groupBoxGeneral.Controls.Add(this.labelEffectCode);
            this.groupBoxGeneral.Controls.Add(this.checkBoxContact);
            this.groupBoxGeneral.Controls.Add(this.numericUpDownPP);
            this.groupBoxGeneral.Controls.Add(this.labelPP);
            this.groupBoxGeneral.Controls.Add(this.labelRecover);
            this.groupBoxGeneral.Controls.Add(this.numericUpDownRecover);
            this.groupBoxGeneral.Controls.Add(this.numericUpDownRepetitionsInTurn);
            this.groupBoxGeneral.Controls.Add(this.labelRepetitionsInTurn);
            this.groupBoxGeneral.Controls.Add(this.labelRepetitions);
            this.groupBoxGeneral.Controls.Add(this.numericUpDownRepetitions);
            this.groupBoxGeneral.Controls.Add(this.numericUpDownPriority);
            this.groupBoxGeneral.Controls.Add(this.labelPriority);
            this.groupBoxGeneral.Controls.Add(this.comboBoxTarget);
            this.groupBoxGeneral.Controls.Add(this.labelTarget);
            this.groupBoxGeneral.Controls.Add(this.numericUpDownAccuarcy);
            this.groupBoxGeneral.Controls.Add(this.numericUpDownPower);
            this.groupBoxGeneral.Controls.Add(this.labelAccuarcy);
            this.groupBoxGeneral.Controls.Add(this.labelPower);
            this.groupBoxGeneral.Controls.Add(this.comboBoxCategory);
            this.groupBoxGeneral.Controls.Add(this.labelCategory);
            this.groupBoxGeneral.Controls.Add(this.comboBoxType);
            this.groupBoxGeneral.Controls.Add(this.labelType);
            this.groupBoxGeneral.Controls.Add(this.richTextBoxDescription);
            this.groupBoxGeneral.Controls.Add(this.textBoxName);
            this.groupBoxGeneral.Location = new System.Drawing.Point(11, 27);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(557, 426);
            this.groupBoxGeneral.TabIndex = 0;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General";
            // 
            // labelEffectProbability
            // 
            this.labelEffectProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEffectProbability.AutoSize = true;
            this.labelEffectProbability.Location = new System.Drawing.Point(422, 360);
            this.labelEffectProbability.Name = "labelEffectProbability";
            this.labelEffectProbability.Size = new System.Drawing.Size(92, 13);
            this.labelEffectProbability.TabIndex = 11;
            this.labelEffectProbability.Text = "Effect Probability: ";
            // 
            // numericUpDownEffectProbability
            // 
            this.numericUpDownEffectProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownEffectProbability.Location = new System.Drawing.Point(422, 377);
            this.numericUpDownEffectProbability.Name = "numericUpDownEffectProbability";
            this.numericUpDownEffectProbability.Size = new System.Drawing.Size(126, 20);
            this.numericUpDownEffectProbability.TabIndex = 12;
            // 
            // labelEffectCode
            // 
            this.labelEffectCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEffectCode.AutoSize = true;
            this.labelEffectCode.Location = new System.Drawing.Point(285, 360);
            this.labelEffectCode.Name = "labelEffectCode";
            this.labelEffectCode.Size = new System.Drawing.Size(69, 13);
            this.labelEffectCode.TabIndex = 9;
            this.labelEffectCode.Text = "Effect Code: ";
            // 
            // checkBoxContact
            // 
            this.checkBoxContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxContact.AutoSize = true;
            this.checkBoxContact.Location = new System.Drawing.Point(6, 403);
            this.checkBoxContact.Name = "checkBoxContact";
            this.checkBoxContact.Size = new System.Drawing.Size(66, 17);
            this.checkBoxContact.TabIndex = 8;
            this.checkBoxContact.Text = "Contact.";
            this.checkBoxContact.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPP
            // 
            this.numericUpDownPP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownPP.Location = new System.Drawing.Point(425, 329);
            this.numericUpDownPP.Name = "numericUpDownPP";
            this.numericUpDownPP.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownPP.TabIndex = 7;
            // 
            // labelPP
            // 
            this.labelPP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPP.AutoSize = true;
            this.labelPP.Location = new System.Drawing.Point(425, 313);
            this.labelPP.Name = "labelPP";
            this.labelPP.Size = new System.Drawing.Size(27, 13);
            this.labelPP.TabIndex = 5;
            this.labelPP.Text = "PP: ";
            // 
            // labelRecover
            // 
            this.labelRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRecover.AutoSize = true;
            this.labelRecover.Location = new System.Drawing.Point(285, 313);
            this.labelRecover.Name = "labelRecover";
            this.labelRecover.Size = new System.Drawing.Size(54, 13);
            this.labelRecover.TabIndex = 4;
            this.labelRecover.Text = "Recover: ";
            // 
            // numericUpDownRecover
            // 
            this.numericUpDownRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownRecover.Location = new System.Drawing.Point(285, 330);
            this.numericUpDownRecover.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRecover.Name = "numericUpDownRecover";
            this.numericUpDownRecover.Size = new System.Drawing.Size(127, 20);
            this.numericUpDownRecover.TabIndex = 6;
            // 
            // numericUpDownRepetitionsInTurn
            // 
            this.numericUpDownRepetitionsInTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownRepetitionsInTurn.Location = new System.Drawing.Point(425, 282);
            this.numericUpDownRepetitionsInTurn.Name = "numericUpDownRepetitionsInTurn";
            this.numericUpDownRepetitionsInTurn.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownRepetitionsInTurn.TabIndex = 7;
            // 
            // labelRepetitionsInTurn
            // 
            this.labelRepetitionsInTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRepetitionsInTurn.AutoSize = true;
            this.labelRepetitionsInTurn.Location = new System.Drawing.Point(425, 266);
            this.labelRepetitionsInTurn.Name = "labelRepetitionsInTurn";
            this.labelRepetitionsInTurn.Size = new System.Drawing.Size(98, 13);
            this.labelRepetitionsInTurn.TabIndex = 5;
            this.labelRepetitionsInTurn.Text = "Repetitions in turn: ";
            // 
            // labelRepetitions
            // 
            this.labelRepetitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRepetitions.AutoSize = true;
            this.labelRepetitions.Location = new System.Drawing.Point(285, 266);
            this.labelRepetitions.Name = "labelRepetitions";
            this.labelRepetitions.Size = new System.Drawing.Size(66, 13);
            this.labelRepetitions.TabIndex = 4;
            this.labelRepetitions.Text = "Repetitions: ";
            // 
            // numericUpDownRepetitions
            // 
            this.numericUpDownRepetitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownRepetitions.Location = new System.Drawing.Point(285, 283);
            this.numericUpDownRepetitions.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRepetitions.Name = "numericUpDownRepetitions";
            this.numericUpDownRepetitions.Size = new System.Drawing.Size(127, 20);
            this.numericUpDownRepetitions.TabIndex = 6;
            // 
            // numericUpDownPriority
            // 
            this.numericUpDownPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownPriority.Location = new System.Drawing.Point(146, 376);
            this.numericUpDownPriority.Name = "numericUpDownPriority";
            this.numericUpDownPriority.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownPriority.TabIndex = 6;
            // 
            // labelPriority
            // 
            this.labelPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(146, 360);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(44, 13);
            this.labelPriority.TabIndex = 4;
            this.labelPriority.Text = "Priority: ";
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Location = new System.Drawing.Point(6, 376);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(127, 21);
            this.comboBoxTarget.TabIndex = 3;
            // 
            // labelTarget
            // 
            this.labelTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(6, 360);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(44, 13);
            this.labelTarget.TabIndex = 2;
            this.labelTarget.Text = "Target: ";
            // 
            // numericUpDownAccuarcy
            // 
            this.numericUpDownAccuarcy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownAccuarcy.Location = new System.Drawing.Point(146, 328);
            this.numericUpDownAccuarcy.Name = "numericUpDownAccuarcy";
            this.numericUpDownAccuarcy.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownAccuarcy.TabIndex = 7;
            // 
            // numericUpDownPower
            // 
            this.numericUpDownPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownPower.Location = new System.Drawing.Point(6, 329);
            this.numericUpDownPower.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPower.Name = "numericUpDownPower";
            this.numericUpDownPower.Size = new System.Drawing.Size(127, 20);
            this.numericUpDownPower.TabIndex = 6;
            // 
            // labelAccuarcy
            // 
            this.labelAccuarcy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAccuarcy.AutoSize = true;
            this.labelAccuarcy.Location = new System.Drawing.Point(146, 313);
            this.labelAccuarcy.Name = "labelAccuarcy";
            this.labelAccuarcy.Size = new System.Drawing.Size(58, 13);
            this.labelAccuarcy.TabIndex = 5;
            this.labelAccuarcy.Text = "Accuarcy: ";
            // 
            // labelPower
            // 
            this.labelPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(6, 313);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(43, 13);
            this.labelPower.TabIndex = 4;
            this.labelPower.Text = "Power: ";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(146, 282);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(124, 21);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(146, 266);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 13);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category: ";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(6, 282);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(127, 21);
            this.comboBoxType.TabIndex = 3;
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(6, 266);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(37, 13);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type: ";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBoxDescription.Location = new System.Drawing.Point(6, 46);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(547, 207);
            this.richTextBoxDescription.TabIndex = 1;
            this.richTextBoxDescription.Text = "Description...";
            this.richTextBoxDescription.Enter += new System.EventHandler(this.richTextBoxDescription_Enter);
            this.richTextBoxDescription.Leave += new System.EventHandler(this.richTextBoxDescription_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxName.Location = new System.Drawing.Point(6, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(547, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Name...";
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(11, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(56, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Add Move";
            // 
            // buttonAddMove
            // 
            this.buttonAddMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMove.Location = new System.Drawing.Point(493, 459);
            this.buttonAddMove.Name = "buttonAddMove";
            this.buttonAddMove.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMove.TabIndex = 2;
            this.buttonAddMove.Text = "Add";
            this.buttonAddMove.UseVisualStyleBackColor = true;
            this.buttonAddMove.Click += new System.EventHandler(this.buttonAddMove_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(412, 459);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxEffectCode
            // 
            this.comboBoxEffectCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxEffectCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxEffectCode.FormattingEnabled = true;
            this.comboBoxEffectCode.Items.AddRange(new object[] {
            "Effect Code..."});
            this.comboBoxEffectCode.Location = new System.Drawing.Point(285, 377);
            this.comboBoxEffectCode.Name = "comboBoxEffectCode";
            this.comboBoxEffectCode.Size = new System.Drawing.Size(127, 21);
            this.comboBoxEffectCode.TabIndex = 13;
            // 
            // AddOrUpdateMoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 494);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddMove);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrUpdateMoveForm";
            this.Text = "AddOrUpdateMoveForm";
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEffectProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetitionsInTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuarcy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAccuarcy;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.NumericUpDown numericUpDownPower;
        private System.Windows.Forms.NumericUpDown numericUpDownAccuarcy;
        private System.Windows.Forms.NumericUpDown numericUpDownPriority;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.NumericUpDown numericUpDownRepetitionsInTurn;
        private System.Windows.Forms.Label labelRepetitionsInTurn;
        private System.Windows.Forms.Label labelRepetitions;
        private System.Windows.Forms.NumericUpDown numericUpDownRepetitions;
        private System.Windows.Forms.NumericUpDown numericUpDownPP;
        private System.Windows.Forms.Label labelPP;
        private System.Windows.Forms.Label labelRecover;
        private System.Windows.Forms.NumericUpDown numericUpDownRecover;
        private System.Windows.Forms.CheckBox checkBoxContact;
        private System.Windows.Forms.Label labelEffectProbability;
        private System.Windows.Forms.NumericUpDown numericUpDownEffectProbability;
        private System.Windows.Forms.Label labelEffectCode;
        private System.Windows.Forms.Button buttonAddMove;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxEffectCode;
    }
}