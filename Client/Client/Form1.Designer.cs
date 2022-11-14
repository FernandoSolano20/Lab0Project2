namespace Client
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
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.exchangeRateValue = new MetroFramework.Drawing.Html.HtmlLabel();
            this.dateTime = new MetroFramework.Controls.MetroDateTime();
            this.requestExchangeRate = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.inputExchange = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(286, 25);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(214, 35);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(368, 73);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "Consultar tipo de cambio de colones a dolares";
            // 
            // exchangeRateValue
            // 
            this.exchangeRateValue.AutoScroll = true;
            this.exchangeRateValue.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.exchangeRateValue.AutoSize = false;
            this.exchangeRateValue.BackColor = System.Drawing.SystemColors.Window;
            this.exchangeRateValue.Location = new System.Drawing.Point(459, 157);
            this.exchangeRateValue.Name = "exchangeRateValue";
            this.exchangeRateValue.Size = new System.Drawing.Size(198, 73);
            this.exchangeRateValue.TabIndex = 1;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(214, 180);
            this.dateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 30);
            this.dateTime.TabIndex = 2;
            // 
            // requestExchangeRate
            // 
            this.requestExchangeRate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.requestExchangeRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.requestExchangeRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.requestExchangeRate.Location = new System.Drawing.Point(319, 260);
            this.requestExchangeRate.Name = "requestExchangeRate";
            this.requestExchangeRate.Size = new System.Drawing.Size(107, 23);
            this.requestExchangeRate.Style = MetroFramework.MetroColorStyle.Blue;
            this.requestExchangeRate.TabIndex = 3;
            this.requestExchangeRate.Text = "Consultar";
            this.requestExchangeRate.UseSelectable = true;
            this.requestExchangeRate.Click += new System.EventHandler(this.requestExchangeRate_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(520, 260);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Crear";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(158, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(668, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // inputExchange
            // 
            // 
            // 
            // 
            this.inputExchange.CustomButton.Image = null;
            this.inputExchange.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.inputExchange.CustomButton.Name = "";
            this.inputExchange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inputExchange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputExchange.CustomButton.TabIndex = 1;
            this.inputExchange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputExchange.CustomButton.UseSelectable = true;
            this.inputExchange.CustomButton.Visible = false;
            this.inputExchange.Lines = new string[0];
            this.inputExchange.Location = new System.Drawing.Point(12, 186);
            this.inputExchange.MaxLength = 32767;
            this.inputExchange.Name = "inputExchange";
            this.inputExchange.PasswordChar = '\0';
            this.inputExchange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputExchange.SelectedText = "";
            this.inputExchange.SelectionLength = 0;
            this.inputExchange.SelectionStart = 0;
            this.inputExchange.ShortcutsEnabled = true;
            this.inputExchange.Size = new System.Drawing.Size(155, 23);
            this.inputExchange.TabIndex = 7;
            this.inputExchange.UseSelectable = true;
            this.inputExchange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputExchange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputExchange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.requestExchangeRate);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.exchangeRateValue);
            this.Controls.Add(this.htmlLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel exchangeRateValue;
        private MetroFramework.Controls.MetroDateTime dateTime;
        private MetroFramework.Controls.MetroButton requestExchangeRate;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroTextBox inputExchange;
    }
}

