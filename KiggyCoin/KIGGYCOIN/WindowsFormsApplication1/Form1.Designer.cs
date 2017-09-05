namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.btnACT = new System.Windows.Forms.Button();
            this.btnACP = new System.Windows.Forms.Button();
            this.btnCP = new System.Windows.Forms.Button();
            this.btnInterest = new System.Windows.Forms.Button();
            this.lblACTPrice = new System.Windows.Forms.Label();
            this.lblACPPrice = new System.Windows.Forms.Label();
            this.lblCPPrice = new System.Windows.Forms.Label();
            this.lblICPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblACTAmt = new System.Windows.Forms.Label();
            this.lblACPAmt = new System.Windows.Forms.Label();
            this.lblCPAmt = new System.Windows.Forms.Label();
            this.lblICAmt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coins :";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(117, 13);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(29, 31);
            this.lblCoins.TabIndex = 2;
            this.lblCoins.Text = "0";
            // 
            // btnACT
            // 
            this.btnACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACT.Location = new System.Drawing.Point(362, 61);
            this.btnACT.Name = "btnACT";
            this.btnACT.Size = new System.Drawing.Size(210, 33);
            this.btnACT.TabIndex = 3;
            this.btnACT.Text = "Auto Clicker Timer";
            this.btnACT.UseVisualStyleBackColor = true;
            // 
            // btnACP
            // 
            this.btnACP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACP.Location = new System.Drawing.Point(362, 131);
            this.btnACP.Name = "btnACP";
            this.btnACP.Size = new System.Drawing.Size(210, 33);
            this.btnACP.TabIndex = 4;
            this.btnACP.Text = "Auto Clicker Power";
            this.btnACP.UseVisualStyleBackColor = true;
            this.btnACP.Click += new System.EventHandler(this.btnACP_Click);
            // 
            // btnCP
            // 
            this.btnCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCP.Location = new System.Drawing.Point(362, 201);
            this.btnCP.Name = "btnCP";
            this.btnCP.Size = new System.Drawing.Size(210, 33);
            this.btnCP.TabIndex = 6;
            this.btnCP.Text = "Clicker Power";
            this.btnCP.UseVisualStyleBackColor = true;
            this.btnCP.Click += new System.EventHandler(this.btnCP_Click);
            // 
            // btnInterest
            // 
            this.btnInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterest.Location = new System.Drawing.Point(362, 271);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(210, 33);
            this.btnInterest.TabIndex = 7;
            this.btnInterest.Text = "Interest Coin";
            this.btnInterest.UseVisualStyleBackColor = true;
            // 
            // lblACTPrice
            // 
            this.lblACTPrice.AutoSize = true;
            this.lblACTPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTPrice.Location = new System.Drawing.Point(362, 97);
            this.lblACTPrice.Name = "lblACTPrice";
            this.lblACTPrice.Size = new System.Drawing.Size(29, 31);
            this.lblACTPrice.TabIndex = 8;
            this.lblACTPrice.Text = "0";
            // 
            // lblACPPrice
            // 
            this.lblACPPrice.AutoSize = true;
            this.lblACPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACPPrice.Location = new System.Drawing.Point(362, 167);
            this.lblACPPrice.Name = "lblACPPrice";
            this.lblACPPrice.Size = new System.Drawing.Size(29, 31);
            this.lblACPPrice.TabIndex = 9;
            this.lblACPPrice.Text = "0";
            // 
            // lblCPPrice
            // 
            this.lblCPPrice.AutoSize = true;
            this.lblCPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPPrice.Location = new System.Drawing.Point(362, 237);
            this.lblCPPrice.Name = "lblCPPrice";
            this.lblCPPrice.Size = new System.Drawing.Size(29, 31);
            this.lblCPPrice.TabIndex = 11;
            this.lblCPPrice.Text = "0";
            // 
            // lblICPrice
            // 
            this.lblICPrice.AutoSize = true;
            this.lblICPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICPrice.Location = new System.Drawing.Point(362, 307);
            this.lblICPrice.Name = "lblICPrice";
            this.lblICPrice.Size = new System.Drawing.Size(29, 31);
            this.lblICPrice.TabIndex = 12;
            this.lblICPrice.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "x";
            // 
            // lblACTAmt
            // 
            this.lblACTAmt.AutoSize = true;
            this.lblACTAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTAmt.Location = new System.Drawing.Point(612, 63);
            this.lblACTAmt.Name = "lblACTAmt";
            this.lblACTAmt.Size = new System.Drawing.Size(29, 31);
            this.lblACTAmt.TabIndex = 18;
            this.lblACTAmt.Text = "0";
            // 
            // lblACPAmt
            // 
            this.lblACPAmt.AutoSize = true;
            this.lblACPAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACPAmt.Location = new System.Drawing.Point(612, 133);
            this.lblACPAmt.Name = "lblACPAmt";
            this.lblACPAmt.Size = new System.Drawing.Size(29, 31);
            this.lblACPAmt.TabIndex = 19;
            this.lblACPAmt.Text = "0";
            // 
            // lblCPAmt
            // 
            this.lblCPAmt.AutoSize = true;
            this.lblCPAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPAmt.Location = new System.Drawing.Point(612, 203);
            this.lblCPAmt.Name = "lblCPAmt";
            this.lblCPAmt.Size = new System.Drawing.Size(29, 31);
            this.lblCPAmt.TabIndex = 21;
            this.lblCPAmt.Text = "0";
            // 
            // lblICAmt
            // 
            this.lblICAmt.AutoSize = true;
            this.lblICAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICAmt.Location = new System.Drawing.Point(612, 273);
            this.lblICAmt.Name = "lblICAmt";
            this.lblICAmt.Size = new System.Drawing.Size(29, 31);
            this.lblICAmt.TabIndex = 22;
            this.lblICAmt.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 354);
            this.Controls.Add(this.lblICAmt);
            this.Controls.Add(this.lblCPAmt);
            this.Controls.Add(this.lblACPAmt);
            this.Controls.Add(this.lblACTAmt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblICPrice);
            this.Controls.Add(this.lblCPPrice);
            this.Controls.Add(this.lblACPPrice);
            this.Controls.Add(this.lblACTPrice);
            this.Controls.Add(this.btnInterest);
            this.Controls.Add(this.btnCP);
            this.Controls.Add(this.btnACP);
            this.Controls.Add(this.btnACT);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "CatCoin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Button btnACT;
        private System.Windows.Forms.Button btnACP;
        private System.Windows.Forms.Button btnCP;
        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Label lblACTPrice;
        private System.Windows.Forms.Label lblACPPrice;
        private System.Windows.Forms.Label lblCPPrice;
        private System.Windows.Forms.Label lblICPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblACTAmt;
        private System.Windows.Forms.Label lblACPAmt;
        private System.Windows.Forms.Label lblCPAmt;
        private System.Windows.Forms.Label lblICAmt;
    }
}

