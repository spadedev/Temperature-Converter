
namespace Temperature_Converter
{
    partial class TemperatureConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.celcius_txtbox = new System.Windows.Forms.TextBox();
            this.fahrenheit_txtbox = new System.Windows.Forms.TextBox();
            this.convertFahren_btn = new System.Windows.Forms.Button();
            this.convertCelcius_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the temperature:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celcius:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fahrenheit:";
            // 
            // celcius_txtbox
            // 
            this.celcius_txtbox.Location = new System.Drawing.Point(37, 100);
            this.celcius_txtbox.Name = "celcius_txtbox";
            this.celcius_txtbox.Size = new System.Drawing.Size(100, 20);
            this.celcius_txtbox.TabIndex = 3;
            // 
            // fahrenheit_txtbox
            // 
            this.fahrenheit_txtbox.Location = new System.Drawing.Point(180, 100);
            this.fahrenheit_txtbox.Name = "fahrenheit_txtbox";
            this.fahrenheit_txtbox.Size = new System.Drawing.Size(100, 20);
            this.fahrenheit_txtbox.TabIndex = 4;
            // 
            // convertFahren_btn
            // 
            this.convertFahren_btn.Location = new System.Drawing.Point(88, 150);
            this.convertFahren_btn.Name = "convertFahren_btn";
            this.convertFahren_btn.Size = new System.Drawing.Size(137, 23);
            this.convertFahren_btn.TabIndex = 5;
            this.convertFahren_btn.Text = "Convert to Fahrenheit";
            this.convertFahren_btn.UseVisualStyleBackColor = true;
            this.convertFahren_btn.Click += new System.EventHandler(this.convertFahren_btn_Click);
            // 
            // convertCelcius_btn
            // 
            this.convertCelcius_btn.Location = new System.Drawing.Point(88, 179);
            this.convertCelcius_btn.Name = "convertCelcius_btn";
            this.convertCelcius_btn.Size = new System.Drawing.Size(137, 23);
            this.convertCelcius_btn.TabIndex = 6;
            this.convertCelcius_btn.Text = "Convert to Celcius";
            this.convertCelcius_btn.UseVisualStyleBackColor = true;
            this.convertCelcius_btn.Click += new System.EventHandler(this.convertCelcius_btn_Click);
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(324, 243);
            this.Controls.Add(this.convertCelcius_btn);
            this.Controls.Add(this.convertFahren_btn);
            this.Controls.Add(this.fahrenheit_txtbox);
            this.Controls.Add(this.celcius_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TemperatureConverter";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox celcius_txtbox;
        private System.Windows.Forms.TextBox fahrenheit_txtbox;
        private System.Windows.Forms.Button convertFahren_btn;
        private System.Windows.Forms.Button convertCelcius_btn;
    }
}

