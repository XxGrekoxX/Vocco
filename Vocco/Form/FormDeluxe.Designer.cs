namespace Vocco
{
    partial class FormDeluxe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeluxe));
            this.btnBook = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblBath = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDeluxe = new System.Windows.Forms.Label();
            this.lblRoomFeatures = new System.Windows.Forms.Label();
            this.dateTimeCheckIn = new System.Windows.Forms.DateTimePicker();
            this.cbmRoom = new System.Windows.Forms.ComboBox();
            this.cbmAdult = new System.Windows.Forms.ComboBox();
            this.cbmNights = new System.Windows.Forms.ComboBox();
            this.picBoxDoubleRoom = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBoxReturn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDoubleRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Location = new System.Drawing.Point(793, 67);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(121, 29);
            this.btnBook.TabIndex = 34;
            this.btnBook.Text = "Reservar";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(577, 311);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(201, 135);
            this.richTextBox2.TabIndex = 33;
            this.richTextBox2.Text = "• Ducha\n• Inodoro\n• Albornoces\n• Zapatillas\n• Artículos de tocador\n• Secador de p" +
    "elo";
            // 
            // lblBath
            // 
            this.lblBath.AutoSize = true;
            this.lblBath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBath.Location = new System.Drawing.Point(573, 265);
            this.lblBath.Name = "lblBath";
            this.lblBath.Size = new System.Drawing.Size(60, 23);
            this.lblBath.TabIndex = 32;
            this.lblBath.Text = "Baño";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(136, 311);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(197, 199);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "• Cama extra grande \n• Caja fuerte\n• Aire acondicionado\n• Calefacción\n• Insonoriz" +
    "ación\n• Plancha \n• Armario\n• Zona de estar\n• Sofá";
            // 
            // lblDeluxe
            // 
            this.lblDeluxe.AutoSize = true;
            this.lblDeluxe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeluxe.Location = new System.Drawing.Point(26, 21);
            this.lblDeluxe.Name = "lblDeluxe";
            this.lblDeluxe.Size = new System.Drawing.Size(191, 23);
            this.lblDeluxe.TabIndex = 30;
            this.lblDeluxe.Text = "Habitacion Deluxe";
            // 
            // lblRoomFeatures
            // 
            this.lblRoomFeatures.AutoSize = true;
            this.lblRoomFeatures.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomFeatures.Location = new System.Drawing.Point(132, 265);
            this.lblRoomFeatures.Name = "lblRoomFeatures";
            this.lblRoomFeatures.Size = new System.Drawing.Size(317, 23);
            this.lblRoomFeatures.TabIndex = 29;
            this.lblRoomFeatures.Text = "Comodidades de la habitación";
            // 
            // dateTimeCheckIn
            // 
            this.dateTimeCheckIn.Location = new System.Drawing.Point(14, 65);
            this.dateTimeCheckIn.Name = "dateTimeCheckIn";
            this.dateTimeCheckIn.Size = new System.Drawing.Size(200, 28);
            this.dateTimeCheckIn.TabIndex = 28;
            // 
            // cbmRoom
            // 
            this.cbmRoom.FormattingEnabled = true;
            this.cbmRoom.Items.AddRange(new object[] {
            "1 habitación",
            "2 habitaciones",
            "3 habitaciones",
            "4 habitaciones"});
            this.cbmRoom.Location = new System.Drawing.Point(443, 64);
            this.cbmRoom.Name = "cbmRoom";
            this.cbmRoom.Size = new System.Drawing.Size(121, 29);
            this.cbmRoom.TabIndex = 27;
            // 
            // cbmAdult
            // 
            this.cbmAdult.FormattingEnabled = true;
            this.cbmAdult.Items.AddRange(new object[] {
            "1 adulto",
            "2 adulto",
            "3 adulto",
            "4 adulto"});
            this.cbmAdult.Location = new System.Drawing.Point(618, 64);
            this.cbmAdult.Name = "cbmAdult";
            this.cbmAdult.Size = new System.Drawing.Size(121, 29);
            this.cbmAdult.TabIndex = 26;
            // 
            // cbmNights
            // 
            this.cbmNights.FormattingEnabled = true;
            this.cbmNights.Items.AddRange(new object[] {
            "2 noches",
            "3 noches",
            "4 noches",
            "5 noches",
            "6 noches"});
            this.cbmNights.Location = new System.Drawing.Point(268, 64);
            this.cbmNights.Name = "cbmNights";
            this.cbmNights.Size = new System.Drawing.Size(121, 29);
            this.cbmNights.TabIndex = 25;
            // 
            // picBoxDoubleRoom
            // 
            this.picBoxDoubleRoom.Location = new System.Drawing.Point(12, 12);
            this.picBoxDoubleRoom.Name = "picBoxDoubleRoom";
            this.picBoxDoubleRoom.Size = new System.Drawing.Size(976, 576);
            this.picBoxDoubleRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDoubleRoom.TabIndex = 24;
            this.picBoxDoubleRoom.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBoxReturn
            // 
            this.picBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("picBoxReturn.Image")));
            this.picBoxReturn.Location = new System.Drawing.Point(947, 12);
            this.picBoxReturn.Name = "picBoxReturn";
            this.picBoxReturn.Size = new System.Drawing.Size(41, 33);
            this.picBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxReturn.TabIndex = 35;
            this.picBoxReturn.TabStop = false;
            this.picBoxReturn.Click += new System.EventHandler(this.picBoxReturn_Click);
            this.picBoxReturn.MouseHover += new System.EventHandler(this.picBoxReturn_MouseHover);
            // 
            // FormDeluxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.picBoxReturn);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lblBath);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblDeluxe);
            this.Controls.Add(this.lblRoomFeatures);
            this.Controls.Add(this.dateTimeCheckIn);
            this.Controls.Add(this.cbmRoom);
            this.Controls.Add(this.cbmAdult);
            this.Controls.Add(this.cbmNights);
            this.Controls.Add(this.picBoxDoubleRoom);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDeluxe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeluxe";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDoubleRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lblBath;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblDeluxe;
        private System.Windows.Forms.Label lblRoomFeatures;
        private System.Windows.Forms.DateTimePicker dateTimeCheckIn;
        private System.Windows.Forms.ComboBox cbmRoom;
        private System.Windows.Forms.ComboBox cbmAdult;
        private System.Windows.Forms.ComboBox cbmNights;
        private System.Windows.Forms.PictureBox picBoxDoubleRoom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBoxReturn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}