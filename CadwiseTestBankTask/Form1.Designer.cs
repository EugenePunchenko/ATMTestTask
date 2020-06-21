namespace CadwiseTestBankTask
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
            this.listBoxINFO = new System.Windows.Forms.ListBox();
            this.buttonAddCash = new System.Windows.Forms.Button();
            this.radioButtonFiftyRubbles = new System.Windows.Forms.RadioButton();
            this.radioButtonOneHundredRubbles = new System.Windows.Forms.RadioButton();
            this.buttonINFO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTenRubbles = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxINFO
            // 
            this.listBoxINFO.FormattingEnabled = true;
            this.listBoxINFO.Location = new System.Drawing.Point(135, 199);
            this.listBoxINFO.Name = "listBoxINFO";
            this.listBoxINFO.Size = new System.Drawing.Size(571, 134);
            this.listBoxINFO.TabIndex = 0;
            // 
            // buttonAddCash
            // 
            this.buttonAddCash.Location = new System.Drawing.Point(631, 79);
            this.buttonAddCash.Name = "buttonAddCash";
            this.buttonAddCash.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCash.TabIndex = 1;
            this.buttonAddCash.Text = "AddCash";
            this.buttonAddCash.UseVisualStyleBackColor = true;
            this.buttonAddCash.Click += new System.EventHandler(this.buttonAddCash_Click);
            // 
            // radioButtonFiftyRubbles
            // 
            this.radioButtonFiftyRubbles.AutoSize = true;
            this.radioButtonFiftyRubbles.Location = new System.Drawing.Point(48, 42);
            this.radioButtonFiftyRubbles.Name = "radioButtonFiftyRubbles";
            this.radioButtonFiftyRubbles.Size = new System.Drawing.Size(74, 17);
            this.radioButtonFiftyRubbles.TabIndex = 3;
            this.radioButtonFiftyRubbles.Text = "50 rubbles";
            this.radioButtonFiftyRubbles.UseVisualStyleBackColor = true;
            // 
            // radioButtonOneHundredRubbles
            // 
            this.radioButtonOneHundredRubbles.AutoSize = true;
            this.radioButtonOneHundredRubbles.Location = new System.Drawing.Point(48, 65);
            this.radioButtonOneHundredRubbles.Name = "radioButtonOneHundredRubbles";
            this.radioButtonOneHundredRubbles.Size = new System.Drawing.Size(80, 17);
            this.radioButtonOneHundredRubbles.TabIndex = 4;
            this.radioButtonOneHundredRubbles.Text = "100 rubbles";
            this.radioButtonOneHundredRubbles.UseVisualStyleBackColor = true;
            // 
            // buttonINFO
            // 
            this.buttonINFO.Location = new System.Drawing.Point(631, 125);
            this.buttonINFO.Name = "buttonINFO";
            this.buttonINFO.Size = new System.Drawing.Size(75, 23);
            this.buttonINFO.TabIndex = 5;
            this.buttonINFO.Text = "INFO";
            this.buttonINFO.UseVisualStyleBackColor = true;
            this.buttonINFO.Click += new System.EventHandler(this.buttonINFO_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTenRubbles);
            this.groupBox1.Controls.Add(this.radioButtonFiftyRubbles);
            this.groupBox1.Controls.Add(this.radioButtonOneHundredRubbles);
            this.groupBox1.Location = new System.Drawing.Point(407, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonTenRubbles
            // 
            this.radioButtonTenRubbles.AutoSize = true;
            this.radioButtonTenRubbles.Location = new System.Drawing.Point(48, 19);
            this.radioButtonTenRubbles.Name = "radioButtonTenRubbles";
            this.radioButtonTenRubbles.Size = new System.Drawing.Size(74, 17);
            this.radioButtonTenRubbles.TabIndex = 5;
            this.radioButtonTenRubbles.Text = "10 rubbles";
            this.radioButtonTenRubbles.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "PrintCash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonINFO);
            this.Controls.Add(this.buttonAddCash);
            this.Controls.Add(this.listBoxINFO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxINFO;
        private System.Windows.Forms.Button buttonAddCash;
        private System.Windows.Forms.RadioButton radioButtonFiftyRubbles;
        private System.Windows.Forms.RadioButton radioButtonOneHundredRubbles;
        private System.Windows.Forms.Button buttonINFO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTenRubbles;
        private System.Windows.Forms.Button button1;
    }
}

