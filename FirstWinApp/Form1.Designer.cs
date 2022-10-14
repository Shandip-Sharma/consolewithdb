namespace FirstWinApp
{
    partial class Calculator
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
            this.lbl_firstNum = new System.Windows.Forms.Label();
            this.lbl_secondNum = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btmAdd = new System.Windows.Forms.Button();
            this.btmSubstract = new System.Windows.Forms.Button();
            this.btmMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_firstNum
            // 
            this.lbl_firstNum.AutoSize = true;
            this.lbl_firstNum.Location = new System.Drawing.Point(29, 43);
            this.lbl_firstNum.Name = "lbl_firstNum";
            this.lbl_firstNum.Size = new System.Drawing.Size(76, 15);
            this.lbl_firstNum.TabIndex = 0;
            this.lbl_firstNum.Text = "First Number";
            // 
            // lbl_secondNum
            // 
            this.lbl_secondNum.AutoSize = true;
            this.lbl_secondNum.Location = new System.Drawing.Point(29, 75);
            this.lbl_secondNum.Name = "lbl_secondNum";
            this.lbl_secondNum.Size = new System.Drawing.Size(93, 15);
            this.lbl_secondNum.TabIndex = 1;
            this.lbl_secondNum.Text = "Second Number";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(158, 35);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(133, 23);
            this.txtFirstNum.TabIndex = 2;
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(158, 72);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(133, 23);
            this.txtSecondNum.TabIndex = 3;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(38, 113);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(39, 15);
            this.lbl_result.TabIndex = 4;
            this.lbl_result.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(158, 114);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(133, 23);
            this.txtResult.TabIndex = 5;
            // 
            // btmAdd
            // 
            this.btmAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btmAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmAdd.ForeColor = System.Drawing.Color.Black;
            this.btmAdd.Location = new System.Drawing.Point(12, 167);
            this.btmAdd.Name = "btmAdd";
            this.btmAdd.Size = new System.Drawing.Size(65, 23);
            this.btmAdd.TabIndex = 6;
            this.btmAdd.Text = "Add";
            this.btmAdd.UseVisualStyleBackColor = false;
            this.btmAdd.Click += new System.EventHandler(this.btmAdd_Click);
            // 
            // btmSubstract
            // 
            this.btmSubstract.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btmSubstract.Location = new System.Drawing.Point(104, 167);
            this.btmSubstract.Name = "btmSubstract";
            this.btmSubstract.Size = new System.Drawing.Size(75, 23);
            this.btmSubstract.TabIndex = 7;
            this.btmSubstract.Text = "Substract";
            this.btmSubstract.UseVisualStyleBackColor = false;
            // 
            // btmMultiply
            // 
            this.btmMultiply.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btmMultiply.Location = new System.Drawing.Point(185, 167);
            this.btmMultiply.Name = "btmMultiply";
            this.btmMultiply.Size = new System.Drawing.Size(75, 23);
            this.btmMultiply.TabIndex = 8;
            this.btmMultiply.Text = "Multiply";
            this.btmMultiply.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDivide.Location = new System.Drawing.Point(296, 167);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 244);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btmMultiply);
            this.Controls.Add(this.btmSubstract);
            this.Controls.Add(this.btmAdd);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.lbl_secondNum);
            this.Controls.Add(this.lbl_firstNum);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_firstNum;
        private Label lbl_secondNum;
        private TextBox txtFirstNum;
        private TextBox txtSecondNum;
        private Label lbl_result;
        private TextBox txtResult;
        private Button btmAdd;
        private Button btmSubstract;
        private Button btmMultiply;
        private Button btnDivide;
    }
}