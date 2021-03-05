
namespace Blunt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resourcePanel = new System.Windows.Forms.Panel();
            this.resourceLabel = new System.Windows.Forms.TextBox();
            this.tsRes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.closeModal = new System.Windows.Forms.Button();
            this.resourcePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected directory";
            // 
            // resourcePanel
            // 
            this.resourcePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resourcePanel.Controls.Add(this.closeModal);
            this.resourcePanel.Controls.Add(this.resourceLabel);
            this.resourcePanel.Controls.Add(this.tsRes);
            this.resourcePanel.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resourcePanel.ForeColor = System.Drawing.Color.White;
            this.resourcePanel.Location = new System.Drawing.Point(218, 129);
            this.resourcePanel.Name = "resourcePanel";
            this.resourcePanel.Size = new System.Drawing.Size(354, 173);
            this.resourcePanel.TabIndex = 3;
            // 
            // resourceLabel
            // 
            this.resourceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.resourceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resourceLabel.ForeColor = System.Drawing.Color.White;
            this.resourceLabel.Location = new System.Drawing.Point(72, 10);
            this.resourceLabel.Name = "resourceLabel";
            this.resourceLabel.Size = new System.Drawing.Size(213, 23);
            this.resourceLabel.TabIndex = 1;
            // 
            // tsRes
            // 
            this.tsRes.BackColor = System.Drawing.SystemColors.Desktop;
            this.tsRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsRes.FlatAppearance.BorderSize = 0;
            this.tsRes.Location = new System.Drawing.Point(15, 75);
            this.tsRes.Name = "tsRes";
            this.tsRes.Size = new System.Drawing.Size(97, 35);
            this.tsRes.TabIndex = 0;
            this.tsRes.Text = "TypeScript";
            this.tsRes.UseVisualStyleBackColor = false;
            this.tsRes.Click += new System.EventHandler(this.tsRes_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "New resource";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.newResource_Click);
            // 
            // closeModal
            // 
            this.closeModal.BackColor = System.Drawing.Color.Maroon;
            this.closeModal.Location = new System.Drawing.Point(315, 10);
            this.closeModal.Name = "closeModal";
            this.closeModal.Size = new System.Drawing.Size(27, 23);
            this.closeModal.TabIndex = 2;
            this.closeModal.Text = "X";
            this.closeModal.UseVisualStyleBackColor = false;
            this.closeModal.Click += new System.EventHandler(this.closeModal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.resourcePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.resourcePanel.ResumeLayout(false);
            this.resourcePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel resourcePanel;
        private System.Windows.Forms.Button tsRes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox resourceLabel;
        private System.Windows.Forms.Button closeModal;
    }
}

