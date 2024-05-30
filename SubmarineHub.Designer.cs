namespace PR6._2_submarine
{
    partial class SubmarineHub
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.triggerRadar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.triggerControlPanel = new System.Windows.Forms.PictureBox();
            this.triggerAttack = new System.Windows.Forms.PictureBox();
            this.triggerExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.triggerRadar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerControlPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerExit)).BeginInit();
            this.SuspendLayout();
            // 
            // triggerRadar
            // 
            this.triggerRadar.BackColor = System.Drawing.Color.Transparent;
            this.triggerRadar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.triggerRadar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triggerRadar.Location = new System.Drawing.Point(323, 365);
            this.triggerRadar.Name = "triggerRadar";
            this.triggerRadar.Size = new System.Drawing.Size(76, 25);
            this.triggerRadar.TabIndex = 0;
            this.triggerRadar.TabStop = false;
            this.triggerRadar.Click += new System.EventHandler(this.triggerRadar_Click);
            this.triggerRadar.MouseEnter += new System.EventHandler(this.triggerRadar_MouseEnter);
            // 
            // triggerControlPanel
            // 
            this.triggerControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.triggerControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.triggerControlPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triggerControlPanel.Location = new System.Drawing.Point(420, 365);
            this.triggerControlPanel.Name = "triggerControlPanel";
            this.triggerControlPanel.Size = new System.Drawing.Size(76, 25);
            this.triggerControlPanel.TabIndex = 0;
            this.triggerControlPanel.TabStop = false;
            this.triggerControlPanel.MouseEnter += new System.EventHandler(this.triggerControlPanel_MouseEnter);
            // 
            // triggerAttack
            // 
            this.triggerAttack.BackColor = System.Drawing.Color.Transparent;
            this.triggerAttack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.triggerAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triggerAttack.Location = new System.Drawing.Point(128, 270);
            this.triggerAttack.Name = "triggerAttack";
            this.triggerAttack.Size = new System.Drawing.Size(46, 69);
            this.triggerAttack.TabIndex = 0;
            this.triggerAttack.TabStop = false;
            this.triggerAttack.Click += new System.EventHandler(this.triggerAttack_Click);
            this.triggerAttack.MouseEnter += new System.EventHandler(this.triggerAttack_MouseEnter);
            // 
            // triggerExit
            // 
            this.triggerExit.BackColor = System.Drawing.Color.Transparent;
            this.triggerExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.triggerExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triggerExit.Location = new System.Drawing.Point(502, 127);
            this.triggerExit.Name = "triggerExit";
            this.triggerExit.Size = new System.Drawing.Size(120, 47);
            this.triggerExit.TabIndex = 0;
            this.triggerExit.TabStop = false;
            this.triggerExit.Click += new System.EventHandler(this.triggerExit_Click);
            this.triggerExit.MouseEnter += new System.EventHandler(this.triggerExit_MouseEnter);
            // 
            // SubmarineHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PR6._2_submarine.Properties.Resources.scale_1200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 640);
            this.ControlBox = false;
            this.Controls.Add(this.triggerAttack);
            this.Controls.Add(this.triggerExit);
            this.Controls.Add(this.triggerControlPanel);
            this.Controls.Add(this.triggerRadar);
            this.MaximizeBox = false;
            this.Name = "SubmarineHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Жёлтая Субмарина";
            ((System.ComponentModel.ISupportInitialize)(this.triggerRadar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerControlPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox triggerRadar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox triggerControlPanel;
        private System.Windows.Forms.PictureBox triggerAttack;
        private System.Windows.Forms.PictureBox triggerExit;
    }
}

