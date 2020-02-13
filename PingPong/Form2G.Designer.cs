namespace PingPong
{
    partial class Form2G
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2G));
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Panelrestart = new System.Windows.Forms.Panel();
            this.crs = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.scr = new Bunifu.Framework.UI.BunifuTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.scoretxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstatusclick = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.Panelrestart.SuspendLayout();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(78, 111);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(36, 38);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labar
            // 
            this.labar.ActiveBorderThickness = 1;
            this.labar.ActiveCornerRadius = 20;
            this.labar.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.labar.ActiveForecolor = System.Drawing.Color.LawnGreen;
            this.labar.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.labar.BackColor = System.Drawing.Color.Gray;
            this.labar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("labar.BackgroundImage")));
            this.labar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.labar.ButtonText = "";
            this.labar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labar.Enabled = false;
            this.labar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labar.ForeColor = System.Drawing.Color.LawnGreen;
            this.labar.IdleBorderThickness = 1;
            this.labar.IdleCornerRadius = 15;
            this.labar.IdleFillColor = System.Drawing.Color.LawnGreen;
            this.labar.IdleForecolor = System.Drawing.Color.Transparent;
            this.labar.IdleLineColor = System.Drawing.Color.Transparent;
            this.labar.Location = new System.Drawing.Point(187, 338);
            this.labar.Margin = new System.Windows.Forms.Padding(5);
            this.labar.Name = "labar";
            this.labar.Size = new System.Drawing.Size(101, 18);
            this.labar.TabIndex = 1;
            this.labar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panelrestart
            // 
            this.Panelrestart.Controls.Add(this.crs);
            this.Panelrestart.Controls.Add(this.scr);
            this.Panelrestart.Controls.Add(this.label3);
            this.Panelrestart.Controls.Add(this.scoretxt);
            this.Panelrestart.Controls.Add(this.bunifuFlatButton1);
            this.Panelrestart.Controls.Add(this.exitbtn);
            this.Panelrestart.Location = new System.Drawing.Point(46, 30);
            this.Panelrestart.Name = "Panelrestart";
            this.Panelrestart.Size = new System.Drawing.Size(382, 326);
            this.Panelrestart.TabIndex = 2;
            this.Panelrestart.Visible = false;
            // 
            // crs
            // 
            this.crs.BackColor = System.Drawing.Color.LawnGreen;
            this.crs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.crs.Enabled = false;
            this.crs.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crs.ForeColor = System.Drawing.Color.Gray;
            this.crs.HintForeColor = System.Drawing.Color.Empty;
            this.crs.HintText = "";
            this.crs.isPassword = false;
            this.crs.LineFocusedColor = System.Drawing.Color.Blue;
            this.crs.LineIdleColor = System.Drawing.Color.Gray;
            this.crs.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.crs.LineThickness = 4;
            this.crs.Location = new System.Drawing.Point(218, 255);
            this.crs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.crs.Name = "crs";
            this.crs.Size = new System.Drawing.Size(106, 33);
            this.crs.TabIndex = 6;
            this.crs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hight Score";
            // 
            // scoretxt
            // 
            this.scoretxt.BackColor = System.Drawing.Color.LawnGreen;
            this.scoretxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.scoretxt.Enabled = false;
            this.scoretxt.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scoretxt.HintForeColor = System.Drawing.Color.Empty;
            this.scoretxt.HintText = "";
            this.scoretxt.isPassword = false;
            this.scoretxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.scoretxt.LineIdleColor = System.Drawing.Color.Gray;
            this.scoretxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.scoretxt.LineThickness = 8;
            this.scoretxt.Location = new System.Drawing.Point(85, 183);
            this.scoretxt.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.scoretxt.Name = "scoretxt";
            this.scoretxt.Size = new System.Drawing.Size(200, 47);
            this.scoretxt.TabIndex = 2;
            this.scoretxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(24, 93);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.LawnGreen;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LawnGreen;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(327, 60);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Again";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
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
            this.exitbtn.Location = new System.Drawing.Point(24, 12);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Normalcolor = System.Drawing.Color.LawnGreen;
            this.exitbtn.OnHovercolor = System.Drawing.Color.LawnGreen;
            this.exitbtn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.exitbtn.selected = false;
            this.exitbtn.Size = new System.Drawing.Size(327, 60);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.Text = "Exit";
            this.exitbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitbtn.Textcolor = System.Drawing.Color.White;
            this.exitbtn.TextFont = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // lblstatusclick
            // 
            this.lblstatusclick.AutoSize = true;
            this.lblstatusclick.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatusclick.Location = new System.Drawing.Point(387, 0);
            this.lblstatusclick.Name = "lblstatusclick";
            this.lblstatusclick.Size = new System.Drawing.Size(41, 14);
            this.lblstatusclick.TabIndex = 4;
            this.lblstatusclick.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status  :  ";
            // 
            // Form2G
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(499, 381);
            this.Controls.Add(this.Panelrestart);
            this.Controls.Add(this.labar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblstatusclick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2G";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2G";
            this.Load += new System.EventHandler(this.Form2G_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2G_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.Panelrestart.ResumeLayout(false);
            this.Panelrestart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuThinButton2 labar;
        private System.Windows.Forms.Panel Panelrestart;
        private Bunifu.Framework.UI.BunifuMaterialTextbox scoretxt;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton exitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstatusclick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuTextbox scr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox crs;
    }
}