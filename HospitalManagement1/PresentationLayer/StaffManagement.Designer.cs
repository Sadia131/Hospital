
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
            this.label2 = new System.Windows.Forms.Label();
            this.addStaffNameTextBox = new System.Windows.Forms.TextBox();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateStaffButton = new System.Windows.Forms.Button();
            this.updateStaffNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadStaffDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadStaffDataGridView
            // 
            this.loadStaffDataGridView.AllowUserToAddRows = false;
            this.loadStaffDataGridView.AllowUserToDeleteRows = false;
            this.loadStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadStaffDataGridView.Location = new System.Drawing.Point(335, 55);
            this.loadStaffDataGridView.Name = "loadStaffDataGridView";
            this.loadStaffDataGridView.ReadOnly = true;
            this.loadStaffDataGridView.Size = new System.Drawing.Size(240, 150);
            this.loadStaffDataGridView.TabIndex = 0;
            this.loadStaffDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadStaffDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Of Staffs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addStaffButton);
            this.groupBox1.Controls.Add(this.addStaffNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Add New Staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff";
            // 
            // addStaffNameTextBox
            // 
            this.addStaffNameTextBox.Location = new System.Drawing.Point(63, 27);
            this.addStaffNameTextBox.Name = "addStaffNameTextBox";
            this.addStaffNameTextBox.Size = new System.Drawing.Size(179, 26);
            this.addStaffNameTextBox.TabIndex = 1;
            // 
            // addStaffButton
            // 
            this.addStaffButton.Location = new System.Drawing.Point(146, 75);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(75, 32);
            this.addStaffButton.TabIndex = 2;
            this.addStaffButton.Text = "Add";
            this.addStaffButton.UseVisualStyleBackColor = true;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateStaffButton);
            this.groupBox2.Controls.Add(this.updateStaffNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 119);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Staff";
            // 
            // updateStaffButton
            // 
            this.updateStaffButton.Location = new System.Drawing.Point(146, 75);
            this.updateStaffButton.Name = "updateStaffButton";
            this.updateStaffButton.Size = new System.Drawing.Size(75, 32);
            this.updateStaffButton.TabIndex = 2;
            this.updateStaffButton.Text = "Save";
            this.updateStaffButton.UseVisualStyleBackColor = true;
            this.updateStaffButton.Click += new System.EventHandler(this.updateStaffButton_Click);
            // 
            // updateStaffNameTextBox
            // 
            this.updateStaffNameTextBox.Location = new System.Drawing.Point(63, 27);
            this.updateStaffNameTextBox.Name = "updateStaffNameTextBox";
            this.updateStaffNameTextBox.Size = new System.Drawing.Size(179, 26);
            this.updateStaffNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Staff";
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadStaffDataGridView);
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
    }
}