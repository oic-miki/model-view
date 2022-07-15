
namespace ModelView
{
    partial class CharacterView
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
            this.agilityLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.hitPointLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agilityLabel
            // 
            this.agilityLabel.AutoSize = true;
            this.agilityLabel.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.agilityLabel.Location = new System.Drawing.Point(114, 422);
            this.agilityLabel.Name = "agilityLabel";
            this.agilityLabel.Size = new System.Drawing.Size(107, 45);
            this.agilityLabel.TabIndex = 9;
            this.agilityLabel.Text = "label1";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.strengthLabel.Location = new System.Drawing.Point(114, 331);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(107, 45);
            this.strengthLabel.TabIndex = 8;
            this.strengthLabel.Text = "label1";
            // 
            // hitPointLabel
            // 
            this.hitPointLabel.AutoSize = true;
            this.hitPointLabel.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hitPointLabel.Location = new System.Drawing.Point(114, 244);
            this.hitPointLabel.Name = "hitPointLabel";
            this.hitPointLabel.Size = new System.Drawing.Size(107, 45);
            this.hitPointLabel.TabIndex = 7;
            this.hitPointLabel.Text = "label1";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.roleLabel.Location = new System.Drawing.Point(114, 157);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(107, 45);
            this.roleLabel.TabIndex = 6;
            this.roleLabel.Text = "label1";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.Location = new System.Drawing.Point(114, 73);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 45);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "label1";
            // 
            // CharacterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 541);
            this.Controls.Add(this.agilityLabel);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.hitPointLabel);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "CharacterView";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label agilityLabel;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label hitPointLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}