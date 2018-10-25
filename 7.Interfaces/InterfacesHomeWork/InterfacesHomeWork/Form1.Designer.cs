namespace InterfacesHomeWork
{
    partial class Form1
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
            this.wall1 = new System.Windows.Forms.Panel();
            this.wall2 = new System.Windows.Forms.Panel();
            this.foundation = new System.Windows.Forms.Panel();
            this.roof1 = new System.Windows.Forms.Panel();
            this.roof2 = new System.Windows.Forms.Panel();
            this.roof3 = new System.Windows.Forms.Panel();
            this.wall3 = new System.Windows.Forms.Panel();
            this.wallLabel1 = new System.Windows.Forms.Label();
            this.wallLabel3 = new System.Windows.Forms.Label();
            this.wallLabel2 = new System.Windows.Forms.Label();
            this.roofLabel = new System.Windows.Forms.Label();
            this.foundationLabel = new System.Windows.Forms.Label();
            this.buildButton = new System.Windows.Forms.Button();
            this.wall1.SuspendLayout();
            this.wall2.SuspendLayout();
            this.foundation.SuspendLayout();
            this.roof2.SuspendLayout();
            this.wall3.SuspendLayout();
            this.SuspendLayout();
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.Gray;
            this.wall1.Controls.Add(this.wallLabel1);
            this.wall1.Location = new System.Drawing.Point(481, 148);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(54, 243);
            this.wall1.TabIndex = 1;
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.Gray;
            this.wall2.Controls.Add(this.wallLabel3);
            this.wall2.Location = new System.Drawing.Point(22, 148);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(54, 243);
            this.wall2.TabIndex = 2;
            // 
            // foundation
            // 
            this.foundation.BackColor = System.Drawing.Color.Black;
            this.foundation.Controls.Add(this.foundationLabel);
            this.foundation.Location = new System.Drawing.Point(22, 397);
            this.foundation.Name = "foundation";
            this.foundation.Size = new System.Drawing.Size(513, 42);
            this.foundation.TabIndex = 0;
            // 
            // roof1
            // 
            this.roof1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roof1.Location = new System.Drawing.Point(22, 100);
            this.roof1.Name = "roof1";
            this.roof1.Size = new System.Drawing.Size(513, 42);
            this.roof1.TabIndex = 1;
            // 
            // roof2
            // 
            this.roof2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roof2.Controls.Add(this.roofLabel);
            this.roof2.Location = new System.Drawing.Point(35, 56);
            this.roof2.Name = "roof2";
            this.roof2.Size = new System.Drawing.Size(486, 38);
            this.roof2.TabIndex = 3;
            // 
            // roof3
            // 
            this.roof3.BackColor = System.Drawing.Color.Black;
            this.roof3.Location = new System.Drawing.Point(84, 12);
            this.roof3.Name = "roof3";
            this.roof3.Size = new System.Drawing.Size(390, 38);
            this.roof3.TabIndex = 4;
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wall3.Controls.Add(this.wallLabel2);
            this.wall3.Location = new System.Drawing.Point(84, 148);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(394, 243);
            this.wall3.TabIndex = 5;
            // 
            // wallLabel1
            // 
            this.wallLabel1.AllowDrop = true;
            this.wallLabel1.AutoSize = true;
            this.wallLabel1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wallLabel1.Location = new System.Drawing.Point(5, 113);
            this.wallLabel1.Name = "wallLabel1";
            this.wallLabel1.Size = new System.Drawing.Size(48, 23);
            this.wallLabel1.TabIndex = 0;
            this.wallLabel1.Text = "Wall ";
            this.wallLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wallLabel3
            // 
            this.wallLabel3.AllowDrop = true;
            this.wallLabel3.AutoSize = true;
            this.wallLabel3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wallLabel3.Location = new System.Drawing.Point(3, 113);
            this.wallLabel3.Name = "wallLabel3";
            this.wallLabel3.Size = new System.Drawing.Size(48, 23);
            this.wallLabel3.TabIndex = 1;
            this.wallLabel3.Text = "Wall ";
            this.wallLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wallLabel2
            // 
            this.wallLabel2.AllowDrop = true;
            this.wallLabel2.AutoSize = true;
            this.wallLabel2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wallLabel2.Location = new System.Drawing.Point(179, 113);
            this.wallLabel2.Name = "wallLabel2";
            this.wallLabel2.Size = new System.Drawing.Size(48, 23);
            this.wallLabel2.TabIndex = 2;
            this.wallLabel2.Text = "Wall ";
            this.wallLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roofLabel
            // 
            this.roofLabel.AllowDrop = true;
            this.roofLabel.AutoSize = true;
            this.roofLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roofLabel.Location = new System.Drawing.Point(199, -4);
            this.roofLabel.Name = "roofLabel";
            this.roofLabel.Size = new System.Drawing.Size(89, 45);
            this.roofLabel.TabIndex = 3;
            this.roofLabel.Text = "Roof";
            this.roofLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foundationLabel
            // 
            this.foundationLabel.AllowDrop = true;
            this.foundationLabel.AutoSize = true;
            this.foundationLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foundationLabel.ForeColor = System.Drawing.Color.White;
            this.foundationLabel.Location = new System.Drawing.Point(166, 0);
            this.foundationLabel.Name = "foundationLabel";
            this.foundationLabel.Size = new System.Drawing.Size(189, 45);
            this.foundationLabel.TabIndex = 4;
            this.foundationLabel.Text = "Foundation";
            this.foundationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buildButton
            // 
            this.buildButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buildButton.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildButton.Location = new System.Drawing.Point(595, 211);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(179, 73);
            this.buildButton.TabIndex = 6;
            this.buildButton.Text = "BUILD";
            this.buildButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.roof3);
            this.Controls.Add(this.roof2);
            this.Controls.Add(this.roof1);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.foundation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.wall1.ResumeLayout(false);
            this.wall1.PerformLayout();
            this.wall2.ResumeLayout(false);
            this.wall2.PerformLayout();
            this.foundation.ResumeLayout(false);
            this.foundation.PerformLayout();
            this.roof2.ResumeLayout(false);
            this.roof2.PerformLayout();
            this.wall3.ResumeLayout(false);
            this.wall3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel wall1;
        private System.Windows.Forms.Panel wall2;
        private System.Windows.Forms.Panel foundation;
        private System.Windows.Forms.Panel roof1;
        private System.Windows.Forms.Panel roof2;
        private System.Windows.Forms.Panel roof3;
        private System.Windows.Forms.Panel wall3;
        private System.Windows.Forms.Label wallLabel1;
        private System.Windows.Forms.Label wallLabel3;
        private System.Windows.Forms.Label roofLabel;
        private System.Windows.Forms.Label wallLabel2;
        private System.Windows.Forms.Label foundationLabel;
        private System.Windows.Forms.Button buildButton;
    }
}

