namespace Алгоритмы
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNumberOne = new System.Windows.Forms.TabPage();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxReply = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxForZ = new System.Windows.Forms.TextBox();
            this.txtbxForY = new System.Windows.Forms.TextBox();
            this.txtbxForX = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageNumberTwo = new System.Windows.Forms.TabPage();
            this.btnGetAnswer = new System.Windows.Forms.Button();
            this.txtbxAnswer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxForYNumberTwo = new System.Windows.Forms.TextBox();
            this.txtbxForXNumberTwo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnExpX = new System.Windows.Forms.RadioButton();
            this.rbtnSqrX = new System.Windows.Forms.RadioButton();
            this.rbtnCosX = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageNumberOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageNumberTwo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNumberOne);
            this.tabControl1.Controls.Add(this.tabPageNumberTwo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(407, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageNumberOne
            // 
            this.tabPageNumberOne.Controls.Add(this.btnCalculation);
            this.tabPageNumberOne.Controls.Add(this.label4);
            this.tabPageNumberOne.Controls.Add(this.label3);
            this.tabPageNumberOne.Controls.Add(this.label2);
            this.tabPageNumberOne.Controls.Add(this.txtbxReply);
            this.tabPageNumberOne.Controls.Add(this.label1);
            this.tabPageNumberOne.Controls.Add(this.txtbxForZ);
            this.tabPageNumberOne.Controls.Add(this.txtbxForY);
            this.tabPageNumberOne.Controls.Add(this.txtbxForX);
            this.tabPageNumberOne.Controls.Add(this.pictureBox1);
            this.tabPageNumberOne.Location = new System.Drawing.Point(4, 22);
            this.tabPageNumberOne.Name = "tabPageNumberOne";
            this.tabPageNumberOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNumberOne.Size = new System.Drawing.Size(399, 357);
            this.tabPageNumberOne.TabIndex = 0;
            this.tabPageNumberOne.Text = "Линейный алгоритм";
            this.tabPageNumberOne.UseVisualStyleBackColor = true;
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(6, 119);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(387, 37);
            this.btnCalculation.TabIndex = 1;
            this.btnCalculation.Text = "Получить ответ";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // txtbxReply
            // 
            this.txtbxReply.Location = new System.Drawing.Point(6, 162);
            this.txtbxReply.Multiline = true;
            this.txtbxReply.Name = "txtbxReply";
            this.txtbxReply.ReadOnly = true;
            this.txtbxReply.Size = new System.Drawing.Size(387, 189);
            this.txtbxReply.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите значения x, y, z в поля соответственно";
            // 
            // txtbxForZ
            // 
            this.txtbxForZ.Location = new System.Drawing.Point(294, 86);
            this.txtbxForZ.Name = "txtbxForZ";
            this.txtbxForZ.Size = new System.Drawing.Size(80, 20);
            this.txtbxForZ.TabIndex = 1;
            // 
            // txtbxForY
            // 
            this.txtbxForY.Location = new System.Drawing.Point(166, 86);
            this.txtbxForY.Name = "txtbxForY";
            this.txtbxForY.Size = new System.Drawing.Size(80, 20);
            this.txtbxForY.TabIndex = 1;
            // 
            // txtbxForX
            // 
            this.txtbxForX.Location = new System.Drawing.Point(35, 86);
            this.txtbxForX.Name = "txtbxForX";
            this.txtbxForX.Size = new System.Drawing.Size(80, 20);
            this.txtbxForX.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageNumberTwo
            // 
            this.tabPageNumberTwo.BackColor = System.Drawing.Color.White;
            this.tabPageNumberTwo.Controls.Add(this.btnGetAnswer);
            this.tabPageNumberTwo.Controls.Add(this.txtbxAnswer);
            this.tabPageNumberTwo.Controls.Add(this.label6);
            this.tabPageNumberTwo.Controls.Add(this.label5);
            this.tabPageNumberTwo.Controls.Add(this.txtbxForYNumberTwo);
            this.tabPageNumberTwo.Controls.Add(this.txtbxForXNumberTwo);
            this.tabPageNumberTwo.Controls.Add(this.groupBox1);
            this.tabPageNumberTwo.Controls.Add(this.pictureBox2);
            this.tabPageNumberTwo.Location = new System.Drawing.Point(4, 22);
            this.tabPageNumberTwo.Name = "tabPageNumberTwo";
            this.tabPageNumberTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNumberTwo.Size = new System.Drawing.Size(399, 357);
            this.tabPageNumberTwo.TabIndex = 1;
            this.tabPageNumberTwo.Text = "Разветвляющийся алгоритм";
            // 
            // btnGetAnswer
            // 
            this.btnGetAnswer.Location = new System.Drawing.Point(6, 216);
            this.btnGetAnswer.Name = "btnGetAnswer";
            this.btnGetAnswer.Size = new System.Drawing.Size(387, 37);
            this.btnGetAnswer.TabIndex = 7;
            this.btnGetAnswer.Text = "Получить ответ";
            this.btnGetAnswer.UseVisualStyleBackColor = true;
            this.btnGetAnswer.Click += new System.EventHandler(this.btnGetAnswer_Click);
            // 
            // txtbxAnswer
            // 
            this.txtbxAnswer.Location = new System.Drawing.Point(6, 259);
            this.txtbxAnswer.Multiline = true;
            this.txtbxAnswer.Name = "txtbxAnswer";
            this.txtbxAnswer.ReadOnly = true;
            this.txtbxAnswer.Size = new System.Drawing.Size(387, 92);
            this.txtbxAnswer.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "X";
            // 
            // txtbxForYNumberTwo
            // 
            this.txtbxForYNumberTwo.Location = new System.Drawing.Point(51, 175);
            this.txtbxForYNumberTwo.Name = "txtbxForYNumberTwo";
            this.txtbxForYNumberTwo.Size = new System.Drawing.Size(100, 20);
            this.txtbxForYNumberTwo.TabIndex = 3;
            // 
            // txtbxForXNumberTwo
            // 
            this.txtbxForXNumberTwo.Location = new System.Drawing.Point(51, 129);
            this.txtbxForXNumberTwo.Name = "txtbxForXNumberTwo";
            this.txtbxForXNumberTwo.Size = new System.Drawing.Size(100, 20);
            this.txtbxForXNumberTwo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnExpX);
            this.groupBox1.Controls.Add(this.rbtnSqrX);
            this.groupBox1.Controls.Add(this.rbtnCosX);
            this.groupBox1.Location = new System.Drawing.Point(193, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите функцию";
            // 
            // rbtnExpX
            // 
            this.rbtnExpX.AutoSize = true;
            this.rbtnExpX.Location = new System.Drawing.Point(17, 68);
            this.rbtnExpX.Name = "rbtnExpX";
            this.rbtnExpX.Size = new System.Drawing.Size(56, 17);
            this.rbtnExpX.TabIndex = 2;
            this.rbtnExpX.TabStop = true;
            this.rbtnExpX.Text = "Exp(X)";
            this.rbtnExpX.UseVisualStyleBackColor = true;
            // 
            // rbtnSqrX
            // 
            this.rbtnSqrX.AutoSize = true;
            this.rbtnSqrX.Location = new System.Drawing.Point(17, 44);
            this.rbtnSqrX.Name = "rbtnSqrX";
            this.rbtnSqrX.Size = new System.Drawing.Size(54, 17);
            this.rbtnSqrX.TabIndex = 1;
            this.rbtnSqrX.TabStop = true;
            this.rbtnSqrX.Text = "Sqr(X)";
            this.rbtnSqrX.UseVisualStyleBackColor = true;
            // 
            // rbtnCosX
            // 
            this.rbtnCosX.AutoSize = true;
            this.rbtnCosX.Location = new System.Drawing.Point(17, 20);
            this.rbtnCosX.Name = "rbtnCosX";
            this.rbtnCosX.Size = new System.Drawing.Size(56, 17);
            this.rbtnCosX.TabIndex = 0;
            this.rbtnCosX.TabStop = true;
            this.rbtnCosX.Text = "Cos(X)";
            this.rbtnCosX.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(16, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(403, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая работа";
            this.tabControl1.ResumeLayout(false);
            this.tabPageNumberOne.ResumeLayout(false);
            this.tabPageNumberOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageNumberTwo.ResumeLayout(false);
            this.tabPageNumberTwo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNumberOne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageNumberTwo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxReply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxForY;
        private System.Windows.Forms.TextBox txtbxForX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxForZ;
        private System.Windows.Forms.Button btnGetAnswer;
        private System.Windows.Forms.TextBox txtbxAnswer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxForYNumberTwo;
        private System.Windows.Forms.TextBox txtbxForXNumberTwo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnExpX;
        private System.Windows.Forms.RadioButton rbtnSqrX;
        private System.Windows.Forms.RadioButton rbtnCosX;
    }
}

