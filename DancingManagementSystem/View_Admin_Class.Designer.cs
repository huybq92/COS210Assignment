namespace DancingManagementSystem
{
    partial class View_Admin_Class
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxCategory = new System.Windows.Forms.TextBox();
            this.txtboxVenue = new System.Windows.Forms.TextBox();
            this.txtboxFee = new System.Windows.Forms.TextBox();
            this.comboInstructor = new System.Windows.Forms.ComboBox();
            this.lblInstructorValue = new System.Windows.Forms.Label();
            this.datePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDateValue = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(258, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 37);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(320, 241);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(45, 44);
            this.btnLast.TabIndex = 18;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(253, 241);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 44);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(202, 241);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(45, 44);
            this.btnPrevious.TabIndex = 16;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(135, 241);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(45, 44);
            this.btnFirst.TabIndex = 15;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.Location = new System.Drawing.Point(66, 195);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(40, 17);
            this.lblFee.TabIndex = 12;
            this.lblFee.Text = "Fee:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(66, 171);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(87, 17);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(66, 145);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(59, 17);
            this.lblVenue.TabIndex = 8;
            this.lblVenue.Text = "Venue:";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.Location = new System.Drawing.Point(66, 121);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(82, 17);
            this.lblInstructor.TabIndex = 6;
            this.lblInstructor.Text = "Instructor:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(66, 93);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(78, 17);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(66, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Class Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(174, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 22);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "View Classes Info";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(170, 65);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(209, 20);
            this.txtboxName.TabIndex = 27;
            // 
            // txtboxCategory
            // 
            this.txtboxCategory.Location = new System.Drawing.Point(170, 92);
            this.txtboxCategory.Name = "txtboxCategory";
            this.txtboxCategory.Size = new System.Drawing.Size(209, 20);
            this.txtboxCategory.TabIndex = 27;
            // 
            // txtboxVenue
            // 
            this.txtboxVenue.Location = new System.Drawing.Point(170, 144);
            this.txtboxVenue.Name = "txtboxVenue";
            this.txtboxVenue.Size = new System.Drawing.Size(209, 20);
            this.txtboxVenue.TabIndex = 27;
            // 
            // txtboxFee
            // 
            this.txtboxFee.Location = new System.Drawing.Point(170, 194);
            this.txtboxFee.Name = "txtboxFee";
            this.txtboxFee.Size = new System.Drawing.Size(209, 20);
            this.txtboxFee.TabIndex = 27;
            // 
            // comboInstructor
            // 
            this.comboInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInstructor.FormattingEnabled = true;
            this.comboInstructor.Location = new System.Drawing.Point(258, 118);
            this.comboInstructor.Name = "comboInstructor";
            this.comboInstructor.Size = new System.Drawing.Size(121, 21);
            this.comboInstructor.TabIndex = 28;
            // 
            // lblInstructorValue
            // 
            this.lblInstructorValue.AutoSize = true;
            this.lblInstructorValue.Location = new System.Drawing.Point(167, 123);
            this.lblInstructorValue.Name = "lblInstructorValue";
            this.lblInstructorValue.Size = new System.Drawing.Size(0, 13);
            this.lblInstructorValue.TabIndex = 29;
            // 
            // datePickerStartDate
            // 
            this.datePickerStartDate.Location = new System.Drawing.Point(258, 168);
            this.datePickerStartDate.Name = "datePickerStartDate";
            this.datePickerStartDate.Size = new System.Drawing.Size(121, 20);
            this.datePickerStartDate.TabIndex = 30;
            // 
            // lblStartDateValue
            // 
            this.lblStartDateValue.AutoSize = true;
            this.lblStartDateValue.Location = new System.Drawing.Point(167, 175);
            this.lblStartDateValue.Name = "lblStartDateValue";
            this.lblStartDateValue.Size = new System.Drawing.Size(0, 13);
            this.lblStartDateValue.TabIndex = 29;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 37);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // View_Admin_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 349);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.datePickerStartDate);
            this.Controls.Add(this.lblStartDateValue);
            this.Controls.Add(this.lblInstructorValue);
            this.Controls.Add(this.comboInstructor);
            this.Controls.Add(this.txtboxFee);
            this.Controls.Add(this.txtboxVenue);
            this.Controls.Add(this.txtboxCategory);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "View_Admin_Class";
            this.Text = "View_Admin_Class";
            this.Load += new System.EventHandler(this.View_Admin_Class_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxCategory;
        private System.Windows.Forms.TextBox txtboxVenue;
        private System.Windows.Forms.TextBox txtboxFee;
        private System.Windows.Forms.ComboBox comboInstructor;
        private System.Windows.Forms.Label lblInstructorValue;
        private System.Windows.Forms.DateTimePicker datePickerStartDate;
        private System.Windows.Forms.Label lblStartDateValue;
        private System.Windows.Forms.Button btnAdd;
    }
}