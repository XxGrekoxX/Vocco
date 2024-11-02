namespace Vocco
{
    partial class FormHabitacionDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHabitacionDoble));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbmNights = new System.Windows.Forms.ComboBox();
            this.cbmRoom = new System.Windows.Forms.ComboBox();
            this.dateTimeCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblRoomFeatures = new System.Windows.Forms.Label();
            this.lblDoubleRoom = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblBath = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.picBoxDoubleRoom = new System.Windows.Forms.PictureBox();
            this.picBoxReturn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDoubleRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.cbmNights.Location = new System.Drawing.Point(410, 64);
            this.cbmNights.Name = "cbmNights";
            this.cbmNights.Size = new System.Drawing.Size(121, 29);
            this.cbmNights.TabIndex = 1;
            // 
            // cbmRoom
            // 
            this.cbmRoom.FormattingEnabled = true;
            this.cbmRoom.Items.AddRange(new object[] {
            "1 habitación",
            "2 habitaciones",
            "3 habitaciones",
            "4 habitaciones"});
            this.cbmRoom.Location = new System.Drawing.Point(585, 64);
            this.cbmRoom.Name = "cbmRoom";
            this.cbmRoom.Size = new System.Drawing.Size(121, 29);
            this.cbmRoom.TabIndex = 3;
            this.cbmRoom.SelectedIndexChanged += new System.EventHandler(this.cbmRoom_SelectedIndexChanged);
            // 
            // dateTimeCheckIn
            // 
            this.dateTimeCheckIn.Location = new System.Drawing.Point(156, 65);
            this.dateTimeCheckIn.Name = "dateTimeCheckIn";
            this.dateTimeCheckIn.Size = new System.Drawing.Size(200, 28);
            this.dateTimeCheckIn.TabIndex = 4;
            this.dateTimeCheckIn.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblRoomFeatures
            // 
            this.lblRoomFeatures.AutoSize = true;
            this.lblRoomFeatures.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomFeatures.Location = new System.Drawing.Point(167, 265);
            this.lblRoomFeatures.Name = "lblRoomFeatures";
            this.lblRoomFeatures.Size = new System.Drawing.Size(317, 23);
            this.lblRoomFeatures.TabIndex = 5;
            this.lblRoomFeatures.Text = "Comodidades de la habitación";
            // 
            // lblDoubleRoom
            // 
            this.lblDoubleRoom.AutoSize = true;
            this.lblDoubleRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoubleRoom.Location = new System.Drawing.Point(26, 21);
            this.lblDoubleRoom.Name = "lblDoubleRoom";
            this.lblDoubleRoom.Size = new System.Drawing.Size(187, 23);
            this.lblDoubleRoom.TabIndex = 6;
            this.lblDoubleRoom.Text = "Habitacion Doble ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(171, 311);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(209, 155);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "• Cama extra grande\n• Caja fuerte\n• Aire acondicionado\n• Calefacción\n• Insonoriza" +
    "ción\n• Plancha \n• Armario";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(577, 311);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(198, 140);
            this.richTextBox2.TabIndex = 9;
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
            this.lblBath.TabIndex = 8;
            this.lblBath.Text = "Baño";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Location = new System.Drawing.Point(767, 54);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(128, 46);
            this.btnBook.TabIndex = 12;
            this.btnBook.Text = "Reservar";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // picBoxDoubleRoom
            // 
            this.picBoxDoubleRoom.Location = new System.Drawing.Point(12, 12);
            this.picBoxDoubleRoom.Name = "picBoxDoubleRoom";
            this.picBoxDoubleRoom.Size = new System.Drawing.Size(976, 576);
            this.picBoxDoubleRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDoubleRoom.TabIndex = 0;
            this.picBoxDoubleRoom.TabStop = false;
            // 
            // picBoxReturn
            // 
            this.picBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("picBoxReturn.Image")));
            this.picBoxReturn.Location = new System.Drawing.Point(947, 12);
            this.picBoxReturn.Name = "picBoxReturn";
            this.picBoxReturn.Size = new System.Drawing.Size(41, 33);
            this.picBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxReturn.TabIndex = 37;
            this.picBoxReturn.TabStop = false;
            this.picBoxReturn.Click += new System.EventHandler(this.picBoxReturn_Click);
            this.picBoxReturn.MouseHover += new System.EventHandler(this.picBoxReturn_MouseHover);
            // 
            // FormHabitacionDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.picBoxReturn);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lblBath);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblDoubleRoom);
            this.Controls.Add(this.lblRoomFeatures);
            this.Controls.Add(this.dateTimeCheckIn);
            this.Controls.Add(this.cbmRoom);
            this.Controls.Add(this.cbmNights);
            this.Controls.Add(this.picBoxDoubleRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHabitacionDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHabitacionDoble";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDoubleRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxDoubleRoom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbmNights;
        private System.Windows.Forms.ComboBox cbmRoom;
        private System.Windows.Forms.DateTimePicker dateTimeCheckIn;
        private System.Windows.Forms.Label lblRoomFeatures;
        private System.Windows.Forms.Label lblDoubleRoom;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lblBath;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.PictureBox picBoxReturn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}