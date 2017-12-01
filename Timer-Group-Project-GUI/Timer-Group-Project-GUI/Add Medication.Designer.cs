namespace Timer_Group_Project_GUI
{
	partial class Add_Medication
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
			this.addMedicationTitle = new System.Windows.Forms.TextBox();
			this.currentTimers = new System.Windows.Forms.RichTextBox();
			this.currentTimersTitle = new System.Windows.Forms.TextBox();
			this.medicationNameLeble = new System.Windows.Forms.TextBox();
			this.medicationDoesLeble = new System.Windows.Forms.TextBox();
			this.treatmentTimeLeble = new System.Windows.Forms.TextBox();
			this.treatTimeInput = new System.Windows.Forms.TextBox();
			this.medDoesInput = new System.Windows.Forms.TextBox();
			this.medNameInput = new System.Windows.Forms.TextBox();
			this.Exit = new System.Windows.Forms.Button();
			this.addMed = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// addMedicationTitle
			// 
			this.addMedicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addMedicationTitle.Location = new System.Drawing.Point(12, 12);
			this.addMedicationTitle.Name = "addMedicationTitle";
			this.addMedicationTitle.Size = new System.Drawing.Size(701, 62);
			this.addMedicationTitle.TabIndex = 5;
			this.addMedicationTitle.Text = "Add Medication";
			this.addMedicationTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.addMedicationTitle.TextChanged += new System.EventHandler(this.addMedicationTitle_TextChanged);
			// 
			// currentTimers
			// 
			this.currentTimers.Location = new System.Drawing.Point(456, 120);
			this.currentTimers.Name = "currentTimers";
			this.currentTimers.Size = new System.Drawing.Size(257, 289);
			this.currentTimers.TabIndex = 10;
			this.currentTimers.Text = "";
			// 
			// currentTimersTitle
			// 
			this.currentTimersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentTimersTitle.Location = new System.Drawing.Point(456, 79);
			this.currentTimersTitle.Name = "currentTimersTitle";
			this.currentTimersTitle.Size = new System.Drawing.Size(257, 35);
			this.currentTimersTitle.TabIndex = 6;
			this.currentTimersTitle.Text = "Current Medications";
			this.currentTimersTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// medicationNameLeble
			// 
			this.medicationNameLeble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.medicationNameLeble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medicationNameLeble.Location = new System.Drawing.Point(62, 120);
			this.medicationNameLeble.Name = "medicationNameLeble";
			this.medicationNameLeble.Size = new System.Drawing.Size(159, 26);
			this.medicationNameLeble.TabIndex = 7;
			this.medicationNameLeble.Text = "Medication Name";
			// 
			// medicationDoesLeble
			// 
			this.medicationDoesLeble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.medicationDoesLeble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medicationDoesLeble.Location = new System.Drawing.Point(62, 164);
			this.medicationDoesLeble.Name = "medicationDoesLeble";
			this.medicationDoesLeble.Size = new System.Drawing.Size(159, 26);
			this.medicationDoesLeble.TabIndex = 8;
			this.medicationDoesLeble.Text = "Medication Does";
			// 
			// treatmentTimeLeble
			// 
			this.treatmentTimeLeble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.treatmentTimeLeble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treatmentTimeLeble.Location = new System.Drawing.Point(62, 209);
			this.treatmentTimeLeble.Name = "treatmentTimeLeble";
			this.treatmentTimeLeble.Size = new System.Drawing.Size(159, 26);
			this.treatmentTimeLeble.TabIndex = 9;
			this.treatmentTimeLeble.Text = "Treatment Time(Min.) ";
			this.treatmentTimeLeble.TextChanged += new System.EventHandler(this.treatmentTimeLeble_TextChanged);
			// 
			// treatTimeInput
			// 
			this.treatTimeInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.treatTimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treatTimeInput.Location = new System.Drawing.Point(241, 209);
			this.treatTimeInput.Name = "treatTimeInput";
			this.treatTimeInput.Size = new System.Drawing.Size(138, 26);
			this.treatTimeInput.TabIndex = 2;
			// 
			// medDoesInput
			// 
			this.medDoesInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.medDoesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medDoesInput.Location = new System.Drawing.Point(241, 164);
			this.medDoesInput.Name = "medDoesInput";
			this.medDoesInput.Size = new System.Drawing.Size(138, 26);
			this.medDoesInput.TabIndex = 1;
			// 
			// medNameInput
			// 
			this.medNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.medNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medNameInput.Location = new System.Drawing.Point(241, 120);
			this.medNameInput.Name = "medNameInput";
			this.medNameInput.Size = new System.Drawing.Size(138, 26);
			this.medNameInput.TabIndex = 0;
			// 
			// Exit
			// 
			this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Exit.Location = new System.Drawing.Point(12, 386);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 23);
			this.Exit.TabIndex = 4;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// addMed
			// 
			this.addMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addMed.Location = new System.Drawing.Point(178, 260);
			this.addMed.Name = "addMed";
			this.addMed.Size = new System.Drawing.Size(127, 32);
			this.addMed.TabIndex = 3;
			this.addMed.Text = "Add Medication";
			this.addMed.Click += new System.EventHandler(this.addMed_Click);
			// 
			// Add_Medication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 421);
			this.Controls.Add(this.addMed);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.medNameInput);
			this.Controls.Add(this.medDoesInput);
			this.Controls.Add(this.treatTimeInput);
			this.Controls.Add(this.treatmentTimeLeble);
			this.Controls.Add(this.medicationDoesLeble);
			this.Controls.Add(this.medicationNameLeble);
			this.Controls.Add(this.currentTimersTitle);
			this.Controls.Add(this.currentTimers);
			this.Controls.Add(this.addMedicationTitle);
			this.Name = "Add_Medication";
			this.Text = "Add_Medication";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox addMedicationTitle;
		private System.Windows.Forms.RichTextBox currentTimers;
		private System.Windows.Forms.TextBox currentTimersTitle;
		private System.Windows.Forms.TextBox medicationNameLeble;
		private System.Windows.Forms.TextBox medicationDoesLeble;
		private System.Windows.Forms.TextBox treatmentTimeLeble;
		private System.Windows.Forms.TextBox treatTimeInput;
		private System.Windows.Forms.TextBox medDoesInput;
		private System.Windows.Forms.TextBox medNameInput;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Button addMed;
	}
}