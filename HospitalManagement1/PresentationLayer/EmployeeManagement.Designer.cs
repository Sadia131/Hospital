namespace HospitalManagement1.PresentationLayer
{
    partial class EmployeeManagement
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
            this.EmployeelistGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddEmployeeStaflistcomboBox = new System.Windows.Forms.ComboBox();
            this.AddEmployeebutton = new System.Windows.Forms.Button();
            this.AddSalarytextBox = new System.Windows.Forms.TextBox();
            this.AddSpecialisttextBox = new System.Windows.Forms.TextBox();
            this.AddOccupationtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddEmployeeNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchEmployeetextBox = new System.Windows.Forms.TextBox();
            this.searchEmployeedataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.deletetextBox = new System.Windows.Forms.TextBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updateEmployeebutton = new System.Windows.Forms.Button();
            this.updateEmployeetextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeelistGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmployeedataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeelistGridView
            // 
            this.EmployeelistGridView.AllowUserToAddRows = false;
            this.EmployeelistGridView.AllowUserToDeleteRows = false;
            this.EmployeelistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeelistGridView.Location = new System.Drawing.Point(491, 67);
            this.EmployeelistGridView.Name = "EmployeelistGridView";
            this.EmployeelistGridView.ReadOnly = true;
            this.EmployeelistGridView.RowHeadersWidth = 51;
            this.EmployeelistGridView.RowTemplate.Height = 24;
            this.EmployeelistGridView.Size = new System.Drawing.Size(566, 185);
            this.EmployeelistGridView.TabIndex = 0;
            this.EmployeelistGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeelistGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddEmployeeStaflistcomboBox);
            this.groupBox1.Controls.Add(this.AddEmployeebutton);
            this.groupBox1.Controls.Add(this.AddSalarytextBox);
            this.groupBox1.Controls.Add(this.AddSpecialisttextBox);
            this.groupBox1.Controls.Add(this.AddOccupationtextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddEmployeeNametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 382);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Employee";
            // 
            // AddEmployeeStaflistcomboBox
            // 
            this.AddEmployeeStaflistcomboBox.FormattingEnabled = true;
            this.AddEmployeeStaflistcomboBox.Location = new System.Drawing.Point(199, 262);
            this.AddEmployeeStaflistcomboBox.Name = "AddEmployeeStaflistcomboBox";
            this.AddEmployeeStaflistcomboBox.Size = new System.Drawing.Size(154, 28);
            this.AddEmployeeStaflistcomboBox.TabIndex = 11;
            // 
            // AddEmployeebutton
            // 
            this.AddEmployeebutton.Location = new System.Drawing.Point(129, 320);
            this.AddEmployeebutton.Name = "AddEmployeebutton";
            this.AddEmployeebutton.Size = new System.Drawing.Size(109, 43);
            this.AddEmployeebutton.TabIndex = 10;
            this.AddEmployeebutton.Text = "Add";
            this.AddEmployeebutton.UseVisualStyleBackColor = true;
            this.AddEmployeebutton.Click += new System.EventHandler(this.AddEmployeebutton_Click);
            // 
            // AddSalarytextBox
            // 
            this.AddSalarytextBox.Location = new System.Drawing.Point(199, 219);
            this.AddSalarytextBox.Name = "AddSalarytextBox";
            this.AddSalarytextBox.Size = new System.Drawing.Size(154, 27);
            this.AddSalarytextBox.TabIndex = 8;
            // 
            // AddSpecialisttextBox
            // 
            this.AddSpecialisttextBox.Location = new System.Drawing.Point(199, 166);
            this.AddSpecialisttextBox.Name = "AddSpecialisttextBox";
            this.AddSpecialisttextBox.Size = new System.Drawing.Size(154, 27);
            this.AddSpecialisttextBox.TabIndex = 7;
            // 
            // AddOccupationtextBox
            // 
            this.AddOccupationtextBox.Location = new System.Drawing.Point(199, 115);
            this.AddOccupationtextBox.Name = "AddOccupationtextBox";
            this.AddOccupationtextBox.Size = new System.Drawing.Size(154, 27);
            this.AddOccupationtextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Staff";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Specialist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Occupation";
            // 
            // AddEmployeeNametextBox
            // 
            this.AddEmployeeNametextBox.Location = new System.Drawing.Point(199, 46);
            this.AddEmployeeNametextBox.Name = "AddEmployeeNametextBox";
            this.AddEmployeeNametextBox.Size = new System.Drawing.Size(154, 27);
            this.AddEmployeeNametextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchEmployeetextBox);
            this.groupBox2.Controls.Add(this.searchEmployeedataGridView);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(457, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 347);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Employee List";
            // 
            // searchEmployeetextBox
            // 
            this.searchEmployeetextBox.Location = new System.Drawing.Point(255, 52);
            this.searchEmployeetextBox.Name = "searchEmployeetextBox";
            this.searchEmployeetextBox.Size = new System.Drawing.Size(209, 27);
            this.searchEmployeetextBox.TabIndex = 4;
            this.searchEmployeetextBox.TextChanged += new System.EventHandler(this.searchEmployeetextBox_TextChanged);
            // 
            // searchEmployeedataGridView
            // 
            this.searchEmployeedataGridView.AllowUserToAddRows = false;
            this.searchEmployeedataGridView.AllowUserToDeleteRows = false;
            this.searchEmployeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchEmployeedataGridView.Location = new System.Drawing.Point(19, 94);
            this.searchEmployeedataGridView.Name = "searchEmployeedataGridView";
            this.searchEmployeedataGridView.ReadOnly = true;
            this.searchEmployeedataGridView.RowHeadersWidth = 51;
            this.searchEmployeedataGridView.RowTemplate.Height = 24;
            this.searchEmployeedataGridView.Size = new System.Drawing.Size(522, 214);
            this.searchEmployeedataGridView.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Employee Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(901, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back To Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deletebutton);
            this.groupBox4.Controls.Add(this.deletetextBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 593);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 160);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Employee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Employee Id";
            // 
            // deletetextBox
            // 
            this.deletetextBox.Location = new System.Drawing.Point(129, 45);
            this.deletetextBox.Name = "deletetextBox";
            this.deletetextBox.Size = new System.Drawing.Size(159, 22);
            this.deletetextBox.TabIndex = 9;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(100, 100);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(109, 43);
            this.deletebutton.TabIndex = 11;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updateEmployeebutton);
            this.groupBox3.Controls.Add(this.updateEmployeetextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 173);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Employee";
            // 
            // updateEmployeebutton
            // 
            this.updateEmployeebutton.Location = new System.Drawing.Point(100, 100);
            this.updateEmployeebutton.Name = "updateEmployeebutton";
            this.updateEmployeebutton.Size = new System.Drawing.Size(109, 43);
            this.updateEmployeebutton.TabIndex = 11;
            this.updateEmployeebutton.Text = "Update";
            this.updateEmployeebutton.UseVisualStyleBackColor = true;
            this.updateEmployeebutton.Click += new System.EventHandler(this.updateEmployeebutton_Click);
            // 
            // updateEmployeetextBox
            // 
            this.updateEmployeetextBox.Location = new System.Drawing.Point(145, 48);
            this.updateEmployeetextBox.Name = "updateEmployeetextBox";
            this.updateEmployeetextBox.Size = new System.Drawing.Size(159, 22);
            this.updateEmployeetextBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Employee Name";
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 765);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeelistGridView);
            this.Name = "EmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeManagement_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeelistGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmployeedataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeelistGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddEmployeeNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AddEmployeeStaflistcomboBox;
        private System.Windows.Forms.Button AddEmployeebutton;
        private System.Windows.Forms.TextBox AddSalarytextBox;
        private System.Windows.Forms.TextBox AddSpecialisttextBox;
        private System.Windows.Forms.TextBox AddOccupationtextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView searchEmployeedataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchEmployeetextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.TextBox deletetextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button updateEmployeebutton;
        private System.Windows.Forms.TextBox updateEmployeetextBox;
        private System.Windows.Forms.Label label9;
    }
}