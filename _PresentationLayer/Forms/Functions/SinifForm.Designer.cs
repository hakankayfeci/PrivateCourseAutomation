namespace _PresentationLayer.Forms.Functions
{
    partial class SinifForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinifForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFormAdi = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.lblClassName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.dgvClasses = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbLesson = new System.Windows.Forms.ComboBox();
            this.lblLesson = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormAdi
            // 
            this.lblFormAdi.AutoSize = true;
            this.lblFormAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormAdi.ForeColor = System.Drawing.Color.White;
            this.lblFormAdi.Location = new System.Drawing.Point(12, 15);
            this.lblFormAdi.Name = "lblFormAdi";
            this.lblFormAdi.Size = new System.Drawing.Size(94, 18);
            this.lblFormAdi.TabIndex = 2;
            this.lblFormAdi.Text = "Sınıf İşlemleri";
            this.lblFormAdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormAdi_MouseDown);
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(755, 6);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 30);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKucult.ForeColor = System.Drawing.Color.White;
            this.btnKucult.Location = new System.Drawing.Point(722, 0);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(28, 30);
            this.btnKucult.TabIndex = 0;
            this.btnKucult.Text = "_";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // pnlKontrol
            // 
            this.pnlKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlKontrol.Controls.Add(this.lblFormAdi);
            this.pnlKontrol.Controls.Add(this.btnKapat);
            this.pnlKontrol.Controls.Add(this.btnKucult);
            this.pnlKontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlKontrol.Name = "pnlKontrol";
            this.pnlKontrol.Size = new System.Drawing.Size(791, 45);
            this.pnlKontrol.TabIndex = 200;
            this.pnlKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlKontrol_MouseDown);
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClassName.ForeColor = System.Drawing.Color.White;
            this.lblClassName.Location = new System.Drawing.Point(15, 113);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(64, 18);
            this.lblClassName.TabIndex = 213;
            this.lblClassName.Text = "Sınıf Adı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(130, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 1);
            this.panel1.TabIndex = 212;
            // 
            // txtClassName
            // 
            this.txtClassName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtClassName.ForeColor = System.Drawing.Color.White;
            this.txtClassName.Location = new System.Drawing.Point(131, 109);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(202, 15);
            this.txtClassName.TabIndex = 211;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "add.png");
            this.ImageList1.Images.SetKeyName(1, "delete.png");
            this.ImageList1.Images.SetKeyName(2, "update.png");
            this.ImageList1.Images.SetKeyName(3, "search.png");
            this.ImageList1.Images.SetKeyName(4, "print.png");
            // 
            // btSearch
            // 
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.ImageKey = "search.png";
            this.btSearch.ImageList = this.ImageList1;
            this.btSearch.Location = new System.Drawing.Point(12, 315);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(45, 37);
            this.btSearch.TabIndex = 298;
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(62, 330);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(34, 18);
            this.lblSearch.TabIndex = 297;
            this.lblSearch.Text = "Ara:";
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.White;
            this.pnl5.ForeColor = System.Drawing.Color.White;
            this.pnl5.Location = new System.Drawing.Point(125, 351);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(202, 1);
            this.pnl5.TabIndex = 296;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(125, 330);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 15);
            this.txtSearch.TabIndex = 295;
            this.txtSearch.TabStopChanged += new System.EventHandler(this.TxtSearch_TabStopChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.ImageKey = "delete.png";
            this.btnDelete.ImageList = this.ImageList1;
            this.btnDelete.Location = new System.Drawing.Point(489, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(270, 47);
            this.btnDelete.TabIndex = 300;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.ImageKey = "add.png";
            this.btnAdd.ImageList = this.ImageList1;
            this.btnAdd.Location = new System.Drawing.Point(489, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(270, 47);
            this.btnAdd.TabIndex = 299;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.ImageKey = "update.png";
            this.BtnUpdate.ImageList = this.ImageList1;
            this.BtnUpdate.Location = new System.Drawing.Point(489, 153);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(270, 47);
            this.BtnUpdate.TabIndex = 301;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dgvClasses
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.BackgroundColor = System.Drawing.Color.White;
            this.dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClasses.ColumnHeadersHeight = 40;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassId,
            this.ClassName,
            this.LessonId,
            this.LessonName});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasses.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClasses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClasses.DoubleBuffered = true;
            this.dgvClasses.EnableHeadersVisualStyles = false;
            this.dgvClasses.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dgvClasses.HeaderForeColor = System.Drawing.Color.White;
            this.dgvClasses.Location = new System.Drawing.Point(0, 372);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClasses.RowHeadersVisible = false;
            this.dgvClasses.RowTemplate.DividerHeight = 1;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(791, 289);
            this.dgvClasses.TabIndex = 302;
            this.dgvClasses.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInspections_RowEnter);
            // 
            // ClassId
            // 
            this.ClassId.DataPropertyName = "ClassId";
            this.ClassId.HeaderText = "Id";
            this.ClassId.Name = "ClassId";
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Sınıf Adı";
            this.ClassName.Name = "ClassName";
            // 
            // LessonId
            // 
            this.LessonId.DataPropertyName = "LessonId";
            this.LessonId.HeaderText = "Ders Id";
            this.LessonId.Name = "LessonId";
            this.LessonId.Visible = false;
            // 
            // LessonName
            // 
            this.LessonName.DataPropertyName = "LessonName";
            this.LessonName.HeaderText = "Ders Adı";
            this.LessonName.Name = "LessonName";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(127, 183);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 15);
            this.txtId.TabIndex = 303;
            this.txtId.Visible = false;
            // 
            // cmbLesson
            // 
            this.cmbLesson.FormattingEnabled = true;
            this.cmbLesson.Location = new System.Drawing.Point(126, 177);
            this.cmbLesson.Name = "cmbLesson";
            this.cmbLesson.Size = new System.Drawing.Size(203, 21);
            this.cmbLesson.TabIndex = 305;
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLesson.ForeColor = System.Drawing.Color.White;
            this.lblLesson.Location = new System.Drawing.Point(15, 176);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(71, 18);
            this.lblLesson.TabIndex = 304;
            this.lblLesson.Text = "Mesleği : ";
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.ImageKey = "print.png";
            this.btnPrint.ImageList = this.ImageList1;
            this.btnPrint.Location = new System.Drawing.Point(641, 305);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 47);
            this.btnPrint.TabIndex = 325;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // SinifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(791, 661);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbLesson);
            this.Controls.Add(this.lblLesson);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.pnlKontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SinifForm";
            this.Text = "SinifForm";
            this.Load += new System.EventHandler(this.SinifForm_Load);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormAdi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Panel pnlKontrol;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvClasses;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.ComboBox cmbLesson;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Button btnPrint;
    }
}