
namespace WindowsFormsApp1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtNumKids = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstRelation = new System.Windows.Forms.ListBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.radioYesOnce = new System.Windows.Forms.RadioButton();
            this.radioYesMore = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(136, 99);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(159, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtNumKids
            // 
            this.txtNumKids.Location = new System.Drawing.Point(136, 153);
            this.txtNumKids.Name = "txtNumKids";
            this.txtNumKids.Size = new System.Drawing.Size(159, 20);
            this.txtNumKids.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of children";
            // 
            // lstRelation
            // 
            this.lstRelation.FormattingEnabled = true;
            this.lstRelation.Items.AddRange(new object[] {
            "Father",
            "Intimate Partner",
            "Relative",
            "Neighbour",
            "Collegue",
            "Aquintance",
            "Stranger"});
            this.lstRelation.Location = new System.Drawing.Point(545, 39);
            this.lstRelation.Name = "lstRelation";
            this.lstRelation.Size = new System.Drawing.Size(221, 134);
            this.lstRelation.TabIndex = 6;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(48, 234);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(713, 108);
            this.lstOutput.TabIndex = 7;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(48, 372);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(130, 46);
            this.btnCapture.TabIndex = 8;
            this.btnCapture.Text = "Capture GBV victim";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(276, 372);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(162, 46);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate Staying Costs";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Location = new System.Drawing.Point(535, 372);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(226, 46);
            this.btnNewRecord.TabIndex = 10;
            this.btnNewRecord.Text = "New Record";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioYesMore);
            this.groupBox1.Controls.Add(this.radioYesOnce);
            this.groupBox1.Controls.Add(this.radioNo);
            this.groupBox1.Location = new System.Drawing.Point(342, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 136);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Has the victim visited before";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Primary Relationship with Perpetrator";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(20, 41);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(130, 17);
            this.radioNo.TabIndex = 0;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No, this is the first time";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // radioYesOnce
            // 
            this.radioYesOnce.AutoSize = true;
            this.radioYesOnce.Location = new System.Drawing.Point(20, 79);
            this.radioYesOnce.Name = "radioYesOnce";
            this.radioYesOnce.Size = new System.Drawing.Size(106, 17);
            this.radioYesOnce.TabIndex = 1;
            this.radioYesOnce.TabStop = true;
            this.radioYesOnce.Text = "Yes, once before";
            this.radioYesOnce.UseVisualStyleBackColor = true;
            // 
            // radioYesMore
            // 
            this.radioYesMore.AutoSize = true;
            this.radioYesMore.Location = new System.Drawing.Point(20, 113);
            this.radioYesMore.Name = "radioYesMore";
            this.radioYesMore.Size = new System.Drawing.Size(123, 17);
            this.radioYesMore.TabIndex = 2;
            this.radioYesMore.TabStop = true;
            this.radioYesMore.Text = "Yes, more than once";
            this.radioYesMore.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewRecord);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lstRelation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumKids);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Abafazi Wethu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtNumKids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstRelation;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioYesMore;
        private System.Windows.Forms.RadioButton radioYesOnce;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.Label label4;
    }
}

