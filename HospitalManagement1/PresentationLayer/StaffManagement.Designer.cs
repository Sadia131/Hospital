
namespace HospitalManagement1.PresentationLayer
{
    partial class StaffManagement
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
            this.loadStaffDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.addStaffNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateStaffButton = new System.Windows.Forms.Button();
            this.updateStaffNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteStaffButton = new System.Windows.Forms.Button();
            this.DeleteStaffIdtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.StaffwiseEmployeelistdataGridView = new System.Windows.Forms.DataGridView();
            this.SearchStaffcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadStaffDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffwiseEmployeelistdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadStaffDataGridView
            // 
            this.loadStaffDataGridView.AllowUserToAddRows = false;
            this.loadStaffDataGridView.AllowUserToDeleteRows = false;
            this.loadStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadStaffDataGridView.Location = new System.Drawing.Point(447, 68);
            this.loadStaffDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.loadStaffDataGridView.Name = "loadStaffDataGridView";
            this.loadStaffDataGridView.ReadOnly = true;
            this.loadStaffDataGridView.RowHeadersWidth = 51;
            this.loadStaffDataGridView.Size = new System.Drawing.Size(320, 185);
            this.loadStaffDataGridView.TabIndex = 0;
            this.loadStaffDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadStaffDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Of Staffs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addStaffButton);
            this.groupBox1.Controls.Add(this.addStaffNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(353, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Add New Staff";
            // 
            // addStaffButton
            // 
            this.addStaffButton.Location = new System.Drawing.Point(195, 92);
            this.addStaffButton.Margin = new System.Windows.Forms.Padding(4);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(100, 39);
            this.addStaffButton.TabIndex = 2;
            this.addStaffButton.Text = "Add";
            this.addStaffButton.UseVisualStyleBackColor = true;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // addStaffNameTextBox
            // 
            this.addStaffNameTextBox.Location = new System.Drawing.Point(84, 33);
            this.addStaffNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addStaffNameTextBox.Name = "addStaffNameTextBox";
            this.addStaffNameTextBox.Size = new System.Drawing.Size(237, 30);
            this.addStaffNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateStaffButton);
            this.groupBox2.Controls.Add(this.updateStaffNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 204);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(353, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Staff";
            // 
            // updateStaffButton
            // 
            this.updateStaffButton.Location = new System.Drawing.Point(195, 92);
            this.updateStaffButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateStaffButton.Name = "updateStaffButton";
            this.updateStaffButton.Size = new System.Drawing.Size(100, 39);
            this.updateStaffButton.TabIndex = 2;
            this.updateStaffButton.Text = "Save";
            this.updateStaffButton.UseVisualStyleBackColor = true;
            this.updateStaffButton.Click += new System.EventHandler(this.updateStaffButton_Click);
            // 
            // updateStaffNameTextBox
            // 
            this.updateStaffNameTextBox.Location = new System.Drawing.Point(84, 33);
            this.updateStaffNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.updateStaffNameTextBox.Name = "updateStaffNameTextBox";
            this.updateStaffNameTextBox.Size = new System.Drawing.Size(237, 30);
            this.updateStaffNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Staff";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeleteStaffButton);
            this.groupBox3.Controls.Add(this.DeleteStaffIdtextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 394);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(353, 146);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remove Staff";
            // 
            // DeleteStaffButton
            // 
            this.DeleteStaffButton.Location = new System.Drawing.Point(142, 88);
            this.DeleteStaffButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteStaffButton.Name = "DeleteStaffButton";
            this.DeleteStaffButton.Size = new System.Drawing.Size(126, 39);
            this.DeleteStaffButton.TabIndex = 2;
            this.DeleteStaffButton.Text = "Remove";
            this.DeleteStaffButton.UseVisualStyleBackColor = true;
            this.DeleteStaffButton.Click += new System.EventHandler(this.DeleteStaffbutton_Click);
            // 
            // DeleteStaffIdtextBox
            // 
            this.DeleteStaffIdtextBox.Location = new System.Drawing.Point(108, 31);
            this.DeleteStaffIdtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteStaffIdtextBox.Name = "DeleteStaffIdtextBox";
            this.DeleteStaffIdtextBox.Size = new System.Drawing.Size(237, 30);
            this.DeleteStaffIdtextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Staff Id";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.StaffwiseEmployeelistdataGridView);
            this.groupBox4.Controls.Add(this.SearchStaffcomboBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(477, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(531, 327);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Staff\'s category wise Employee List";
            // 
            // StaffwiseEmployeelistdataGridView
            // 
            this.StaffwiseEmployeelistdataGridView.AllowUserToAddRows = false;
            this.StaffwiseEmployeelistdataGridView.AllowUserToDeleteRows = false;
            this.StaffwiseEmployeelistdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffwiseEmployeelistdataGridView.Location = new System.Drawing.Point(31, 123);
            this.StaffwiseEmployeelistdataGridView.Name = "StaffwiseEmployeelistdataGridView";
            this.StaffwiseEmployeelistdataGridView.ReadOnly = true;
            this.StaffwiseEmployeelistdataGridView.RowHeadersWidth = 51;
            this.StaffwiseEmployeelistdataGridView.RowTemplate.Height = 24;
            this.StaffwiseEmployeelistdataGridView.Size = new System.Drawing.Size(468, 182);
            this.StaffwiseEmployeelistdataGridView.TabIndex = 3;
            this.StaffwiseEmployeelistdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffwiseEmployeelistdataGridView_CellContentClick);
            // 
            // SearchStaffcomboBox
            // 
            this.SearchStaffcomboBox.FormattingEnabled = true;
            this.SearchStaffcomboBox.Location = new System.Drawing.Point(148, 55);
            this.SearchStaffcomboBox.Name = "SearchStaffcomboBox";
            this.SearchStaffcomboBox.Size = new System.Drawing.Size(182, 33);
            this.SearchStaffcomboBox.TabIndex = 2;
            this.SearchStaffcomboBox.SelectedIndexChanged += new System.EventHandler(this.SearchStaffcomboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Staff";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(212, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back To Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(943, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 667);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadStaffDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffManagement_FormClosing);
            this.Load += new System.EventHandler(this.StaffManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadStaffDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffwiseEmployeelistdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loadStaffDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.TextBox addStaffNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateStaffButton;
        private System.Windows.Forms.TextBox updateStaffNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteStaffButton;
        private System.Windows.Forms.TextBox DeleteStaffIdtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView StaffwiseEmployeelistdataGridView;
        private System.Windows.Forms.ComboBox SearchStaffcomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}