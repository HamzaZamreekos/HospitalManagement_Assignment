namespace HospitalManagement.Presentation
{
	partial class AddLaboratory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLaboratory));
			this.Cancel = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.NumberOfRooms = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.deviceName = new System.Windows.Forms.TextBox();
			this.AddDeviceButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.wardSelector = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.wardBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.NumberOfRooms)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// Cancel
			// 
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this.Cancel, "Cancel");
			this.Cancel.Name = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			resources.ApplyResources(this.okButton, "okButton");
			this.okButton.Name = "okButton";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// nameBox
			// 
			resources.ApplyResources(this.nameBox, "nameBox");
			this.nameBox.Name = "nameBox";
			this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
			// 
			// NumberOfRooms
			// 
			resources.ApplyResources(this.NumberOfRooms, "NumberOfRooms");
			this.NumberOfRooms.Name = "NumberOfRooms";
			this.NumberOfRooms.ValueChanged += new System.EventHandler(this.NumberOfRooms_ValueChanged);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// deviceName
			// 
			resources.ApplyResources(this.deviceName, "deviceName");
			this.deviceName.Name = "deviceName";
			this.deviceName.TextChanged += new System.EventHandler(this.deviceName_TextChanged);
			// 
			// AddDeviceButton
			// 
			resources.ApplyResources(this.AddDeviceButton, "AddDeviceButton");
			this.AddDeviceButton.Name = "AddDeviceButton";
			this.AddDeviceButton.UseVisualStyleBackColor = true;
			this.AddDeviceButton.Click += new System.EventHandler(this.AddDeviceButton_Click);
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// wardSelector
			// 
			this.wardSelector.DataSource = this.wardBindingSource;
			this.wardSelector.DisplayMember = "Name";
			this.wardSelector.FormattingEnabled = true;
			resources.ApplyResources(this.wardSelector, "wardSelector");
			this.wardSelector.Name = "wardSelector";
			this.wardSelector.SelectedIndexChanged += new System.EventHandler(this.wardSelector_SelectedIndexChanged);
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// wardBindingSource
			// 
			this.wardBindingSource.DataSource = typeof(HospitalManagement.Core.Entities.Ward);
			// 
			// AddLaboratory
			// 
			this.AcceptButton = this.okButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Controls.Add(this.label6);
			this.Controls.Add(this.wardSelector);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.AddDeviceButton);
			this.Controls.Add(this.deviceName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NumberOfRooms);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.Cancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddLaboratory";
			((System.ComponentModel.ISupportInitialize)(this.NumberOfRooms)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.NumericUpDown NumberOfRooms;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox deviceName;
		private System.Windows.Forms.Button AddDeviceButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox wardSelector;
		private System.Windows.Forms.BindingSource wardBindingSource;
		private System.Windows.Forms.Label label6;
	}
}