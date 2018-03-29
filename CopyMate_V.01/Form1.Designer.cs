namespace CopyMate_V._01
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.srcTextBox = new System.Windows.Forms.TextBox();
            this.desTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run / Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.runPause_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Source";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.src_button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Destination";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.des_button_Click);
            // 
            // srcTextBox
            // 
            this.srcTextBox.Location = new System.Drawing.Point(126, 130);
            this.srcTextBox.Name = "srcTextBox";
            this.srcTextBox.Size = new System.Drawing.Size(545, 20);
            this.srcTextBox.TabIndex = 4;
            this.srcTextBox.TextChanged += new System.EventHandler(this.srcTextBox_TextChanged);
            // 
            // desTextBox
            // 
            this.desTextBox.Location = new System.Drawing.Point(126, 224);
            this.desTextBox.Name = "desTextBox";
            this.desTextBox.Size = new System.Drawing.Size(545, 20);
            this.desTextBox.TabIndex = 5;
            this.desTextBox.TextChanged += new System.EventHandler(this.desTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desTextBox);
            this.Controls.Add(this.srcTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "CopyMate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox srcTextBox;
        private System.Windows.Forms.TextBox desTextBox;
    }
}

