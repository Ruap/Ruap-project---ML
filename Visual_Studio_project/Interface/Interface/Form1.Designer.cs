namespace Interface
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
            System.Windows.Forms.Button btn_clear;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_request = new System.Windows.Forms.Button();
            this.lbl_result_title = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save_draw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnNormal = new System.Windows.Forms.RadioButton();
            this.radioBtnInverse = new System.Windows.Forms.RadioButton();
            this.btn_exitApp = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.BackColor = System.Drawing.Color.Transparent;
            btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_clear.ForeColor = System.Drawing.Color.Transparent;
            btn_clear.Location = new System.Drawing.Point(540, 292);
            btn_clear.Margin = new System.Windows.Forms.Padding(0);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new System.Drawing.Size(93, 41);
            btn_clear.TabIndex = 10;
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Image = ((System.Drawing.Image)(resources.GetObject("canvas.Image")));
            this.canvas.Location = new System.Drawing.Point(82, 57);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(279, 224);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Transparent;
            this.btn_open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_open.BackgroundImage")));
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_open.FlatAppearance.BorderSize = 0;
            this.btn_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.Color.Transparent;
            this.btn_open.Location = new System.Drawing.Point(82, 290);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(93, 40);
            this.btn_open.TabIndex = 1;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_request
            // 
            this.btn_request.BackColor = System.Drawing.Color.Transparent;
            this.btn_request.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_request.BackgroundImage")));
            this.btn_request.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_request.FlatAppearance.BorderSize = 0;
            this.btn_request.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_request.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_request.ForeColor = System.Drawing.Color.Transparent;
            this.btn_request.Location = new System.Drawing.Point(269, 290);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(92, 41);
            this.btn_request.TabIndex = 3;
            this.btn_request.UseVisualStyleBackColor = false;
            this.btn_request.Click += new System.EventHandler(this.btn_request_Click);
            // 
            // lbl_result_title
            // 
            this.lbl_result_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_result_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_result_title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_result_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_result_title.Image")));
            this.lbl_result_title.Location = new System.Drawing.Point(89, 350);
            this.lbl_result_title.Name = "lbl_result_title";
            this.lbl_result_title.Size = new System.Drawing.Size(75, 20);
            this.lbl_result_title.TabIndex = 4;
            this.lbl_result_title.Text = "Result:";
            this.lbl_result_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_result
            // 
            this.lbl_result.BackColor = System.Drawing.Color.Transparent;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_result.Image = ((System.Drawing.Image)(resources.GetObject("lbl_result.Image")));
            this.lbl_result.Location = new System.Drawing.Point(163, 350);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(162, 20);
            this.lbl_result.TabIndex = 5;
            this.lbl_result.Text = "waiting for request...";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(406, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 224);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_save_draw
            // 
            this.btn_save_draw.BackColor = System.Drawing.Color.Transparent;
            this.btn_save_draw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save_draw.BackgroundImage")));
            this.btn_save_draw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_save_draw.FlatAppearance.BorderSize = 0;
            this.btn_save_draw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_save_draw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_save_draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_draw.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save_draw.Location = new System.Drawing.Point(403, 291);
            this.btn_save_draw.Name = "btn_save_draw";
            this.btn_save_draw.Size = new System.Drawing.Size(93, 42);
            this.btn_save_draw.TabIndex = 9;
            this.btn_save_draw.UseVisualStyleBackColor = false;
            this.btn_save_draw.Click += new System.EventHandler(this.btn_save_draw_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(386, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Draw a number (between 0 and 9) on canvas and then save and load.";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(79, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Load image on which is number from PC and then press \"Request\" button.";
            // 
            // radioBtnNormal
            // 
            this.radioBtnNormal.AutoSize = true;
            this.radioBtnNormal.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioBtnNormal.BackgroundImage")));
            this.radioBtnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioBtnNormal.Location = new System.Drawing.Point(438, 362);
            this.radioBtnNormal.Name = "radioBtnNormal";
            this.radioBtnNormal.Size = new System.Drawing.Size(188, 17);
            this.radioBtnNormal.TabIndex = 13;
            this.radioBtnNormal.TabStop = true;
            this.radioBtnNormal.Text = "Black tint, white background";
            this.radioBtnNormal.UseVisualStyleBackColor = false;
            // 
            // radioBtnInverse
            // 
            this.radioBtnInverse.AutoSize = true;
            this.radioBtnInverse.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnInverse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioBtnInverse.BackgroundImage")));
            this.radioBtnInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioBtnInverse.Location = new System.Drawing.Point(438, 341);
            this.radioBtnInverse.Name = "radioBtnInverse";
            this.radioBtnInverse.Size = new System.Drawing.Size(190, 17);
            this.radioBtnInverse.TabIndex = 14;
            this.radioBtnInverse.TabStop = true;
            this.radioBtnInverse.Text = "White tint, black background";
            this.radioBtnInverse.UseVisualStyleBackColor = false;
            // 
            // btn_exitApp
            // 
            this.btn_exitApp.BackColor = System.Drawing.Color.Transparent;
            this.btn_exitApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exitApp.BackgroundImage")));
            this.btn_exitApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exitApp.FlatAppearance.BorderSize = 0;
            this.btn_exitApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btn_exitApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_exitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitApp.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exitApp.Location = new System.Drawing.Point(648, 340);
            this.btn_exitApp.Name = "btn_exitApp";
            this.btn_exitApp.Size = new System.Drawing.Size(90, 40);
            this.btn_exitApp.TabIndex = 6;
            this.btn_exitApp.UseVisualStyleBackColor = false;
            this.btn_exitApp.Click += new System.EventHandler(this.btn_exitApp_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(86, 339);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(243, 40);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(384, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel2.BackgroundImage")));
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(377, 340);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(257, 40);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_result_title);
            this.Controls.Add(this.radioBtnInverse);
            this.Controls.Add(this.radioBtnNormal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(btn_clear);
            this.Controls.Add(this.btn_save_draw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_exitApp);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_request;
        private System.Windows.Forms.Label lbl_result_title;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save_draw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBtnNormal;
        private System.Windows.Forms.RadioButton radioBtnInverse;
        private System.Windows.Forms.Button btn_exitApp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

