﻿namespace Feedbuff
{
    partial class FeedforwardOverview
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
            this.addTeacherNameTxtbx = new System.Windows.Forms.TextBox();
            this.addTeacherNameLbl = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.feedforwardFromDatabaseLstBx = new System.Windows.Forms.ListBox();
            this.pageNameLbl = new System.Windows.Forms.Label();
            this.addFeedbackToDataBaseLbl = new System.Windows.Forms.Label();
            this.addFeedbackToDataBaseBtn = new System.Windows.Forms.Button();
            this.addDocumentTxtBx = new System.Windows.Forms.TextBox();
            this.addDocumentLbl = new System.Windows.Forms.Label();
            this.addSubjectTxtBx = new System.Windows.Forms.TextBox();
            this.asignSubject = new System.Windows.Forms.Label();
            this.addFeedforwardLbl = new System.Windows.Forms.Label();
            this.addFeedbackTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addTeacherNameTxtbx
            // 
            this.addTeacherNameTxtbx.Location = new System.Drawing.Point(133, 152);
            this.addTeacherNameTxtbx.Name = "addTeacherNameTxtbx";
            this.addTeacherNameTxtbx.Size = new System.Drawing.Size(281, 22);
            this.addTeacherNameTxtbx.TabIndex = 26;
            // 
            // addTeacherNameLbl
            // 
            this.addTeacherNameLbl.AutoSize = true;
            this.addTeacherNameLbl.Location = new System.Drawing.Point(9, 155);
            this.addTeacherNameLbl.Name = "addTeacherNameLbl";
            this.addTeacherNameLbl.Size = new System.Drawing.Size(118, 16);
            this.addTeacherNameLbl.TabIndex = 25;
            this.addTeacherNameLbl.Text = "Docent toevoegen";
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(12, 792);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(121, 29);
            this.ReturnBtn.TabIndex = 24;
            this.ReturnBtn.Text = "terug";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // feedforwardFromDatabaseLstBx
            // 
            this.feedforwardFromDatabaseLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedforwardFromDatabaseLstBx.FormattingEnabled = true;
            this.feedforwardFromDatabaseLstBx.ItemHeight = 22;
            this.feedforwardFromDatabaseLstBx.Location = new System.Drawing.Point(442, 65);
            this.feedforwardFromDatabaseLstBx.Name = "feedforwardFromDatabaseLstBx";
            this.feedforwardFromDatabaseLstBx.Size = new System.Drawing.Size(1066, 752);
            this.feedforwardFromDatabaseLstBx.TabIndex = 23;
            // 
            // pageNameLbl
            // 
            this.pageNameLbl.AutoSize = true;
            this.pageNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNameLbl.Location = new System.Drawing.Point(12, 9);
            this.pageNameLbl.Name = "pageNameLbl";
            this.pageNameLbl.Size = new System.Drawing.Size(450, 32);
            this.pageNameLbl.TabIndex = 22;
            this.pageNameLbl.Text = "Feedforward toevoegen en in zien ";
            // 
            // addFeedbackToDataBaseLbl
            // 
            this.addFeedbackToDataBaseLbl.AutoSize = true;
            this.addFeedbackToDataBaseLbl.Location = new System.Drawing.Point(13, 188);
            this.addFeedbackToDataBaseLbl.Name = "addFeedbackToDataBaseLbl";
            this.addFeedbackToDataBaseLbl.Size = new System.Drawing.Size(135, 16);
            this.addFeedbackToDataBaseLbl.TabIndex = 21;
            this.addFeedbackToDataBaseLbl.Text = "Feedforward opslaan";
            // 
            // addFeedbackToDataBaseBtn
            // 
            this.addFeedbackToDataBaseBtn.Location = new System.Drawing.Point(154, 185);
            this.addFeedbackToDataBaseBtn.Name = "addFeedbackToDataBaseBtn";
            this.addFeedbackToDataBaseBtn.Size = new System.Drawing.Size(139, 23);
            this.addFeedbackToDataBaseBtn.TabIndex = 20;
            this.addFeedbackToDataBaseBtn.Text = "opslaan";
            this.addFeedbackToDataBaseBtn.UseVisualStyleBackColor = true;
            this.addFeedbackToDataBaseBtn.Click += new System.EventHandler(this.addFeedbackToDataBaseBtn_Click);
            // 
            // addDocumentTxtBx
            // 
            this.addDocumentTxtBx.Location = new System.Drawing.Point(218, 89);
            this.addDocumentTxtBx.Name = "addDocumentTxtBx";
            this.addDocumentTxtBx.Size = new System.Drawing.Size(196, 22);
            this.addDocumentTxtBx.TabIndex = 19;
            // 
            // addDocumentLbl
            // 
            this.addDocumentLbl.AutoSize = true;
            this.addDocumentLbl.Location = new System.Drawing.Point(12, 92);
            this.addDocumentLbl.Name = "addDocumentLbl";
            this.addDocumentLbl.Size = new System.Drawing.Size(200, 16);
            this.addDocumentLbl.TabIndex = 18;
            this.addDocumentLbl.Text = "Onderdeel/document toekennen";
            // 
            // addSubjectTxtBx
            // 
            this.addSubjectTxtBx.Location = new System.Drawing.Point(115, 120);
            this.addSubjectTxtBx.Name = "addSubjectTxtBx";
            this.addSubjectTxtBx.Size = new System.Drawing.Size(299, 22);
            this.addSubjectTxtBx.TabIndex = 17;
            // 
            // asignSubject
            // 
            this.asignSubject.AutoSize = true;
            this.asignSubject.Location = new System.Drawing.Point(12, 120);
            this.asignSubject.Name = "asignSubject";
            this.asignSubject.Size = new System.Drawing.Size(97, 16);
            this.asignSubject.TabIndex = 16;
            this.asignSubject.Text = "Vak toekennen";
            // 
            // addFeedforwardLbl
            // 
            this.addFeedforwardLbl.AutoSize = true;
            this.addFeedforwardLbl.Location = new System.Drawing.Point(13, 64);
            this.addFeedforwardLbl.Name = "addFeedforwardLbl";
            this.addFeedforwardLbl.Size = new System.Drawing.Size(151, 16);
            this.addFeedforwardLbl.TabIndex = 15;
            this.addFeedforwardLbl.Text = "Feedforward toevoegen";
            // 
            // addFeedbackTxtBx
            // 
            this.addFeedbackTxtBx.Location = new System.Drawing.Point(170, 61);
            this.addFeedbackTxtBx.Name = "addFeedbackTxtBx";
            this.addFeedbackTxtBx.Size = new System.Drawing.Size(258, 22);
            this.addFeedbackTxtBx.TabIndex = 14;
            // 
            // FeedforwardOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.addTeacherNameTxtbx);
            this.Controls.Add(this.addTeacherNameLbl);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.feedforwardFromDatabaseLstBx);
            this.Controls.Add(this.pageNameLbl);
            this.Controls.Add(this.addFeedbackToDataBaseLbl);
            this.Controls.Add(this.addFeedbackToDataBaseBtn);
            this.Controls.Add(this.addDocumentTxtBx);
            this.Controls.Add(this.addDocumentLbl);
            this.Controls.Add(this.addSubjectTxtBx);
            this.Controls.Add(this.asignSubject);
            this.Controls.Add(this.addFeedforwardLbl);
            this.Controls.Add(this.addFeedbackTxtBx);
            this.Name = "FeedforwardOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeedforwardOverview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addTeacherNameTxtbx;
        private System.Windows.Forms.Label addTeacherNameLbl;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.ListBox feedforwardFromDatabaseLstBx;
        private System.Windows.Forms.Label pageNameLbl;
        private System.Windows.Forms.Label addFeedbackToDataBaseLbl;
        private System.Windows.Forms.Button addFeedbackToDataBaseBtn;
        private System.Windows.Forms.TextBox addDocumentTxtBx;
        private System.Windows.Forms.Label addDocumentLbl;
        private System.Windows.Forms.TextBox addSubjectTxtBx;
        private System.Windows.Forms.Label asignSubject;
        private System.Windows.Forms.Label addFeedforwardLbl;
        private System.Windows.Forms.TextBox addFeedbackTxtBx;
    }
}