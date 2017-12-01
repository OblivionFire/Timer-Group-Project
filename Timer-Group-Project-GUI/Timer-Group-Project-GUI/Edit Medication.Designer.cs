namespace Timer_Group_Project_GUI
{
	partial class Edit_Medication
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
			this.Exit = new System.Windows.Forms.Button();
			this.currentTimersTitle = new System.Windows.Forms.TextBox();
			this.currentTimers = new System.Windows.Forms.RichTextBox();
			this.editMedicationTitle = new System.Windows.Forms.TextBox();
			this.nameOfMedLable = new System.Windows.Forms.TextBox();
			this.nameOfMedInput = new System.Windows.Forms.TextBox();
			this.nameOfMedLable2 = new System.Windows.Forms.TextBox();
			this.doesOfMedLeble = new System.Windows.Forms.TextBox();
			this.treatTimeLeble = new System.Windows.Forms.TextBox();
			this.medNameOutput = new System.Windows.Forms.TextBox();
			this.medDoesOutput = new System.Windows.Forms.TextBox();
			this.treatTimeOutput = new System.Windows.Forms.TextBox();
			this.saveChanges = new System.Windows.Forms.Button();
			this.searchMed = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Exit
			// 
			this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Exit.Location = new System.Drawing.Point(12, 418);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 23);
			this.Exit.TabIndex = 6;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// currentTimersTitle
			// 
			this.currentTimersTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.currentTimersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentTimersTitle.Location = new System.Drawing.Point(440, 66);
			this.currentTimersTitle.Name = "currentTimersTitle";
			this.currentTimersTitle.Size = new System.Drawing.Size(315, 35);
			this.currentTimersTitle.TabIndex = 8;
			this.currentTimersTitle.Text = "Current Medication";
			this.currentTimersTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// currentTimers
			// 
			this.currentTimers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.currentTimers.Location = new System.Drawing.Point(440, 107);
			this.currentTimers.Name = "currentTimers";
			this.currentTimers.Size = new System.Drawing.Size(315, 347);
			this.currentTimers.TabIndex = 13;
			this.currentTimers.Text = "";
			this.currentTimers.TextChanged += new System.EventHandler(this.currentTimers_TextChanged);
			// 
			// editMedicationTitle
			// 
			this.editMedicationTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editMedicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editMedicationTitle.Location = new System.Drawing.Point(19, -2);
			this.editMedicationTitle.Name = "editMedicationTitle";
			this.editMedicationTitle.Size = new System.Drawing.Size(736, 62);
			this.editMedicationTitle.TabIndex = 7;
			this.editMedicationTitle.Text = "Edit Medication";
			this.editMedicationTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nameOfMedLable
			// 
			this.nameOfMedLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameOfMedLable.Location = new System.Drawing.Point(19, 107);
			this.nameOfMedLable.Name = "nameOfMedLable";
			this.nameOfMedLable.Size = new System.Drawing.Size(191, 24);
			this.nameOfMedLable.TabIndex = 9;
			this.nameOfMedLable.Text = "Name of Medication to Edit";
			this.nameOfMedLable.TextChanged += new System.EventHandler(this.nameOfMedLable_TextChanged);
			// 
			// nameOfMedInput
			// 
			this.nameOfMedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameOfMedInput.Location = new System.Drawing.Point(234, 107);
			this.nameOfMedInput.Name = "nameOfMedInput";
			this.nameOfMedInput.Size = new System.Drawing.Size(176, 24);
			this.nameOfMedInput.TabIndex = 0;
			this.nameOfMedInput.TextChanged += new System.EventHandler(this.nameOfMedInput_TextChanged);
			// 
			// nameOfMedLable2
			// 
			this.nameOfMedLable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameOfMedLable2.Location = new System.Drawing.Point(28, 190);
			this.nameOfMedLable2.Name = "nameOfMedLable2";
			this.nameOfMedLable2.Size = new System.Drawing.Size(113, 22);
			this.nameOfMedLable2.TabIndex = 10;
			this.nameOfMedLable2.Text = "Medication Name";
			this.nameOfMedLable2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// doesOfMedLeble
			// 
			this.doesOfMedLeble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.doesOfMedLeble.Location = new System.Drawing.Point(164, 189);
			this.doesOfMedLeble.Name = "doesOfMedLeble";
			this.doesOfMedLeble.Size = new System.Drawing.Size(110, 22);
			this.doesOfMedLeble.TabIndex = 11;
			this.doesOfMedLeble.Text = "Medication Does";
			this.doesOfMedLeble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// treatTimeLeble
			// 
			this.treatTimeLeble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treatTimeLeble.Location = new System.Drawing.Point(293, 189);
			this.treatTimeLeble.Name = "treatTimeLeble";
			this.treatTimeLeble.Size = new System.Drawing.Size(100, 22);
			this.treatTimeLeble.TabIndex = 12;
			this.treatTimeLeble.Text = "Treatment Time";
			this.treatTimeLeble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// medNameOutput
			// 
			this.medNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medNameOutput.Location = new System.Drawing.Point(28, 238);
			this.medNameOutput.Name = "medNameOutput";
			this.medNameOutput.Size = new System.Drawing.Size(113, 21);
			this.medNameOutput.TabIndex = 2;
			this.medNameOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// medDoesOutput
			// 
			this.medDoesOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medDoesOutput.Location = new System.Drawing.Point(164, 237);
			this.medDoesOutput.Name = "medDoesOutput";
			this.medDoesOutput.Size = new System.Drawing.Size(110, 21);
			this.medDoesOutput.TabIndex = 3;
			this.medDoesOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// treatTimeOutput
			// 
			this.treatTimeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treatTimeOutput.Location = new System.Drawing.Point(293, 237);
			this.treatTimeOutput.Name = "treatTimeOutput";
			this.treatTimeOutput.Size = new System.Drawing.Size(100, 21);
			this.treatTimeOutput.TabIndex = 4;
			this.treatTimeOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// saveChanges
			// 
			this.saveChanges.Location = new System.Drawing.Point(164, 306);
			this.saveChanges.Name = "saveChanges";
			this.saveChanges.Size = new System.Drawing.Size(110, 23);
			this.saveChanges.TabIndex = 5;
			this.saveChanges.Text = "Save Changes";
			this.saveChanges.UseVisualStyleBackColor = true;
			this.saveChanges.Click += new System.EventHandler(this.button1_Click);
			// 
			// searchMed
			// 
			this.searchMed.Location = new System.Drawing.Point(183, 137);
			this.searchMed.Name = "searchMed";
			this.searchMed.Size = new System.Drawing.Size(75, 23);
			this.searchMed.TabIndex = 1;
			this.searchMed.Text = "Search";
			this.searchMed.UseVisualStyleBackColor = true;
			this.searchMed.Click += new System.EventHandler(this.searchMed_Click);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(183, 359);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(75, 23);
			this.clear.TabIndex = 14;
			this.clear.Text = "Clear";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// Edit_Medication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 453);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.searchMed);
			this.Controls.Add(this.saveChanges);
			this.Controls.Add(this.treatTimeOutput);
			this.Controls.Add(this.medDoesOutput);
			this.Controls.Add(this.medNameOutput);
			this.Controls.Add(this.treatTimeLeble);
			this.Controls.Add(this.doesOfMedLeble);
			this.Controls.Add(this.nameOfMedLable2);
			this.Controls.Add(this.nameOfMedInput);
			this.Controls.Add(this.nameOfMedLable);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.currentTimersTitle);
			this.Controls.Add(this.currentTimers);
			this.Controls.Add(this.editMedicationTitle);
			this.Name = "Edit_Medication";
			this.Text = "Edit_Medication";
			this.Load += new System.EventHandler(this.Edit_Medication_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TextBox currentTimersTitle;
		private System.Windows.Forms.RichTextBox currentTimers;
		private System.Windows.Forms.TextBox editMedicationTitle;
		private System.Windows.Forms.TextBox nameOfMedLable;
		private System.Windows.Forms.TextBox nameOfMedInput;
		private System.Windows.Forms.TextBox nameOfMedLable2;
		private System.Windows.Forms.TextBox doesOfMedLeble;
		private System.Windows.Forms.TextBox treatTimeLeble;
		private System.Windows.Forms.TextBox medNameOutput;
		private System.Windows.Forms.TextBox medDoesOutput;
		private System.Windows.Forms.TextBox treatTimeOutput;
		private System.Windows.Forms.Button saveChanges;
		private System.Windows.Forms.Button searchMed;
		private System.Windows.Forms.Button clear;
	}
}