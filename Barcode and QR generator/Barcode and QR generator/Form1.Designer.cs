namespace Barcode_and_QR_generator
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
            this.barCodeTextBox = new System.Windows.Forms.TextBox();
            this.qrCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateButton1 = new System.Windows.Forms.Button();
            this.generateButton2 = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // barCodeTextBox
            // 
            this.barCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barCodeTextBox.Location = new System.Drawing.Point(109, 23);
            this.barCodeTextBox.Name = "barCodeTextBox";
            this.barCodeTextBox.Size = new System.Drawing.Size(554, 34);
            this.barCodeTextBox.TabIndex = 0;
            // 
            // qrCodeTextBox
            // 
            this.qrCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrCodeTextBox.Location = new System.Drawing.Point(109, 76);
            this.qrCodeTextBox.Name = "qrCodeTextBox";
            this.qrCodeTextBox.Size = new System.Drawing.Size(554, 34);
            this.qrCodeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "QRcode:";
            // 
            // generateButton1
            // 
            this.generateButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton1.Location = new System.Drawing.Point(679, 21);
            this.generateButton1.Name = "generateButton1";
            this.generateButton1.Size = new System.Drawing.Size(109, 37);
            this.generateButton1.TabIndex = 4;
            this.generateButton1.Text = "Generate";
            this.generateButton1.UseVisualStyleBackColor = true;
            this.generateButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateButton2
            // 
            this.generateButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton2.Location = new System.Drawing.Point(679, 75);
            this.generateButton2.Name = "generateButton2";
            this.generateButton2.Size = new System.Drawing.Size(109, 37);
            this.generateButton2.TabIndex = 5;
            this.generateButton2.Text = "Generate";
            this.generateButton2.UseVisualStyleBackColor = true;
            this.generateButton2.Click += new System.EventHandler(this.generateButton2_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPictureBox.Location = new System.Drawing.Point(17, 143);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(771, 258);
            this.resultPictureBox.TabIndex = 6;
            this.resultPictureBox.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(327, 407);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(147, 50);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.generateButton2);
            this.Controls.Add(this.generateButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qrCodeTextBox);
            this.Controls.Add(this.barCodeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode & QR generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barCodeTextBox;
        private System.Windows.Forms.TextBox qrCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateButton1;
        private System.Windows.Forms.Button generateButton2;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Button saveButton;
    }
}

