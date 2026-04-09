namespace BurgerKiosk
{
    partial class Form1
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
            grpMenu = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            rdoHam = new RadioButton();
            rdoBul = new RadioButton();
            rdoChi = new RadioButton();
            grpOption = new GroupBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpOrder = new GroupBox();
            lblError = new Label();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            label1 = new Label();
            btnOrder = new Button();
            btnClear = new Button();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(pictureBox1);
            grpMenu.Controls.Add(pictureBox2);
            grpMenu.Controls.Add(pictureBox3);
            grpMenu.Controls.Add(rdoHam);
            grpMenu.Controls.Add(rdoBul);
            grpMenu.Controls.Add(rdoChi);
            grpMenu.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.IndianRed;
            grpMenu.Location = new Point(22, 77);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(231, 339);
            grpMenu.TabIndex = 1;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Buger;
            pictureBox1.Location = new Point(123, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Bulggogi;
            pictureBox2.Location = new Point(123, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Shrimp;
            pictureBox3.Location = new Point(123, 241);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(102, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // rdoHam
            // 
            rdoHam.AutoSize = true;
            rdoHam.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoHam.ForeColor = Color.Maroon;
            rdoHam.Location = new Point(6, 69);
            rdoHam.Name = "rdoHam";
            rdoHam.Size = new Size(87, 29);
            rdoHam.TabIndex = 0;
            rdoHam.TabStop = true;
            rdoHam.Text = "햄버거";
            rdoHam.UseVisualStyleBackColor = true;
            // 
            // rdoBul
            // 
            rdoBul.AutoSize = true;
            rdoBul.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            rdoBul.ForeColor = Color.Maroon;
            rdoBul.Location = new Point(6, 155);
            rdoBul.Name = "rdoBul";
            rdoBul.Size = new Size(123, 29);
            rdoBul.TabIndex = 1;
            rdoBul.TabStop = true;
            rdoBul.Text = "불고기버거";
            rdoBul.UseVisualStyleBackColor = true;
            // 
            // rdoChi
            // 
            rdoChi.AutoSize = true;
            rdoChi.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            rdoChi.ForeColor = Color.Maroon;
            rdoChi.Location = new Point(6, 249);
            rdoChi.Name = "rdoChi";
            rdoChi.Size = new Size(105, 29);
            rdoChi.TabIndex = 2;
            rdoChi.TabStop = true;
            rdoChi.Text = "치킨버거";
            rdoChi.UseVisualStyleBackColor = true;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkPotato);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkSauce);
            grpOption.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.IndianRed;
            grpOption.Location = new Point(271, 77);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(168, 227);
            grpOption.TabIndex = 2;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            chkPotato.ForeColor = Color.Maroon;
            chkPotato.Location = new Point(6, 33);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(106, 29);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            chkCola.ForeColor = Color.Maroon;
            chkCola.Location = new Point(6, 79);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(70, 29);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            chkCheese.ForeColor = Color.Maroon;
            chkCheese.Location = new Point(6, 125);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(112, 29);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            chkSauce.ForeColor = Color.Maroon;
            chkSauce.Location = new Point(6, 173);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(112, 29);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblError);
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.IndianRed;
            grpOrder.Location = new Point(461, 77);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(327, 311);
            grpOrder.TabIndex = 3;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            lblError.Location = new Point(17, 249);
            lblError.Name = "lblError";
            lblError.Size = new Size(192, 25);
            lblError.TabIndex = 0;
            lblError.Text = "메뉴를 선택해 주세요!";
            lblError.Visible = false;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = SystemColors.Highlight;
            lblTotalCost.Location = new Point(17, 280);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(130, 28);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.ItemHeight = 28;
            lstOrder.Location = new Point(17, 38);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(294, 200);
            lstOrder.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 21F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(324, 47);
            label1.TabIndex = 0;
            label1.Text = "버거 주문 키오스크";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.MediumSeaGreen;
            btnOrder.Font = new Font("맑은 고딕", 15F);
            btnOrder.ForeColor = SystemColors.ButtonHighlight;
            btnOrder.Location = new Point(462, 394);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(156, 44);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(642, 394);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 44);
            btnClear.TabIndex = 5;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnOrder);
            Controls.Add(label1);
            Controls.Add(grpOption);
            Controls.Add(grpOrder);
            Controls.Add(grpMenu);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpMenu;
        private GroupBox grpOption;
        private GroupBox grpOrder;
        private Label label1;
        private Button btnOrder;
        private Button btnClear;
        private RadioButton rdoHam;
        private RadioButton rdoBul;
        private RadioButton rdoChi;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblError;
    }
}
