namespace WindowsFormsApp
{
    partial class MainForm
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
            this.btn_qlop = new System.Windows.Forms.Button();
            this.btn_qlsv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_qlop
            // 
            this.btn_qlop.Location = new System.Drawing.Point(144, 213);
            this.btn_qlop.Name = "btn_qlop";
            this.btn_qlop.Size = new System.Drawing.Size(178, 56);
            this.btn_qlop.TabIndex = 0;
            this.btn_qlop.Text = "Quản lý lớp học";
            this.btn_qlop.UseVisualStyleBackColor = true;
            this.btn_qlop.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_qlsv
            // 
            this.btn_qlsv.Location = new System.Drawing.Point(446, 213);
            this.btn_qlsv.Name = "btn_qlsv";
            this.btn_qlsv.Size = new System.Drawing.Size(178, 56);
            this.btn_qlsv.TabIndex = 1;
            this.btn_qlsv.Text = "Quản lý sinh viên";
            this.btn_qlsv.UseVisualStyleBackColor = true;
            this.btn_qlsv.Click += new System.EventHandler(this.btn_qlsv_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "App quản lý ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(12, 412);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(94, 26);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_qlsv);
            this.Controls.Add(this.btn_qlop);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_qlop;
        private System.Windows.Forms.Button btn_qlsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
    }
}