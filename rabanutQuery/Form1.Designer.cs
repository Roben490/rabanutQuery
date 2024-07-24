namespace rabanutQuery
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
            this.btnRead = new System.Windows.Forms.Button();
            this.cmbDayOnWeek = new System.Windows.Forms.ComboBox();
            this.lblReadDate = new System.Windows.Forms.Label();
            this.txtResault = new System.Windows.Forms.TextBox();
            this.lblDayOnWeek = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblMounth = new System.Windows.Forms.Label();
            this.cmbMounth = new System.Windows.Forms.ComboBox();
            this.lblDayOfMounth = new System.Windows.Forms.Label();
            this.cmbDayOfMounth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(328, 180);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(147, 66);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "כתיבה";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // cmbDayOnWeek
            // 
            this.cmbDayOnWeek.FormattingEnabled = true;
            this.cmbDayOnWeek.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "ששי"});
            this.cmbDayOnWeek.Location = new System.Drawing.Point(623, 116);
            this.cmbDayOnWeek.Name = "cmbDayOnWeek";
            this.cmbDayOnWeek.Size = new System.Drawing.Size(121, 28);
            this.cmbDayOnWeek.TabIndex = 1;
            // 
            // lblReadDate
            // 
            this.lblReadDate.AutoSize = true;
            this.lblReadDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadDate.Location = new System.Drawing.Point(308, 37);
            this.lblReadDate.Name = "lblReadDate";
            this.lblReadDate.Size = new System.Drawing.Size(167, 32);
            this.lblReadDate.TabIndex = 2;
            this.lblReadDate.Text = "כתיבת תאריך";
            // 
            // txtResault
            // 
            this.txtResault.Location = new System.Drawing.Point(80, 284);
            this.txtResault.Name = "txtResault";
            this.txtResault.ReadOnly = true;
            this.txtResault.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResault.Size = new System.Drawing.Size(649, 26);
            this.txtResault.TabIndex = 3;
            // 
            // lblDayOnWeek
            // 
            this.lblDayOnWeek.AutoSize = true;
            this.lblDayOnWeek.Location = new System.Drawing.Point(644, 93);
            this.lblDayOnWeek.Name = "lblDayOnWeek";
            this.lblDayOnWeek.Size = new System.Drawing.Size(85, 20);
            this.lblDayOnWeek.TabIndex = 4;
            this.lblDayOnWeek.Text = "היום בשבוע";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(123, 93);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(35, 20);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "שנה";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "תשפ\'\'ד",
            "תשפ\'\'ג",
            "תשפ\'\'ב",
            "תשפ\'\'א",
            "תש\'\'פ",
            "תשע\'\'ט",
            "תשע\'\'ח",
            "תשע\'\'ז",
            "תשע\'\'ו",
            "תשע\'\'ה",
            "תשע\'\'ד"});
            this.cmbYear.Location = new System.Drawing.Point(80, 116);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 28);
            this.cmbYear.TabIndex = 7;
            // 
            // lblMounth
            // 
            this.lblMounth.AutoSize = true;
            this.lblMounth.Location = new System.Drawing.Point(287, 93);
            this.lblMounth.Name = "lblMounth";
            this.lblMounth.Size = new System.Drawing.Size(44, 20);
            this.lblMounth.TabIndex = 10;
            this.lblMounth.Text = "חודש";
            // 
            // cmbMounth
            // 
            this.cmbMounth.FormattingEnabled = true;
            this.cmbMounth.Items.AddRange(new object[] {
            "תשרי",
            "חשוון",
            "כסליו",
            "טבת",
            "שבט",
            "אדר",
            "ניסן",
            "אייר",
            "סיוון",
            "תמוז",
            "אב",
            "אלול"});
            this.cmbMounth.Location = new System.Drawing.Point(251, 116);
            this.cmbMounth.Name = "cmbMounth";
            this.cmbMounth.Size = new System.Drawing.Size(121, 28);
            this.cmbMounth.TabIndex = 9;
            // 
            // lblDayOfMounth
            // 
            this.lblDayOfMounth.AutoSize = true;
            this.lblDayOfMounth.Location = new System.Drawing.Point(464, 93);
            this.lblDayOfMounth.Name = "lblDayOfMounth";
            this.lblDayOfMounth.Size = new System.Drawing.Size(85, 20);
            this.lblDayOfMounth.TabIndex = 12;
            this.lblDayOfMounth.Text = "היום בחודש";
            // 
            // cmbDayOfMounth
            // 
            this.cmbDayOfMounth.FormattingEnabled = true;
            this.cmbDayOfMounth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbDayOfMounth.Location = new System.Drawing.Point(443, 116);
            this.cmbDayOfMounth.Name = "cmbDayOfMounth";
            this.cmbDayOfMounth.Size = new System.Drawing.Size(121, 28);
            this.cmbDayOfMounth.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDayOfMounth);
            this.Controls.Add(this.cmbDayOfMounth);
            this.Controls.Add(this.lblMounth);
            this.Controls.Add(this.cmbMounth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblDayOnWeek);
            this.Controls.Add(this.txtResault);
            this.Controls.Add(this.lblReadDate);
            this.Controls.Add(this.cmbDayOnWeek);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ComboBox cmbDayOnWeek;
        private System.Windows.Forms.Label lblReadDate;
        private System.Windows.Forms.TextBox txtResault;
        private System.Windows.Forms.Label lblDayOnWeek;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblMounth;
        private System.Windows.Forms.ComboBox cmbMounth;
        private System.Windows.Forms.Label lblDayOfMounth;
        private System.Windows.Forms.ComboBox cmbDayOfMounth;
    }
}

