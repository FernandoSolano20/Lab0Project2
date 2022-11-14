namespace ClientForm
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
            this.dateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.inputExchange = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.exchangeRateValue = new MetroFramework.Drawing.Html.HtmlLabel();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(324, 171);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(265, 30);
            this.dateTime.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(560, 271);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 28);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Actualizar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(449, 42);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tipo de cambio";
            // 
            // inputExchange
            // 
            // 
            // 
            // 
            this.inputExchange.CustomButton.Image = null;
            this.inputExchange.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.inputExchange.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputExchange.CustomButton.Name = "";
            this.inputExchange.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.inputExchange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputExchange.CustomButton.TabIndex = 1;
            this.inputExchange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputExchange.CustomButton.UseSelectable = true;
            this.inputExchange.CustomButton.Visible = false;
            this.inputExchange.Lines = new string[0];
            this.inputExchange.Location = new System.Drawing.Point(88, 177);
            this.inputExchange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputExchange.MaxLength = 32767;
            this.inputExchange.Name = "inputExchange";
            this.inputExchange.PasswordChar = '\0';
            this.inputExchange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputExchange.SelectedText = "";
            this.inputExchange.SelectionLength = 0;
            this.inputExchange.SelectionStart = 0;
            this.inputExchange.ShortcutsEnabled = true;
            this.inputExchange.Size = new System.Drawing.Size(141, 28);
            this.inputExchange.TabIndex = 3;
            this.inputExchange.UseSelectable = true;
            this.inputExchange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputExchange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(88, 271);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(100, 28);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Crear";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(324, 270);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(100, 28);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "Consultar";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(776, 270);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(100, 28);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Eliminar";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // exchangeRateValue
            // 
            this.exchangeRateValue.AutoScroll = true;
            this.exchangeRateValue.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.exchangeRateValue.AutoSize = false;
            this.exchangeRateValue.BackColor = System.Drawing.SystemColors.Window;
            this.exchangeRateValue.Location = new System.Drawing.Point(708, 171);
            this.exchangeRateValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exchangeRateValue.Name = "exchangeRateValue";
            this.exchangeRateValue.Size = new System.Drawing.Size(168, 47);
            this.exchangeRateValue.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.exchangeRateValue);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.inputExchange);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dateTime);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dateTime;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox inputExchange;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Drawing.Html.HtmlLabel exchangeRateValue;
    }
}

