namespace Vocco
{
    partial class FormSuite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuite));
            this.btnBook = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblBath = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblSuite = new System.Windows.Forms.Label();
            this.lblRoomFeatures = new System.Windows.Forms.Label();
            this.dateTimeCheckIn = new System.Windows.Forms.DateTimePicker();
            this.cbmRoom = new System.Windows.Forms.ComboBox();
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
            this.btnBook.Location = new System.Drawing.Point(795, 53);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(135, 49);
            this.btnBook.TabIndex = 23;
            this.btnBook.Text = "Reservar";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(563, 281);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(218, 156);
            this.richTextBox2.TabIndex = 22;
            this.richTextBox2.Text = "• Ducha\n• Inodoro\n• Albornoces\n• Zapatillas\n• Artículos de tocador\n• Secador de p" +
    "elo\n• Bañera de hidromasaje";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // lblBath
            // 
            this.lblBath.AutoSize = true;
            this.lblBath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBath.Location = new System.Drawing.Point(559, 235);
            this.lblBath.Name = "lblBath";
            this.lblBath.Size = new System.Drawing.Size(60, 23);
            this.lblBath.TabIndex = 21;
            this.lblBath.Text = "Baño";
            this.lblBath.Click += new System.EventHandler(this.lblBath_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(166, 281);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(196, 237);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "• Cama extra grande\n• Caja fuerte\n• Aire acondicionado\n• Calefacción\n• Insonoriza" +
    "ción\n• Plancha \n• Armario\n• Zona de estar\n• Escritorio\n• Sofá\n• Mosquitero";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblSuite
            // 
            this.lblSuite.AutoSize = true;
            this.lblSuite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuite.Location = new System.Drawing.Point(26, 21);
            this.lblSuite.Name = "lblSuite";
            this.lblSuite.Size = new System.Drawing.Size(169, 23);
            this.lblSuite.TabIndex = 19;
            this.lblSuite.Text = "Habitacion Suite";
            this.lblSuite.Click += new System.EventHandler(this.lblDoubleRoom_Click);
            // 
            // lblRoomFeatures
            // 
            this.lblRoomFeatures.AutoSize = true;
            this.lblRoomFeatures.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomFeatures.Location = new System.Drawing.Point(162, 235);
            this.lblRoomFeatures.Name = "lblRoomFeatures";
            this.lblRoomFeatures.Size = new System.Drawing.Size(317, 23);
            this.lblRoomFeatures.TabIndex = 18;
            this.lblRoomFeatures.Text = "Comodidades de la habitación";
            this.lblRoomFeatures.Click += new System.EventHandler(this.lblRoomFeatures_Click);
            // 
            // dateTimeCheckIn
            // 
            this.dateTimeCheckIn.Location = new System.Drawing.Point(203, 61);
            this.dateTimeCheckIn.Name = "dateTimeCheckIn";
            this.dateTimeCheckIn.Size = new System.Drawing.Size(200, 28);
            this.dateTimeCheckIn.TabIndex = 17;
            this.dateTimeCheckIn.ValueChanged += new System.EventHandler(this.dateTimeCheckIn_ValueChanged);
            // 
            // cbmRoom
            // 
            this.cbmRoom.FormattingEnabled = true;
            this.cbmRoom.Items.AddRange(new object[] {
            "1 habitación",
            "2 habitaciones",
            "3 habitaciones",
            "4 habitaciones"});
            this.cbmRoom.Location = new System.Drawing.Point(632, 60);
            this.cbmRoom.Name = "cbmRoom";
            this.cbmRoom.Size = new System.Drawing.Size(121, 29);
            this.cbmRoom.TabIndex = 16;
            this.cbmRoom.SelectedIndexChanged += new System.EventHandler(this.cbmRoom_SelectedIndexChanged);
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
            this.cbmNights.Location = new System.Drawing.Point(457, 60);
            this.cbmNights.Name = "cbmNights";
            this.cbmNights.Size = new System.Drawing.Size(121, 29);
            this.cbmNights.TabIndex = 14;
            this.cbmNights.SelectedIndexChanged += new System.EventHandler(this.cbmNights_SelectedIndexChanged);
            // 
            // picBoxDoubleRoom
            // 
            this.picBoxDoubleRoom.Location = new System.Drawing.Point(14, 12);
            this.picBoxDoubleRoom.Name = "picBoxDoubleRoom";
            this.picBoxDoubleRoom.Size = new System.Drawing.Size(974, 576);
            this.picBoxDoubleRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDoubleRoom.TabIndex = 13;
            this.picBoxDoubleRoom.TabStop = false;
            this.picBoxDoubleRoom.Click += new System.EventHandler(this.picBoxDoubleRoom_Click);
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
            this.picBoxReturn.TabIndex = 36;
            this.picBoxReturn.TabStop = false;
            this.picBoxReturn.Click += new System.EventHandler(this.picBoxReturn_Click);
            this.picBoxReturn.MouseHover += new System.EventHandler(this.picBoxReturn_MouseHover);
            // 
            // FormSuite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.picBoxReturn);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lblBath);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblSuite);
            this.Controls.Add(this.lblRoomFeatures);
            this.Controls.Add(this.dateTimeCheckIn);
            this.Controls.Add(this.cbmRoom);
            this.Controls.Add(this.cbmNights);
            this.Controls.Add(this.picBoxDoubleRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSuite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSuite";
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
        private System.Windows.Forms.Label lblSuite;
        private System.Windows.Forms.Label lblRoomFeatures;
        private System.Windows.Forms.DateTimePicker dateTimeCheckIn;
        private System.Windows.Forms.ComboBox cbmRoom;
        private System.Windows.Forms.ComboBox cbmNights;
        private System.Windows.Forms.PictureBox picBoxDoubleRoom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBoxReturn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}