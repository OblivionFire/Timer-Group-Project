namespace Timer_Group_Project_GUI
{
	partial class Remove_Medication
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
			this.currentTimersTitle = new System.Windows.Forms.TextBox();
			this.currentTimers = new System.Windows.Forms.RichTextBox();
			this.removeMedicationTitle = new System.Windows.Forms.TextBox();
			this.searchMed = new System.Windows.Forms.Button();
			this.nameOfMedInput = new System.Windows.Forms.TextBox();
			this.nameOfMedLable = new System.Windows.Forms.TextBox();
			this.Exit = new System.Windows.Forms.Button();
			this.treatTimeOutput = new System.Windows.Forms.TextBox();
			this.medDoesOutput = new System.Windows.Forms.TextBox();
			this.medNameOutput = new System.Windows.Forms.TextBox();
			this.treatTimeLeble = new System.Windows.Forms.TextBox();
			this.doesOfMedLeble = new System.Windows.Forms.TextBox();
			this.nameOfMedLable2 = new System.Windows.Forms.TextBox();
			this.remove = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// currentTimersTitle
			// 
			this.currentTimersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentTimersTitle.Location = new System.Drawing.Point(456, 79);
			this.currentTimersTitle.Name = "currentTimersTitle";
			this.currentTimersTitle.Size = new System.Drawing.Size(257, 35);
			this.currentTimersTitle.TabIndex = 12;
			this.currentTimersTitle.Text = "Current Timers";
			this.currentTimersTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// currentTimers
			// 
			this.currentTimers.Location = new System.Drawing.Point(456, 120);
			this.currentTimers.Name = "currentTimers";
			this.currentTimers.Size = new System.Drawing.Size(257, 289);
			this.currentTimers.TabIndex = 13;
			this.currentTimers.Text = "";
			// 
			// removeMedicationTitle
			// 
			this.removeMedicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeMedicationTitle.Location = new System.Drawing.Point(12, 12);
			this.removeMedicationTitle.Name = "removeMedicationTitle";
			this.removeMedicationTitle.Size = new System.Drawing.Size(701, 62);
			this.removeMedicationTitle.TabIndex = 11;
			this.removeMedicationTitle.Text = "Remove Medication";
			this.removeMedicationTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// searchMed
			// 
			this.searchMed.Location = new System.Drawing.Point(206, 150);
			this.searchMed.Name = "searchMed";
			this.searchMed.Size = new System.Drawing.Size(75, 23);
			this.searchMed.TabIndex = 1;
			this.searchMed.Text = "Search";
			this.searchMed.UseVisualStyleBackColor = true;
			this.searchMed.Click += new System.EventHandler(this.searchMed_Click);
			// 
			// nameOfMedInput
			// 
			this.nameOfMedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameOfMedInput.Location = new System.Drawing.Point(253, 120);
			this.nameOfMedInput.Name = "nameOfMedInput";
			this.nameOfMedInput.Size = new System.Drawing.Size(176, 24);
			this.nameOfMedInput.TabIndex = 0;
			// 
			// nameOfMedLable
			// 
			this.nameOfMedLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameOfMedLable.Location = new System.Drawing.Point(12, 120);
			this.nameOfMedLable.Name = "nameOfMedLable";
			this.nameOfMedLable.Size = new System.Drawing.Size(225, 24);
			this.nameOfMedLable.TabIndex = 16;
			this.nameOfMedLable.Text = "Name of Medication to Remove";
			// 
			// Exit
			// 
			this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Exit.Location = new System.Drawing.Point(12, 386);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 23);
			this.Exit.TabIndex = 3;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// treatTimeOutput
			// 
			this.treatTimeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treatTimeOutput.Location = new System.Drawing.Point(318, 243);
			this.treatTimeOutput.Name = "treatTimeOutput";
			this.treatTimeOutput.Size = new System.Drawing.Size(100, 21);
			this.treatTimeOutput.TabIndex = 1;
			this.treatTimeOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// medDoesOutput
			// 
			this.medDoesOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medDoesOutput.Location = new System.Drawing.Point(189, 243);
			this.medDoesOutput.Name = "medDoesOutput";
			this.medDoesOutput.Size = new System.Drawing.Size(110, 21);
			this.medDoesOutput.TabIndex = 0;
			this.medDoesOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// medNameOutput
			// 
			this.medNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medNameOutput.Location = new System.Drawing.Point(53, 244);
			this.medNameOutput.Name = "medNameOutput";
			this.medNameOutput.Size = new System.Drawing.Size(113, 21);
			this.medNameOutput.TabIndex = 2;
			this.medNameOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// treatTimeLeble
			// 
			this.treatTimeLeble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treatTimeLeble.Location = new System.Drawing.Point(318, 195);
			this.treatTimeLeble.Name = "treatTimeLeble";
			this.treatTimeLeble.Size = new System.Drawing.Size(100, 22);
			this.treatTimeLeble.TabIndex = 23;
			this.treatTimeLeble.Text = "Treatment Time";
			this.treatTimeLeble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// doesOfMedLeble
			// 
			this.doesOfMedLeble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.doesOfMedLeble.Location = new System.Drawing.Point(189, 195);
			this.doesOfMedLeble.Name = "doesOfMedLeble";
			this.doesOfMedLeble.Size = new System.Drawing.Size(110, 22);
			this.doesOfMedLeble.TabIndex = 22;
			this.doesOfMedLeble.Text = "Medication Does";
			this.doesOfMedLeble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nameOfMedLable2
			// 
			this.nameOfMedLable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameOfMedLable2.Location = new System.Drawing.Point(53, 196);
			this.nameOfMedLable2.Name = "nameOfMedLable2";
			this.nameOfMedLable2.Size = new System.Drawing.Size(113, 22);
			this.nameOfMedLable2.TabIndex = 21;
			this.nameOfMedLable2.Text = "Medication Name";
			this.nameOfMedLable2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// remove
			// 
			this.remove.Location = new System.Drawing.Point(206, 300);
			this.remove.Name = "remove";
			this.remove.Size = new System.Drawing.Size(75, 23);
			this.remove.TabIndex = 2;
			this.remove.Text = "Remove";
			this.remove.UseVisualStyleBackColor = true;
			this.remove.Click += new System.EventHandler(this.remove_Click);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(206, 329);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(75, 23);
			this.clear.TabIndex = 2;
			this.clear.Text = "Clear";
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// Remove_Medication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 421);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.remove);
			this.Controls.Add(this.treatTimeOutput);
			this.Controls.Add(this.medDoesOutput);
			this.Controls.Add(this.medNameOutput);
			this.Controls.Add(this.treatTimeLeble);
			this.Controls.Add(this.doesOfMedLeble);
			this.Controls.Add(this.nameOfMedLable2);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.searchMed);
			this.Controls.Add(this.nameOfMedInput);
			this.Controls.Add(this.nameOfMedLable);
			this.Controls.Add(this.currentTimersTitle);
			this.Controls.Add(this.currentTimers);
			this.Controls.Add(this.removeMedicationTitle);
			this.Name = "Remove_Medication";
			this.Text = "Remove_Medication";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox currentTimersTitle;
		private System.Windows.Forms.RichTextBox currentTimers;
		private System.Windows.Forms.TextBox removeMedicationTitle;
		private System.Windows.Forms.Button searchMed;
		private System.Windows.Forms.TextBox nameOfMedInput;
		private System.Windows.Forms.TextBox nameOfMedLable;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TextBox treatTimeOutput;
		private System.Windows.Forms.TextBox medDoesOutput;
		private System.Windows.Forms.TextBox medNameOutput;
		private System.Windows.Forms.TextBox treatTimeLeble;
		private System.Windows.Forms.TextBox doesOfMedLeble;
		private System.Windows.Forms.TextBox nameOfMedLable2;
		private System.Windows.Forms.Button remove;
		private System.Windows.Forms.Button clear;
	}
}