namespace Hex___Decimal_Converter
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
            this.num1 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.num2 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.hex_btn = new Siticone.UI.WinForms.SiticoneButton();
            this.dec_btn = new Siticone.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num1.DefaultText = "";
            this.num1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.num1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.num1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.num1.DisabledState.Parent = this.num1;
            this.num1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.num1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.num1.FocusedState.Parent = this.num1;
            this.num1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.num1.HoveredState.Parent = this.num1;
            this.num1.Location = new System.Drawing.Point(78, 112);
            this.num1.Name = "num1";
            this.num1.PasswordChar = '\0';
            this.num1.PlaceholderText = "";
            this.num1.SelectedText = "";
            this.num1.ShadowDecoration.Parent = this.num1;
            this.num1.Size = new System.Drawing.Size(200, 36);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num2.DefaultText = "";
            this.num2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.num2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.num2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.num2.DisabledState.Parent = this.num2;
            this.num2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.num2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.num2.FocusedState.Parent = this.num2;
            this.num2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.num2.HoveredState.Parent = this.num2;
            this.num2.Location = new System.Drawing.Point(367, 112);
            this.num2.Name = "num2";
            this.num2.PasswordChar = '\0';
            this.num2.PlaceholderText = "";
            this.num2.SelectedText = "";
            this.num2.ShadowDecoration.Parent = this.num2;
            this.num2.Size = new System.Drawing.Size(200, 36);
            this.num2.TabIndex = 1;
            // 
            // hex_btn
            // 
            this.hex_btn.CheckedState.Parent = this.hex_btn;
            this.hex_btn.CustomImages.Parent = this.hex_btn;
            this.hex_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hex_btn.ForeColor = System.Drawing.Color.White;
            this.hex_btn.HoveredState.Parent = this.hex_btn;
            this.hex_btn.Location = new System.Drawing.Point(224, 178);
            this.hex_btn.Name = "hex_btn";
            this.hex_btn.ShadowDecoration.Parent = this.hex_btn;
            this.hex_btn.Size = new System.Drawing.Size(180, 45);
            this.hex_btn.TabIndex = 2;
            this.hex_btn.Text = "Convert To Hex";
            this.hex_btn.Click += new System.EventHandler(this.hex_btn_Click);
            // 
            // dec_btn
            // 
            this.dec_btn.CheckedState.Parent = this.dec_btn;
            this.dec_btn.CustomImages.Parent = this.dec_btn;
            this.dec_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dec_btn.ForeColor = System.Drawing.Color.White;
            this.dec_btn.HoveredState.Parent = this.dec_btn;
            this.dec_btn.Location = new System.Drawing.Point(224, 229);
            this.dec_btn.Name = "dec_btn";
            this.dec_btn.ShadowDecoration.Parent = this.dec_btn;
            this.dec_btn.Size = new System.Drawing.Size(180, 45);
            this.dec_btn.TabIndex = 3;
            this.dec_btn.Text = "Convert To Decimal";
            this.dec_btn.Click += new System.EventHandler(this.dec_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 415);
            this.Controls.Add(this.dec_btn);
            this.Controls.Add(this.hex_btn);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneMaterialTextBox num1;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox num2;
        private Siticone.UI.WinForms.SiticoneButton hex_btn;
        private Siticone.UI.WinForms.SiticoneButton dec_btn;
    }
}

