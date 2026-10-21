namespace calculator_winApp
{
    partial class frmCalculator
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
            this.lblDsplay = new System.Windows.Forms.Label();
            this.Btn0 = new System.Windows.Forms.Button();
            this.buttonFloat = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnMulty = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.Btn08 = new System.Windows.Forms.Button();
            this.BtnInvovle = new System.Windows.Forms.Button();
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDsplay
            // 
            this.lblDsplay.BackColor = System.Drawing.Color.LightBlue;
            this.lblDsplay.Font = new System.Drawing.Font("Microsoft PhagsPa", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDsplay.Location = new System.Drawing.Point(12, 9);
            this.lblDsplay.Name = "lblDsplay";
            this.lblDsplay.Size = new System.Drawing.Size(420, 152);
            this.lblDsplay.TabIndex = 1;
            this.lblDsplay.Click += new System.EventHandler(this.allBtnClick);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn0.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn0.Location = new System.Drawing.Point(12, 525);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(100, 74);
            this.Btn0.TabIndex = 8;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.allBtnClick);
            // 
            // buttonFloat
            // 
            this.buttonFloat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonFloat.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFloat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFloat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFloat.Location = new System.Drawing.Point(118, 525);
            this.buttonFloat.Name = "buttonFloat";
            this.buttonFloat.Size = new System.Drawing.Size(100, 74);
            this.buttonFloat.TabIndex = 9;
            this.buttonFloat.Text = ",";
            this.buttonFloat.UseVisualStyleBackColor = false;
            this.buttonFloat.Click += new System.EventHandler(this.allBtnClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDelete.Location = new System.Drawing.Point(226, 525);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 74);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.DarkSalmon;
            this.BtnEquals.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEquals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEquals.Location = new System.Drawing.Point(332, 525);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(100, 74);
            this.BtnEquals.TabIndex = 19;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = false;
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnPlus.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPlus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPlus.Location = new System.Drawing.Point(332, 445);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(100, 74);
            this.BtnPlus.TabIndex = 12;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn3.Location = new System.Drawing.Point(226, 445);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(100, 74);
            this.Btn3.TabIndex = 13;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.allBtnClick);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn2.Location = new System.Drawing.Point(118, 445);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(100, 74);
            this.Btn2.TabIndex = 14;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.allBtnClick);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn1.Location = new System.Drawing.Point(12, 445);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(100, 74);
            this.Btn1.TabIndex = 15;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.allBtnClick);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnMinus.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMinus.Location = new System.Drawing.Point(332, 365);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(100, 74);
            this.BtnMinus.TabIndex = 16;
            this.BtnMinus.Text = "—";
            this.BtnMinus.UseVisualStyleBackColor = false;
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn6.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn6.Location = new System.Drawing.Point(226, 365);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(100, 74);
            this.Btn6.TabIndex = 17;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.allBtnClick);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn5.Location = new System.Drawing.Point(118, 365);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(100, 74);
            this.Btn5.TabIndex = 18;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.allBtnClick);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn4.Location = new System.Drawing.Point(12, 365);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(100, 74);
            this.Btn4.TabIndex = 19;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.allBtnClick);
            // 
            // BtnMulty
            // 
            this.BtnMulty.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnMulty.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnMulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMulty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMulty.Location = new System.Drawing.Point(332, 285);
            this.BtnMulty.Name = "BtnMulty";
            this.BtnMulty.Size = new System.Drawing.Size(100, 74);
            this.BtnMulty.TabIndex = 20;
            this.BtnMulty.Text = "×";
            this.BtnMulty.UseVisualStyleBackColor = false;
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnDivision.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDivision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDivision.Location = new System.Drawing.Point(332, 205);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(100, 74);
            this.BtnDivision.TabIndex = 21;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = false;
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn9.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn9.Location = new System.Drawing.Point(226, 285);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(100, 74);
            this.Btn9.TabIndex = 22;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.allBtnClick);
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnPercent.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPercent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPercent.Location = new System.Drawing.Point(226, 205);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(100, 74);
            this.BtnPercent.TabIndex = 23;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = false;
            // 
            // Btn08
            // 
            this.Btn08.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn08.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn08.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn08.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn08.Location = new System.Drawing.Point(118, 285);
            this.Btn08.Name = "Btn08";
            this.Btn08.Size = new System.Drawing.Size(100, 74);
            this.Btn08.TabIndex = 24;
            this.Btn08.Text = "8";
            this.Btn08.UseVisualStyleBackColor = false;
            this.Btn08.Click += new System.EventHandler(this.allBtnClick);
            // 
            // BtnInvovle
            // 
            this.BtnInvovle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnInvovle.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnInvovle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInvovle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInvovle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnInvovle.Location = new System.Drawing.Point(118, 205);
            this.BtnInvovle.Name = "BtnInvovle";
            this.BtnInvovle.Size = new System.Drawing.Size(100, 74);
            this.BtnInvovle.TabIndex = 25;
            this.BtnInvovle.Text = "^";
            this.BtnInvovle.UseVisualStyleBackColor = false;
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.BackColor = System.Drawing.Color.DarkSalmon;
            this.BtnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClearAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClearAll.Location = new System.Drawing.Point(12, 205);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(100, 74);
            this.BtnClearAll.TabIndex = 26;
            this.BtnClearAll.Text = "AC";
            this.BtnClearAll.UseVisualStyleBackColor = false;
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn7.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn7.Location = new System.Drawing.Point(12, 285);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(100, 74);
            this.Btn7.TabIndex = 27;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.allBtnClick);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(444, 611);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnClearAll);
            this.Controls.Add(this.BtnInvovle);
            this.Controls.Add(this.Btn08);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnMulty);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.buttonFloat);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.lblDsplay);
            this.Name = "frmCalculator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblDsplay;
        private Button Btn0;
        private Button buttonFloat;
        private Button BtnDelete;
        private Button BtnEquals;
        private Button BtnPlus;
        private Button Btn3;
        private Button Btn2;
        private Button Btn1;
        private Button BtnMinus;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button BtnMulty;
        private Button BtnDivision;
        private Button Btn9;
        private Button BtnPercent;
        private Button Btn08;
        private Button BtnInvovle;
        private Button BtnClearAll;
        private Button Btn7;
    }
}
