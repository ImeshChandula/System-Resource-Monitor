namespace System_Resource_Monitor
{
    partial class form_cpu
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
            this.pnl_title = new System.Windows.Forms.Panel();
            this.pnl_title_right = new System.Windows.Forms.Panel();
            this.pnl_generate = new System.Windows.Forms.Panel();
            this.btn_genetare = new System.Windows.Forms.Button();
            this.pnl_date_time = new System.Windows.Forms.Panel();
            this.lbl_titleName = new System.Windows.Forms.Label();
            this.pnl_title.SuspendLayout();
            this.pnl_title_right.SuspendLayout();
            this.pnl_generate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.Black;
            this.pnl_title.Controls.Add(this.pnl_title_right);
            this.pnl_title.Controls.Add(this.lbl_titleName);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(800, 81);
            this.pnl_title.TabIndex = 2;
            // 
            // pnl_title_right
            // 
            this.pnl_title_right.Controls.Add(this.pnl_generate);
            this.pnl_title_right.Controls.Add(this.pnl_date_time);
            this.pnl_title_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_title_right.Location = new System.Drawing.Point(600, 0);
            this.pnl_title_right.Name = "pnl_title_right";
            this.pnl_title_right.Size = new System.Drawing.Size(200, 81);
            this.pnl_title_right.TabIndex = 1;
            // 
            // pnl_generate
            // 
            this.pnl_generate.Controls.Add(this.btn_genetare);
            this.pnl_generate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_generate.Location = new System.Drawing.Point(0, 34);
            this.pnl_generate.Name = "pnl_generate";
            this.pnl_generate.Size = new System.Drawing.Size(200, 47);
            this.pnl_generate.TabIndex = 0;
            // 
            // btn_genetare
            // 
            this.btn_genetare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_genetare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_genetare.FlatAppearance.BorderSize = 0;
            this.btn_genetare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_genetare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_genetare.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genetare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_genetare.Location = new System.Drawing.Point(0, 0);
            this.btn_genetare.Name = "btn_genetare";
            this.btn_genetare.Size = new System.Drawing.Size(200, 47);
            this.btn_genetare.TabIndex = 0;
            this.btn_genetare.Text = "Click Here to Generate";
            this.btn_genetare.UseVisualStyleBackColor = true;
            // 
            // pnl_date_time
            // 
            this.pnl_date_time.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_date_time.Location = new System.Drawing.Point(0, 0);
            this.pnl_date_time.Name = "pnl_date_time";
            this.pnl_date_time.Size = new System.Drawing.Size(200, 34);
            this.pnl_date_time.TabIndex = 0;
            // 
            // lbl_titleName
            // 
            this.lbl_titleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_titleName.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titleName.Location = new System.Drawing.Point(0, 0);
            this.lbl_titleName.Name = "lbl_titleName";
            this.lbl_titleName.Size = new System.Drawing.Size(800, 81);
            this.lbl_titleName.TabIndex = 0;
            this.lbl_titleName.Text = "CPU";
            this.lbl_titleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form_cpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_title);
            this.Name = "form_cpu";
            this.Text = "form_cpu";
            this.pnl_title.ResumeLayout(false);
            this.pnl_title_right.ResumeLayout(false);
            this.pnl_generate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Panel pnl_title_right;
        private System.Windows.Forms.Panel pnl_generate;
        private System.Windows.Forms.Button btn_genetare;
        private System.Windows.Forms.Panel pnl_date_time;
        private System.Windows.Forms.Label lbl_titleName;
    }
}