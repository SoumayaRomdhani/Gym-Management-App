namespace GYM_management
{
    partial class deleteup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteup));
            this.memebrsgbd = new System.Windows.Forms.DataGridView();
            this.timingcb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.amountTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gendercb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ageTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PAY = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.memebrsgbd)).BeginInit();
            this.SuspendLayout();
            // 
            // memebrsgbd
            // 
            this.memebrsgbd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memebrsgbd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memebrsgbd.Location = new System.Drawing.Point(270, 64);
            this.memebrsgbd.Name = "memebrsgbd";
            this.memebrsgbd.Size = new System.Drawing.Size(680, 392);
            this.memebrsgbd.TabIndex = 0;
            this.memebrsgbd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memebrsgbd_CellContentClick);
            // 
            // timingcb
            // 
            this.timingcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.timingcb.ForeColor = System.Drawing.Color.Gainsboro;
            this.timingcb.FormattingEnabled = true;
            this.timingcb.Items.AddRange(new object[] {
            "6Am-8Am",
            "8Am-10Am",
            "6Pm-8Pm",
            "8Pm-10Pm",
            ""});
            this.timingcb.Location = new System.Drawing.Point(38, 432);
            this.timingcb.Name = "timingcb";
            this.timingcb.Size = new System.Drawing.Size(152, 24);
            this.timingcb.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(37, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "TIMING";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(33, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "MONTHLY AMOUNT";
            // 
            // amountTb
            // 
            this.amountTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.amountTb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.amountTb.HintForeColor = System.Drawing.Color.Empty;
            this.amountTb.HintText = "";
            this.amountTb.isPassword = false;
            this.amountTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.amountTb.LineIdleColor = System.Drawing.Color.DimGray;
            this.amountTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.amountTb.LineThickness = 3;
            this.amountTb.Location = new System.Drawing.Point(30, 214);
            this.amountTb.Margin = new System.Windows.Forms.Padding(4);
            this.amountTb.Name = "amountTb";
            this.amountTb.Size = new System.Drawing.Size(151, 32);
            this.amountTb.TabIndex = 25;
            this.amountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gendercb
            // 
            this.gendercb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gendercb.ForeColor = System.Drawing.Color.Gainsboro;
            this.gendercb.FormattingEnabled = true;
            this.gendercb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.gendercb.Location = new System.Drawing.Point(38, 358);
            this.gendercb.Name = "gendercb";
            this.gendercb.Size = new System.Drawing.Size(152, 24);
            this.gendercb.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(34, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "GENDER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(39, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "AGE";
            // 
            // ageTb
            // 
            this.ageTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ageTb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ageTb.HintForeColor = System.Drawing.Color.Empty;
            this.ageTb.HintText = "";
            this.ageTb.isPassword = false;
            this.ageTb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.ageTb.LineIdleColor = System.Drawing.Color.DimGray;
            this.ageTb.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.ageTb.LineThickness = 3;
            this.ageTb.Location = new System.Drawing.Point(38, 280);
            this.ageTb.Margin = new System.Windows.Forms.Padding(4);
            this.ageTb.Name = "ageTb";
            this.ageTb.Size = new System.Drawing.Size(137, 32);
            this.ageTb.TabIndex = 21;
            this.ageTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(39, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "PHONE NUMBER";
            // 
            // phoneTb
            // 
            this.phoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.phoneTb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.phoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.phoneTb.HintText = "";
            this.phoneTb.isPassword = false;
            this.phoneTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.phoneTb.LineIdleColor = System.Drawing.Color.DimGray;
            this.phoneTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.phoneTb.LineThickness = 3;
            this.phoneTb.Location = new System.Drawing.Point(30, 139);
            this.phoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(151, 32);
            this.phoneTb.TabIndex = 19;
            this.phoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(43, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "MEMBER";
            // 
            // nameTb
            // 
            this.nameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nameTb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nameTb.HintForeColor = System.Drawing.Color.Empty;
            this.nameTb.HintText = "";
            this.nameTb.isPassword = false;
            this.nameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.nameTb.LineIdleColor = System.Drawing.Color.DimGray;
            this.nameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nameTb.LineThickness = 3;
            this.nameTb.Location = new System.Drawing.Point(39, 64);
            this.nameTb.Margin = new System.Windows.Forms.Padding(4);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(152, 32);
            this.nameTb.TabIndex = 17;
            this.nameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "RESET";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(128, 466);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(78, 39);
            this.bunifuThinButton21.TabIndex = 35;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // PAY
            // 
            this.PAY.ActiveBorderThickness = 1;
            this.PAY.ActiveCornerRadius = 20;
            this.PAY.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.PAY.ActiveForecolor = System.Drawing.Color.White;
            this.PAY.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.PAY.BackColor = System.Drawing.Color.White;
            this.PAY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PAY.BackgroundImage")));
            this.PAY.ButtonText = "ADD";
            this.PAY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PAY.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAY.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PAY.IdleBorderThickness = 1;
            this.PAY.IdleCornerRadius = 20;
            this.PAY.IdleFillColor = System.Drawing.Color.White;
            this.PAY.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.PAY.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.PAY.Location = new System.Drawing.Point(38, 464);
            this.PAY.Margin = new System.Windows.Forms.Padding(5);
            this.PAY.Name = "PAY";
            this.PAY.Size = new System.Drawing.Size(71, 41);
            this.PAY.TabIndex = 34;
            this.PAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PAY.Click += new System.EventHandler(this.PAY_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(924, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 43);
            this.label3.TabIndex = 36;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "back";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(66, 511);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(78, 39);
            this.bunifuThinButton22.TabIndex = 37;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "delete";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(166, 511);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(78, 39);
            this.bunifuThinButton23.TabIndex = 38;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // deleteup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 564);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.PAY);
            this.Controls.Add(this.timingcb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.amountTb);
            this.Controls.Add(this.gendercb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ageTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.memebrsgbd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleteup";
            this.Text = "deleteup";
            this.Load += new System.EventHandler(this.deleteup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memebrsgbd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView memebrsgbd;
        private System.Windows.Forms.ComboBox timingcb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox amountTb;
        private System.Windows.Forms.ComboBox gendercb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ageTb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTb;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 PAY;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
    }
}