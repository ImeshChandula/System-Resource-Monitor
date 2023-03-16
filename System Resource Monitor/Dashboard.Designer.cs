namespace System_Resource_Monitor
{
    partial class Monitor
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
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_button = new System.Windows.Forms.Panel();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_genetare = new System.Windows.Forms.Button();
            this.pnl_category = new System.Windows.Forms.Panel();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.pnl_headding = new System.Windows.Forms.Panel();
            this.heading = new System.Windows.Forms.Label();
            this.pnl_right_up = new System.Windows.Forms.Panel();
            this.pnl_right_down = new System.Windows.Forms.Panel();
            this.pnl_date = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.pnl_time = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_cpu = new System.Windows.Forms.Label();
            this.lbl_ram = new System.Windows.Forms.Label();
            this.lbl_upTime = new System.Windows.Forms.Label();
            this.lbl_cores = new System.Windows.Forms.Label();
            this.lbl_L_cpu = new System.Windows.Forms.Label();
            this.lbl_P_cpu = new System.Windows.Forms.Label();
            this.pnl_left.SuspendLayout();
            this.pnl_button.SuspendLayout();
            this.pnl_category.SuspendLayout();
            this.pnl_headding.SuspendLayout();
            this.pnl_right_up.SuspendLayout();
            this.pnl_right_down.SuspendLayout();
            this.pnl_date.SuspendLayout();
            this.pnl_time.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnl_left.Controls.Add(this.pnl_button);
            this.pnl_left.Controls.Add(this.pnl_category);
            this.pnl_left.Controls.Add(this.pnl_headding);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(303, 495);
            this.pnl_left.TabIndex = 0;
            // 
            // pnl_button
            // 
            this.pnl_button.AutoScroll = true;
            this.pnl_button.Controls.Add(this.btn_stop);
            this.pnl_button.Controls.Add(this.btn_genetare);
            this.pnl_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_button.Location = new System.Drawing.Point(0, 206);
            this.pnl_button.Name = "pnl_button";
            this.pnl_button.Size = new System.Drawing.Size(303, 201);
            this.pnl_button.TabIndex = 2;
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_stop.Location = new System.Drawing.Point(0, 50);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(0);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_stop.Size = new System.Drawing.Size(303, 50);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "STOP";
            this.btn_stop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_ram_Click);
            // 
            // btn_genetare
            // 
            this.btn_genetare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_genetare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_genetare.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_genetare.FlatAppearance.BorderSize = 0;
            this.btn_genetare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_genetare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_genetare.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genetare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_genetare.Location = new System.Drawing.Point(0, 0);
            this.btn_genetare.Margin = new System.Windows.Forms.Padding(0);
            this.btn_genetare.Name = "btn_genetare";
            this.btn_genetare.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_genetare.Size = new System.Drawing.Size(303, 50);
            this.btn_genetare.TabIndex = 0;
            this.btn_genetare.Text = "GENERATE";
            this.btn_genetare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_genetare.UseVisualStyleBackColor = false;
            this.btn_genetare.Click += new System.EventHandler(this.btn_cpu_Click);
            // 
            // pnl_category
            // 
            this.pnl_category.Controls.Add(this.btn_dashboard);
            this.pnl_category.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_category.Location = new System.Drawing.Point(0, 166);
            this.pnl_category.Name = "pnl_category";
            this.pnl_category.Size = new System.Drawing.Size(303, 40);
            this.pnl_category.TabIndex = 1;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(303, 40);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pnl_headding
            // 
            this.pnl_headding.BackColor = System.Drawing.Color.Black;
            this.pnl_headding.Controls.Add(this.heading);
            this.pnl_headding.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_headding.Location = new System.Drawing.Point(0, 0);
            this.pnl_headding.Name = "pnl_headding";
            this.pnl_headding.Size = new System.Drawing.Size(303, 166);
            this.pnl_headding.TabIndex = 0;
            // 
            // heading
            // 
            this.heading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heading.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.heading.Location = new System.Drawing.Point(0, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(303, 166);
            this.heading.TabIndex = 0;
            this.heading.Text = "System Resource \r\nMonitor";
            this.heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_right_up
            // 
            this.pnl_right_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnl_right_up.Controls.Add(this.tableLayoutPanel1);
            this.pnl_right_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_right_up.Location = new System.Drawing.Point(303, 0);
            this.pnl_right_up.Name = "pnl_right_up";
            this.pnl_right_up.Size = new System.Drawing.Size(568, 438);
            this.pnl_right_up.TabIndex = 2;
            // 
            // pnl_right_down
            // 
            this.pnl_right_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnl_right_down.Controls.Add(this.pnl_date);
            this.pnl_right_down.Controls.Add(this.pnl_time);
            this.pnl_right_down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_right_down.Location = new System.Drawing.Point(303, 438);
            this.pnl_right_down.Name = "pnl_right_down";
            this.pnl_right_down.Size = new System.Drawing.Size(568, 57);
            this.pnl_right_down.TabIndex = 3;
            // 
            // pnl_date
            // 
            this.pnl_date.Controls.Add(this.lbl_date);
            this.pnl_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_date.Location = new System.Drawing.Point(297, 0);
            this.pnl_date.Name = "pnl_date";
            this.pnl_date.Size = new System.Drawing.Size(271, 57);
            this.pnl_date.TabIndex = 1;
            // 
            // lbl_date
            // 
            this.lbl_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_date.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_date.Location = new System.Drawing.Point(0, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(271, 57);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date : ";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_time
            // 
            this.pnl_time.Controls.Add(this.lbl_time);
            this.pnl_time.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_time.Location = new System.Drawing.Point(0, 0);
            this.pnl_time.Name = "pnl_time";
            this.pnl_time.Size = new System.Drawing.Size(297, 57);
            this.pnl_time.TabIndex = 0;
            // 
            // lbl_time
            // 
            this.lbl_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_time.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_time.Location = new System.Drawing.Point(0, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(297, 57);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "Time : ";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.03521F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.96479F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 438);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_P_cpu, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbl_L_cpu, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_cores, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_upTime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_cpu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_ram, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(335, 432);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cpu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cpu.Location = new System.Drawing.Point(3, 0);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(329, 72);
            this.lbl_cpu.TabIndex = 1;
            this.lbl_cpu.Text = "CPU : ";
            this.lbl_cpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ram
            // 
            this.lbl_ram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ram.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ram.Location = new System.Drawing.Point(3, 72);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(329, 72);
            this.lbl_ram.TabIndex = 2;
            this.lbl_ram.Text = "Available RAM :";
            this.lbl_ram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_upTime
            // 
            this.lbl_upTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_upTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_upTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_upTime.Location = new System.Drawing.Point(3, 144);
            this.lbl_upTime.Name = "lbl_upTime";
            this.lbl_upTime.Size = new System.Drawing.Size(329, 72);
            this.lbl_upTime.TabIndex = 3;
            this.lbl_upTime.Text = "System Up Time :";
            this.lbl_upTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cores
            // 
            this.lbl_cores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cores.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cores.Location = new System.Drawing.Point(3, 216);
            this.lbl_cores.Name = "lbl_cores";
            this.lbl_cores.Size = new System.Drawing.Size(329, 72);
            this.lbl_cores.TabIndex = 4;
            this.lbl_cores.Text = "Count of Cores :";
            this.lbl_cores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_L_cpu
            // 
            this.lbl_L_cpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_L_cpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_L_cpu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_L_cpu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_L_cpu.Location = new System.Drawing.Point(3, 288);
            this.lbl_L_cpu.Name = "lbl_L_cpu";
            this.lbl_L_cpu.Size = new System.Drawing.Size(329, 72);
            this.lbl_L_cpu.TabIndex = 5;
            this.lbl_L_cpu.Text = "Count of Logical CPU\'s :";
            this.lbl_L_cpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_P_cpu
            // 
            this.lbl_P_cpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_P_cpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_P_cpu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P_cpu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_P_cpu.Location = new System.Drawing.Point(3, 360);
            this.lbl_P_cpu.Name = "lbl_P_cpu";
            this.lbl_P_cpu.Size = new System.Drawing.Size(329, 72);
            this.lbl_P_cpu.TabIndex = 6;
            this.lbl_P_cpu.Text = "Count of Physical CPU\'s :";
            this.lbl_P_cpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 495);
            this.Controls.Add(this.pnl_right_down);
            this.Controls.Add(this.pnl_right_up);
            this.Controls.Add(this.pnl_left);
            this.Name = "Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Resource Monitor";
            this.Load += new System.EventHandler(this.Monitor_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_button.ResumeLayout(false);
            this.pnl_category.ResumeLayout(false);
            this.pnl_headding.ResumeLayout(false);
            this.pnl_right_up.ResumeLayout(false);
            this.pnl_right_down.ResumeLayout(false);
            this.pnl_date.ResumeLayout(false);
            this.pnl_time.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_right_up;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Panel pnl_headding;
        private System.Windows.Forms.Panel pnl_category;
        private System.Windows.Forms.Panel pnl_button;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_genetare;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel pnl_right_down;
        private System.Windows.Forms.Panel pnl_date;
        private System.Windows.Forms.Panel pnl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_cpu;
        private System.Windows.Forms.Label lbl_P_cpu;
        private System.Windows.Forms.Label lbl_L_cpu;
        private System.Windows.Forms.Label lbl_cores;
        private System.Windows.Forms.Label lbl_upTime;
        private System.Windows.Forms.Label lbl_ram;
    }
}

