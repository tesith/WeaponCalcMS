namespace WeaponCalcMS
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
            this.button1 = new System.Windows.Forms.Button();
            this.radioReboot = new System.Windows.Forms.RadioButton();
            this.radio100 = new System.Windows.Forms.RadioButton();
            this.radio70 = new System.Windows.Forms.RadioButton();
            this.radio30 = new System.Windows.Forms.RadioButton();
            this.radio15 = new System.Windows.Forms.RadioButton();
            this.textLevel = new System.Windows.Forms.TextBox();
            this.textUpgrade = new System.Windows.Forms.TextBox();
            this.textBasepower = new System.Windows.Forms.TextBox();
            this.textStarforce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textAdditionalPower = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "공격력?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioReboot
            // 
            this.radioReboot.AutoSize = true;
            this.radioReboot.Location = new System.Drawing.Point(185, 35);
            this.radioReboot.Name = "radioReboot";
            this.radioReboot.Size = new System.Drawing.Size(59, 16);
            this.radioReboot.TabIndex = 1;
            this.radioReboot.TabStop = true;
            this.radioReboot.Text = "리부트";
            this.radioReboot.UseVisualStyleBackColor = true;
            // 
            // radio100
            // 
            this.radio100.AutoSize = true;
            this.radio100.Location = new System.Drawing.Point(185, 57);
            this.radio100.Name = "radio100";
            this.radio100.Size = new System.Drawing.Size(51, 16);
            this.radio100.TabIndex = 2;
            this.radio100.TabStop = true;
            this.radio100.Text = "100%";
            this.radio100.UseVisualStyleBackColor = true;
            // 
            // radio70
            // 
            this.radio70.AutoSize = true;
            this.radio70.Location = new System.Drawing.Point(185, 79);
            this.radio70.Name = "radio70";
            this.radio70.Size = new System.Drawing.Size(45, 16);
            this.radio70.TabIndex = 3;
            this.radio70.TabStop = true;
            this.radio70.Text = "70%";
            this.radio70.UseVisualStyleBackColor = true;
            // 
            // radio30
            // 
            this.radio30.AutoSize = true;
            this.radio30.Location = new System.Drawing.Point(185, 101);
            this.radio30.Name = "radio30";
            this.radio30.Size = new System.Drawing.Size(45, 16);
            this.radio30.TabIndex = 4;
            this.radio30.TabStop = true;
            this.radio30.Text = "30%";
            this.radio30.UseVisualStyleBackColor = true;
            // 
            // radio15
            // 
            this.radio15.AutoSize = true;
            this.radio15.Location = new System.Drawing.Point(185, 123);
            this.radio15.Name = "radio15";
            this.radio15.Size = new System.Drawing.Size(45, 16);
            this.radio15.TabIndex = 5;
            this.radio15.TabStop = true;
            this.radio15.Text = "15%";
            this.radio15.UseVisualStyleBackColor = true;
            // 
            // textLevel
            // 
            this.textLevel.Location = new System.Drawing.Point(103, 12);
            this.textLevel.Name = "textLevel";
            this.textLevel.Size = new System.Drawing.Size(64, 21);
            this.textLevel.TabIndex = 6;
            // 
            // textUpgrade
            // 
            this.textUpgrade.Location = new System.Drawing.Point(103, 39);
            this.textUpgrade.Name = "textUpgrade";
            this.textUpgrade.Size = new System.Drawing.Size(64, 21);
            this.textUpgrade.TabIndex = 7;
            // 
            // textBasepower
            // 
            this.textBasepower.Location = new System.Drawing.Point(103, 66);
            this.textBasepower.Name = "textBasepower";
            this.textBasepower.Size = new System.Drawing.Size(64, 21);
            this.textBasepower.TabIndex = 8;
            // 
            // textStarforce
            // 
            this.textStarforce.Location = new System.Drawing.Point(103, 93);
            this.textStarforce.Name = "textStarforce";
            this.textStarforce.Size = new System.Drawing.Size(64, 21);
            this.textStarforce.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "렙제(착감X)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "작 횟수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "기본공격력";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "강화 수";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(101, 156);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(41, 12);
            this.labelResult.TabIndex = 14;
            this.labelResult.Text = "대기중";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "추옵";
            // 
            // textAdditionalPower
            // 
            this.textAdditionalPower.Location = new System.Drawing.Point(103, 120);
            this.textAdditionalPower.Name = "textAdditionalPower";
            this.textAdditionalPower.Size = new System.Drawing.Size(64, 21);
            this.textAdditionalPower.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "주흔 작";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "추옵 표";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 182);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textAdditionalPower);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textStarforce);
            this.Controls.Add(this.textBasepower);
            this.Controls.Add(this.textUpgrade);
            this.Controls.Add(this.textLevel);
            this.Controls.Add(this.radio15);
            this.Controls.Add(this.radio30);
            this.Controls.Add(this.radio70);
            this.Controls.Add(this.radio100);
            this.Controls.Add(this.radioReboot);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "무기 작 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioReboot;
        private System.Windows.Forms.RadioButton radio100;
        private System.Windows.Forms.RadioButton radio70;
        private System.Windows.Forms.RadioButton radio30;
        private System.Windows.Forms.RadioButton radio15;
        private System.Windows.Forms.TextBox textLevel;
        private System.Windows.Forms.TextBox textUpgrade;
        private System.Windows.Forms.TextBox textBasepower;
        private System.Windows.Forms.TextBox textStarforce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAdditionalPower;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

