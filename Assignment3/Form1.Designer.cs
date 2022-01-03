
namespace Assignment3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFilePathName = new System.Windows.Forms.Label();
            this.txtFilePathName = new System.Windows.Forms.TextBox();
            this.btnConfirmFile = new System.Windows.Forms.Button();
            this.btnReloadRecord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.lblRecordFormTextFile = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateRegistered = new System.Windows.Forms.Label();
            this.lblNumberOfClasses = new System.Windows.Forms.Label();
            this.lblTotalCostPerClass = new System.Windows.Forms.Label();
            this.lblTotalCostAllClass = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDataRegistered = new System.Windows.Forms.TextBox();
            this.txtNumberOfClasses = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtTotalCostAllClasses = new System.Windows.Forms.TextBox();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.lblAmountOutstanding = new System.Windows.Forms.Label();
            this.txtAmountOutstanding = new System.Windows.Forms.TextBox();
            this.btnSaveAddUpdate = new System.Windows.Forms.Button();
            this.btnEmptyFile = new System.Windows.Forms.Button();
            this.gbMassages = new System.Windows.Forms.GroupBox();
            this.lblerrorShow = new System.Windows.Forms.Label();
            this.lblMassageBox = new System.Windows.Forms.Label();
            this.gbMassages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilePathName
            // 
            this.lblFilePathName.AutoSize = true;
            this.lblFilePathName.Location = new System.Drawing.Point(31, 18);
            this.lblFilePathName.Name = "lblFilePathName";
            this.lblFilePathName.Size = new System.Drawing.Size(90, 15);
            this.lblFilePathName.TabIndex = 0;
            this.lblFilePathName.Text = "File Path & Name";
            // 
            // txtFilePathName
            // 
            this.txtFilePathName.Location = new System.Drawing.Point(127, 15);
            this.txtFilePathName.Name = "txtFilePathName";
            this.txtFilePathName.Size = new System.Drawing.Size(297, 23);
            this.txtFilePathName.TabIndex = 1;
            // 
            // btnConfirmFile
            // 
            this.btnConfirmFile.Location = new System.Drawing.Point(464, 9);
            this.btnConfirmFile.Name = "btnConfirmFile";
            this.btnConfirmFile.Size = new System.Drawing.Size(140, 40);
            this.btnConfirmFile.TabIndex = 2;
            this.btnConfirmFile.Text = "Confirm File Exist";
            this.btnConfirmFile.UseVisualStyleBackColor = true;
            this.btnConfirmFile.Click += new System.EventHandler(this.btnConfirmFile_Click);
            // 
            // btnReloadRecord
            // 
            this.btnReloadRecord.Location = new System.Drawing.Point(610, 9);
            this.btnReloadRecord.Name = "btnReloadRecord";
            this.btnReloadRecord.Size = new System.Drawing.Size(148, 40);
            this.btnReloadRecord.TabIndex = 3;
            this.btnReloadRecord.Text = "Reload Records";
            this.btnReloadRecord.UseVisualStyleBackColor = true;
            this.btnReloadRecord.Click += new System.EventHandler(this.btnReloadRecord_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(764, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbShow
            // 
            this.rtbShow.Location = new System.Drawing.Point(31, 77);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(1068, 135);
            this.rtbShow.TabIndex = 5;
            this.rtbShow.Text = "";
            // 
            // lblRecordFormTextFile
            // 
            this.lblRecordFormTextFile.AutoSize = true;
            this.lblRecordFormTextFile.Location = new System.Drawing.Point(31, 59);
            this.lblRecordFormTextFile.Name = "lblRecordFormTextFile";
            this.lblRecordFormTextFile.Size = new System.Drawing.Size(125, 15);
            this.lblRecordFormTextFile.TabIndex = 6;
            this.lblRecordFormTextFile.Text = "Records Form Text File";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(59, 224);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(63, 15);
            this.lblMemberID.TabIndex = 7;
            this.lblMemberID.Text = "MemberID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(59, 247);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(58, 273);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 15);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name";
            // 
            // lblDateRegistered
            // 
            this.lblDateRegistered.AutoSize = true;
            this.lblDateRegistered.Location = new System.Drawing.Point(57, 301);
            this.lblDateRegistered.Name = "lblDateRegistered";
            this.lblDateRegistered.Size = new System.Drawing.Size(89, 15);
            this.lblDateRegistered.TabIndex = 10;
            this.lblDateRegistered.Text = "Date Registered";
            // 
            // lblNumberOfClasses
            // 
            this.lblNumberOfClasses.AutoSize = true;
            this.lblNumberOfClasses.Location = new System.Drawing.Point(56, 330);
            this.lblNumberOfClasses.Name = "lblNumberOfClasses";
            this.lblNumberOfClasses.Size = new System.Drawing.Size(106, 15);
            this.lblNumberOfClasses.TabIndex = 11;
            this.lblNumberOfClasses.Text = "Number of Classes";
            // 
            // lblTotalCostPerClass
            // 
            this.lblTotalCostPerClass.AutoSize = true;
            this.lblTotalCostPerClass.Location = new System.Drawing.Point(56, 355);
            this.lblTotalCostPerClass.Name = "lblTotalCostPerClass";
            this.lblTotalCostPerClass.Size = new System.Drawing.Size(109, 15);
            this.lblTotalCostPerClass.TabIndex = 12;
            this.lblTotalCostPerClass.Text = "Total Cost Per Class";
            // 
            // lblTotalCostAllClass
            // 
            this.lblTotalCostAllClass.AutoSize = true;
            this.lblTotalCostAllClass.Location = new System.Drawing.Point(57, 381);
            this.lblTotalCostAllClass.Name = "lblTotalCostAllClass";
            this.lblTotalCostAllClass.Size = new System.Drawing.Size(127, 15);
            this.lblTotalCostAllClass.TabIndex = 13;
            this.lblTotalCostAllClass.Text = "Total Cost of all classes";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Location = new System.Drawing.Point(58, 408);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(58, 15);
            this.lblTotalPaid.TabIndex = 14;
            this.lblTotalPaid.Text = "Total Paid";
            // 
            // txtMemberID
            // 
            this.txtMemberID.HideSelection = false;
            this.txtMemberID.Location = new System.Drawing.Point(127, 220);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(536, 23);
            this.txtMemberID.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(669, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(129, 246);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(295, 23);
            this.txtFirstName.TabIndex = 17;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(129, 272);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(295, 23);
            this.txtLastName.TabIndex = 18;
            // 
            // txtDataRegistered
            // 
            this.txtDataRegistered.Location = new System.Drawing.Point(155, 298);
            this.txtDataRegistered.Name = "txtDataRegistered";
            this.txtDataRegistered.Size = new System.Drawing.Size(269, 23);
            this.txtDataRegistered.TabIndex = 19;
            // 
            // txtNumberOfClasses
            // 
            this.txtNumberOfClasses.Location = new System.Drawing.Point(172, 326);
            this.txtNumberOfClasses.Name = "txtNumberOfClasses";
            this.txtNumberOfClasses.Size = new System.Drawing.Size(252, 23);
            this.txtNumberOfClasses.TabIndex = 20;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(172, 352);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(252, 23);
            this.txtTotalCost.TabIndex = 21;
            // 
            // txtTotalCostAllClasses
            // 
            this.txtTotalCostAllClasses.Location = new System.Drawing.Point(193, 378);
            this.txtTotalCostAllClasses.Name = "txtTotalCostAllClasses";
            this.txtTotalCostAllClasses.Size = new System.Drawing.Size(231, 23);
            this.txtTotalCostAllClasses.TabIndex = 22;
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(140, 405);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Size = new System.Drawing.Size(285, 23);
            this.txtTotalPaid.TabIndex = 23;
            // 
            // lblAmountOutstanding
            // 
            this.lblAmountOutstanding.AutoSize = true;
            this.lblAmountOutstanding.Location = new System.Drawing.Point(58, 432);
            this.lblAmountOutstanding.Name = "lblAmountOutstanding";
            this.lblAmountOutstanding.Size = new System.Drawing.Size(120, 15);
            this.lblAmountOutstanding.TabIndex = 24;
            this.lblAmountOutstanding.Text = "Amount Outstanding";
            // 
            // txtAmountOutstanding
            // 
            this.txtAmountOutstanding.Location = new System.Drawing.Point(185, 431);
            this.txtAmountOutstanding.Name = "txtAmountOutstanding";
            this.txtAmountOutstanding.Size = new System.Drawing.Size(240, 23);
            this.txtAmountOutstanding.TabIndex = 25;
            // 
            // btnSaveAddUpdate
            // 
            this.btnSaveAddUpdate.Location = new System.Drawing.Point(59, 460);
            this.btnSaveAddUpdate.Name = "btnSaveAddUpdate";
            this.btnSaveAddUpdate.Size = new System.Drawing.Size(366, 25);
            this.btnSaveAddUpdate.TabIndex = 26;
            this.btnSaveAddUpdate.Text = "Save(Add/Update)";
            this.btnSaveAddUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAddUpdate.Click += new System.EventHandler(this.btnSaveAddUpdate_Click);
            // 
            // btnEmptyFile
            // 
            this.btnEmptyFile.Location = new System.Drawing.Point(60, 491);
            this.btnEmptyFile.Name = "btnEmptyFile";
            this.btnEmptyFile.Size = new System.Drawing.Size(365, 24);
            this.btnEmptyFile.TabIndex = 27;
            this.btnEmptyFile.Text = "Empty File";
            this.btnEmptyFile.UseVisualStyleBackColor = true;
            this.btnEmptyFile.Click += new System.EventHandler(this.btnEmptyFile_Click);
            // 
            // gbMassages
            // 
            this.gbMassages.Controls.Add(this.lblerrorShow);
            this.gbMassages.Controls.Add(this.lblMassageBox);
            this.gbMassages.Location = new System.Drawing.Point(502, 259);
            this.gbMassages.Name = "gbMassages";
            this.gbMassages.Size = new System.Drawing.Size(597, 256);
            this.gbMassages.TabIndex = 28;
            this.gbMassages.TabStop = false;
            this.gbMassages.Text = "Massages";
            // 
            // lblerrorShow
            // 
            this.lblerrorShow.AutoSize = true;
            this.lblerrorShow.Location = new System.Drawing.Point(19, 33);
            this.lblerrorShow.Name = "lblerrorShow";
            this.lblerrorShow.Size = new System.Drawing.Size(0, 15);
            this.lblerrorShow.TabIndex = 1;
            // 
            // lblMassageBox
            // 
            this.lblMassageBox.AutoSize = true;
            this.lblMassageBox.Location = new System.Drawing.Point(25, 39);
            this.lblMassageBox.Name = "lblMassageBox";
            this.lblMassageBox.Size = new System.Drawing.Size(0, 15);
            this.lblMassageBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 527);
            this.Controls.Add(this.gbMassages);
            this.Controls.Add(this.btnEmptyFile);
            this.Controls.Add(this.btnSaveAddUpdate);
            this.Controls.Add(this.txtAmountOutstanding);
            this.Controls.Add(this.lblAmountOutstanding);
            this.Controls.Add(this.txtTotalPaid);
            this.Controls.Add(this.txtTotalCostAllClasses);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtNumberOfClasses);
            this.Controls.Add(this.txtDataRegistered);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblTotalPaid);
            this.Controls.Add(this.lblTotalCostAllClass);
            this.Controls.Add(this.lblTotalCostPerClass);
            this.Controls.Add(this.lblNumberOfClasses);
            this.Controls.Add(this.lblDateRegistered);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblRecordFormTextFile);
            this.Controls.Add(this.rtbShow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReloadRecord);
            this.Controls.Add(this.btnConfirmFile);
            this.Controls.Add(this.txtFilePathName);
            this.Controls.Add(this.lblFilePathName);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Management";
            this.gbMassages.ResumeLayout(false);
            this.gbMassages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilePathName;
        private System.Windows.Forms.TextBox txtFilePathName;
        private System.Windows.Forms.Button btnConfirmFile;
        private System.Windows.Forms.Button btnReloadRecord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.Label lblRecordFormTextFile;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateRegistered;
        private System.Windows.Forms.Label lblNumberOfClasses;
        private System.Windows.Forms.Label lblTotalCostPerClass;
        private System.Windows.Forms.Label lblTotalCostAllClass;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDataRegistered;
        private System.Windows.Forms.TextBox txtNumberOfClasses;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtTotalCostAllClasses;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Label lblAmountOutstanding;
        private System.Windows.Forms.TextBox txtAmountOutstanding;
        private System.Windows.Forms.Button btnSaveAddUpdate;
        private System.Windows.Forms.Button btnEmptyFile;
        private System.Windows.Forms.GroupBox gbMassages;
        private System.Windows.Forms.Label lblMassageBox;
        private System.Windows.Forms.Label lblerrorShow;
    }
}

