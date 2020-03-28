namespace YOLO_TO_AUTOML
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gsPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.LinkLabel();
            this.localPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.LinkLabel();
            this.csvPath = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gsPathAppend = new System.Windows.Forms.TextBox();
            this.labelMap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gsPath
            // 
            this.gsPath.Location = new System.Drawing.Point(218, 6);
            this.gsPath.Name = "gsPath";
            this.gsPath.Size = new System.Drawing.Size(430, 21);
            this.gsPath.TabIndex = 0;
            this.gsPath.Text = "gs://curl_stones/dataset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cloud Storage Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 12);
            this.label2.TabIndex = 2;
            this.label2.TabStop = true;
            this.label2.Text = "Your img path (txt included folder)";
            this.label2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label2_LinkClicked);
            // 
            // localPath
            // 
            this.localPath.Location = new System.Drawing.Point(218, 58);
            this.localPath.Name = "localPath";
            this.localPath.Size = new System.Drawing.Size(430, 21);
            this.localPath.TabIndex = 3;
            this.localPath.Text = "C:\\Users\\Park\\Downloads\\windows_v1.8.0\\txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 12);
            this.label3.TabIndex = 4;
            this.label3.TabStop = true;
            this.label3.Text = "Output CSV path";
            this.label3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label3_LinkClicked);
            // 
            // csvPath
            // 
            this.csvPath.Location = new System.Drawing.Point(218, 85);
            this.csvPath.Name = "csvPath";
            this.csvPath.Size = new System.Drawing.Size(430, 21);
            this.csvPath.TabIndex = 5;
            this.csvPath.Text = "test.csv";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(654, 6);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(99, 48);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Append for Filename(Google)";
            // 
            // gsPathAppend
            // 
            this.gsPathAppend.Location = new System.Drawing.Point(218, 33);
            this.gsPathAppend.Name = "gsPathAppend";
            this.gsPathAppend.Size = new System.Drawing.Size(430, 21);
            this.gsPathAppend.TabIndex = 8;
            this.gsPathAppend.Text = "-2020-03-28T03:01:10.593Z";
            // 
            // labelMap
            // 
            this.labelMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMap.Location = new System.Drawing.Point(218, 113);
            this.labelMap.Multiline = true;
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(430, 108);
            this.labelMap.TabIndex = 9;
            this.labelMap.Text = "red_stone\r\nyellow_stone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 12);
            this.label5.TabIndex = 10;
            this.label5.TabStop = true;
            this.label5.Text = "Labelmap (Your classes)";
            this.label5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label5_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Instructions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 233);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMap);
            this.Controls.Add(this.gsPathAppend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.csvPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.localPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gsPath);
            this.Name = "Form1";
            this.Text = "YOLO-TO-AUTOML-WINDOWS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gsPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel label2;
        private System.Windows.Forms.TextBox localPath;
        private System.Windows.Forms.LinkLabel label3;
        private System.Windows.Forms.TextBox csvPath;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gsPathAppend;
        private System.Windows.Forms.TextBox labelMap;
        private System.Windows.Forms.LinkLabel label5;
        private System.Windows.Forms.Button button1;
    }
}

