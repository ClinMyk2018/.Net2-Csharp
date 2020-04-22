namespace W5.T1.ClinardMykal
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
            this.backBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hourBox = new System.Windows.Forms.PictureBox();
            this.minuteBox = new System.Windows.Forms.PictureBox();
            this.dotBox = new System.Windows.Forms.PictureBox();
            this.secondBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backBox
            // 
            this.backBox.BackColor = System.Drawing.Color.Transparent;
            this.backBox.Location = new System.Drawing.Point(62, 68);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(300, 300);
            this.backBox.TabIndex = 0;
            this.backBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hourBox
            // 
            this.hourBox.BackColor = System.Drawing.Color.Transparent;
            this.hourBox.Location = new System.Drawing.Point(62, 79);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(300, 300);
            this.hourBox.TabIndex = 1;
            this.hourBox.TabStop = false;
            // 
            // minuteBox
            // 
            this.minuteBox.BackColor = System.Drawing.Color.Transparent;
            this.minuteBox.Location = new System.Drawing.Point(62, 95);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(300, 300);
            this.minuteBox.TabIndex = 2;
            this.minuteBox.TabStop = false;
            // 
            // dotBox
            // 
            this.dotBox.BackColor = System.Drawing.Color.Transparent;
            this.dotBox.Location = new System.Drawing.Point(62, 113);
            this.dotBox.Name = "dotBox";
            this.dotBox.Size = new System.Drawing.Size(300, 300);
            this.dotBox.TabIndex = 3;
            this.dotBox.TabStop = false;
            // 
            // secondBox
            // 
            this.secondBox.BackColor = System.Drawing.Color.Transparent;
            this.secondBox.Location = new System.Drawing.Point(62, 126);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(300, 300);
            this.secondBox.TabIndex = 4;
            this.secondBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 22);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alarm";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.listBox1.Location = new System.Drawing.Point(168, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(43, 30);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.listBox2.Location = new System.Drawing.Point(227, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(44, 30);
            this.listBox2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Set Alarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Stop/Reset Alarm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.dotBox);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.backBox);
            this.Name = "Form1";
            this.Text = "Analog Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox hourBox;
        private System.Windows.Forms.PictureBox minuteBox;
        private System.Windows.Forms.PictureBox dotBox;
        private System.Windows.Forms.PictureBox secondBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

