namespace Lesson_10_TabControl
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHTML = new System.Windows.Forms.TabPage();
            this.tabCSS = new System.Windows.Forms.TabPage();
            this.tabJS = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabHTML.SuspendLayout();
            this.tabCSS.SuspendLayout();
            this.tabJS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHTML);
            this.tabControl1.Controls.Add(this.tabCSS);
            this.tabControl1.Controls.Add(this.tabJS);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHTML
            // 
            this.tabHTML.Controls.Add(this.button2);
            this.tabHTML.Controls.Add(this.button1);
            this.tabHTML.Controls.Add(this.label2);
            this.tabHTML.Controls.Add(this.label1);
            this.tabHTML.ImageIndex = 0;
            this.tabHTML.Location = new System.Drawing.Point(4, 26);
            this.tabHTML.Name = "tabHTML";
            this.tabHTML.Padding = new System.Windows.Forms.Padding(3);
            this.tabHTML.Size = new System.Drawing.Size(647, 370);
            this.tabHTML.TabIndex = 0;
            this.tabHTML.Text = "HTML";
            this.tabHTML.UseVisualStyleBackColor = true;
            // 
            // tabCSS
            // 
            this.tabCSS.Controls.Add(this.label5);
            this.tabCSS.Controls.Add(this.label3);
            this.tabCSS.ImageIndex = 1;
            this.tabCSS.Location = new System.Drawing.Point(4, 26);
            this.tabCSS.Name = "tabCSS";
            this.tabCSS.Padding = new System.Windows.Forms.Padding(3);
            this.tabCSS.Size = new System.Drawing.Size(647, 370);
            this.tabCSS.TabIndex = 1;
            this.tabCSS.Text = "CSS";
            this.tabCSS.UseVisualStyleBackColor = true;
            // 
            // tabJS
            // 
            this.tabJS.Controls.Add(this.label6);
            this.tabJS.Controls.Add(this.label4);
            this.tabJS.ImageIndex = 2;
            this.tabJS.Location = new System.Drawing.Point(4, 26);
            this.tabJS.Name = "tabJS";
            this.tabJS.Size = new System.Drawing.Size(647, 370);
            this.tabJS.TabIndex = 2;
            this.tabJS.Text = "JavaScript";
            this.tabJS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giới thiệu";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(641, 346);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(641, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới thiệu";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(647, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới thiệu";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(641, 346);
            this.label5.TabIndex = 2;
            this.label5.Text = "Trong tin học, các tập tin định kiểu theo tầng – dịch từ tiếng Anh là Cascading S" +
    "tyle Sheets – được dùng để miêu tả cách trình bày các tài liệu viết bằng ngôn ng" +
    "ữ HTML và XHTML.";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(0, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(647, 352);
            this.label6.TabIndex = 2;
            this.label6.Text = "JavaScript, theo phiên bản hiện hành, là một ngôn ngữ lập trình kịch bản dựa trên" +
    " đối tượng được phát triển từ các ý niệm nguyên mẫu";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bersoft-html-print.gif");
            this.imageList1.Images.SetKeyName(1, "9f3073392ac0b5b1edba34efe91208ee.png");
            this.imageList1.Images.SetKeyName(2, "2100.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(61, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(177, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 50);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 400);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHTML.ResumeLayout(false);
            this.tabCSS.ResumeLayout(false);
            this.tabJS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHTML;
        private System.Windows.Forms.TabPage tabCSS;
        private System.Windows.Forms.TabPage tabJS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

