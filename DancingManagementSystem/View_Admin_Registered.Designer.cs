namespace DancingManagementSystem
{
    partial class View_Admin_Registered
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.listMember = new System.Windows.Forms.ListBox();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(130, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 22);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Class Attendants";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(55, 50);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(73, 13);
            this.lblClass.TabIndex = 30;
            this.lblClass.Text = "Choose class:";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(127, 88);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(109, 13);
            this.lblMember.TabIndex = 30;
            this.lblMember.Text = "Registered member(s)";
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(282, 149);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(88, 23);
            this.btnDetail.TabIndex = 31;
            this.btnDetail.Text = "Member Details";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // listMember
            // 
            this.listMember.FormattingEnabled = true;
            this.listMember.Location = new System.Drawing.Point(130, 104);
            this.listMember.Name = "listMember";
            this.listMember.Size = new System.Drawing.Size(146, 121);
            this.listMember.TabIndex = 32;
            // 
            // comboClass
            // 
            this.comboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Location = new System.Drawing.Point(130, 50);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(146, 21);
            this.comboClass.TabIndex = 33;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(282, 50);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(88, 23);
            this.btnShow.TabIndex = 34;
            this.btnShow.Text = "Show Members";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // View_Admin_Registered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 237);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.listMember);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblTitle);
            this.Name = "View_Admin_Registered";
            this.Text = "View_Admin_Registered";
            this.Load += new System.EventHandler(this.View_Admin_Registered_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.ListBox listMember;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.Button btnShow;
    }
}