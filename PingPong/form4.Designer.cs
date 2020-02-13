namespace PingPong
{
    partial class form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form4));
            this.bar1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pl1 = new System.Windows.Forms.Label();
            this.pl2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.point = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsc1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.scr = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtsc2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.ActiveBorderThickness = 1;
            this.bar1.ActiveCornerRadius = 20;
            this.bar1.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.bar1.ActiveForecolor = System.Drawing.Color.LawnGreen;
            this.bar1.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.bar1.BackColor = System.Drawing.Color.Gray;
            this.bar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bar1.BackgroundImage")));
            this.bar1.ButtonText = "";
            this.bar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bar1.Enabled = false;
            this.bar1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.ForeColor = System.Drawing.Color.LawnGreen;
            this.bar1.IdleBorderThickness = 1;
            this.bar1.IdleCornerRadius = 20;
            this.bar1.IdleFillColor = System.Drawing.Color.LawnGreen;
            this.bar1.IdleForecolor = System.Drawing.Color.Transparent;
            this.bar1.IdleLineColor = System.Drawing.Color.Transparent;
            this.bar1.Location = new System.Drawing.Point(29, 113);
            this.bar1.Margin = new System.Windows.Forms.Padding(5);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(10, 116);
            this.bar1.TabIndex = 0;
            this.bar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bar2
            // 
            this.bar2.ActiveBorderThickness = 1;
            this.bar2.ActiveCornerRadius = 20;
            this.bar2.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.bar2.ActiveForecolor = System.Drawing.Color.LawnGreen;
            this.bar2.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.bar2.BackColor = System.Drawing.Color.Gray;
            this.bar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bar2.BackgroundImage")));
            this.bar2.ButtonText = "";
            this.bar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bar2.Enabled = false;
            this.bar2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.ForeColor = System.Drawing.Color.LawnGreen;
            this.bar2.IdleBorderThickness = 1;
            this.bar2.IdleCornerRadius = 20;
            this.bar2.IdleFillColor = System.Drawing.Color.LawnGreen;
            this.bar2.IdleForecolor = System.Drawing.Color.Transparent;
            this.bar2.IdleLineColor = System.Drawing.Color.Transparent;
            this.bar2.Location = new System.Drawing.Point(462, 113);
            this.bar2.Margin = new System.Windows.Forms.Padding(5);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(10, 116);
            this.bar2.TabIndex = 1;
            this.bar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(55, 21);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(36, 38);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // pl1
            // 
            this.pl1.AutoSize = true;
            this.pl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl1.Location = new System.Drawing.Point(186, 0);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(16, 16);
            this.pl1.TabIndex = 4;
            this.pl1.Text = "0";
            // 
            // pl2
            // 
            this.pl2.AutoSize = true;
            this.pl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl2.Location = new System.Drawing.Point(285, 0);
            this.pl2.Name = "pl2";
            this.pl2.Size = new System.Drawing.Size(16, 16);
            this.pl2.TabIndex = 5;
            this.pl2.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.point);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtsc1);
            this.panel1.Controls.Add(this.scr);
            this.panel1.Controls.Add(this.txtsc2);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.exitbtn);
            this.panel1.Location = new System.Drawing.Point(13, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 350);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(190, 297);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(75, 29);
            this.point.TabIndex = 10;
            this.point.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Player 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player 1";
            // 
            // txtsc1
            // 
            this.txtsc1.BackColor = System.Drawing.Color.LawnGreen;
            this.txtsc1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsc1.Enabled = false;
            this.txtsc1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsc1.HintForeColor = System.Drawing.Color.Empty;
            this.txtsc1.HintText = "";
            this.txtsc1.isPassword = false;
            this.txtsc1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtsc1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtsc1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtsc1.LineThickness = 8;
            this.txtsc1.Location = new System.Drawing.Point(34, 158);
            this.txtsc1.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtsc1.Name = "txtsc1";
            this.txtsc1.Size = new System.Drawing.Size(166, 47);
            this.txtsc1.TabIndex = 6;
            this.txtsc1.Text = "0";
            this.txtsc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scr
            // 
            this.scr.BackColor = System.Drawing.Color.LawnGreen;
            this.scr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scr.BackgroundImage")));
            this.scr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scr.Enabled = false;
            this.scr.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scr.ForeColor = System.Drawing.Color.LawnGreen;
            this.scr.Icon = ((System.Drawing.Image)(resources.GetObject("scr.Icon")));
            this.scr.Location = new System.Drawing.Point(528, 551);
            this.scr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.scr.Name = "scr";
            this.scr.Size = new System.Drawing.Size(335, 85);
            this.scr.TabIndex = 5;
            this.scr.text = "";
            // 
            // txtsc2
            // 
            this.txtsc2.BackColor = System.Drawing.Color.LawnGreen;
            this.txtsc2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsc2.Enabled = false;
            this.txtsc2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsc2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsc2.HintForeColor = System.Drawing.Color.Empty;
            this.txtsc2.HintText = "";
            this.txtsc2.isPassword = false;
            this.txtsc2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtsc2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtsc2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtsc2.LineThickness = 8;
            this.txtsc2.Location = new System.Drawing.Point(271, 158);
            this.txtsc2.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtsc2.Name = "txtsc2";
            this.txtsc2.Size = new System.Drawing.Size(166, 47);
            this.txtsc2.TabIndex = 2;
            this.txtsc2.Text = "0";
            this.txtsc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.LawnGreen;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.LawnGreen;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 2;
            this.bunifuFlatButton1.ButtonText = "Again";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage_right")));
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(242, 36);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.LawnGreen;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LawnGreen;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(210, 55);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Again";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exitbtn.BackColor = System.Drawing.Color.LawnGreen;
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbtn.BorderRadius = 2;
            this.exitbtn.ButtonText = "Exit";
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.DisabledColor = System.Drawing.Color.Gray;
            this.exitbtn.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.exitbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("exitbtn.Iconimage")));
            this.exitbtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("exitbtn.Iconimage_right")));
            this.exitbtn.Iconimage_right_Selected = null;
            this.exitbtn.Iconimage_Selected = null;
            this.exitbtn.IconMarginLeft = 0;
            this.exitbtn.IconMarginRight = 0;
            this.exitbtn.IconRightVisible = true;
            this.exitbtn.IconRightZoom = 0D;
            this.exitbtn.IconVisible = true;
            this.exitbtn.IconZoom = 90D;
            this.exitbtn.IsTab = false;
            this.exitbtn.Location = new System.Drawing.Point(0, 36);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Normalcolor = System.Drawing.Color.LawnGreen;
            this.exitbtn.OnHovercolor = System.Drawing.Color.LawnGreen;
            this.exitbtn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.exitbtn.selected = false;
            this.exitbtn.Size = new System.Drawing.Size(215, 55);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.Text = "Exit";
            this.exitbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitbtn.Textcolor = System.Drawing.Color.White;
            this.exitbtn.TextFont = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(499, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pl2);
            this.Controls.Add(this.pl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.ball);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form4";
            this.Load += new System.EventHandler(this.form4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form4_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 bar1;
        private Bunifu.Framework.UI.BunifuThinButton2 bar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pl1;
        private System.Windows.Forms.Label pl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsc1;
        private Bunifu.Framework.UI.BunifuTextbox scr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsc2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton exitbtn;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Label label4;
    }
}