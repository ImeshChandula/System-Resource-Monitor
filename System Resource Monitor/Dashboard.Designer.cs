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
            this.btn_ram = new System.Windows.Forms.Button();
            this.btn_cpu = new System.Windows.Forms.Button();
            this.pnl_category = new System.Windows.Forms.Panel();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.pnl_headding = new System.Windows.Forms.Panel();
            this.heading = new System.Windows.Forms.Label();
            this.pnl_right_up = new System.Windows.Forms.Panel();
            this.pnl_cpu = new System.Windows.Forms.Panel();
            this.lbl_cpu = new System.Windows.Forms.Label();
            this.pnl_right_down = new System.Windows.Forms.Panel();
            this.pnl_date = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.pnl_time = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_left.SuspendLayout();
            this.pnl_button.SuspendLayout();
            this.pnl_category.SuspendLayout();
            this.pnl_headding.SuspendLayout();
            this.pnl_right_up.SuspendLayout();
            this.pnl_cpu.SuspendLayout();
            this.pnl_right_down.SuspendLayout();
            this.pnl_date.SuspendLayout();
            this.pnl_time.SuspendLayout();
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
            this.pnl_button.Controls.Add(this.btn_ram);
            this.pnl_button.Controls.Add(this.btn_cpu);
            this.pnl_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_button.Location = new System.Drawing.Point(0, 140);
            this.pnl_button.Name = "pnl_button";
            this.pnl_button.Size = new System.Drawing.Size(303, 201);
            this.pnl_button.TabIndex = 2;
            // 
            // btn_ram
            // 
            this.btn_ram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_ram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ram.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ram.FlatAppearance.BorderSize = 0;
            this.btn_ram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ram.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ram.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ram.Location = new System.Drawing.Point(0, 50);
            this.btn_ram.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ram.Name = "btn_ram";
            this.btn_ram.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_ram.Size = new System.Drawing.Size(303, 50);
            this.btn_ram.TabIndex = 1;
            this.btn_ram.Text = "RAM";
            this.btn_ram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ram.UseVisualStyleBackColor = false;
            this.btn_ram.Click += new System.EventHandler(this.btn_ram_Click);
            // 
            // btn_cpu
            // 
            this.btn_cpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_cpu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cpu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cpu.FlatAppearance.BorderSize = 0;
            this.btn_cpu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cpu.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cpu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cpu.Location = new System.Drawing.Point(0, 0);
            this.btn_cpu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cpu.Name = "btn_cpu";
            this.btn_cpu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_cpu.Size = new System.Drawing.Size(303, 50);
            this.btn_cpu.TabIndex = 0;
            this.btn_cpu.Text = "CPU";
            this.btn_cpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cpu.UseVisualStyleBackColor = false;
            this.btn_cpu.Click += new System.EventHandler(this.btn_cpu_Click);
            // 
            // pnl_category
            // 
            this.pnl_category.Controls.Add(this.btn_dashboard);
            this.pnl_category.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_category.Location = new System.Drawing.Point(0, 100);
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
            this.pnl_headding.Controls.Add(this.heading);
            this.pnl_headding.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_headding.Location = new System.Drawing.Point(0, 0);
            this.pnl_headding.Name = "pnl_headding";
            this.pnl_headding.Size = new System.Drawing.Size(303, 100);
            this.pnl_headding.TabIndex = 0;
            // 
            // heading
            // 
            this.heading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heading.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.heading.Location = new System.Drawing.Point(0, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(303, 100);
            this.heading.TabIndex = 0;
            this.heading.Text = "System Resource \r\nMonitor";
            this.heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_right_up
            // 
            this.pnl_right_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnl_right_up.Controls.Add(this.pnl_cpu);
            this.pnl_right_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_right_up.Location = new System.Drawing.Point(303, 0);
            this.pnl_right_up.Name = "pnl_right_up";
            this.pnl_right_up.Size = new System.Drawing.Size(568, 444);
            this.pnl_right_up.TabIndex = 2;
            // 
            // pnl_cpu
            // 
            this.pnl_cpu.Controls.Add(this.lbl_cpu);
            this.pnl_cpu.Location = new System.Drawing.Point(186, 173);
            this.pnl_cpu.Name = "pnl_cpu";
            this.pnl_cpu.Size = new System.Drawing.Size(316, 194);
            this.pnl_cpu.TabIndex = 0;
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_cpu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cpu.Location = new System.Drawing.Point(0, 0);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(316, 46);
            this.lbl_cpu.TabIndex = 0;
            this.lbl_cpu.Text = "CPU : ";
            // 
            // pnl_right_down
            // 
            this.pnl_right_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnl_right_down.Controls.Add(this.pnl_date);
            this.pnl_right_down.Controls.Add(this.pnl_time);
            this.pnl_right_down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_right_down.Location = new System.Drawing.Point(303, 444);
            this.pnl_right_down.Name = "pnl_right_down";
            this.pnl_right_down.Size = new System.Drawing.Size(568, 51);
            this.pnl_right_down.TabIndex = 3;
            // 
            // pnl_date
            // 
            this.pnl_date.Controls.Add(this.lbl_date);
            this.pnl_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_date.Location = new System.Drawing.Point(297, 0);
            this.pnl_date.Name = "pnl_date";
            this.pnl_date.Size = new System.Drawing.Size(271, 51);
            this.pnl_date.TabIndex = 1;
            // 
            // lbl_date
            // 
            this.lbl_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_date.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_date.Location = new System.Drawing.Point(0, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(271, 51);
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
            this.pnl_time.Size = new System.Drawing.Size(297, 51);
            this.pnl_time.TabIndex = 0;
            // 
            // lbl_time
            // 
            this.lbl_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_time.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_time.Location = new System.Drawing.Point(0, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(297, 51);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "Time : ";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.pnl_cpu.ResumeLayout(false);
            this.pnl_right_down.ResumeLayout(false);
            this.pnl_date.ResumeLayout(false);
            this.pnl_time.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_right_up;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Panel pnl_headding;
        private System.Windows.Forms.Panel pnl_category;
        private System.Windows.Forms.Panel pnl_button;
        private System.Windows.Forms.Button btn_ram;
        private System.Windows.Forms.Button btn_cpu;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel pnl_cpu;
        private System.Windows.Forms.Label lbl_cpu;
        private System.Windows.Forms.Panel pnl_right_down;
        private System.Windows.Forms.Panel pnl_date;
        private System.Windows.Forms.Panel pnl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
    }
}

