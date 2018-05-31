namespace Game
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
            this.components = new System.ComponentModel.Container();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.t2 = new System.Windows.Forms.Timer(this.components);
            this.z = new System.Windows.Forms.Button();
            this.t3 = new System.Windows.Forms.Timer(this.components);
            this.t4 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Interval = 25;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // t2
            // 
            this.t2.Interval = 25;
            this.t2.Tick += new System.EventHandler(this.t2_Tick_1);
            // 
            // z
            // 
            this.z.BackColor = System.Drawing.Color.SpringGreen;
            this.z.Location = new System.Drawing.Point(393, 415);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(40, 40);
            this.z.TabIndex = 0;
            this.z.UseVisualStyleBackColor = false;
            // 
            // t3
            // 
            this.t3.Interval = 25;
            this.t3.Tick += new System.EventHandler(this.t3_Tick);
            // 
            // t4
            // 
            this.t4.Enabled = true;
            this.t4.Tick += new System.EventHandler(this.t4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.z);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Timer t2;
        private System.Windows.Forms.Button z;
        private System.Windows.Forms.Timer t3;
        private System.Windows.Forms.Timer t4;
    }
}

