namespace SalesManagerSystem.View
{
    partial class RegisterUser
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductValue = new System.Windows.Forms.Label();
            this.txtProductValue = new System.Windows.Forms.TextBox();
            this.cbxUnitMedium = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(297, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cadastro de Usuário";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(23, 74);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(80, 13);
            this.lblProductCode.TabIndex = 1;
            this.lblProductCode.Text = "Código Produto";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(26, 91);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(239, 20);
            this.txtProductCode.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(23, 138);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Nome Produto";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(26, 154);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(748, 20);
            this.txtProductName.TabIndex = 4;
            // 
            // lblProductValue
            // 
            this.lblProductValue.AutoSize = true;
            this.lblProductValue.Location = new System.Drawing.Point(23, 208);
            this.lblProductValue.Name = "lblProductValue";
            this.lblProductValue.Size = new System.Drawing.Size(71, 13);
            this.lblProductValue.TabIndex = 5;
            this.lblProductValue.Text = "Valor Produto";
            // 
            // txtProductValue
            // 
            this.txtProductValue.Location = new System.Drawing.Point(26, 225);
            this.txtProductValue.Name = "txtProductValue";
            this.txtProductValue.Size = new System.Drawing.Size(346, 20);
            this.txtProductValue.TabIndex = 6;
            // 
            // cbxUnitMedium
            // 
            this.cbxUnitMedium.FormattingEnabled = true;
            this.cbxUnitMedium.Location = new System.Drawing.Point(410, 224);
            this.cbxUnitMedium.Name = "cbxUnitMedium";
            this.cbxUnitMedium.Size = new System.Drawing.Size(364, 21);
            this.cbxUnitMedium.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(410, 295);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblMeasure
            // 
            this.lblMeasure.AutoSize = true;
            this.lblMeasure.Location = new System.Drawing.Point(410, 208);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(100, 13);
            this.lblMeasure.TabIndex = 10;
            this.lblMeasure.Text = "Unidade de Medida";
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 411);
            this.Controls.Add(this.lblMeasure);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbxUnitMedium);
            this.Controls.Add(this.txtProductValue);
            this.Controls.Add(this.lblProductValue);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblTitle);
            this.Name = "RegisterUser";
            this.Text = "Sistema de Gerenciamento de Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductValue;
        private System.Windows.Forms.TextBox txtProductValue;
        private System.Windows.Forms.ComboBox cbxUnitMedium;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblMeasure;
    }
}