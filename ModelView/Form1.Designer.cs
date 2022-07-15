
namespace ModelView
{
    partial class Arena
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.redCorner = new System.Windows.Forms.Label();
            this.blueCorner = new System.Windows.Forms.Label();
            this.redBehavior = new System.Windows.Forms.Label();
            this.blueBehavior = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redCorner
            // 
            this.redCorner.AutoSize = true;
            this.redCorner.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.redCorner.Location = new System.Drawing.Point(116, 195);
            this.redCorner.Name = "redCorner";
            this.redCorner.Size = new System.Drawing.Size(107, 45);
            this.redCorner.TabIndex = 0;
            this.redCorner.Text = "label1";
            // 
            // blueCorner
            // 
            this.blueCorner.AutoSize = true;
            this.blueCorner.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.blueCorner.Location = new System.Drawing.Point(417, 195);
            this.blueCorner.Name = "blueCorner";
            this.blueCorner.Size = new System.Drawing.Size(107, 45);
            this.blueCorner.TabIndex = 1;
            this.blueCorner.Text = "label1";
            // 
            // redBehavior
            // 
            this.redBehavior.AutoSize = true;
            this.redBehavior.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.redBehavior.Location = new System.Drawing.Point(116, 285);
            this.redBehavior.Name = "redBehavior";
            this.redBehavior.Size = new System.Drawing.Size(107, 45);
            this.redBehavior.TabIndex = 2;
            this.redBehavior.Text = "label1";
            // 
            // blueBehavior
            // 
            this.blueBehavior.AutoSize = true;
            this.blueBehavior.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.blueBehavior.Location = new System.Drawing.Point(417, 285);
            this.blueBehavior.Name = "blueBehavior";
            this.blueBehavior.Size = new System.Drawing.Size(107, 45);
            this.blueBehavior.TabIndex = 3;
            this.blueBehavior.Text = "label1";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.message.Location = new System.Drawing.Point(268, 70);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(107, 45);
            this.message.TabIndex = 4;
            this.message.Text = "label1";
            // 
            // Arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 413);
            this.Controls.Add(this.message);
            this.Controls.Add(this.blueBehavior);
            this.Controls.Add(this.redBehavior);
            this.Controls.Add(this.blueCorner);
            this.Controls.Add(this.redCorner);
            this.Name = "Arena";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label redCorner;
        private System.Windows.Forms.Label blueCorner;
        private System.Windows.Forms.Label redBehavior;
        private System.Windows.Forms.Label blueBehavior;
        private System.Windows.Forms.Label message;
    }
}

