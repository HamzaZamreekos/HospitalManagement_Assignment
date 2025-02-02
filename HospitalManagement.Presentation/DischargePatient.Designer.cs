﻿namespace HospitalManagement.Presentation
{
    partial class DischargePatient
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.patientState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceField)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(33, 465);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(151, 465);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // patientState
            // 
            this.patientState.FormattingEnabled = true;
            this.patientState.Location = new System.Drawing.Point(63, 126);
            this.patientState.Name = "patientState";
            this.patientState.Size = new System.Drawing.Size(121, 24);
            this.patientState.TabIndex = 2;
            this.patientState.SelectedIndexChanged += new System.EventHandler(this.patientState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient\'s state";
            // 
            // priceField
            // 
            this.priceField.DecimalPlaces = 2;
            this.priceField.Location = new System.Drawing.Point(63, 183);
            this.priceField.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(120, 24);
            this.priceField.TabIndex = 4;
            this.priceField.ValueChanged += new System.EventHandler(this.priceField_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paid";
            // 
            // DischargePatient
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(259, 500);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientState);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DischargePatient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DischargePatient";
            this.Load += new System.EventHandler(this.DischargePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.ComboBox patientState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown priceField;
        private System.Windows.Forms.Label label2;
    }
}