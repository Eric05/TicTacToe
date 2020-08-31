using System.Windows.Forms;

namespace Tic
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        /// sdf
        private System.ComponentModel.IContainer components = null;

        public Button TopLeftButton { get => a1; }
        public Button TopCenterButton { get => a2; }
        public Button TopRightButton { get => a3; }
        public Button CenterLeftButton { get => b1; }
        public Button CenterButton { get => b2; }
        public Button CenterRightButton { get => b3; }
        public Button BottomLeftButton { get => c1; }
        public Button BottomCenterButton { get => c2; }
        public Button BottomRightButton { get => c3; }
        public Label Xwin { get => xwin; set => xwin = value; }
        public Label Draw { get => draw; set => draw = value; }
        public Label Owin { get => owin; set => owin = value; }
        public Label Textbox { get => textbox; set => textbox = value; }

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                
            }
            base.Dispose(disposing);
        }


        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.a1 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.xwin = new System.Windows.Forms.Label();
            this.draw = new System.Windows.Forms.Label();
            this.owin = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textbox = new System.Windows.Forms.Label();
            this.SimEasy = new System.Windows.Forms.Label();
            this.SimPro = new System.Windows.Forms.Label();
            this.SimExp = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.DimGray;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(94, 92);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(80, 80);
            this.a1.TabIndex = 0;
            this.a1.UseVisualStyleBackColor = false;
            this.a1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.Color.DimGray;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(266, 92);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(80, 80);
            this.a3.TabIndex = 1;
            this.a3.UseVisualStyleBackColor = false;
            this.a3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.DimGray;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(180, 92);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(80, 80);
            this.a2.TabIndex = 2;
            this.a2.UseVisualStyleBackColor = false;
            this.a2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.DimGray;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(266, 178);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(80, 80);
            this.b3.TabIndex = 3;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.DimGray;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(180, 178);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(80, 80);
            this.b2.TabIndex = 4;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.DimGray;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(94, 178);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(80, 80);
            this.b1.TabIndex = 5;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.Color.DimGray;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(180, 264);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(80, 80);
            this.c2.TabIndex = 6;
            this.c2.UseVisualStyleBackColor = false;
            this.c2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.Color.DimGray;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(266, 264);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(80, 80);
            this.c3.TabIndex = 7;
            this.c3.UseVisualStyleBackColor = false;
            this.c3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.Color.DimGray;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.ForeColor = System.Drawing.Color.DarkOrange;
            this.c1.Location = new System.Drawing.Point(94, 264);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(80, 80);
            this.c1.TabIndex = 8;
            this.c1.UseVisualStyleBackColor = false;
            this.c1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(90, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "x win:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(194, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "draw:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(297, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "o win:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGreen;
            this.label7.Location = new System.Drawing.Point(246, 10);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label7.Size = new System.Drawing.Size(48, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "NEW";
            this.label7.Click += new System.EventHandler(this.NewGame);
            this.label7.MouseEnter += new System.EventHandler(this.Hover1);
            this.label7.MouseLeave += new System.EventHandler(this.Hover1_Reset);
            // 
            // xwin
            // 
            this.xwin.AutoSize = true;
            this.xwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xwin.ForeColor = System.Drawing.Color.Lime;
            this.xwin.Location = new System.Drawing.Point(92, 392);
            this.xwin.Name = "xwin";
            this.xwin.Size = new System.Drawing.Size(18, 20);
            this.xwin.TabIndex = 13;
            this.xwin.Text = "0";
            // 
            // draw
            // 
            this.draw.AutoSize = true;
            this.draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw.ForeColor = System.Drawing.Color.LightGreen;
            this.draw.Location = new System.Drawing.Point(204, 392);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(18, 20);
            this.draw.TabIndex = 14;
            this.draw.Text = "0";
            // 
            // owin
            // 
            this.owin.AutoSize = true;
            this.owin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owin.ForeColor = System.Drawing.Color.Gainsboro;
            this.owin.Location = new System.Drawing.Point(328, 392);
            this.owin.Name = "owin";
            this.owin.Size = new System.Drawing.Size(18, 20);
            this.owin.TabIndex = 15;
            this.owin.Text = "0";
            this.owin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton1.Location = new System.Drawing.Point(386, 455);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 20);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "vs.";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.LevelVs);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton2.Location = new System.Drawing.Point(261, 455);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 20);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.Text = "Pro";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.Level_Pro);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton3.Location = new System.Drawing.Point(318, 455);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 20);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.Text = "Easy";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.Level_Easy);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(300, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label4.Size = new System.Drawing.Size(46, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "NXT";
            this.label4.Click += new System.EventHandler(this.Next);
            this.label4.MouseEnter += new System.EventHandler(this.Hover2);
            this.label4.MouseLeave += new System.EventHandler(this.Hover2_Reset);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton4.Location = new System.Drawing.Point(176, 455);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(66, 20);
            this.radioButton4.TabIndex = 26;
            this.radioButton4.Text = "Expert";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.Level_Expert);
            this.radioButton4.Click += new System.EventHandler(this.Level_Expert);
            // 
            // textbox
            // 
            this.textbox.AutoSize = true;
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.Location = new System.Drawing.Point(12, 24);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(0, 20);
            this.textbox.TabIndex = 27;
            this.textbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimEasy
            // 
            this.SimEasy.AutoSize = true;
            this.SimEasy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimEasy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SimEasy.Location = new System.Drawing.Point(15, 448);
            this.SimEasy.Name = "SimEasy";
            this.SimEasy.Size = new System.Drawing.Size(26, 27);
            this.SimEasy.TabIndex = 30;
            this.SimEasy.Text = ">";
            this.toolTip1.SetToolTip(this.SimEasy, "Click here to Start Simulation on Level Easy");
            this.SimEasy.Click += new System.EventHandler(this.Simulation_Click);
            this.SimEasy.MouseEnter += new System.EventHandler(this.HoverSimul);
            this.SimEasy.MouseLeave += new System.EventHandler(this.ResetHoverSimul);
            // 
            // SimPro
            // 
            this.SimPro.AutoSize = true;
            this.SimPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimPro.ForeColor = System.Drawing.Color.PaleGreen;
            this.SimPro.Location = new System.Drawing.Point(38, 448);
            this.SimPro.Name = "SimPro";
            this.SimPro.Size = new System.Drawing.Size(38, 27);
            this.SimPro.TabIndex = 31;
            this.SimPro.Text = ">>";
            this.toolTip1.SetToolTip(this.SimPro, "Click here to start Simulation on Level Pro");
            this.SimPro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SimulationPro_Click);
            this.SimPro.MouseEnter += new System.EventHandler(this.HoverSimul);
            this.SimPro.MouseLeave += new System.EventHandler(this.ResetHoverSimul);
            // 
            // SimExp
            // 
            this.SimExp.AutoSize = true;
            this.SimExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimExp.ForeColor = System.Drawing.Color.Lime;
            this.SimExp.Location = new System.Drawing.Point(73, 448);
            this.SimExp.Name = "SimExp";
            this.SimExp.Size = new System.Drawing.Size(50, 27);
            this.SimExp.TabIndex = 32;
            this.SimExp.Text = ">>>";
            this.toolTip1.SetToolTip(this.SimExp, "Click here to start Simulation on Level Expert");
            this.SimExp.Click += new System.EventHandler(this.SimulationExpert_Click);
            this.SimExp.MouseEnter += new System.EventHandler(this.HoverSimul);
            this.SimExp.MouseLeave += new System.EventHandler(this.ResetHoverSimul);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(96, 10);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label6.Size = new System.Drawing.Size(61, 30);
            this.label6.TabIndex = 33;
            this.label6.Text = "PAUSE";
            this.toolTip1.SetToolTip(this.label6, "Stop Simulation");
            this.label6.Click += new System.EventHandler(this.ResetSimulation);
            this.label6.MouseEnter += new System.EventHandler(this.HoverSimul);
            this.label6.MouseLeave += new System.EventHandler(this.ResetHoverSimul);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(440, 493);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SimExp);
            this.Controls.Add(this.SimPro);
            this.Controls.Add(this.SimEasy);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.owin);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.xwin);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(52, 39);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xwin;
        private System.Windows.Forms.Label draw;
        private System.Windows.Forms.Label owin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label textbox;
        private Label SimEasy;
        private Label SimPro;
        private Label SimExp;
        private ToolTip toolTip1;
        private Label label6;
    }
}

