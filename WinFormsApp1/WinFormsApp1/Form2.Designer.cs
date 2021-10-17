
namespace WinFormsApp1
{
    partial class Form2
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
            this.principaltext = new System.Windows.Forms.TextBox();
            this.Rate = new System.Windows.Forms.Label();
            this.ratetxt = new System.Windows.Forms.TextBox();
            this.Calculateinterestbt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inttxt = new System.Windows.Forms.TextBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            // 
            // principaltext
            // 
            this.principaltext.Location = new System.Drawing.Point(447, 82);
            this.principaltext.Name = "principaltext";
            this.principaltext.Size = new System.Drawing.Size(125, 27);
            this.principaltext.TabIndex = 1;
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Location = new System.Drawing.Point(271, 153);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(39, 20);
            this.Rate.TabIndex = 2;
            this.Rate.Text = "Rate";
            // 
            // ratetxt
            // 
            this.ratetxt.AcceptsReturn = true;
            this.ratetxt.Location = new System.Drawing.Point(447, 146);
            this.ratetxt.Name = "ratetxt";
            this.ratetxt.Size = new System.Drawing.Size(125, 27);
            this.ratetxt.TabIndex = 3;
            // 
            // Calculateinterestbt
            // 
            this.Calculateinterestbt.Location = new System.Drawing.Point(447, 232);
            this.Calculateinterestbt.Name = "Calculateinterestbt";
            this.Calculateinterestbt.Size = new System.Drawing.Size(125, 29);
            this.Calculateinterestbt.TabIndex = 4;
            this.Calculateinterestbt.Text = "Calculate interest";
            this.Calculateinterestbt.UseVisualStyleBackColor = true;
            this.Calculateinterestbt.Click += new System.EventHandler(this.Calculateinterestbt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price(months)";
            // 
            // pricetxt
            // 
            this.pricetxt.AcceptsReturn = true;
            this.pricetxt.Location = new System.Drawing.Point(447, 197);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(125, 27);
            this.pricetxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(271, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Interest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount";
            // 
            // inttxt
            // 
            this.inttxt.AcceptsReturn = true;
            this.inttxt.Location = new System.Drawing.Point(447, 295);
            this.inttxt.Name = "inttxt";
            this.inttxt.Size = new System.Drawing.Size(125, 27);
            this.inttxt.TabIndex = 9;
            // 
            // amounttxt
            // 
            this.amounttxt.AcceptsReturn = true;
            this.amounttxt.Location = new System.Drawing.Point(447, 352);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.ReadOnly = true;
            this.amounttxt.Size = new System.Drawing.Size(125, 27);
            this.amounttxt.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.inttxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calculateinterestbt);
            this.Controls.Add(this.ratetxt);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.principaltext);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox principaltext;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.TextBox ratetxt;
        private System.Windows.Forms.Button Calculateinterestbt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inttxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox amounttxt;
    }
}