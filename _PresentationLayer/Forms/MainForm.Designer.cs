namespace _PresentationLayer.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DdbtnStudent = new System.Windows.Forms.ToolStripDropDownButton();
            this.SubitemStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.DdbtnEmployee = new System.Windows.Forms.ToolStripDropDownButton();
            this.SubitemEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.DdbtnClass = new System.Windows.Forms.ToolStripDropDownButton();
            this.SubitemClass = new System.Windows.Forms.ToolStripMenuItem();
            this.DdbtnRole = new System.Windows.Forms.ToolStripDropDownButton();
            this.SubitemRole = new System.Windows.Forms.ToolStripMenuItem();
            this.DdbtnLesson = new System.Windows.Forms.ToolStripDropDownButton();
            this.SubitemLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.DdbtnExam = new System.Windows.Forms.ToolStripDropDownButton();
            this.SubitemExam = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.RestoreDown = new System.Windows.Forms.ToolStripButton();
            this.btnMinimize = new System.Windows.Forms.ToolStripButton();
            this.DdbtnTrialExam = new System.Windows.Forms.ToolStripDropDownButton();
            this.SubitemTrialExam = new System.Windows.Forms.ToolStripMenuItem();
            this.DdbtnTrialExamNote = new System.Windows.Forms.ToolStripDropDownButton();
            this.SubitemTrialExamNote = new System.Windows.Forms.ToolStripMenuItem();
            this.DdbtnPayment = new System.Windows.Forms.ToolStripDropDownButton();
            this.SubitemPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.DdbtnExtend = new System.Windows.Forms.ToolStripDropDownButton();
            this.SubitemExtend = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbtnLeave = new System.Windows.Forms.ToolStripDropDownButton();
            this.Leavelblts = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlKontrol.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKontrol
            // 
            this.pnlKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlKontrol.Controls.Add(this.toolStrip1);
            this.pnlKontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlKontrol.Name = "pnlKontrol";
            this.pnlKontrol.Size = new System.Drawing.Size(1003, 45);
            this.pnlKontrol.TabIndex = 27;
            this.pnlKontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKontrol_Paint);
            this.pnlKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlKontrol_MouseDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DdbtnStudent,
            this.DdbtnEmployee,
            this.DdbtnClass,
            this.DdbtnRole,
            this.DdbtnLesson,
            this.DdbtnExam,
            this.btnClose,
            this.RestoreDown,
            this.btnMinimize,
            this.DdbtnTrialExam,
            this.DdbtnTrialExamNote,
            this.DdbtnPayment,
            this.DdbtnExtend,
            this.tstbtnLeave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1003, 45);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // DdbtnStudent
            // 
            this.DdbtnStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DdbtnStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubitemStudent});
            this.DdbtnStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.DdbtnStudent.Image = ((System.Drawing.Image)(resources.GetObject("DdbtnStudent.Image")));
            this.DdbtnStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DdbtnStudent.Name = "DdbtnStudent";
            this.DdbtnStudent.Size = new System.Drawing.Size(62, 42);
            this.DdbtnStudent.Text = "Öğrenci";
            this.DdbtnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // SubitemStudent
            // 
            this.SubitemStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SubitemStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.SubitemStudent.Name = "SubitemStudent";
            this.SubitemStudent.Size = new System.Drawing.Size(180, 22);
            this.SubitemStudent.Text = "Ögrenci İşlemleri";
            this.SubitemStudent.Click += new System.EventHandler(this.SubitemStudent_Click);
            // 
            // DdbtnEmployee
            // 
            this.DdbtnEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DdbtnEmployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubitemEmployee});
            this.DdbtnEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.DdbtnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("DdbtnEmployee.Image")));
            this.DdbtnEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DdbtnEmployee.Name = "DdbtnEmployee";
            this.DdbtnEmployee.Size = new System.Drawing.Size(65, 42);
            this.DdbtnEmployee.Text = "Personel";
            // 
            // SubitemEmployee
            // 
            this.SubitemEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SubitemEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.SubitemEmployee.Name = "SubitemEmployee";
            this.SubitemEmployee.Size = new System.Drawing.Size(166, 22);
            this.SubitemEmployee.Text = "Personel İşlemleri";
            this.SubitemEmployee.Click += new System.EventHandler(this.SubitemEmployee_Click);
            // 
            // DdbtnClass
            // 
            this.DdbtnClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DdbtnClass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubitemClass});
            this.DdbtnClass.ForeColor = System.Drawing.SystemColors.Control;
            this.DdbtnClass.Image = ((System.Drawing.Image)(resources.GetObject("DdbtnClass.Image")));
            this.DdbtnClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DdbtnClass.Name = "DdbtnClass";
            this.DdbtnClass.Size = new System.Drawing.Size(43, 42);
            this.DdbtnClass.Text = "Sınıf";
            // 
            // SubitemClass
            // 
            this.SubitemClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SubitemClass.ForeColor = System.Drawing.SystemColors.Control;
            this.SubitemClass.Name = "SubitemClass";
            this.SubitemClass.Size = new System.Drawing.Size(144, 22);
            this.SubitemClass.Text = "Sınıf İşlemleri";
            this.SubitemClass.Click += new System.EventHandler(this.SubitemClass_Click);
            // 
            // DdbtnRole
            // 
            this.DdbtnRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DdbtnRole.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubitemRole});
            this.DdbtnRole.ForeColor = System.Drawing.SystemColors.Control;
            this.DdbtnRole.Image = ((System.Drawing.Image)(resources.GetObject("DdbtnRole.Image")));
            this.DdbtnRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DdbtnRole.Name = "DdbtnRole";
            this.DdbtnRole.Size = new System.Drawing.Size(37, 42);
            this.DdbtnRole.Text = "Rol";
            // 
            // SubitemRole
            // 
            this.SubitemRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SubitemRole.ForeColor = System.Drawing.SystemColors.Control;
            this.SubitemRole.Name = "SubitemRole";
            this.SubitemRole.Size = new System.Drawing.Size(138, 22);
            this.SubitemRole.Text = "Rol İşlemleri";
            this.SubitemRole.Click += new System.EventHandler(this.SubitemRole_Click);
            // 
            // DdbtnLesson
            // 
            this.DdbtnLesson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DdbtnLesson.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubitemLesson});
            this.DdbtnLesson.ForeColor = System.Drawing.SystemColors.Control;
            this.DdbtnLesson.Image = ((System.Drawing.Image)(resources.GetObject("DdbtnLesson.Image")));
            this.DdbtnLesson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DdbtnLesson.Name = "DdbtnLesson";
            this.DdbtnLesson.Size = new System.Drawing.Size(43, 42);
            this.DdbtnLesson.Text = "Ders";
            // 
            // SubitemLesson
            // 
            this.SubitemLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SubitemLesson.ForeColor = System.Drawing.SystemColors.Control;
            this.SubitemLesson.Name = "SubitemLesson";
            this.SubitemLesson.Size = new System.Drawing.Size(144, 22);
            this.SubitemLesson.Text = "Ders İşlemleri";
            this.SubitemLesson.Click += new System.EventHandler(this.SubitemLesson_Click);
            // 
            // DdbtnExam
            // 
            this.DdbtnExam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DdbtnExam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubitemExam});
            this.DdbtnExam.ForeColor = System.Drawing.SystemColors.Control;
            this.DdbtnExam.Image = ((System.Drawing.Image)(resources.GetObject("DdbtnExam.Image")));
            this.DdbtnExam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DdbtnExam.Name = "DdbtnExam";
            this.DdbtnExam.Size = new System.Drawing.Size(48, 42);
            this.DdbtnExam.Text = "Sınav";
            // 
            // SubitemExam
            // 
            this.SubitemExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SubitemExam.ForeColor = System.Drawing.SystemColors.Control;
            this.SubitemExam.Name = "SubitemExam";
            this.SubitemExam.Size = new System.Drawing.Size(149, 22);
            this.SubitemExam.Text = "Sınav İşlemleri";
            this.SubitemExam.Click += new System.EventHandler(this.SubitemExam_Click);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 42);
            this.btnClose.Text = "  X  ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RestoreDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RestoreDown.Image = global::_PresentationLayer.Properties.Resources.doguk;
            this.RestoreDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RestoreDown.Name = "RestoreDown";
            this.RestoreDown.Size = new System.Drawing.Size(23, 42);
            this.RestoreDown.Text = "Restore Down";
            this.RestoreDown.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 42);
            this.btnMinimize.Text = "  _  ";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // DdbtnTrialExam
            // 
            this.DdbtnTrialExam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DdbtnTrialExam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubitemTrialExam});
            this.DdbtnTrialExam.ForeColor = System.Drawing.SystemColors.Control;
            this.DdbtnTrialExam.Image = ((System.Drawing.Image)(resources.GetObject("DdbtnTrialExam.Image")));
            this.DdbtnTrialExam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DdbtnTrialExam.Name = "DdbtnTrialExam";
            this.DdbtnTrialExam.Size = new System.Drawing.Size(98, 42);
            this.DdbtnTrialExam.Text = "Deneme Sınavı";
            // 
            // SubitemTrialExam
            // 
            this.SubitemTrialExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SubitemTrialExam.ForeColor = System.Drawing.SystemColors.Control;
            this.SubitemTrialExam.Name = "SubitemTrialExam";
            this.SubitemTrialExam.Size = new System.Drawing.Size(199, 22);
            this.SubitemTrialExam.Text = "Deneme Sınavı İşlemleri";
            this.SubitemTrialExam.Click += new System.EventHandler(this.SubitemTrialExam_Click);
            // 
            // DdbtnTrialExamNote
            // 
            this.DdbtnTrialExamNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DdbtnTrialExamNote.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubitemTrialExamNote});
            this.DdbtnTrialExamNote.ForeColor = System.Drawing.SystemColors.Control;
            this.DdbtnTrialExamNote.Image = ((System.Drawing.Image)(resources.GetObject("DdbtnTrialExamNote.Image")));
            this.DdbtnTrialExamNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DdbtnTrialExamNote.Name = "DdbtnTrialExamNote";
            this.DdbtnTrialExamNote.Size = new System.Drawing.Size(128, 42);
            this.DdbtnTrialExamNote.Text = "Deneme Sınavı Notu";
            // 
            // SubitemTrialExamNote
            // 
            this.SubitemTrialExamNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SubitemTrialExamNote.ForeColor = System.Drawing.SystemColors.Control;
            this.SubitemTrialExamNote.Name = "SubitemTrialExamNote";
            this.SubitemTrialExamNote.Size = new System.Drawing.Size(229, 22);
            this.SubitemTrialExamNote.Text = "Deneme Sınavı Notu İşlemleri";
            this.SubitemTrialExamNote.Click += new System.EventHandler(this.SubitemTrialExamNote_Click);
            // 
            // DdbtnPayment
            // 
            this.DdbtnPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DdbtnPayment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubitemPayment});
            this.DdbtnPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.DdbtnPayment.Image = ((System.Drawing.Image)(resources.GetObject("DdbtnPayment.Image")));
            this.DdbtnPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DdbtnPayment.Name = "DdbtnPayment";
            this.DdbtnPayment.Size = new System.Drawing.Size(48, 42);
            this.DdbtnPayment.Text = "Maaş";
            // 
            // SubitemPayment
            // 
            this.SubitemPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SubitemPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.SubitemPayment.Name = "SubitemPayment";
            this.SubitemPayment.Size = new System.Drawing.Size(149, 22);
            this.SubitemPayment.Text = "Maaş İşlemleri";
            this.SubitemPayment.Click += new System.EventHandler(this.SubitemPayment_Click);
            // 
            // DdbtnExtend
            // 
            this.DdbtnExtend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DdbtnExtend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubitemExtend});
            this.DdbtnExtend.ForeColor = System.Drawing.SystemColors.Control;
            this.DdbtnExtend.Image = ((System.Drawing.Image)(resources.GetObject("DdbtnExtend.Image")));
            this.DdbtnExtend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DdbtnExtend.Name = "DdbtnExtend";
            this.DdbtnExtend.Size = new System.Drawing.Size(61, 42);
            this.DdbtnExtend.Text = "Giderler";
            // 
            // SubitemExtend
            // 
            this.SubitemExtend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SubitemExtend.ForeColor = System.Drawing.SystemColors.Control;
            this.SubitemExtend.Name = "SubitemExtend";
            this.SubitemExtend.Size = new System.Drawing.Size(149, 22);
            this.SubitemExtend.Text = "Gider İşlemleri";
            this.SubitemExtend.Click += new System.EventHandler(this.SubitemExtend_Click);
            // 
            // tstbtnLeave
            // 
            this.tstbtnLeave.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tstbtnLeave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbtnLeave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Leavelblts});
            this.tstbtnLeave.ForeColor = System.Drawing.SystemColors.Control;
            this.tstbtnLeave.Image = global::_PresentationLayer.Properties.Resources.logOut;
            this.tstbtnLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tstbtnLeave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbtnLeave.Name = "tstbtnLeave";
            this.tstbtnLeave.Size = new System.Drawing.Size(90, 42);
            this.tstbtnLeave.Text = "Kullanıcı : ";
            // 
            // Leavelblts
            // 
            this.Leavelblts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Leavelblts.ForeColor = System.Drawing.Color.Red;
            this.Leavelblts.Name = "Leavelblts";
            this.Leavelblts.Size = new System.Drawing.Size(99, 22);
            this.Leavelblts.Text = "Çıkış";
            this.Leavelblts.Click += new System.EventHandler(this.Leavelblts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1003, 531);
            this.Controls.Add(this.pnlKontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlKontrol;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton DdbtnStudent;
        private System.Windows.Forms.ToolStripDropDownButton DdbtnEmployee;
        private System.Windows.Forms.ToolStripDropDownButton DdbtnClass;
        private System.Windows.Forms.ToolStripDropDownButton DdbtnRole;
        private System.Windows.Forms.ToolStripDropDownButton DdbtnLesson;
        private System.Windows.Forms.ToolStripDropDownButton DdbtnPayment;
        private System.Windows.Forms.ToolStripDropDownButton DdbtnExtend;
        private System.Windows.Forms.ToolStripDropDownButton DdbtnExam;
        private System.Windows.Forms.ToolStripDropDownButton DdbtnTrialExamNote;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnMinimize;
        private System.Windows.Forms.ToolStripDropDownButton DdbtnTrialExam;
        private System.Windows.Forms.ToolStripMenuItem SubitemStudent;
        private System.Windows.Forms.ToolStripMenuItem SubitemEmployee;
        private System.Windows.Forms.ToolStripMenuItem SubitemClass;
        private System.Windows.Forms.ToolStripMenuItem SubitemRole;
        private System.Windows.Forms.ToolStripMenuItem SubitemLesson;
        private System.Windows.Forms.ToolStripMenuItem SubitemPayment;
        private System.Windows.Forms.ToolStripMenuItem SubitemExtend;
        private System.Windows.Forms.ToolStripMenuItem SubitemExam;
        private System.Windows.Forms.ToolStripMenuItem SubitemTrialExam;
        private System.Windows.Forms.ToolStripMenuItem SubitemTrialExamNote;
        private System.Windows.Forms.ToolStripDropDownButton tstbtnLeave;
        private System.Windows.Forms.ToolStripMenuItem Leavelblts;
        private System.Windows.Forms.ToolStripButton RestoreDown;
    }
}