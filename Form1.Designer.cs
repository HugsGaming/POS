namespace POS
{
    partial class MainApp
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
            this.foodList = new System.Windows.Forms.ListBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.TextBox();
            this.AddFoodToList = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.Payment = new System.Windows.Forms.Button();
            this.Chang = new System.Windows.Forms.Button();
            this.NextSale = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.food6 = new System.Windows.Forms.Button();
            this.food3 = new System.Windows.Forms.Button();
            this.food1 = new System.Windows.Forms.Button();
            this.food7 = new System.Windows.Forms.Button();
            this.food2 = new System.Windows.Forms.Button();
            this.food4 = new System.Windows.Forms.Button();
            this.food8 = new System.Windows.Forms.Button();
            this.food9 = new System.Windows.Forms.Button();
            this.food10 = new System.Windows.Forms.Button();
            this.food5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // foodList
            // 
            this.foodList.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodList.FormattingEnabled = true;
            this.foodList.ItemHeight = 31;
            this.foodList.Location = new System.Drawing.Point(1335, 142);
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(709, 469);
            this.foodList.TabIndex = 1;
            this.foodList.SelectedIndexChanged += new System.EventHandler(this.RemoveItemFromList);
            // 
            // amount
            // 
            this.amount.Enabled = false;
            this.amount.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.amount.Location = new System.Drawing.Point(184, 142);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(1145, 107);
            this.amount.TabIndex = 5;
            this.amount.Text = "0.00";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPayment);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS.Properties.Resources.KGB;
            this.pictureBox1.Location = new System.Drawing.Point(184, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // OperationLabel
            // 
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.Font = new System.Drawing.Font("Gill Sans MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.OperationLabel.Location = new System.Drawing.Point(184, 28);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(225, 111);
            this.OperationLabel.TabIndex = 8;
            this.OperationLabel.Text = "Sale:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-1, 881);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2048, 202);
            this.panel2.TabIndex = 10;
            // 
            // description
            // 
            this.description.Enabled = false;
            this.description.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(400, 539);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(703, 45);
            this.description.TabIndex = 2;
            // 
            // AddFoodToList
            // 
            this.AddFoodToList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.AddFoodToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFoodToList.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoodToList.Location = new System.Drawing.Point(1109, 539);
            this.AddFoodToList.Name = "AddFoodToList";
            this.AddFoodToList.Size = new System.Drawing.Size(190, 47);
            this.AddFoodToList.TabIndex = 4;
            this.AddFoodToList.Text = "Add Item";
            this.AddFoodToList.UseVisualStyleBackColor = false;
            this.AddFoodToList.Click += new System.EventHandler(this.AddFoodToList_Click);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(294, 541);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 45);
            this.quantity.TabIndex = 3;
            this.quantity.Text = "1";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.Payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Payment.Enabled = false;
            this.Payment.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(1335, 615);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(249, 94);
            this.Payment.TabIndex = 6;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = false;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // Chang
            // 
            this.Chang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.Chang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chang.Enabled = false;
            this.Chang.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chang.Location = new System.Drawing.Point(1335, 715);
            this.Chang.Name = "Chang";
            this.Chang.Size = new System.Drawing.Size(249, 94);
            this.Chang.TabIndex = 6;
            this.Chang.Text = "Change";
            this.Chang.UseVisualStyleBackColor = false;
            this.Chang.Click += new System.EventHandler(this.Change_Click);
            // 
            // NextSale
            // 
            this.NextSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.NextSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextSale.Enabled = false;
            this.NextSale.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextSale.Location = new System.Drawing.Point(1590, 615);
            this.NextSale.Name = "NextSale";
            this.NextSale.Size = new System.Drawing.Size(252, 94);
            this.NextSale.TabIndex = 6;
            this.NextSale.Text = "Next Sale";
            this.NextSale.UseVisualStyleBackColor = false;
            this.NextSale.Click += new System.EventHandler(this.NextSale_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1590, 715);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(252, 94);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.ExitForm);
            // 
            // food6
            // 
            this.food6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.food6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.food6.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food6.Location = new System.Drawing.Point(449, 399);
            this.food6.Name = "food6";
            this.food6.Size = new System.Drawing.Size(171, 134);
            this.food6.TabIndex = 0;
            this.food6.Text = "Denis Rodman\'s Korean BBQ@165.00";
            this.food6.UseVisualStyleBackColor = false;
            this.food6.Click += new System.EventHandler(this.AddFood);
            // 
            // food3
            // 
            this.food3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.food3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.food3.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food3.Location = new System.Drawing.Point(803, 259);
            this.food3.Name = "food3";
            this.food3.Size = new System.Drawing.Size(171, 134);
            this.food3.TabIndex = 0;
            this.food3.Text = "Tsar\'s Peperoni Pizza@350.00";
            this.food3.UseVisualStyleBackColor = false;
            this.food3.Click += new System.EventHandler(this.AddFood);
            // 
            // food1
            // 
            this.food1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.food1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.food1.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food1.Location = new System.Drawing.Point(449, 259);
            this.food1.Name = "food1";
            this.food1.Size = new System.Drawing.Size(171, 134);
            this.food1.TabIndex = 0;
            this.food1.Text = "Potato Burger@125.00";
            this.food1.UseVisualStyleBackColor = false;
            this.food1.Click += new System.EventHandler(this.AddFood);
            // 
            // food7
            // 
            this.food7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.food7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.food7.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food7.Location = new System.Drawing.Point(626, 399);
            this.food7.Name = "food7";
            this.food7.Size = new System.Drawing.Size(171, 134);
            this.food7.TabIndex = 0;
            this.food7.Text = "Cuban Nuclear Hotdog@120.00";
            this.food7.UseVisualStyleBackColor = false;
            this.food7.Click += new System.EventHandler(this.AddFood);
            // 
            // food2
            // 
            this.food2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.food2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.food2.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food2.Location = new System.Drawing.Point(626, 259);
            this.food2.Name = "food2";
            this.food2.Size = new System.Drawing.Size(171, 134);
            this.food2.TabIndex = 0;
            this.food2.Text = "Lenin\'s Potato@200.00";
            this.food2.UseVisualStyleBackColor = false;
            this.food2.Click += new System.EventHandler(this.AddFood);
            // 
            // food4
            // 
            this.food4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.food4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.food4.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food4.Location = new System.Drawing.Point(980, 259);
            this.food4.Name = "food4";
            this.food4.Size = new System.Drawing.Size(171, 134);
            this.food4.TabIndex = 0;
            this.food4.Text = "USSR Vodka@50.00";
            this.food4.UseVisualStyleBackColor = false;
            this.food4.Click += new System.EventHandler(this.AddFood);
            // 
            // food8
            // 
            this.food8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.food8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.food8.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food8.Location = new System.Drawing.Point(803, 399);
            this.food8.Name = "food8";
            this.food8.Size = new System.Drawing.Size(171, 134);
            this.food8.TabIndex = 0;
            this.food8.Text = "Mao\'s Shitsu Noodles@250.00";
            this.food8.UseVisualStyleBackColor = false;
            this.food8.Click += new System.EventHandler(this.AddFood);
            // 
            // food9
            // 
            this.food9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.food9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.food9.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food9.Location = new System.Drawing.Point(980, 399);
            this.food9.Name = "food9";
            this.food9.Size = new System.Drawing.Size(171, 134);
            this.food9.TabIndex = 0;
            this.food9.Text = "Western Spy Beer@150.00";
            this.food9.UseVisualStyleBackColor = false;
            this.food9.Click += new System.EventHandler(this.AddFood);
            // 
            // food10
            // 
            this.food10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.food10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.food10.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food10.Location = new System.Drawing.Point(1157, 399);
            this.food10.Name = "food10";
            this.food10.Size = new System.Drawing.Size(171, 134);
            this.food10.TabIndex = 0;
            this.food10.Text = "Equality Ice Cream@30.00";
            this.food10.UseVisualStyleBackColor = false;
            this.food10.Click += new System.EventHandler(this.AddFood);
            // 
            // food5
            // 
            this.food5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            this.food5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.food5.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food5.Location = new System.Drawing.Point(1157, 259);
            this.food5.Name = "food5";
            this.food5.Size = new System.Drawing.Size(171, 134);
            this.food5.TabIndex = 0;
            this.food5.Text = "Mother Russia\'s Wine@500.00";
            this.food5.UseVisualStyleBackColor = false;
            this.food5.Click += new System.EventHandler(this.AddFood);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1942, 1055);
            this.Controls.Add(this.AddFoodToList);
            this.Controls.Add(this.description);
            this.Controls.Add(this.Chang);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.food5);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.NextSale);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.foodList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.food10);
            this.Controls.Add(this.food8);
            this.Controls.Add(this.food4);
            this.Controls.Add(this.food2);
            this.Controls.Add(this.food7);
            this.Controls.Add(this.food1);
            this.Controls.Add(this.food6);
            this.Controls.Add(this.food3);
            this.Controls.Add(this.food9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainApp";
            this.Text = "Я люблю Советский Союз.";
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox foodList;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label OperationLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Chang;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button NextSale;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button AddFoodToList;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button food6;
        private System.Windows.Forms.Button food3;
        private System.Windows.Forms.Button food1;
        private System.Windows.Forms.Button food7;
        private System.Windows.Forms.Button food2;
        private System.Windows.Forms.Button food4;
        private System.Windows.Forms.Button food8;
        private System.Windows.Forms.Button food9;
        private System.Windows.Forms.Button food10;
        private System.Windows.Forms.Button food5;
    }
}

