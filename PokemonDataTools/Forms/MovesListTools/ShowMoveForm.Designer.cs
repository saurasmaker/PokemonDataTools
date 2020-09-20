namespace PokemonDataTools.Forms.MovesListTools
{
    partial class ShowMoveForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.richTextBoxShowPokeMove = new System.Windows.Forms.RichTextBox();
            this.btnSearchPokeMove = new System.Windows.Forms.Button();
            this.labelShowPokemove = new System.Windows.Forms.Label();
            this.comboBoxPokemove = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(12, 358);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(64, 20);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // richTextBoxShowPokeMove
            // 
            this.richTextBoxShowPokeMove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxShowPokeMove.Location = new System.Drawing.Point(12, 49);
            this.richTextBoxShowPokeMove.Name = "richTextBoxShowPokeMove";
            this.richTextBoxShowPokeMove.ReadOnly = true;
            this.richTextBoxShowPokeMove.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxShowPokeMove.Size = new System.Drawing.Size(465, 303);
            this.richTextBoxShowPokeMove.TabIndex = 9;
            this.richTextBoxShowPokeMove.Text = "";
            // 
            // btnSearchPokeMove
            // 
            this.btnSearchPokeMove.Location = new System.Drawing.Point(12, 24);
            this.btnSearchPokeMove.Name = "btnSearchPokeMove";
            this.btnSearchPokeMove.Size = new System.Drawing.Size(64, 20);
            this.btnSearchPokeMove.TabIndex = 7;
            this.btnSearchPokeMove.Text = "Search";
            this.btnSearchPokeMove.UseVisualStyleBackColor = true;
            this.btnSearchPokeMove.Click += new System.EventHandler(this.btnSearchPokeMove_Click);
            // 
            // labelShowPokemove
            // 
            this.labelShowPokemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShowPokemove.AutoSize = true;
            this.labelShowPokemove.Location = new System.Drawing.Point(12, 9);
            this.labelShowPokemove.Name = "labelShowPokemove";
            this.labelShowPokemove.Size = new System.Drawing.Size(88, 13);
            this.labelShowPokemove.TabIndex = 6;
            this.labelShowPokemove.Text = "Show Pokemove";
            // 
            // comboBoxPokemove
            // 
            this.comboBoxPokemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPokemove.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxPokemove.FormattingEnabled = true;
            this.comboBoxPokemove.Location = new System.Drawing.Point(83, 22);
            this.comboBoxPokemove.Name = "comboBoxPokemove";
            this.comboBoxPokemove.Size = new System.Drawing.Size(394, 21);
            this.comboBoxPokemove.TabIndex = 11;
            // 
            // ShowMoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 393);
            this.Controls.Add(this.comboBoxPokemove);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.richTextBoxShowPokeMove);
            this.Controls.Add(this.btnSearchPokeMove);
            this.Controls.Add(this.labelShowPokemove);
            this.Name = "ShowMoveForm";
            this.Text = "ShowMoveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RichTextBox richTextBoxShowPokeMove;
        private System.Windows.Forms.Button btnSearchPokeMove;
        private System.Windows.Forms.Label labelShowPokemove;
        private System.Windows.Forms.ComboBox comboBoxPokemove;
    }
}