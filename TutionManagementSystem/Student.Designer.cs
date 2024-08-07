namespace TutionManagementSystem
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.Label();
            this.txtMedium = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.Label();
            this.txtNod = new System.Windows.Forms.Label();
            this.txtOs = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblNod = new System.Windows.Forms.Label();
            this.lblOs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.ACTION = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FEEDBACK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.REMOVE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorMedium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorUniverstiy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorNumberOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorExpectedSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 126);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(439, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Panel";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSearch,
            this.msLogout,
            this.msExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msSearch
            // 
            this.msSearch.Name = "msSearch";
            this.msSearch.Size = new System.Drawing.Size(67, 24);
            this.msSearch.Text = "Search";
            this.msSearch.Click += new System.EventHandler(this.msSearch_Click);
            // 
            // msLogout
            // 
            this.msLogout.Name = "msLogout";
            this.msLogout.Size = new System.Drawing.Size(70, 24);
            this.msLogout.Text = "Logout";
            this.msLogout.Click += new System.EventHandler(this.msLogout_Click);
            // 
            // msExit
            // 
            this.msExit.Name = "msExit";
            this.msExit.Size = new System.Drawing.Size(47, 24);
            this.msExit.Text = "Exit";
            this.msExit.Click += new System.EventHandler(this.msExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "My Information";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(108, 312);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(62, 27);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // txtLocation
            // 
            this.txtLocation.AutoSize = true;
            this.txtLocation.BackColor = System.Drawing.Color.Transparent;
            this.txtLocation.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.ForeColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(108, 366);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(80, 27);
            this.txtLocation.TabIndex = 3;
            this.txtLocation.Text = "Location";
            // 
            // txtMedium
            // 
            this.txtMedium.AutoSize = true;
            this.txtMedium.BackColor = System.Drawing.Color.Transparent;
            this.txtMedium.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedium.ForeColor = System.Drawing.Color.White;
            this.txtMedium.Location = new System.Drawing.Point(108, 455);
            this.txtMedium.Name = "txtMedium";
            this.txtMedium.Size = new System.Drawing.Size(79, 27);
            this.txtMedium.TabIndex = 4;
            this.txtMedium.Text = "Medium";
            // 
            // txtClass
            // 
            this.txtClass.AutoSize = true;
            this.txtClass.BackColor = System.Drawing.Color.Transparent;
            this.txtClass.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.White;
            this.txtClass.Location = new System.Drawing.Point(108, 501);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(58, 27);
            this.txtClass.TabIndex = 5;
            this.txtClass.Text = "Class";
            // 
            // txtNod
            // 
            this.txtNod.AutoSize = true;
            this.txtNod.BackColor = System.Drawing.Color.Transparent;
            this.txtNod.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNod.ForeColor = System.Drawing.Color.White;
            this.txtNod.Location = new System.Drawing.Point(108, 550);
            this.txtNod.Name = "txtNod";
            this.txtNod.Size = new System.Drawing.Size(150, 27);
            this.txtNod.TabIndex = 6;
            this.txtNod.Text = "Number Of Days";
            // 
            // txtOs
            // 
            this.txtOs.AutoSize = true;
            this.txtOs.BackColor = System.Drawing.Color.Transparent;
            this.txtOs.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOs.ForeColor = System.Drawing.Color.White;
            this.txtOs.Location = new System.Drawing.Point(108, 602);
            this.txtOs.Name = "txtOs";
            this.txtOs.Size = new System.Drawing.Size(130, 27);
            this.txtOs.TabIndex = 7;
            this.txtOs.Text = "Offered Salary";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(325, 312);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 27);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "label8";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(325, 366);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(60, 27);
            this.lblLocation.TabIndex = 9;
            this.lblLocation.Text = "label9";
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.BackColor = System.Drawing.Color.Transparent;
            this.lblMedium.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.ForeColor = System.Drawing.Color.White;
            this.lblMedium.Location = new System.Drawing.Point(325, 455);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(70, 27);
            this.lblMedium.TabIndex = 10;
            this.lblMedium.Text = "label10";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.White;
            this.lblClass.Location = new System.Drawing.Point(325, 501);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(70, 27);
            this.lblClass.TabIndex = 11;
            this.lblClass.Text = "label11";
            // 
            // lblNod
            // 
            this.lblNod.AutoSize = true;
            this.lblNod.BackColor = System.Drawing.Color.Transparent;
            this.lblNod.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNod.ForeColor = System.Drawing.Color.White;
            this.lblNod.Location = new System.Drawing.Point(325, 550);
            this.lblNod.Name = "lblNod";
            this.lblNod.Size = new System.Drawing.Size(70, 27);
            this.lblNod.TabIndex = 12;
            this.lblNod.Text = "label12";
            // 
            // lblOs
            // 
            this.lblOs.AutoSize = true;
            this.lblOs.BackColor = System.Drawing.Color.Transparent;
            this.lblOs.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOs.ForeColor = System.Drawing.Color.White;
            this.lblOs.Location = new System.Drawing.Point(325, 602);
            this.lblOs.Name = "lblOs";
            this.lblOs.Size = new System.Drawing.Size(70, 27);
            this.lblOs.TabIndex = 13;
            this.lblOs.Text = "label13";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(741, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "Requests";
            // 
            // dgvRequest
            // 
            this.dgvRequest.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACTION,
            this.FEEDBACK,
            this.REMOVE,
            this.TutorId,
            this.TutorName,
            this.TutorGender,
            this.TutorLocation,
            this.TutorMedium,
            this.TutorUniverstiy,
            this.TutorDepartment,
            this.TutorNumberOfDays,
            this.TutorExpectedSalary});
            this.dgvRequest.Location = new System.Drawing.Point(526, 312);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.RowHeadersWidth = 51;
            this.dgvRequest.RowTemplate.Height = 24;
            this.dgvRequest.Size = new System.Drawing.Size(499, 317);
            this.dgvRequest.TabIndex = 31;
            this.dgvRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellContentClick);
            // 
            // ACTION
            // 
            this.ACTION.HeaderText = "ACTION";
            this.ACTION.MinimumWidth = 6;
            this.ACTION.Name = "ACTION";
            this.ACTION.Text = "Accept Req";
            this.ACTION.UseColumnTextForButtonValue = true;
            this.ACTION.Width = 85;
            // 
            // FEEDBACK
            // 
            this.FEEDBACK.HeaderText = "FEEDBACK";
            this.FEEDBACK.MinimumWidth = 6;
            this.FEEDBACK.Name = "FEEDBACK";
            this.FEEDBACK.Text = "REPORT";
            this.FEEDBACK.UseColumnTextForButtonValue = true;
            this.FEEDBACK.Width = 90;
            // 
            // REMOVE
            // 
            this.REMOVE.HeaderText = "REMOVE";
            this.REMOVE.MinimumWidth = 6;
            this.REMOVE.Name = "REMOVE";
            this.REMOVE.Text = "REMOVE";
            this.REMOVE.UseColumnTextForButtonValue = true;
            this.REMOVE.Width = 85;
            // 
            // TutorId
            // 
            this.TutorId.HeaderText = "Id";
            this.TutorId.MinimumWidth = 6;
            this.TutorId.Name = "TutorId";
            this.TutorId.Width = 125;
            // 
            // TutorName
            // 
            this.TutorName.HeaderText = "Name";
            this.TutorName.MinimumWidth = 6;
            this.TutorName.Name = "TutorName";
            this.TutorName.Width = 125;
            // 
            // TutorGender
            // 
            this.TutorGender.HeaderText = "Gender";
            this.TutorGender.MinimumWidth = 6;
            this.TutorGender.Name = "TutorGender";
            this.TutorGender.Width = 125;
            // 
            // TutorLocation
            // 
            this.TutorLocation.HeaderText = "Location";
            this.TutorLocation.MinimumWidth = 6;
            this.TutorLocation.Name = "TutorLocation";
            this.TutorLocation.Width = 125;
            // 
            // TutorMedium
            // 
            this.TutorMedium.HeaderText = "Medium";
            this.TutorMedium.MinimumWidth = 6;
            this.TutorMedium.Name = "TutorMedium";
            this.TutorMedium.Width = 125;
            // 
            // TutorUniverstiy
            // 
            this.TutorUniverstiy.HeaderText = "Universtiy";
            this.TutorUniverstiy.MinimumWidth = 6;
            this.TutorUniverstiy.Name = "TutorUniverstiy";
            this.TutorUniverstiy.Width = 125;
            // 
            // TutorDepartment
            // 
            this.TutorDepartment.HeaderText = "Department";
            this.TutorDepartment.MinimumWidth = 6;
            this.TutorDepartment.Name = "TutorDepartment";
            this.TutorDepartment.Width = 125;
            // 
            // TutorNumberOfDays
            // 
            this.TutorNumberOfDays.HeaderText = "NumberOfDays";
            this.TutorNumberOfDays.MinimumWidth = 6;
            this.TutorNumberOfDays.Name = "TutorNumberOfDays";
            this.TutorNumberOfDays.Width = 125;
            // 
            // TutorExpectedSalary
            // 
            this.TutorExpectedSalary.HeaderText = "ExpectedSalary";
            this.TutorExpectedSalary.MinimumWidth = 6;
            this.TutorExpectedSalary.Name = "TutorExpectedSalary";
            this.TutorExpectedSalary.Width = 125;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(325, 410);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(73, 27);
            this.lblGender.TabIndex = 34;
            this.lblGender.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "Gender";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 691);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvRequest);
            this.Controls.Add(this.lblOs);
            this.Controls.Add(this.lblNod);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtOs);
            this.Controls.Add(this.txtNod);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtMedium);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label txtLocation;
        private System.Windows.Forms.Label txtMedium;
        private System.Windows.Forms.Label txtClass;
        private System.Windows.Forms.Label txtNod;
        private System.Windows.Forms.Label txtOs;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblNod;
        private System.Windows.Forms.Label lblOs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msSearch;
        private System.Windows.Forms.ToolStripMenuItem msLogout;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn ACTION;
        private System.Windows.Forms.DataGridViewButtonColumn FEEDBACK;
        private System.Windows.Forms.DataGridViewButtonColumn REMOVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorMedium;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorUniverstiy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorNumberOfDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorExpectedSalary;
    }
}