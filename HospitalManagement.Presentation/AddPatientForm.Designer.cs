namespace HospitalManagement.Presentation
{
    partial class AddPatientForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.AddressBox = new System.Windows.Forms.TextBox();
			this.AgeNumeric = new System.Windows.Forms.NumericUpDown();
			this.DoctorCombo = new System.Windows.Forms.ComboBox();
			this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.Nurse = new System.Windows.Forms.Label();
			this.NurseBox = new System.Windows.Forms.ComboBox();
			this.Add = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.AgeNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 35;
			this.label2.Text = "Affliction";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 17);
			this.label1.TabIndex = 34;
			this.label1.Text = "Age";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// AddressBox
			// 
			this.AddressBox.Location = new System.Drawing.Point(63, 181);
			this.AddressBox.Name = "AddressBox";
			this.AddressBox.Size = new System.Drawing.Size(100, 24);
			this.AddressBox.TabIndex = 30;
			this.AddressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
			// 
			// AgeNumeric
			// 
			this.AgeNumeric.Location = new System.Drawing.Point(65, 75);
			this.AgeNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.AgeNumeric.Name = "AgeNumeric";
			this.AgeNumeric.Size = new System.Drawing.Size(120, 24);
			this.AgeNumeric.TabIndex = 40;
			this.AgeNumeric.ThousandsSeparator = true;
			this.AgeNumeric.ValueChanged += new System.EventHandler(this.AgeNumeric_ValueChanged);
			// 
			// DoctorCombo
			// 
			this.DoctorCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doctorBindingSource, "Name", true));
			this.DoctorCombo.DataSource = this.doctorBindingSource;
			this.DoctorCombo.DisplayMember = "Name";
			this.DoctorCombo.FormattingEnabled = true;
			this.DoctorCombo.Location = new System.Drawing.Point(63, 234);
			this.DoctorCombo.Name = "DoctorCombo";
			this.DoctorCombo.Size = new System.Drawing.Size(121, 24);
			this.DoctorCombo.TabIndex = 41;
			this.DoctorCombo.SelectedIndexChanged += new System.EventHandler(this.DoctorCombo_SelectedIndexChanged);
			// 
			// doctorBindingSource
			// 
			this.doctorBindingSource.DataSource = typeof(HospitalManagement.Core.Entities.Doctor);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(61, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 17);
			this.label3.TabIndex = 42;
			this.label3.Text = "Doctor";
			// 
			// Nurse
			// 
			this.Nurse.AutoSize = true;
			this.Nurse.Location = new System.Drawing.Point(62, 270);
			this.Nurse.Name = "Nurse";
			this.Nurse.Size = new System.Drawing.Size(43, 17);
			this.Nurse.TabIndex = 44;
			this.Nurse.Text = "Nurse";
			// 
			// NurseBox
			// 
			this.NurseBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doctorBindingSource, "Name", true));
			this.NurseBox.DataSource = this.doctorBindingSource;
			this.NurseBox.DisplayMember = "Name";
			this.NurseBox.FormattingEnabled = true;
			this.NurseBox.Location = new System.Drawing.Point(64, 289);
			this.NurseBox.Name = "NurseBox";
			this.NurseBox.Size = new System.Drawing.Size(121, 24);
			this.NurseBox.TabIndex = 43;
			this.NurseBox.SelectedIndexChanged += new System.EventHandler(this.NurseBox_SelectedIndexChanged);
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(145, 451);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(75, 23);
			this.Add.TabIndex = 46;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Cancel
			// 
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(41, 451);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 45;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(65, 134);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 24);
			this.textBox1.TabIndex = 47;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(63, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 17);
			this.label4.TabIndex = 48;
			this.label4.Text = "Name";
			// 
			// AddPatientForm
			// 
			this.AcceptButton = this.Add;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(259, 500);
			this.ControlBox = false;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Nurse);
			this.Controls.Add(this.NurseBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.DoctorCombo);
			this.Controls.Add(this.AgeNumeric);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddressBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddPatientForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "AddPatientForm";
			((System.ComponentModel.ISupportInitialize)(this.AgeNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.NumericUpDown AgeNumeric;
        private System.Windows.Forms.ComboBox DoctorCombo;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nurse;
        private System.Windows.Forms.ComboBox NurseBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
	}
}