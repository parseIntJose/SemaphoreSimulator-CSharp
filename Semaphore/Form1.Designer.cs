namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_semaphore = new System.Windows.Forms.PictureBox();
            this.pictureBox_car = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.pictureBox_yellow = new System.Windows.Forms.PictureBox();
            this.pictureBox_red = new System.Windows.Forms.PictureBox();
            this.pictureBox_green = new System.Windows.Forms.PictureBox();
            this.timer_yellow = new System.Windows.Forms.Timer(this.components);
            this.timer_100ms = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_greenB = new System.Windows.Forms.PictureBox();
            this.pictureBox_redB = new System.Windows.Forms.PictureBox();
            this.pictureBox_yellowB = new System.Windows.Forms.PictureBox();
            this.pictureBox_semaphoreB = new System.Windows.Forms.PictureBox();
            this.pictureBox_car2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_semaphore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_greenB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_redB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yellowB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_semaphoreB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_semaphore
            // 
            this.pictureBox_semaphore.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_semaphore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_semaphore.BackgroundImage")));
            this.pictureBox_semaphore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_semaphore.Location = new System.Drawing.Point(1039, 274);
            this.pictureBox_semaphore.Name = "pictureBox_semaphore";
            this.pictureBox_semaphore.Size = new System.Drawing.Size(232, 322);
            this.pictureBox_semaphore.TabIndex = 0;
            this.pictureBox_semaphore.TabStop = false;
            // 
            // pictureBox_car
            // 
            this.pictureBox_car.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_car.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_car.BackgroundImage")));
            this.pictureBox_car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_car.Location = new System.Drawing.Point(12, 386);
            this.pictureBox_car.Name = "pictureBox_car";
            this.pictureBox_car.Size = new System.Drawing.Size(313, 172);
            this.pictureBox_car.TabIndex = 1;
            this.pictureBox_car.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.Control;
            this.button_start.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_start.Location = new System.Drawing.Point(3, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(136, 64);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // pictureBox_yellow
            // 
            this.pictureBox_yellow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_yellow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_yellow.BackgroundImage")));
            this.pictureBox_yellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_yellow.Location = new System.Drawing.Point(1039, 274);
            this.pictureBox_yellow.Name = "pictureBox_yellow";
            this.pictureBox_yellow.Size = new System.Drawing.Size(232, 322);
            this.pictureBox_yellow.TabIndex = 3;
            this.pictureBox_yellow.TabStop = false;
            this.pictureBox_yellow.Visible = false;
            // 
            // pictureBox_red
            // 
            this.pictureBox_red.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_red.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_red.BackgroundImage")));
            this.pictureBox_red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_red.Location = new System.Drawing.Point(1039, 274);
            this.pictureBox_red.Name = "pictureBox_red";
            this.pictureBox_red.Size = new System.Drawing.Size(232, 322);
            this.pictureBox_red.TabIndex = 4;
            this.pictureBox_red.TabStop = false;
            this.pictureBox_red.Visible = false;
            // 
            // pictureBox_green
            // 
            this.pictureBox_green.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_green.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_green.BackgroundImage")));
            this.pictureBox_green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_green.Location = new System.Drawing.Point(1039, 274);
            this.pictureBox_green.Name = "pictureBox_green";
            this.pictureBox_green.Size = new System.Drawing.Size(232, 322);
            this.pictureBox_green.TabIndex = 5;
            this.pictureBox_green.TabStop = false;
            this.pictureBox_green.Visible = false;
            // 
            // timer_yellow
            // 
            this.timer_yellow.Interval = 3000;
            this.timer_yellow.Tick += new System.EventHandler(this.timer_yellow_Tick);
            // 
            // timer_100ms
            // 
            this.timer_100ms.Tick += new System.EventHandler(this.timer_100ms_Tick);
            // 
            // pictureBox_greenB
            // 
            this.pictureBox_greenB.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_greenB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_greenB.BackgroundImage")));
            this.pictureBox_greenB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_greenB.Location = new System.Drawing.Point(145, -21);
            this.pictureBox_greenB.Name = "pictureBox_greenB";
            this.pictureBox_greenB.Size = new System.Drawing.Size(232, 322);
            this.pictureBox_greenB.TabIndex = 6;
            this.pictureBox_greenB.TabStop = false;
            this.pictureBox_greenB.Visible = false;
            // 
            // pictureBox_redB
            // 
            this.pictureBox_redB.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_redB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_redB.BackgroundImage")));
            this.pictureBox_redB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_redB.Location = new System.Drawing.Point(145, -21);
            this.pictureBox_redB.Name = "pictureBox_redB";
            this.pictureBox_redB.Size = new System.Drawing.Size(232, 322);
            this.pictureBox_redB.TabIndex = 7;
            this.pictureBox_redB.TabStop = false;
            this.pictureBox_redB.Visible = false;
            // 
            // pictureBox_yellowB
            // 
            this.pictureBox_yellowB.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_yellowB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_yellowB.BackgroundImage")));
            this.pictureBox_yellowB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_yellowB.Location = new System.Drawing.Point(145, -21);
            this.pictureBox_yellowB.Name = "pictureBox_yellowB";
            this.pictureBox_yellowB.Size = new System.Drawing.Size(232, 322);
            this.pictureBox_yellowB.TabIndex = 8;
            this.pictureBox_yellowB.TabStop = false;
            this.pictureBox_yellowB.Visible = false;
            // 
            // pictureBox_semaphoreB
            // 
            this.pictureBox_semaphoreB.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_semaphoreB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_semaphoreB.BackgroundImage")));
            this.pictureBox_semaphoreB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_semaphoreB.Location = new System.Drawing.Point(145, -21);
            this.pictureBox_semaphoreB.Name = "pictureBox_semaphoreB";
            this.pictureBox_semaphoreB.Size = new System.Drawing.Size(232, 322);
            this.pictureBox_semaphoreB.TabIndex = 9;
            this.pictureBox_semaphoreB.TabStop = false;
            // 
            // pictureBox_car2
            // 
            this.pictureBox_car2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_car2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_car2.BackgroundImage")));
            this.pictureBox_car2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_car2.Location = new System.Drawing.Point(955, 71);
            this.pictureBox_car2.Name = "pictureBox_car2";
            this.pictureBox_car2.Size = new System.Drawing.Size(342, 213);
            this.pictureBox_car2.TabIndex = 10;
            this.pictureBox_car2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 641);
            this.Controls.Add(this.pictureBox_car2);
            this.Controls.Add(this.pictureBox_semaphoreB);
            this.Controls.Add(this.pictureBox_yellowB);
            this.Controls.Add(this.pictureBox_redB);
            this.Controls.Add(this.pictureBox_greenB);
            this.Controls.Add(this.pictureBox_green);
            this.Controls.Add(this.pictureBox_red);
            this.Controls.Add(this.pictureBox_yellow);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox_car);
            this.Controls.Add(this.pictureBox_semaphore);
            this.Name = "Form1";
            this.Text = "SemaphoreSimulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_semaphore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_greenB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_redB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yellowB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_semaphoreB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox_semaphore;
        private PictureBox pictureBox_car;
        private Button button_start;
        private PictureBox pictureBox_yellow;
        private PictureBox pictureBox_red;
        private PictureBox pictureBox_green;
        private System.Windows.Forms.Timer timer_yellow;
        private System.Windows.Forms.Timer timer_100ms;
        private PictureBox pictureBox_greenB;
        private PictureBox pictureBox_redB;
        private PictureBox pictureBox_yellowB;
        private PictureBox pictureBox_semaphoreB;
        private PictureBox pictureBox_car2;
    }
}