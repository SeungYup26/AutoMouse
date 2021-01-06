
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.Label();
            this.yBox = new System.Windows.Forms.Label();
            this.xPointBox = new System.Windows.Forms.TextBox();
            this.yPointBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // xBox
            // 
            this.xBox.AutoSize = true;
            this.xBox.Location = new System.Drawing.Point(104, 21);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(11, 12);
            this.xBox.TabIndex = 3;
            this.xBox.Text = "0";
            // 
            // yBox
            // 
            this.yBox.AutoSize = true;
            this.yBox.Location = new System.Drawing.Point(104, 75);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(11, 12);
            this.yBox.TabIndex = 4;
            this.yBox.Text = "0";
            // 
            // xPointBox
            // 
            this.xPointBox.Location = new System.Drawing.Point(173, 18);
            this.xPointBox.Name = "xPointBox";
            this.xPointBox.Size = new System.Drawing.Size(183, 21);
            this.xPointBox.TabIndex = 5;
            // 
            // yPointBox
            // 
            this.yPointBox.Location = new System.Drawing.Point(173, 72);
            this.yPointBox.Name = "yPointBox";
            this.yPointBox.Size = new System.Drawing.Size(183, 21);
            this.yPointBox.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 174);
            this.Controls.Add(this.yPointBox);
            this.Controls.Add(this.xPointBox);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label xBox;
        private System.Windows.Forms.Label yBox;
        private System.Windows.Forms.TextBox xPointBox;
        private System.Windows.Forms.TextBox yPointBox;
        private System.Windows.Forms.Timer timer1;
    }
}

