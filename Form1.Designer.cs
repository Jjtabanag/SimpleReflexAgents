namespace SimpleReflexAgents
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbRoomba = new System.Windows.Forms.PictureBox();
            this.startPoint3 = new System.Windows.Forms.PictureBox();
            this.startPoint4 = new System.Windows.Forms.PictureBox();
            this.lblDH1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startPoint1 = new System.Windows.Forms.PictureBox();
            this.startPoint2 = new System.Windows.Forms.PictureBox();
            this.btnPlaceDirt = new System.Windows.Forms.Button();
            this.lblDH2 = new System.Windows.Forms.Label();
            this.lblDH4 = new System.Windows.Forms.Label();
            this.lblDH3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.RoombaTimer = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.RoombaLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.lblCurrentRoom = new System.Windows.Forms.Label();
            this.lblNextRoom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoomba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPoint3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPoint4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPoint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPoint2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRoomba
            // 
            this.pbRoomba.BackColor = System.Drawing.Color.Transparent;
            this.pbRoomba.Image = ((System.Drawing.Image)(resources.GetObject("pbRoomba.Image")));
            this.pbRoomba.Location = new System.Drawing.Point(956, 183);
            this.pbRoomba.Margin = new System.Windows.Forms.Padding(2);
            this.pbRoomba.Name = "pbRoomba";
            this.pbRoomba.Size = new System.Drawing.Size(60, 61);
            this.pbRoomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoomba.TabIndex = 1;
            this.pbRoomba.TabStop = false;
            this.pbRoomba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RoombaMouseDown);
            this.pbRoomba.MouseEnter += new System.EventHandler(this.RoombaMouseEnter);
            this.pbRoomba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RoombaMouseMove);
            this.pbRoomba.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RoombaMouseUp);
            // 
            // startPoint3
            // 
            this.startPoint3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startPoint3.Location = new System.Drawing.Point(322, 527);
            this.startPoint3.Margin = new System.Windows.Forms.Padding(2);
            this.startPoint3.Name = "startPoint3";
            this.startPoint3.Size = new System.Drawing.Size(60, 61);
            this.startPoint3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startPoint3.TabIndex = 4;
            this.startPoint3.TabStop = false;
            this.startPoint3.Visible = false;
            // 
            // startPoint4
            // 
            this.startPoint4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startPoint4.Location = new System.Drawing.Point(705, 527);
            this.startPoint4.Margin = new System.Windows.Forms.Padding(2);
            this.startPoint4.Name = "startPoint4";
            this.startPoint4.Size = new System.Drawing.Size(60, 61);
            this.startPoint4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startPoint4.TabIndex = 5;
            this.startPoint4.TabStop = false;
            this.startPoint4.Visible = false;
            // 
            // lblDH1
            // 
            this.lblDH1.AutoSize = true;
            this.lblDH1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblDH1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDH1.ForeColor = System.Drawing.Color.Black;
            this.lblDH1.Location = new System.Drawing.Point(250, 151);
            this.lblDH1.Name = "lblDH1";
            this.lblDH1.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.lblDH1.Size = new System.Drawing.Size(206, 64);
            this.lblDH1.TabIndex = 6;
            this.lblDH1.Text = "Drop Here";
            this.lblDH1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(707, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Drop Here";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(324, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Drop Here";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(707, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Drop Here";
            this.label5.Visible = false;
            // 
            // startPoint1
            // 
            this.startPoint1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startPoint1.Location = new System.Drawing.Point(322, 145);
            this.startPoint1.Margin = new System.Windows.Forms.Padding(2);
            this.startPoint1.Name = "startPoint1";
            this.startPoint1.Size = new System.Drawing.Size(60, 61);
            this.startPoint1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startPoint1.TabIndex = 2;
            this.startPoint1.TabStop = false;
            this.startPoint1.Visible = false;
            // 
            // startPoint2
            // 
            this.startPoint2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startPoint2.Location = new System.Drawing.Point(705, 145);
            this.startPoint2.Margin = new System.Windows.Forms.Padding(2);
            this.startPoint2.Name = "startPoint2";
            this.startPoint2.Size = new System.Drawing.Size(60, 61);
            this.startPoint2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startPoint2.TabIndex = 3;
            this.startPoint2.TabStop = false;
            this.startPoint2.Visible = false;
            // 
            // btnPlaceDirt
            // 
            this.btnPlaceDirt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPlaceDirt.ForeColor = System.Drawing.Color.Black;
            this.btnPlaceDirt.Location = new System.Drawing.Point(940, 341);
            this.btnPlaceDirt.Name = "btnPlaceDirt";
            this.btnPlaceDirt.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceDirt.TabIndex = 7;
            this.btnPlaceDirt.Text = "Place Dirt";
            this.btnPlaceDirt.UseVisualStyleBackColor = false;
            this.btnPlaceDirt.Click += new System.EventHandler(this.btnPlaceDirt_Click);
            // 
            // lblDH2
            // 
            this.lblDH2.AutoSize = true;
            this.lblDH2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblDH2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDH2.ForeColor = System.Drawing.Color.Black;
            this.lblDH2.Location = new System.Drawing.Point(633, 151);
            this.lblDH2.Name = "lblDH2";
            this.lblDH2.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.lblDH2.Size = new System.Drawing.Size(206, 64);
            this.lblDH2.TabIndex = 8;
            this.lblDH2.Text = "Drop Here";
            this.lblDH2.Visible = false;
            // 
            // lblDH4
            // 
            this.lblDH4.AutoSize = true;
            this.lblDH4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblDH4.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDH4.ForeColor = System.Drawing.Color.Black;
            this.lblDH4.Location = new System.Drawing.Point(633, 532);
            this.lblDH4.Name = "lblDH4";
            this.lblDH4.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.lblDH4.Size = new System.Drawing.Size(206, 64);
            this.lblDH4.TabIndex = 10;
            this.lblDH4.Text = "Drop Here";
            this.lblDH4.Visible = false;
            // 
            // lblDH3
            // 
            this.lblDH3.AutoSize = true;
            this.lblDH3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblDH3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDH3.ForeColor = System.Drawing.Color.Black;
            this.lblDH3.Location = new System.Drawing.Point(250, 532);
            this.lblDH3.Name = "lblDH3";
            this.lblDH3.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.lblDH3.Size = new System.Drawing.Size(206, 64);
            this.lblDH3.TabIndex = 9;
            this.lblDH3.Text = "Drop Here";
            this.lblDH3.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(940, 414);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // RoombaTimer
            // 
            this.RoombaTimer.Tick += new System.EventHandler(this.RoombaTimer_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "Roomba Log";
            // 
            // RoombaLog
            // 
            this.RoombaLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RoombaLog.Location = new System.Drawing.Point(0, 327);
            this.RoombaLog.Margin = new System.Windows.Forms.Padding(2);
            this.RoombaLog.Multiline = true;
            this.RoombaLog.Name = "RoombaLog";
            this.RoombaLog.ReadOnly = true;
            this.RoombaLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RoombaLog.Size = new System.Drawing.Size(174, 370);
            this.RoombaLog.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Current Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Current Room:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Next Room:";
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.AutoSize = true;
            this.lblCurrentLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCurrentLocation.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLocation.Location = new System.Drawing.Point(27, 100);
            this.lblCurrentLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(47, 18);
            this.lblCurrentLocation.TabIndex = 22;
            this.lblCurrentLocation.Text = "X- Y-";
            this.lblCurrentLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentRoom
            // 
            this.lblCurrentRoom.AutoSize = true;
            this.lblCurrentRoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCurrentRoom.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRoom.Location = new System.Drawing.Point(64, 166);
            this.lblCurrentRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentRoom.Name = "lblCurrentRoom";
            this.lblCurrentRoom.Size = new System.Drawing.Size(47, 18);
            this.lblCurrentRoom.TabIndex = 23;
            this.lblCurrentRoom.Text = "Origin";
            // 
            // lblNextRoom
            // 
            this.lblNextRoom.AutoSize = true;
            this.lblNextRoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNextRoom.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextRoom.Location = new System.Drawing.Point(64, 235);
            this.lblNextRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextRoom.Name = "lblNextRoom";
            this.lblNextRoom.Size = new System.Drawing.Size(47, 18);
            this.lblNextRoom.TabIndex = 24;
            this.lblNextRoom.Text = "Origin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(911, 367);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "[Places dirt in random rooms]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(929, 448);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "[Start the Roomba]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(907, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 114);
            this.label9.TabIndex = 27;
            this.label9.Text = "Drag\r\nthe\r\nROOMBA";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReset.Enabled = false;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(940, 501);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 691);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNextRoom);
            this.Controls.Add(this.lblCurrentRoom);
            this.Controls.Add(this.lblCurrentLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoombaLog);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDH4);
            this.Controls.Add(this.lblDH3);
            this.Controls.Add(this.lblDH2);
            this.Controls.Add(this.btnPlaceDirt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDH1);
            this.Controls.Add(this.startPoint4);
            this.Controls.Add(this.startPoint3);
            this.Controls.Add(this.startPoint2);
            this.Controls.Add(this.startPoint1);
            this.Controls.Add(this.pbRoomba);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleReflexAgents";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbRoomba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPoint3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPoint4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPoint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPoint2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbRoomba;
        private System.Windows.Forms.PictureBox startPoint3;
        private System.Windows.Forms.PictureBox startPoint4;
        private System.Windows.Forms.Label lblDH1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox startPoint1;
        private System.Windows.Forms.PictureBox startPoint2;
        private System.Windows.Forms.Button btnPlaceDirt;
        private System.Windows.Forms.Label lblDH2;
        private System.Windows.Forms.Label lblDH4;
        private System.Windows.Forms.Label lblDH3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer RoombaTimer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RoombaLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentLocation;
        private System.Windows.Forms.Label lblCurrentRoom;
        private System.Windows.Forms.Label lblNextRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReset;
    }
}

