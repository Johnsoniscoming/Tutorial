namespace BorrowAnd_Repay
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myNameInput = new System.Windows.Forms.TextBox();
            this.otherNameInput = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMy = new System.Windows.Forms.Label();
            this.lblmyMoney = new System.Windows.Forms.Label();
            this.lblotherMoney = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnRepay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Others Name :";
            // 
            // myNameInput
            // 
            this.myNameInput.Location = new System.Drawing.Point(202, 34);
            this.myNameInput.Name = "myNameInput";
            this.myNameInput.Size = new System.Drawing.Size(100, 29);
            this.myNameInput.TabIndex = 2;
            // 
            // otherNameInput
            // 
            this.otherNameInput.Location = new System.Drawing.Point(202, 75);
            this.otherNameInput.Name = "otherNameInput";
            this.otherNameInput.Size = new System.Drawing.Size(100, 29);
            this.otherNameInput.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(347, 38);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 65);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "How much :";
            // 
            // lblMy
            // 
            this.lblMy.AutoSize = true;
            this.lblMy.Location = new System.Drawing.Point(170, 144);
            this.lblMy.Name = "lblMy";
            this.lblMy.Size = new System.Drawing.Size(44, 18);
            this.lblMy.TabIndex = 7;
            this.lblMy.Text = "None";
            // 
            // lblmyMoney
            // 
            this.lblmyMoney.AutoSize = true;
            this.lblmyMoney.Location = new System.Drawing.Point(170, 175);
            this.lblmyMoney.Name = "lblmyMoney";
            this.lblmyMoney.Size = new System.Drawing.Size(16, 18);
            this.lblmyMoney.TabIndex = 8;
            this.lblmyMoney.Text = "0";
            // 
            // lblotherMoney
            // 
            this.lblotherMoney.AutoSize = true;
            this.lblotherMoney.Location = new System.Drawing.Point(434, 175);
            this.lblotherMoney.Name = "lblotherMoney";
            this.lblotherMoney.Size = new System.Drawing.Size(56, 18);
            this.lblotherMoney.TabIndex = 12;
            this.lblotherMoney.Text = "200000";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(434, 144);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(44, 18);
            this.lblOther.TabIndex = 11;
            this.lblOther.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "How much :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Name : ";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Enabled = false;
            this.btnBorrow.Location = new System.Drawing.Point(48, 214);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(430, 40);
            this.btnBorrow.TabIndex = 13;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnRepay
            // 
            this.btnRepay.Enabled = false;
            this.btnRepay.Location = new System.Drawing.Point(48, 270);
            this.btnRepay.Name = "btnRepay";
            this.btnRepay.Size = new System.Drawing.Size(430, 40);
            this.btnRepay.TabIndex = 14;
            this.btnRepay.Text = "Repay";
            this.btnRepay.UseVisualStyleBackColor = true;
            this.btnRepay.Click += new System.EventHandler(this.btnRepay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 349);
            this.Controls.Add(this.btnRepay);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.lblotherMoney);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblmyMoney);
            this.Controls.Add(this.lblMy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.otherNameInput);
            this.Controls.Add(this.myNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BorrowAndRepay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myNameInput;
        private System.Windows.Forms.TextBox otherNameInput;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMy;
        private System.Windows.Forms.Label lblmyMoney;
        private System.Windows.Forms.Label lblotherMoney;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnRepay;
    }
}

