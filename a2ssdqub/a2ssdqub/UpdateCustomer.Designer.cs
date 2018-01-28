namespace a2ssdqub
{
    partial class UpdateCustomer
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
            this.panChoose = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.panForm = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lisCus = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radUndisclosed = new System.Windows.Forms.RadioButton();
            this.radUnknown = new System.Windows.Forms.RadioButton();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panChoose.SuspendLayout();
            this.panForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update A Customer\'s Details";
            // 
            // panChoose
            // 
            this.panChoose.Controls.Add(this.lisCus);
            this.panChoose.Location = new System.Drawing.Point(13, 98);
            this.panChoose.Name = "panChoose";
            this.panChoose.Size = new System.Drawing.Size(324, 243);
            this.panChoose.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(830, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose a customer:";
            // 
            // panForm
            // 
            this.panForm.Controls.Add(this.button2);
            this.panForm.Controls.Add(this.dtpDob);
            this.panForm.Controls.Add(this.radUnknown);
            this.panForm.Controls.Add(this.radUndisclosed);
            this.panForm.Controls.Add(this.radFemale);
            this.panForm.Controls.Add(this.radMale);
            this.panForm.Controls.Add(this.label7);
            this.panForm.Controls.Add(this.txtForename);
            this.panForm.Controls.Add(this.txtCusID);
            this.panForm.Controls.Add(this.label6);
            this.panForm.Controls.Add(this.label5);
            this.panForm.Controls.Add(this.label4);
            this.panForm.Location = new System.Drawing.Point(377, 98);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(441, 243);
            this.panForm.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chosen customer\'s details:";
            // 
            // lisCus
            // 
            this.lisCus.FormattingEnabled = true;
            this.lisCus.Location = new System.Drawing.Point(4, 4);
            this.lisCus.Name = "lisCus";
            this.lisCus.Size = new System.Drawing.Size(317, 225);
            this.lisCus.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Forename";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date of Birth";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(84, 26);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(100, 20);
            this.txtCusID.TabIndex = 3;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(84, 69);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(200, 20);
            this.txtForename.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(84, 140);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 7;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(84, 164);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 8;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radUndisclosed
            // 
            this.radUndisclosed.AutoSize = true;
            this.radUndisclosed.Location = new System.Drawing.Point(84, 188);
            this.radUndisclosed.Name = "radUndisclosed";
            this.radUndisclosed.Size = new System.Drawing.Size(83, 17);
            this.radUndisclosed.TabIndex = 9;
            this.radUndisclosed.TabStop = true;
            this.radUndisclosed.Text = "Undisclosed";
            this.radUndisclosed.UseVisualStyleBackColor = true;
            // 
            // radUnknown
            // 
            this.radUnknown.AutoSize = true;
            this.radUnknown.Location = new System.Drawing.Point(84, 212);
            this.radUnknown.Name = "radUnknown";
            this.radUnknown.Size = new System.Drawing.Size(71, 17);
            this.radUnknown.TabIndex = 10;
            this.radUnknown.TabStop = true;
            this.radUnknown.Text = "Unknown";
            this.radUnknown.UseVisualStyleBackColor = true;
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(84, 105);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 20);
            this.dtpDob.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "UPDATE NOW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panChoose);
            this.Controls.Add(this.label1);
            this.Name = "UpdateCustomer";
            this.Text = "Update A Customer\'s Details";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            this.panChoose.ResumeLayout(false);
            this.panForm.ResumeLayout(false);
            this.panForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panChoose;
        private System.Windows.Forms.ListBox lisCus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panForm;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.RadioButton radUnknown;
        private System.Windows.Forms.RadioButton radUndisclosed;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}