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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.eventNameInput = new System.Windows.Forms.TextBox();
            this.eventTimeInput = new System.Windows.Forms.TextBox();
            this.eventTimeLable = new System.Windows.Forms.TextBox();
            this.eventNameLeble = new System.Windows.Forms.TextBox();
            this.addEvent = new System.Windows.Forms.Button();
            this.linkedMedInput = new System.Windows.Forms.TextBox();
            this.linkedMedLable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currentMedsTitle
            // 
            this.currentMedsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMedsTitle.Location = new System.Drawing.Point(912, 538);
            this.currentMedsTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.currentMedsTitle.Name = "currentMedsTitle";
            this.currentMedsTitle.Size = new System.Drawing.Size(510, 62);
            this.currentMedsTitle.TabIndex = 12;
            this.currentMedsTitle.Text = "Current Medications";
            this.currentMedsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentTimers
            // 
            this.currentTimers.Location = new System.Drawing.Point(912, 617);
            this.currentTimers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.currentTimers.Name = "currentTimers";
            this.currentTimers.Size = new System.Drawing.Size(510, 169);
            this.currentTimers.TabIndex = 13;
            this.currentTimers.Text = "";
            // 
            // addEventTitle
            // 
            this.addEventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventTitle.Location = new System.Drawing.Point(24, 27);
            this.addEventTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addEventTitle.Name = "addEventTitle";
            this.addEventTitle.Size = new System.Drawing.Size(1398, 116);
            this.addEventTitle.TabIndex = 11;
            this.addEventTitle.Text = "Add Events";
            this.addEventTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentEventsTitle
            // 
            this.currentEventsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentEventsTitle.Location = new System.Drawing.Point(912, 156);
            this.currentEventsTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.currentEventsTitle.Name = "currentEventsTitle";
            this.currentEventsTitle.Size = new System.Drawing.Size(510, 62);
            this.currentEventsTitle.TabIndex = 14;
            this.currentEventsTitle.Text = "Current Events";
            this.currentEventsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(912, 235);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(510, 289);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exit.Location = new System.Drawing.Point(24, 746);
            this.Exit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 44);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // eventNameInput
            // 
            this.eventNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eventNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameInput.Location = new System.Drawing.Point(474, 235);
            this.eventNameInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventNameInput.Name = "eventNameInput";
            this.eventNameInput.Size = new System.Drawing.Size(272, 44);
            this.eventNameInput.TabIndex = 17;
            this.eventNameInput.TextChanged += new System.EventHandler(this.eventNameInput_TextChanged);
            // 
            // eventTimeInput
            // 
            this.eventTimeInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eventTimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTimeInput.Location = new System.Drawing.Point(474, 319);
            this.eventTimeInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventTimeInput.Name = "eventTimeInput";
            this.eventTimeInput.Size = new System.Drawing.Size(272, 44);
            this.eventTimeInput.TabIndex = 18;
            // 
            // eventTimeLable
            // 
            this.eventTimeLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eventTimeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTimeLable.Location = new System.Drawing.Point(116, 319);
            this.eventTimeLable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventTimeLable.Name = "eventTimeLable";
            this.eventTimeLable.Size = new System.Drawing.Size(314, 44);
            this.eventTimeLable.TabIndex = 20;
            this.eventTimeLable.Text = "Event Time";
            // 
            // eventNameLeble
            // 
            this.eventNameLeble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eventNameLeble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLeble.Location = new System.Drawing.Point(116, 235);
            this.eventNameLeble.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventNameLeble.Name = "eventNameLeble";
            this.eventNameLeble.Size = new System.Drawing.Size(314, 44);
            this.eventNameLeble.TabIndex = 19;
            this.eventNameLeble.Text = "Event Name";
            // 
            // addEvent
            // 
            this.addEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent.Location = new System.Drawing.Point(348, 512);
            this.addEvent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(254, 62);
            this.addEvent.TabIndex = 22;
            this.addEvent.Text = "Add Event";
            // 
            // linkedMedInput
            // 
            this.linkedMedInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkedMedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedMedInput.Location = new System.Drawing.Point(474, 413);
            this.linkedMedInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.linkedMedInput.Name = "linkedMedInput";
            this.linkedMedInput.Size = new System.Drawing.Size(272, 44);
            this.linkedMedInput.TabIndex = 21;
            // 
            // linkedMedLable
            // 
            this.linkedMedLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkedMedLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedMedLable.Location = new System.Drawing.Point(116, 413);
            this.linkedMedLable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.linkedMedLable.Name = "linkedMedLable";
            this.linkedMedLable.Size = new System.Drawing.Size(314, 44);
            this.linkedMedLable.TabIndex = 23;
            this.linkedMedLable.Text = "Linked Medication";
            // 
            // Add_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 810);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.linkedMedInput);
            this.Controls.Add(this.linkedMedLable);
            this.Controls.Add(this.eventNameInput);
            this.Controls.Add(this.eventTimeInput);
            this.Controls.Add(this.eventTimeLable);
            this.Controls.Add(this.eventNameLeble);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.currentEventsTitle);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.currentMedsTitle);
            this.Controls.Add(this.currentTimers);
            this.Controls.Add(this.addEventTitle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Add_Event";
            this.Text = "Add_Event";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox currentMedsTitle;
		private System.Windows.Forms.RichTextBox currentTimers;
		private System.Windows.Forms.TextBox addEventTitle;
		private System.Windows.Forms.TextBox currentEventsTitle;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TextBox eventNameInput;
		private System.Windows.Forms.TextBox eventTimeInput;
		private System.Windows.Forms.TextBox eventTimeLable;
		private System.Windows.Forms.TextBox eventNameLeble;
		private System.Windows.Forms.Button addEvent;
		private System.Windows.Forms.TextBox linkedMedInput;
		private System.Windows.Forms.TextBox linkedMedLable;
	}
}