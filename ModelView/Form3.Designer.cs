
namespace ModelView
{
    partial class BehaviorController
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
            this.attack = new System.Windows.Forms.Button();
            this.defense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // attack
            // 
            this.attack.Location = new System.Drawing.Point(56, 123);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(75, 23);
            this.attack.TabIndex = 0;
            this.attack.Text = "攻　撃";
            this.attack.UseVisualStyleBackColor = true;
            this.attack.Click += new System.EventHandler(this.button1_Click);
            // 
            // defense
            // 
            this.defense.Location = new System.Drawing.Point(56, 214);
            this.defense.Name = "defense";
            this.defense.Size = new System.Drawing.Size(75, 23);
            this.defense.TabIndex = 1;
            this.defense.Text = "防　御";
            this.defense.UseVisualStyleBackColor = true;
            this.defense.Click += new System.EventHandler(this.defense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // BehaviorController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defense);
            this.Controls.Add(this.attack);
            this.Name = "BehaviorController";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attack;
        private System.Windows.Forms.Button defense;
        private System.Windows.Forms.Label label1;
    }
}