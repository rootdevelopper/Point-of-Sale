namespace Caffe_7_1_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonBuy = new System.Windows.Forms.RadioButton();
            this.radioButtonCredit = new System.Windows.Forms.RadioButton();
            this.radioButtonPriceCheck = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBoxAllItems = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select an item to scann";
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBuy.Location = new System.Drawing.Point(30, 66);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(78, 17);
            this.radioButtonBuy.TabIndex = 6;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Purchase";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            this.radioButtonBuy.CheckedChanged += new System.EventHandler(this.radioButtonBuy_CheckedChanged);
            // 
            // radioButtonCredit
            // 
            this.radioButtonCredit.AutoSize = true;
            this.radioButtonCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCredit.Location = new System.Drawing.Point(30, 117);
            this.radioButtonCredit.Name = "radioButtonCredit";
            this.radioButtonCredit.Size = new System.Drawing.Size(96, 17);
            this.radioButtonCredit.TabIndex = 7;
            this.radioButtonCredit.TabStop = true;
            this.radioButtonCredit.Text = "credit/return";
            this.radioButtonCredit.UseVisualStyleBackColor = true;
            this.radioButtonCredit.CheckedChanged += new System.EventHandler(this.radioButtonCredit_CheckedChanged);
            // 
            // radioButtonPriceCheck
            // 
            this.radioButtonPriceCheck.AutoSize = true;
            this.radioButtonPriceCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPriceCheck.Location = new System.Drawing.Point(30, 172);
            this.radioButtonPriceCheck.Name = "radioButtonPriceCheck";
            this.radioButtonPriceCheck.Size = new System.Drawing.Size(94, 17);
            this.radioButtonPriceCheck.TabIndex = 8;
            this.radioButtonPriceCheck.TabStop = true;
            this.radioButtonPriceCheck.Text = "Price Check";
            this.radioButtonPriceCheck.UseVisualStyleBackColor = true;
            this.radioButtonPriceCheck.CheckedChanged += new System.EventHandler(this.radioButtonPriceCheck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Scan Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(427, 252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(124, 19);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // comboBoxAllItems
            // 
            this.comboBoxAllItems.FormattingEnabled = true;
            this.comboBoxAllItems.Location = new System.Drawing.Point(188, 144);
            this.comboBoxAllItems.Name = "comboBoxAllItems";
            this.comboBoxAllItems.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAllItems.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Exit checkout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxAllItems);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonPriceCheck);
            this.Controls.Add(this.radioButtonCredit);
            this.Controls.Add(this.radioButtonBuy);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "POS Java Caffe, Implemented by Hector Sanchez";
            this.TransparencyKey = System.Drawing.Color.Gold;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonBuy;
        private System.Windows.Forms.RadioButton radioButtonCredit;
        private System.Windows.Forms.RadioButton radioButtonPriceCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBoxAllItems;
        private System.Windows.Forms.Button button2;
    }
}

