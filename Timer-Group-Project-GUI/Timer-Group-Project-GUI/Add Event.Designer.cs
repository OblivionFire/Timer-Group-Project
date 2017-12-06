namespace Timer_Group_Project_GUI
{
	partial class Add_Event
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
			this.currentMedsTitle = new System.Windows.Forms.TextBox();
			this.currentTimers = new System.Windows.Forms.RichTextBox();
			this.addEventTitle = new System.Windows.Forms.TextBox();
			this.currentEventsTitle = new System.Windows.Forms.TextBox();
			this.currentEvents = new System.Windows.Forms.RichTextBox();
			this.Exit = new System.Windows.Forms.Button();
			this.eventNameInput = new System.Windows.Forms.TextBox();
			this.eventTimeLable = new System.Windows.Forms.TextBox();
			this.eventNameLable = new System.Windows.Forms.TextBox();
			this.addEvent = new System.Windows.Forms.Button();
			this.linkedMedInput = new System.Windows.Forms.TextBox();
			this.linkedMedLable = new System.Windows.Forms.TextBox();
			this.eventTimeInput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// currentMedsTitle
			// 
			this.currentMedsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentMedsTitle.Location = new System.Drawing.Point(456, 280);
			this.currentMedsTitle.Name = "currentMedsTitle";
			this.currentMedsTitle.Size = new System.Drawing.Size(257, 35);
			this.currentMedsTitle.TabIndex = 12;
			this.currentMedsTitle.Text = "Current Medications";
			this.currentMedsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// currentTimers
			// 
			this.currentTimers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.currentTimers.Location = new System.Drawing.Point(455, 327);
			this.currentTimers.Name = "currentTimers";
			this.currentTimers.Size = new System.Drawing.Size(260, 113);
			this.currentTimers.TabIndex = 13;
			this.currentTimers.Text = "";
			// 
			// addEventTitle
			// 
			this.addEventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addEventTitle.Location = new System.Drawing.Point(12, 14);
			this.addEventTitle.Name = "addEventTitle";
			this.addEventTitle.Size = new System.Drawing.Size(701, 62);
			this.addEventTitle.TabIndex = 11;
			this.addEventTitle.Text = "Add Events";
			this.addEventTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// currentEventsTitle
			// 
			this.currentEventsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentEventsTitle.Location = new System.Drawing.Point(456, 81);
			this.currentEventsTitle.Name = "currentEventsTitle";
			this.currentEventsTitle.Size = new System.Drawing.Size(257, 35);
			this.currentEventsTitle.TabIndex = 14;
			this.currentEventsTitle.Text = "Current Events";
			this.currentEventsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// currentEvents
			// 
			this.currentEvents.Location = new System.Drawing.Point(456, 122);
			this.currentEvents.Name = "currentEvents";
			this.currentEvents.Size = new System.Drawing.Size(257, 152);
			this.currentEvents.TabIndex = 15;
			this.currentEvents.Text = "";
			// 
			// Exit
			// 
			this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Exit.Location = new System.Drawing.Point(12, 419);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 23);
			this.Exit.TabIndex = 4;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// eventNameInput
			// 
			this.eventNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.eventNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eventNameInput.Location = new System.Drawing.Point(237, 153);
			this.eventNameInput.Name = "eventNameInput";
			this.eventNameInput.Size = new System.Drawing.Size(138, 26);
			this.eventNameInput.TabIndex = 0;
			// 
			// eventTimeLable
			// 
			this.eventTimeLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.eventTimeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eventTimeLable.Location = new System.Drawing.Point(12, 197);
			this.eventTimeLable.Name = "eventTimeLable";
			this.eventTimeLable.Size = new System.Drawing.Size(276, 20);
			this.eventTimeLable.TabIndex = 20;
			this.eventTimeLable.Text = "Event Time: Format - (MM/DD/YYYY  HH:MM:SS AM/PM)";
			// 
			// eventNameLable
			// 
			this.eventNameLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.eventNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eventNameLable.Location = new System.Drawing.Point(58, 153);
			this.eventNameLable.Name = "eventNameLable";
			this.eventNameLable.Size = new System.Drawing.Size(159, 26);
			this.eventNameLable.TabIndex = 19;
			this.eventNameLable.Text = "Event Name";
			// 
			// addEvent
			// 
			this.addEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addEvent.Location = new System.Drawing.Point(174, 297);
			this.addEvent.Name = "addEvent";
			this.addEvent.Size = new System.Drawing.Size(127, 32);
			this.addEvent.TabIndex = 3;
			this.addEvent.Text = "Add Event";
			this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
			// 
			// linkedMedInput
			// 
			this.linkedMedInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkedMedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkedMedInput.Location = new System.Drawing.Point(237, 246);
			this.linkedMedInput.Name = "linkedMedInput";
			this.linkedMedInput.Size = new System.Drawing.Size(138, 26);
			this.linkedMedInput.TabIndex = 2;
			// 
			// linkedMedLable
			// 
			this.linkedMedLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkedMedLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkedMedLable.Location = new System.Drawing.Point(58, 246);
			this.linkedMedLable.Name = "linkedMedLable";
			this.linkedMedLable.Size = new System.Drawing.Size(159, 26);
			this.linkedMedLable.TabIndex = 23;
			this.linkedMedLable.Text = "Linked Medication";
			// 
			// eventTimeInput
			// 
			this.eventTimeInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.eventTimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eventTimeInput.Location = new System.Drawing.Point(298, 197);
			this.eventTimeInput.Name = "eventTimeInput";
			this.eventTimeInput.Size = new System.Drawing.Size(138, 26);
			this.eventTimeInput.TabIndex = 24;
			// 
			// Add_Event
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 452);
			this.Controls.Add(this.eventTimeInput);
			this.Controls.Add(this.addEvent);
			this.Controls.Add(this.linkedMedInput);
			this.Controls.Add(this.linkedMedLable);
			this.Controls.Add(this.eventNameInput);
			this.Controls.Add(this.eventTimeLable);
			this.Controls.Add(this.eventNameLable);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.currentEventsTitle);
			this.Controls.Add(this.currentEvents);
			this.Controls.Add(this.currentMedsTitle);
			this.Controls.Add(this.currentTimers);
			this.Controls.Add(this.addEventTitle);
			this.Name = "Add_Event";
			this.Text = "Add_Event";
			this.Load += new System.EventHandler(this.Add_Event_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox currentMedsTitle;
		private System.Windows.Forms.RichTextBox currentTimers;
		private System.Windows.Forms.TextBox addEventTitle;
		private System.Windows.Forms.TextBox currentEventsTitle;
		private System.Windows.Forms.RichTextBox currentEvents;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TextBox eventNameInput;
		private System.Windows.Forms.TextBox eventTimeLable;
		private System.Windows.Forms.TextBox eventNameLable;
		private System.Windows.Forms.Button addEvent;
		private System.Windows.Forms.TextBox linkedMedInput;
		private System.Windows.Forms.TextBox linkedMedLable;
        private System.Windows.Forms.TextBox eventTimeInput;
	}
}