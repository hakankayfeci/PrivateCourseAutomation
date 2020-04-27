namespace _PresentationLayer.Forms.FormAction
{
    partial class RegisterSuccessfuly
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.icon_delay = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition1_TransitionEnd);
            // 
            // icon_delay
            // 
            this.icon_delay.Enabled = true;
            this.icon_delay.Interval = 4000;
            this.icon_delay.Tick += new System.EventHandler(this.icon_delay_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(224, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giris Basarılı\r\nYönlendiriliyor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.White;
            this.icon.Image = global::_PresentationLayer.Properties.Resources.Succesfully;
            this.icon.Location = new System.Drawing.Point(91, 17);
            this.icon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(483, 311);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 3;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.icon_Click);
            // 
            // RegisterSuccessfuly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterSuccessfuly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterSuccessfuly";
            this.Load += new System.EventHandler(this.RegisterSuccessfuly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.Timer icon_delay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox icon;
    }
}