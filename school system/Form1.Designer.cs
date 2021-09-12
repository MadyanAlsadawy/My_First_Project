namespace school_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnADD = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.typeEmployee = new System.Windows.Forms.ComboBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labelsalary = new System.Windows.Forms.Label();
            this.labeltypeemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelcountemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelsumesal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Blue;
            this.btnADD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Location = new System.Drawing.Point(579, 280);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(124, 61);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "Add";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(288, 98);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(272, 30);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(288, 44);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(272, 30);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(288, 219);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(272, 30);
            this.textBoxSalary.TabIndex = 3;
            // 
            // typeEmployee
            // 
            this.typeEmployee.FormattingEnabled = true;
            this.typeEmployee.Location = new System.Drawing.Point(288, 163);
            this.typeEmployee.Name = "typeEmployee";
            this.typeEmployee.Size = new System.Drawing.Size(272, 31);
            this.typeEmployee.TabIndex = 4;
            this.typeEmployee.SelectedIndexChanged += new System.EventHandler(this.typeemployee_SelectedIndexChanged);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelname.Location = new System.Drawing.Point(74, 101);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(208, 23);
            this.labelname.TabIndex = 5;
            this.labelname.Text = "Employee full Name:";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelid.Location = new System.Drawing.Point(131, 47);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(151, 23);
            this.labelid.TabIndex = 6;
            this.labelid.Text = " Employee ID :";
            // 
            // labelsalary
            // 
            this.labelsalary.AutoSize = true;
            this.labelsalary.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelsalary.Location = new System.Drawing.Point(107, 222);
            this.labelsalary.Name = "labelsalary";
            this.labelsalary.Size = new System.Drawing.Size(175, 23);
            this.labelsalary.TabIndex = 7;
            this.labelsalary.Text = "Employee Salary:";
            // 
            // labeltypeemp
            // 
            this.labeltypeemp.AutoSize = true;
            this.labeltypeemp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltypeemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labeltypeemp.Location = new System.Drawing.Point(120, 171);
            this.labeltypeemp.Name = "labeltypeemp";
            this.labeltypeemp.Size = new System.Drawing.Size(162, 23);
            this.labeltypeemp.TabIndex = 8;
            this.labeltypeemp.Text = "Employee Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(109, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee Count  :";
            // 
            // labelcountemp
            // 
            this.labelcountemp.AutoSize = true;
            this.labelcountemp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcountemp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelcountemp.Location = new System.Drawing.Point(442, 312);
            this.labelcountemp.Name = "labelcountemp";
            this.labelcountemp.Size = new System.Drawing.Size(22, 23);
            this.labelcountemp.TabIndex = 10;
            this.labelcountemp.Text = "0";
            this.labelcountemp.Click += new System.EventHandler(this.labelcountemp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(109, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Salary:";
            // 
            // labelsumesal
            // 
            this.labelsumesal.AutoSize = true;
            this.labelsumesal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsumesal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelsumesal.Location = new System.Drawing.Point(442, 376);
            this.labelsumesal.Name = "labelsumesal";
            this.labelsumesal.Size = new System.Drawing.Size(40, 23);
            this.labelsumesal.TabIndex = 12;
            this.labelsumesal.Text = "0.0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(709, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 61);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSalary);
            this.groupBox1.Controls.Add(this.labelid);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.labelname);
            this.groupBox1.Controls.Add(this.labeltypeemp);
            this.groupBox1.Controls.Add(this.typeEmployee);
            this.groupBox1.Controls.Add(this.labelsalary);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 249);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employe Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelsumesal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelcountemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnADD);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.ComboBox typeEmployee;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelsalary;
        private System.Windows.Forms.Label labeltypeemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelcountemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelsumesal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

