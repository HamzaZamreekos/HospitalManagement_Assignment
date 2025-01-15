namespace HospitalManagement.Presentation
{
	partial class AddHospital
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.AddressBox = new System.Windows.Forms.TextBox();
			this.DoctorComboBox = new System.Windows.Forms.ComboBox();
			this.PhoneNumberBox = new System.Windows.Forms.TextBox();
			this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(137, 410);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(34, 410);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Phone number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Address";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(65, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Doctor";
			// 
			// AddressBox
			// 
			this.AddressBox.Location = new System.Drawing.Point(65, 142);
			this.AddressBox.Name = "AddressBox";
			this.AddressBox.Size = new System.Drawing.Size(100, 24);
			this.AddressBox.TabIndex = 6;
			this.AddressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
			// 
			// DoctorComboBox
			// 
			this.DoctorComboBox.DataSource = this.doctorBindingSource;
			this.DoctorComboBox.DisplayMember = "Name";
			this.DoctorComboBox.FormattingEnabled = true;
			this.DoctorComboBox.Location = new System.Drawing.Point(53, 207);
			this.DoctorComboBox.Name = "DoctorComboBox";
			this.DoctorComboBox.Size = new System.Drawing.Size(121, 24);
			this.DoctorComboBox.TabIndex = 7;
			this.DoctorComboBox.SelectedIndexChanged += new System.EventHandler(this.DoctorComboBox_SelectedIndexChanged);
			// 
			// PhoneNumberBox
			// 
			this.PhoneNumberBox.Location = new System.Drawing.Point(65, 77);
			this.PhoneNumberBox.Name = "PhoneNumberBox";
			this.PhoneNumberBox.Size = new System.Drawing.Size(100, 24);
			this.PhoneNumberBox.TabIndex = 8;
			this.PhoneNumberBox.TextChanged += new System.EventHandler(this.PhoneNumberBox_TextChanged);
			// 
			// doctorBindingSource
			// 
			this.doctorBindingSource.DataSource = typeof(HospitalManagement.Core.Entities.Doctor);
			// 
			// AddHospital
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(241, 453);
			this.Controls.Add(this.PhoneNumberBox);
			this.Controls.Add(this.DoctorComboBox);
			this.Controls.Add(this.AddressBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddHospital";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddHospital";
			((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox AddressBox;
		private System.Windows.Forms.ComboBox DoctorComboBox;
		private System.Windows.Forms.TextBox PhoneNumberBox;
		private System.Windows.Forms.BindingSource doctorBindingSource;
	}
}