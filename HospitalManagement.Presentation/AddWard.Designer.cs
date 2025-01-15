namespace HospitalManagement.Presentation
{
	partial class AddWard
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
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.NursesBox = new System.Windows.Forms.ComboBox();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NursesLabelsda = new System.Windows.Forms.Label();
            this.DoctorsLabel = new System.Windows.Forms.Label();
            this.NursesLabel = new System.Windows.Forms.Label();
            this.DoctorsBox = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalsBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(38, 442);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(139, 442);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "Add";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(66, 52);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 24);
            this.NameBox.TabIndex = 3;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(61, 85);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(99, 17);
            this.PhoneNumber.TabIndex = 5;
            this.PhoneNumber.Text = "Phone number";
            // 
            // NursesBox
            // 
            this.NursesBox.DataSource = this.nurseBindingSource;
            this.NursesBox.DisplayMember = "Name";
            this.NursesBox.FormattingEnabled = true;
            this.NursesBox.Location = new System.Drawing.Point(55, 205);
            this.NursesBox.Name = "NursesBox";
            this.NursesBox.Size = new System.Drawing.Size(121, 24);
            this.NursesBox.TabIndex = 7;
            this.NursesBox.SelectedIndexChanged += new System.EventHandler(this.NursesBox_SelectedIndexChanged);
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataSource = typeof(HospitalManagement.Core.Entities.Nurse);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doctors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nurses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chosen doctors";
            // 
            // NursesLabelsda
            // 
            this.NursesLabelsda.AutoSize = true;
            this.NursesLabelsda.Location = new System.Drawing.Point(38, 372);
            this.NursesLabelsda.Name = "NursesLabelsda";
            this.NursesLabelsda.Size = new System.Drawing.Size(98, 17);
            this.NursesLabelsda.TabIndex = 11;
            this.NursesLabelsda.Text = "Chosen nurses";
            // 
            // DoctorsLabel
            // 
            this.DoctorsLabel.AutoSize = true;
            this.DoctorsLabel.Location = new System.Drawing.Point(38, 332);
            this.DoctorsLabel.Name = "DoctorsLabel";
            this.DoctorsLabel.Size = new System.Drawing.Size(0, 17);
            this.DoctorsLabel.TabIndex = 12;
            // 
            // NursesLabel
            // 
            this.NursesLabel.AutoSize = true;
            this.NursesLabel.Location = new System.Drawing.Point(38, 399);
            this.NursesLabel.Name = "NursesLabel";
            this.NursesLabel.Size = new System.Drawing.Size(0, 17);
            this.NursesLabel.TabIndex = 13;
            // 
            // DoctorsBox
            // 
            this.DoctorsBox.DataSource = this.nurseBindingSource;
            this.DoctorsBox.DisplayMember = "Name";
            this.DoctorsBox.FormattingEnabled = true;
            this.DoctorsBox.Location = new System.Drawing.Point(55, 156);
            this.DoctorsBox.Name = "DoctorsBox";
            this.DoctorsBox.Size = new System.Drawing.Size(121, 24);
            this.DoctorsBox.TabIndex = 14;
            this.DoctorsBox.SelectedIndexChanged += new System.EventHandler(this.DoctorsBox_SelectedIndexChanged);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(HospitalManagement.Core.Entities.Doctor);
            // 
            // hospitalsBox
            // 
            this.hospitalsBox.DataSource = this.hospitalBindingSource;
            this.hospitalsBox.DisplayMember = "Address";
            this.hospitalsBox.FormattingEnabled = true;
            this.hospitalsBox.Location = new System.Drawing.Point(55, 252);
            this.hospitalsBox.Name = "hospitalsBox";
            this.hospitalsBox.Size = new System.Drawing.Size(121, 24);
            this.hospitalsBox.TabIndex = 15;
            this.hospitalsBox.SelectedIndexChanged += new System.EventHandler(this.hospitalsBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "hospital";
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataSource = typeof(HospitalManagement.Core.Entities.Hospital);
            // 
            // AddWard
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(259, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hospitalsBox);
            this.Controls.Add(this.DoctorsBox);
            this.Controls.Add(this.NursesLabel);
            this.Controls.Add(this.DoctorsLabel);
            this.Controls.Add(this.NursesLabelsda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NursesBox);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddWard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWard";
            this.Load += new System.EventHandler(this.AddWard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.ComboBox NursesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NursesLabelsda;
        private System.Windows.Forms.Label DoctorsLabel;
        private System.Windows.Forms.Label NursesLabel;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private System.Windows.Forms.ComboBox DoctorsBox;
        private System.Windows.Forms.ComboBox hospitalsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
    }
}