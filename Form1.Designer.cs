namespace LifeGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOfSetup = new System.Windows.Forms.Button();
            this.buttonOfInitGridView = new System.Windows.Forms.Button();
            this.textBoxOfColumn = new System.Windows.Forms.TextBox();
            this.textBoxOfRow = new System.Windows.Forms.TextBox();
            this.buttonOfStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelOfSpeed = new System.Windows.Forms.Label();
            this.buttonOfStop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(17, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 360);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonOfStop);
            this.panel2.Controls.Add(this.labelOfSpeed);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonOfStart);
            this.panel2.Controls.Add(this.buttonOfSetup);
            this.panel2.Controls.Add(this.buttonOfInitGridView);
            this.panel2.Controls.Add(this.textBoxOfColumn);
            this.panel2.Controls.Add(this.textBoxOfRow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 100);
            this.panel2.TabIndex = 1;
            // 
            // buttonOfSetup
            // 
            this.buttonOfSetup.Enabled = false;
            this.buttonOfSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfSetup.Location = new System.Drawing.Point(454, 30);
            this.buttonOfSetup.Name = "buttonOfSetup";
            this.buttonOfSetup.Size = new System.Drawing.Size(107, 47);
            this.buttonOfSetup.TabIndex = 3;
            this.buttonOfSetup.Text = "Setup cells";
            this.buttonOfSetup.UseVisualStyleBackColor = true;
            this.buttonOfSetup.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonOfInitGridView
            // 
            this.buttonOfInitGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfInitGridView.Location = new System.Drawing.Point(267, 28);
            this.buttonOfInitGridView.Name = "buttonOfInitGridView";
            this.buttonOfInitGridView.Size = new System.Drawing.Size(89, 47);
            this.buttonOfInitGridView.TabIndex = 2;
            this.buttonOfInitGridView.Text = "Init";
            this.buttonOfInitGridView.UseVisualStyleBackColor = true;
            this.buttonOfInitGridView.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOfColumn
            // 
            this.textBoxOfColumn.Location = new System.Drawing.Point(138, 55);
            this.textBoxOfColumn.Name = "textBoxOfColumn";
            this.textBoxOfColumn.Size = new System.Drawing.Size(100, 20);
            this.textBoxOfColumn.TabIndex = 1;
            // 
            // textBoxOfRow
            // 
            this.textBoxOfRow.Location = new System.Drawing.Point(138, 28);
            this.textBoxOfRow.Name = "textBoxOfRow";
            this.textBoxOfRow.Size = new System.Drawing.Size(100, 20);
            this.textBoxOfRow.TabIndex = 0;
            // 
            // buttonOfStart
            // 
            this.buttonOfStart.Enabled = false;
            this.buttonOfStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfStart.Location = new System.Drawing.Point(597, 13);
            this.buttonOfStart.Name = "buttonOfStart";
            this.buttonOfStart.Size = new System.Drawing.Size(75, 35);
            this.buttonOfStart.TabIndex = 4;
            this.buttonOfStart.Text = "Start";
            this.buttonOfStart.UseVisualStyleBackColor = true;
            this.buttonOfStart.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Column";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(816, 33);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(221, 42);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(756, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Speed";
            // 
            // labelOfSpeed
            // 
            this.labelOfSpeed.AutoSize = true;
            this.labelOfSpeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfSpeed.Location = new System.Drawing.Point(768, 52);
            this.labelOfSpeed.Name = "labelOfSpeed";
            this.labelOfSpeed.Size = new System.Drawing.Size(21, 14);
            this.labelOfSpeed.TabIndex = 9;
            this.labelOfSpeed.Text = "50";
            // 
            // buttonOfStop
            // 
            this.buttonOfStop.Enabled = false;
            this.buttonOfStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfStop.Location = new System.Drawing.Point(597, 56);
            this.buttonOfStop.Name = "buttonOfStop";
            this.buttonOfStop.Size = new System.Drawing.Size(75, 32);
            this.buttonOfStop.TabIndex = 10;
            this.buttonOfStop.Text = "Stop";
            this.buttonOfStop.UseVisualStyleBackColor = true;
            this.buttonOfStop.Click += new System.EventHandler(this.buttonOfStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOfInitGridView;
        private System.Windows.Forms.TextBox textBoxOfColumn;
        private System.Windows.Forms.TextBox textBoxOfRow;
        private System.Windows.Forms.Button buttonOfSetup;
        private System.Windows.Forms.Button buttonOfStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelOfSpeed;
        private System.Windows.Forms.Button buttonOfStop;
    }
}

