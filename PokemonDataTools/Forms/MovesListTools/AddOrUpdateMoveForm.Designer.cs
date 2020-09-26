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
            this.groupBoxBooleans = new System.Windows.Forms.GroupBox();
            this.checkBoxContact = new System.Windows.Forms.CheckBox();
            this.checkBoxAffectedByGravity = new System.Windows.Forms.CheckBox();
            this.checkBoxIsDance = new System.Windows.Forms.CheckBox();
            this.checkBoxIsSound = new System.Windows.Forms.CheckBox();
            this.checkBoxCanBeProtected = new System.Windows.Forms.CheckBox();
            this.checkBoxIsPerforation = new System.Windows.Forms.CheckBox();
            this.checkBoxAffectedByBounceEffect = new System.Windows.Forms.CheckBox();
            this.checkBoxAffectedByKingsRock = new System.Windows.Forms.CheckBox();
            this.checkBoxCanDefrost = new System.Windows.Forms.CheckBox();
            this.checkBoxCanBeCopied = new System.Windows.Forms.CheckBox();
            this.checkBoxCanBeStealed = new System.Windows.Forms.CheckBox();
            this.groupBoxAttributes = new System.Windows.Forms.GroupBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelCriticalProbability = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.numericUpDownCriticalProbability = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxEffectCode = new System.Windows.Forms.ComboBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelEffectProbability = new System.Windows.Forms.Label();
            this.labelAccuarcy = new System.Windows.Forms.Label();
            this.numericUpDownEffectProbability = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPower = new System.Windows.Forms.NumericUpDown();
            this.labelEffectCode = new System.Windows.Forms.Label();
            this.numericUpDownAccuarcy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPP = new System.Windows.Forms.NumericUpDown();
            this.labelTarget = new System.Windows.Forms.Label();
            this.labelPP = new System.Windows.Forms.Label();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.labelRecoverByDamage = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.numericUpDownRecoverByDamage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPriority = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRepetitionsInTurn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRepetitions = new System.Windows.Forms.NumericUpDown();
            this.labelRepetitionsInTurn = new System.Windows.Forms.Label();
            this.labelRepetitions = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddMove = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxGeneral.SuspendLayout();
            this.groupBoxBooleans.SuspendLayout();
            this.groupBoxAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCriticalProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEffectProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuarcy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecoverByDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetitionsInTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetitions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGeneral.Controls.Add(this.groupBoxBooleans);
            this.groupBoxGeneral.Controls.Add(this.groupBoxAttributes);
            this.groupBoxGeneral.Controls.Add(this.richTextBoxDescription);
            this.groupBoxGeneral.Controls.Add(this.textBoxName);
            this.groupBoxGeneral.Location = new System.Drawing.Point(11, 12);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(741, 396);
            this.groupBoxGeneral.TabIndex = 0;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "Add Move";
            // 
            // groupBoxBooleans
            // 
            this.groupBoxBooleans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBooleans.Controls.Add(this.checkBoxContact);
            this.groupBoxBooleans.Controls.Add(this.checkBoxAffectedByGravity);
            this.groupBoxBooleans.Controls.Add(this.checkBoxIsDance);
            this.groupBoxBooleans.Controls.Add(this.checkBoxIsSound);
            this.groupBoxBooleans.Controls.Add(this.checkBoxCanBeProtected);
            this.groupBoxBooleans.Controls.Add(this.checkBoxIsPerforation);
            this.groupBoxBooleans.Controls.Add(this.checkBoxAffectedByBounceEffect);
            this.groupBoxBooleans.Controls.Add(this.checkBoxAffectedByKingsRock);
            this.groupBoxBooleans.Controls.Add(this.checkBoxCanDefrost);
            this.groupBoxBooleans.Controls.Add(this.checkBoxCanBeCopied);
            this.groupBoxBooleans.Controls.Add(this.checkBoxCanBeStealed);
            this.groupBoxBooleans.Location = new System.Drawing.Point(6, 272);
            this.groupBoxBooleans.Name = "groupBoxBooleans";
            this.groupBoxBooleans.Size = new System.Drawing.Size(436, 118);
            this.groupBoxBooleans.TabIndex = 27;
            this.groupBoxBooleans.TabStop = false;
            this.groupBoxBooleans.Text = "Booleans";
            // 
            // checkBoxContact
            // 
            this.checkBoxContact.AutoSize = true;
            this.checkBoxContact.Location = new System.Drawing.Point(6, 19);
            this.checkBoxContact.Name = "checkBoxContact";
            this.checkBoxContact.Size = new System.Drawing.Size(66, 17);
            this.checkBoxContact.TabIndex = 8;
            this.checkBoxContact.Text = "Contact.";
            this.checkBoxContact.UseVisualStyleBackColor = true;
            // 
            // checkBoxAffectedByGravity
            // 
            this.checkBoxAffectedByGravity.AutoSize = true;
            this.checkBoxAffectedByGravity.Location = new System.Drawing.Point(6, 39);
            this.checkBoxAffectedByGravity.Name = "checkBoxAffectedByGravity";
            this.checkBoxAffectedByGravity.Size = new System.Drawing.Size(117, 17);
            this.checkBoxAffectedByGravity.TabIndex = 25;
            this.checkBoxAffectedByGravity.Text = "Affected by gravity.";
            this.checkBoxAffectedByGravity.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsDance
            // 
            this.checkBoxIsDance.AutoSize = true;
            this.checkBoxIsDance.Location = new System.Drawing.Point(139, 88);
            this.checkBoxIsDance.Name = "checkBoxIsDance";
            this.checkBoxIsDance.Size = new System.Drawing.Size(79, 17);
            this.checkBoxIsDance.TabIndex = 16;
            this.checkBoxIsDance.Text = "Is a dance.";
            this.checkBoxIsDance.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsSound
            // 
            this.checkBoxIsSound.AutoSize = true;
            this.checkBoxIsSound.Location = new System.Drawing.Point(139, 39);
            this.checkBoxIsSound.Name = "checkBoxIsSound";
            this.checkBoxIsSound.Size = new System.Drawing.Size(78, 17);
            this.checkBoxIsSound.TabIndex = 24;
            this.checkBoxIsSound.Text = "Is a sound.";
            this.checkBoxIsSound.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanBeProtected
            // 
            this.checkBoxCanBeProtected.AutoSize = true;
            this.checkBoxCanBeProtected.Checked = true;
            this.checkBoxCanBeProtected.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCanBeProtected.Location = new System.Drawing.Point(139, 62);
            this.checkBoxCanBeProtected.Name = "checkBoxCanBeProtected";
            this.checkBoxCanBeProtected.Size = new System.Drawing.Size(111, 17);
            this.checkBoxCanBeProtected.TabIndex = 17;
            this.checkBoxCanBeProtected.Text = "Can be protected.";
            this.checkBoxCanBeProtected.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsPerforation
            // 
            this.checkBoxIsPerforation.AutoSize = true;
            this.checkBoxIsPerforation.Location = new System.Drawing.Point(6, 65);
            this.checkBoxIsPerforation.Name = "checkBoxIsPerforation";
            this.checkBoxIsPerforation.Size = new System.Drawing.Size(90, 17);
            this.checkBoxIsPerforation.TabIndex = 23;
            this.checkBoxIsPerforation.Text = "Is perforation.";
            this.checkBoxIsPerforation.UseVisualStyleBackColor = true;
            // 
            // checkBoxAffectedByBounceEffect
            // 
            this.checkBoxAffectedByBounceEffect.AutoSize = true;
            this.checkBoxAffectedByBounceEffect.Location = new System.Drawing.Point(276, 62);
            this.checkBoxAffectedByBounceEffect.Name = "checkBoxAffectedByBounceEffect";
            this.checkBoxAffectedByBounceEffect.Size = new System.Drawing.Size(152, 17);
            this.checkBoxAffectedByBounceEffect.TabIndex = 18;
            this.checkBoxAffectedByBounceEffect.Text = "Affected by bounce effect.";
            this.checkBoxAffectedByBounceEffect.UseVisualStyleBackColor = true;
            // 
            // checkBoxAffectedByKingsRock
            // 
            this.checkBoxAffectedByKingsRock.AutoSize = true;
            this.checkBoxAffectedByKingsRock.Checked = true;
            this.checkBoxAffectedByKingsRock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAffectedByKingsRock.Location = new System.Drawing.Point(276, 39);
            this.checkBoxAffectedByKingsRock.Name = "checkBoxAffectedByKingsRock";
            this.checkBoxAffectedByKingsRock.Size = new System.Drawing.Size(141, 17);
            this.checkBoxAffectedByKingsRock.TabIndex = 22;
            this.checkBoxAffectedByKingsRock.Text = "Affected by Kings Rock.";
            this.checkBoxAffectedByKingsRock.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanDefrost
            // 
            this.checkBoxCanDefrost.AutoSize = true;
            this.checkBoxCanDefrost.Location = new System.Drawing.Point(276, 16);
            this.checkBoxCanDefrost.Name = "checkBoxCanDefrost";
            this.checkBoxCanDefrost.Size = new System.Drawing.Size(136, 17);
            this.checkBoxCanDefrost.TabIndex = 19;
            this.checkBoxCanDefrost.Text = "Can defrost to the user.";
            this.checkBoxCanDefrost.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanBeCopied
            // 
            this.checkBoxCanBeCopied.AutoSize = true;
            this.checkBoxCanBeCopied.Checked = true;
            this.checkBoxCanBeCopied.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCanBeCopied.Location = new System.Drawing.Point(6, 88);
            this.checkBoxCanBeCopied.Name = "checkBoxCanBeCopied";
            this.checkBoxCanBeCopied.Size = new System.Drawing.Size(99, 17);
            this.checkBoxCanBeCopied.TabIndex = 21;
            this.checkBoxCanBeCopied.Text = "Can be Copied.";
            this.checkBoxCanBeCopied.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanBeStealed
            // 
            this.checkBoxCanBeStealed.AutoSize = true;
            this.checkBoxCanBeStealed.Checked = true;
            this.checkBoxCanBeStealed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCanBeStealed.Location = new System.Drawing.Point(139, 16);
            this.checkBoxCanBeStealed.Name = "checkBoxCanBeStealed";
            this.checkBoxCanBeStealed.Size = new System.Drawing.Size(102, 17);
            this.checkBoxCanBeStealed.TabIndex = 20;
            this.checkBoxCanBeStealed.Text = "Can be Stealed.";
            this.checkBoxCanBeStealed.UseVisualStyleBackColor = true;
            // 
            // groupBoxAttributes
            // 
            this.groupBoxAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAttributes.Controls.Add(this.labelType);
            this.groupBoxAttributes.Controls.Add(this.comboBoxType);
            this.groupBoxAttributes.Controls.Add(this.labelCriticalProbability);
            this.groupBoxAttributes.Controls.Add(this.labelCategory);
            this.groupBoxAttributes.Controls.Add(this.numericUpDownCriticalProbability);
            this.groupBoxAttributes.Controls.Add(this.comboBoxCategory);
            this.groupBoxAttributes.Controls.Add(this.comboBoxEffectCode);
            this.groupBoxAttributes.Controls.Add(this.labelPower);
            this.groupBoxAttributes.Controls.Add(this.labelEffectProbability);
            this.groupBoxAttributes.Controls.Add(this.labelAccuarcy);
            this.groupBoxAttributes.Controls.Add(this.numericUpDownEffectProbability);
            this.groupBoxAttributes.Controls.Add(this.numericUpDownPower);
            this.groupBoxAttributes.Controls.Add(this.labelEffectCode);
            this.groupBoxAttributes.Controls.Add(this.numericUpDownAccuarcy);
            this.groupBoxAttributes.Controls.Add(this.numericUpDownPP);
            this.groupBoxAttributes.Controls.Add(this.labelTarget);
            this.groupBoxAttributes.Controls.Add(this.labelPP);
            this.groupBoxAttributes.Controls.Add(this.comboBoxTarget);
            this.groupBoxAttributes.Controls.Add(this.labelRecoverByDamage);
            this.groupBoxAttributes.Controls.Add(this.labelPriority);
            this.groupBoxAttributes.Controls.Add(this.numericUpDownRecoverByDamage);
            this.groupBoxAttributes.Controls.Add(this.numericUpDownPriority);
            this.groupBoxAttributes.Controls.Add(this.numericUpDownRepetitionsInTurn);
            this.groupBoxAttributes.Controls.Add(this.numericUpDownRepetitions);
            this.groupBoxAttributes.Controls.Add(this.labelRepetitionsInTurn);
            this.groupBoxAttributes.Controls.Add(this.labelRepetitions);
            this.groupBoxAttributes.Location = new System.Drawing.Point(448, 19);
            this.groupBoxAttributes.Name = "groupBoxAttributes";
            this.groupBoxAttributes.Size = new System.Drawing.Size(287, 371);
            this.groupBoxAttributes.TabIndex = 26;
            this.groupBoxAttributes.TabStop = false;
            this.groupBoxAttributes.Text = "Attributes";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(9, 27);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(37, 13);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type: ";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(12, 43);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(130, 21);
            this.comboBoxType.TabIndex = 3;
            // 
            // labelCriticalProbability
            // 
            this.labelCriticalProbability.AutoSize = true;
            this.labelCriticalProbability.Location = new System.Drawing.Point(12, 122);
            this.labelCriticalProbability.Name = "labelCriticalProbability";
            this.labelCriticalProbability.Size = new System.Drawing.Size(95, 13);
            this.labelCriticalProbability.TabIndex = 14;
            this.labelCriticalProbability.Text = "Critical Probability: ";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(155, 27);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 13);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category: ";
            // 
            // numericUpDownCriticalProbability
            // 
            this.numericUpDownCriticalProbability.DecimalPlaces = 2;
            this.numericUpDownCriticalProbability.Location = new System.Drawing.Point(12, 140);
            this.numericUpDownCriticalProbability.Name = "numericUpDownCriticalProbability";
            this.numericUpDownCriticalProbability.Size = new System.Drawing.Size(130, 20);
            this.numericUpDownCriticalProbability.TabIndex = 15;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(155, 43);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(123, 21);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // comboBoxEffectCode
            // 
            this.comboBoxEffectCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxEffectCode.FormattingEnabled = true;
            this.comboBoxEffectCode.Items.AddRange(new object[] {
            "Effect Code..."});
            this.comboBoxEffectCode.Location = new System.Drawing.Point(12, 337);
            this.comboBoxEffectCode.Name = "comboBoxEffectCode";
            this.comboBoxEffectCode.Size = new System.Drawing.Size(127, 21);
            this.comboBoxEffectCode.TabIndex = 13;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(152, 75);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(43, 13);
            this.labelPower.TabIndex = 4;
            this.labelPower.Text = "Power: ";
            // 
            // labelEffectProbability
            // 
            this.labelEffectProbability.AutoSize = true;
            this.labelEffectProbability.Location = new System.Drawing.Point(155, 122);
            this.labelEffectProbability.Name = "labelEffectProbability";
            this.labelEffectProbability.Size = new System.Drawing.Size(92, 13);
            this.labelEffectProbability.TabIndex = 11;
            this.labelEffectProbability.Text = "Effect Probability: ";
            // 
            // labelAccuarcy
            // 
            this.labelAccuarcy.AutoSize = true;
            this.labelAccuarcy.Location = new System.Drawing.Point(12, 75);
            this.labelAccuarcy.Name = "labelAccuarcy";
            this.labelAccuarcy.Size = new System.Drawing.Size(58, 13);
            this.labelAccuarcy.TabIndex = 5;
            this.labelAccuarcy.Text = "Accuarcy: ";
            // 
            // numericUpDownEffectProbability
            // 
            this.numericUpDownEffectProbability.DecimalPlaces = 2;
            this.numericUpDownEffectProbability.Location = new System.Drawing.Point(155, 139);
            this.numericUpDownEffectProbability.Name = "numericUpDownEffectProbability";
            this.numericUpDownEffectProbability.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownEffectProbability.TabIndex = 12;
            // 
            // numericUpDownPower
            // 
            this.numericUpDownPower.Location = new System.Drawing.Point(152, 91);
            this.numericUpDownPower.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPower.Name = "numericUpDownPower";
            this.numericUpDownPower.Size = new System.Drawing.Size(126, 20);
            this.numericUpDownPower.TabIndex = 6;
            // 
            // labelEffectCode
            // 
            this.labelEffectCode.AutoSize = true;
            this.labelEffectCode.Location = new System.Drawing.Point(12, 320);
            this.labelEffectCode.Name = "labelEffectCode";
            this.labelEffectCode.Size = new System.Drawing.Size(69, 13);
            this.labelEffectCode.TabIndex = 9;
            this.labelEffectCode.Text = "Effect Code: ";
            // 
            // numericUpDownAccuarcy
            // 
            this.numericUpDownAccuarcy.DecimalPlaces = 2;
            this.numericUpDownAccuarcy.Location = new System.Drawing.Point(12, 91);
            this.numericUpDownAccuarcy.Name = "numericUpDownAccuarcy";
            this.numericUpDownAccuarcy.Size = new System.Drawing.Size(126, 20);
            this.numericUpDownAccuarcy.TabIndex = 7;
            // 
            // numericUpDownPP
            // 
            this.numericUpDownPP.Location = new System.Drawing.Point(155, 189);
            this.numericUpDownPP.Name = "numericUpDownPP";
            this.numericUpDownPP.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownPP.TabIndex = 7;
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(12, 271);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(44, 13);
            this.labelTarget.TabIndex = 2;
            this.labelTarget.Text = "Target: ";
            // 
            // labelPP
            // 
            this.labelPP.AutoSize = true;
            this.labelPP.Location = new System.Drawing.Point(155, 173);
            this.labelPP.Name = "labelPP";
            this.labelPP.Size = new System.Drawing.Size(27, 13);
            this.labelPP.TabIndex = 5;
            this.labelPP.Text = "PP: ";
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Location = new System.Drawing.Point(12, 287);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(127, 21);
            this.comboBoxTarget.TabIndex = 3;
            // 
            // labelRecoverByDamage
            // 
            this.labelRecoverByDamage.AutoSize = true;
            this.labelRecoverByDamage.Location = new System.Drawing.Point(12, 174);
            this.labelRecoverByDamage.Name = "labelRecoverByDamage";
            this.labelRecoverByDamage.Size = new System.Drawing.Size(100, 13);
            this.labelRecoverByDamage.TabIndex = 4;
            this.labelRecoverByDamage.Text = "Rcover by damage:";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(152, 271);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(44, 13);
            this.labelPriority.TabIndex = 4;
            this.labelPriority.Text = "Priority: ";
            // 
            // numericUpDownRecoverByDamage
            // 
            this.numericUpDownRecoverByDamage.DecimalPlaces = 2;
            this.numericUpDownRecoverByDamage.Location = new System.Drawing.Point(12, 190);
            this.numericUpDownRecoverByDamage.Name = "numericUpDownRecoverByDamage";
            this.numericUpDownRecoverByDamage.Size = new System.Drawing.Size(130, 20);
            this.numericUpDownRecoverByDamage.TabIndex = 6;
            // 
            // numericUpDownPriority
            // 
            this.numericUpDownPriority.Location = new System.Drawing.Point(152, 287);
            this.numericUpDownPriority.Name = "numericUpDownPriority";
            this.numericUpDownPriority.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownPriority.TabIndex = 6;
            // 
            // numericUpDownRepetitionsInTurn
            // 
            this.numericUpDownRepetitionsInTurn.Location = new System.Drawing.Point(155, 238);
            this.numericUpDownRepetitionsInTurn.Name = "numericUpDownRepetitionsInTurn";
            this.numericUpDownRepetitionsInTurn.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownRepetitionsInTurn.TabIndex = 7;
            // 
            // numericUpDownRepetitions
            // 
            this.numericUpDownRepetitions.Location = new System.Drawing.Point(12, 239);
            this.numericUpDownRepetitions.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRepetitions.Name = "numericUpDownRepetitions";
            this.numericUpDownRepetitions.Size = new System.Drawing.Size(127, 20);
            this.numericUpDownRepetitions.TabIndex = 6;
            // 
            // labelRepetitionsInTurn
            // 
            this.labelRepetitionsInTurn.AutoSize = true;
            this.labelRepetitionsInTurn.Location = new System.Drawing.Point(155, 222);
            this.labelRepetitionsInTurn.Name = "labelRepetitionsInTurn";
            this.labelRepetitionsInTurn.Size = new System.Drawing.Size(98, 13);
            this.labelRepetitionsInTurn.TabIndex = 5;
            this.labelRepetitionsInTurn.Text = "Repetitions in turn: ";
            // 
            // labelRepetitions
            // 
            this.labelRepetitions.AutoSize = true;
            this.labelRepetitions.Location = new System.Drawing.Point(12, 223);
            this.labelRepetitions.Name = "labelRepetitions";
            this.labelRepetitions.Size = new System.Drawing.Size(66, 13);
            this.labelRepetitions.TabIndex = 4;
            this.labelRepetitions.Text = "Repetitions: ";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBoxDescription.Location = new System.Drawing.Point(6, 46);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(436, 280);
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
            this.textBoxName.Size = new System.Drawing.Size(436, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Name...";
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // buttonAddMove
            // 
            this.buttonAddMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMove.Location = new System.Drawing.Point(682, 414);
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
            this.buttonCancel.Location = new System.Drawing.Point(601, 414);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddOrUpdateMoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 449);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddMove);
            this.Controls.Add(this.groupBoxGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrUpdateMoveForm";
            this.Text = "AddOrUpdateMoveForm";
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.groupBoxBooleans.ResumeLayout(false);
            this.groupBoxBooleans.PerformLayout();
            this.groupBoxAttributes.ResumeLayout(false);
            this.groupBoxAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCriticalProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEffectProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuarcy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecoverByDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetitionsInTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetitions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
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
        private System.Windows.Forms.Label labelRecoverByDamage;
        private System.Windows.Forms.NumericUpDown numericUpDownRecoverByDamage;
        private System.Windows.Forms.CheckBox checkBoxContact;
        private System.Windows.Forms.Label labelEffectProbability;
        private System.Windows.Forms.NumericUpDown numericUpDownEffectProbability;
        private System.Windows.Forms.Label labelEffectCode;
        private System.Windows.Forms.Button buttonAddMove;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxEffectCode;
        private System.Windows.Forms.Label labelCriticalProbability;
        private System.Windows.Forms.NumericUpDown numericUpDownCriticalProbability;
        private System.Windows.Forms.CheckBox checkBoxCanBeProtected;
        private System.Windows.Forms.CheckBox checkBoxIsDance;
        private System.Windows.Forms.CheckBox checkBoxAffectedByBounceEffect;
        private System.Windows.Forms.CheckBox checkBoxCanDefrost;
        private System.Windows.Forms.CheckBox checkBoxCanBeStealed;
        private System.Windows.Forms.CheckBox checkBoxIsSound;
        private System.Windows.Forms.CheckBox checkBoxIsPerforation;
        private System.Windows.Forms.CheckBox checkBoxAffectedByKingsRock;
        private System.Windows.Forms.CheckBox checkBoxCanBeCopied;
        private System.Windows.Forms.CheckBox checkBoxAffectedByGravity;
        private System.Windows.Forms.GroupBox groupBoxBooleans;
        private System.Windows.Forms.GroupBox groupBoxAttributes;
    }
}