namespace TutionManagementSystem
{
    partial class Tutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEs = new System.Windows.Forms.Label();
            this.lblNod = new System.Windows.Forms.Label();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEs = new System.Windows.Forms.Label();
            this.txtNod = new System.Windows.Forms.Label();
            this.txtMedium = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.REMOVE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentMedium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNumberOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentofferedSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(1092, 134);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tutor Panel";
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
            this.menuStrip1.Size = new System.Drawing.Size(1092, 28);
            this.menuStrip1.TabIndex = 1;
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
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.BackColor = System.Drawing.Color.Transparent;
            this.lblEs.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEs.ForeColor = System.Drawing.Color.White;
            this.lblEs.Location = new System.Drawing.Point(322, 561);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(70, 27);
            this.lblEs.TabIndex = 26;
            this.lblEs.Text = "label13";
            // 
            // lblNod
            // 
            this.lblNod.AutoSize = true;
            this.lblNod.BackColor = System.Drawing.Color.Transparent;
            this.lblNod.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNod.ForeColor = System.Drawing.Color.White;
            this.lblNod.Location = new System.Drawing.Point(322, 509);
            this.lblNod.Name = "lblNod";
            this.lblNod.Size = new System.Drawing.Size(70, 27);
            this.lblNod.TabIndex = 25;
            this.lblNod.Text = "label12";
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.BackColor = System.Drawing.Color.Transparent;
            this.lblUniversity.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversity.ForeColor = System.Drawing.Color.White;
            this.lblUniversity.Location = new System.Drawing.Point(322, 416);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(70, 27);
            this.lblUniversity.TabIndex = 24;
            this.lblUniversity.Text = "label11";
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.BackColor = System.Drawing.Color.Transparent;
            this.lblMedium.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.ForeColor = System.Drawing.Color.White;
            this.lblMedium.Location = new System.Drawing.Point(322, 370);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(70, 27);
            this.lblMedium.TabIndex = 23;
            this.lblMedium.Text = "label10";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(322, 317);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(60, 27);
            this.lblLocation.TabIndex = 22;
            this.lblLocation.Text = "label9";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(322, 263);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 27);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "label8";
            // 
            // txtEs
            // 
            this.txtEs.AutoSize = true;
            this.txtEs.BackColor = System.Drawing.Color.Transparent;
            this.txtEs.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEs.ForeColor = System.Drawing.Color.White;
            this.txtEs.Location = new System.Drawing.Point(105, 561);
            this.txtEs.Name = "txtEs";
            this.txtEs.Size = new System.Drawing.Size(145, 27);
            this.txtEs.TabIndex = 20;
            this.txtEs.Text = "Expected Salary";
            // 
            // txtNod
            // 
            this.txtNod.AutoSize = true;
            this.txtNod.BackColor = System.Drawing.Color.Transparent;
            this.txtNod.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNod.ForeColor = System.Drawing.Color.White;
            this.txtNod.Location = new System.Drawing.Point(105, 509);
            this.txtNod.Name = "txtNod";
            this.txtNod.Size = new System.Drawing.Size(150, 27);
            this.txtNod.TabIndex = 19;
            this.txtNod.Text = "Number Of Days";
            // 
            // txtMedium
            // 
            this.txtMedium.AutoSize = true;
            this.txtMedium.BackColor = System.Drawing.Color.Transparent;
            this.txtMedium.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedium.ForeColor = System.Drawing.Color.White;
            this.txtMedium.Location = new System.Drawing.Point(105, 370);
            this.txtMedium.Name = "txtMedium";
            this.txtMedium.Size = new System.Drawing.Size(79, 27);
            this.txtMedium.TabIndex = 17;
            this.txtMedium.Text = "Medium";
            // 
            // txtLocation
            // 
            this.txtLocation.AutoSize = true;
            this.txtLocation.BackColor = System.Drawing.Color.Transparent;
            this.txtLocation.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.ForeColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(105, 317);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(80, 27);
            this.txtLocation.TabIndex = 16;
            this.txtLocation.Text = "Location";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(105, 263);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(62, 27);
            this.name.TabIndex = 15;
            this.name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 43);
            this.label2.TabIndex = 14;
            this.label2.Text = "My Information";
            // 
            // txtClass
            // 
            this.txtClass.AutoSize = true;
            this.txtClass.BackColor = System.Drawing.Color.Transparent;
            this.txtClass.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.White;
            this.txtClass.Location = new System.Drawing.Point(105, 416);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(92, 27);
            this.txtClass.TabIndex = 18;
            this.txtClass.Text = "University";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.White;
            this.lblDepartment.Location = new System.Drawing.Point(322, 462);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(70, 27);
            this.lblDepartment.TabIndex = 28;
            this.lblDepartment.Text = "label13";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(105, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(713, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 33);
            this.label5.TabIndex = 30;
            this.label5.Text = "Requests";
            // 
            // dgvRequest
            // 
            this.dgvRequest.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2,
            this.REMOVE,
            this.TutorId,
            this.StudentName,
            this.StudentGender,
            this.StudentLocation,
            this.StudentMedium,
            this.StudentClass,
            this.StudentNumberOfDays,
            this.StudentofferedSalary});
            this.dgvRequest.Location = new System.Drawing.Point(511, 263);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.RowHeadersWidth = 51;
            this.dgvRequest.RowTemplate.Height = 24;
            this.dgvRequest.Size = new System.Drawing.Size(494, 325);
            this.dgvRequest.TabIndex = 32;
            this.dgvRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellContentClick_1);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "ACTION";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Accept Req";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 85;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "FEEDBACK";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "REPORT";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 90;
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
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 125;
            // 
            // StudentGender
            // 
            this.StudentGender.HeaderText = "Gender";
            this.StudentGender.MinimumWidth = 6;
            this.StudentGender.Name = "StudentGender";
            this.StudentGender.Width = 125;
            // 
            // StudentLocation
            // 
            this.StudentLocation.HeaderText = "Location";
            this.StudentLocation.MinimumWidth = 6;
            this.StudentLocation.Name = "StudentLocation";
            this.StudentLocation.Width = 125;
            // 
            // StudentMedium
            // 
            this.StudentMedium.HeaderText = "Medium";
            this.StudentMedium.MinimumWidth = 6;
            this.StudentMedium.Name = "StudentMedium";
            this.StudentMedium.Width = 125;
            // 
            // StudentClass
            // 
            this.StudentClass.HeaderText = "Class";
            this.StudentClass.MinimumWidth = 6;
            this.StudentClass.Name = "StudentClass";
            this.StudentClass.Width = 125;
            // 
            // StudentNumberOfDays
            // 
            this.StudentNumberOfDays.HeaderText = "NumberOfDays";
            this.StudentNumberOfDays.MinimumWidth = 6;
            this.StudentNumberOfDays.Name = "StudentNumberOfDays";
            this.StudentNumberOfDays.Width = 125;
            // 
            // StudentofferedSalary
            // 
            this.StudentofferedSalary.HeaderText = "OfferedSalary";
            this.StudentofferedSalary.MinimumWidth = 6;
            this.StudentofferedSalary.Name = "StudentofferedSalary";
            this.StudentofferedSalary.Width = 125;
            // 
            // Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 663);
            this.Controls.Add(this.dgvRequest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEs);
            this.Controls.Add(this.lblNod);
            this.Controls.Add(this.lblUniversity);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEs);
            this.Controls.Add(this.txtNod);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtMedium);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor";
            this.Load += new System.EventHandler(this.Tutor_Load);
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
        private System.Windows.Forms.Label lblEs;
        private System.Windows.Forms.Label lblNod;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label txtEs;
        private System.Windows.Forms.Label txtNod;
        private System.Windows.Forms.Label txtMedium;
        private System.Windows.Forms.Label txtLocation;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtClass;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msSearch;
        private System.Windows.Forms.ToolStripMenuItem msLogout;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn REMOVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentMedium;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumberOfDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentofferedSalary;
    }
}