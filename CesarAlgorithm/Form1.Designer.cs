
namespace CesarAlgorithm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.cryptTextBox = new System.Windows.Forms.TextBox();
            this.cryptedText = new System.Windows.Forms.Label();
            this.uncryptTextBox = new System.Windows.Forms.TextBox();
            this.uncryptTextView = new System.Windows.Forms.Label();
            this.uncryptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptingKeyTextBox = new System.Windows.Forms.TextBox();
            this.decryptingKeyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cryptTextBox
            // 
            this.cryptTextBox.Location = new System.Drawing.Point(133, 177);
            this.cryptTextBox.Name = "cryptTextBox";
            this.cryptTextBox.Size = new System.Drawing.Size(133, 22);
            this.cryptTextBox.TabIndex = 1;
            // 
            // cryptedText
            // 
            this.cryptedText.AutoSize = true;
            this.cryptedText.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cryptedText.Location = new System.Drawing.Point(129, 236);
            this.cryptedText.Name = "cryptedText";
            this.cryptedText.Size = new System.Drawing.Size(66, 22);
            this.cryptedText.TabIndex = 2;
            this.cryptedText.Text = "Qwlwk";
            // 
            // uncryptTextBox
            // 
            this.uncryptTextBox.Location = new System.Drawing.Point(520, 177);
            this.uncryptTextBox.Name = "uncryptTextBox";
            this.uncryptTextBox.Size = new System.Drawing.Size(133, 22);
            this.uncryptTextBox.TabIndex = 3;
            // 
            // uncryptTextView
            // 
            this.uncryptTextView.AutoSize = true;
            this.uncryptTextView.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uncryptTextView.Location = new System.Drawing.Point(516, 236);
            this.uncryptTextView.Name = "uncryptTextView";
            this.uncryptTextView.Size = new System.Drawing.Size(55, 22);
            this.uncryptTextView.TabIndex = 4;
            this.uncryptTextView.Text = "Labas";
            // 
            // uncryptButton
            // 
            this.uncryptButton.Location = new System.Drawing.Point(520, 275);
            this.uncryptButton.Name = "uncryptButton";
            this.uncryptButton.Size = new System.Drawing.Size(133, 54);
            this.uncryptButton.TabIndex = 5;
            this.uncryptButton.Text = "Decrypt";
            this.uncryptButton.UseVisualStyleBackColor = true;
            this.uncryptButton.Click += new System.EventHandler(this.uncryptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Encrypting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Decrypting";
            // 
            // encryptingKeyTextBox
            // 
            this.encryptingKeyTextBox.Location = new System.Drawing.Point(199, 34);
            this.encryptingKeyTextBox.Name = "encryptingKeyTextBox";
            this.encryptingKeyTextBox.Size = new System.Drawing.Size(100, 22);
            this.encryptingKeyTextBox.TabIndex = 8;
            // 
            // decryptingKeyTextBox
            // 
            this.decryptingKeyTextBox.Location = new System.Drawing.Point(588, 34);
            this.decryptingKeyTextBox.Name = "decryptingKeyTextBox";
            this.decryptingKeyTextBox.Size = new System.Drawing.Size(100, 22);
            this.decryptingKeyTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Key:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryptingKeyTextBox);
            this.Controls.Add(this.encryptingKeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uncryptButton);
            this.Controls.Add(this.uncryptTextView);
            this.Controls.Add(this.uncryptTextBox);
            this.Controls.Add(this.cryptedText);
            this.Controls.Add(this.cryptTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cryptTextBox;
        private System.Windows.Forms.Label cryptedText;
        private System.Windows.Forms.TextBox uncryptTextBox;
        private System.Windows.Forms.Label uncryptTextView;
        private System.Windows.Forms.Button uncryptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encryptingKeyTextBox;
        private System.Windows.Forms.TextBox decryptingKeyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

