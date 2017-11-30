namespace EventsPage
{

    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.editTabs = new System.Windows.Forms.TabControl();
            this.addEvent = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.eventList = new System.Windows.Forms.ListBox();
            this.editTabs.SuspendLayout();
            this.addEvent.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(180, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(833, 150);
            this.label1.TabIndex = 0;
            this.label1.Text = "Events Page";
            // 
            // editTabs
            // 
            this.editTabs.Controls.Add(this.addEvent);
            this.editTabs.Controls.Add(this.tabPage2);
            this.editTabs.Location = new System.Drawing.Point(50, 753);
            this.editTabs.Name = "editTabs";
            this.editTabs.SelectedIndex = 0;
            this.editTabs.Size = new System.Drawing.Size(656, 153);
            this.editTabs.TabIndex = 3;
            // 
            // addEvent
            // 
            this.addEvent.Controls.Add(this.button1);
            this.addEvent.Controls.Add(this.label2);
            this.addEvent.Controls.Add(this.textBox1);
            this.addEvent.Location = new System.Drawing.Point(8, 39);
            this.addEvent.Name = "addEvent";
            this.addEvent.Padding = new System.Windows.Forms.Padding(3);
            this.addEvent.Size = new System.Drawing.Size(640, 106);
            this.addEvent.TabIndex = 0;
            this.addEvent.Text = "Add Event";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event (name,start,end)";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EventsPage.Properties.Settings.Default, "savetextboxtext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(34, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = global::EventsPage.Properties.Settings.Default.savetextboxtext;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.eventList);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 106);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Event";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // eventList
            // 
            this.eventList.FormattingEnabled = true;
            this.eventList.ItemHeight = 25;
            this.eventList.Items.AddRange(new object[] {
            "event one",
            "event two",
            "event three"});
            this.eventList.Location = new System.Drawing.Point(19, 6);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(120, 79);
            this.eventList.TabIndex = 0;
            this.eventList.Tag = "";
            this.eventList.SelectedIndexChanged += new System.EventHandler(this.eventList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1186, 918);
            this.Controls.Add(this.editTabs);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.editTabs.ResumeLayout(false);
            this.addEvent.ResumeLayout(false);
            this.addEvent.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl editTabs;
        private System.Windows.Forms.TabPage addEvent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox eventList;
        private System.Windows.Forms.Button button1;
    }
}

