namespace Vocco
{
    partial class FormAprobarReservas
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("3456h");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("fgu");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAprobarReservas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReservasPendientes = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxCambiarA = new System.Windows.Forms.ComboBox();
            this.picBoxReturn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picBoxReturn);
            this.panel1.Controls.Add(this.comboBoxCambiarA);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.btnReservasPendientes);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 576);
            this.panel1.TabIndex = 0;
            // 
            // btnReservasPendientes
            // 
            this.btnReservasPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(151)))));
            this.btnReservasPendientes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservasPendientes.ForeColor = System.Drawing.Color.White;
            this.btnReservasPendientes.Location = new System.Drawing.Point(51, 18);
            this.btnReservasPendientes.Name = "btnReservasPendientes";
            this.btnReservasPendientes.Size = new System.Drawing.Size(202, 83);
            this.btnReservasPendientes.TabIndex = 0;
            this.btnReservasPendientes.Text = "Ver Reservas Pendientes";
            this.btnReservasPendientes.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(51, 141);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(886, 400);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            this.columnHeader1.Width = 204;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Estado";
            this.columnHeader2.Width = 331;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cambiar a";
            this.columnHeader3.Width = 164;
            // 
            // comboBoxCambiarA
            // 
            this.comboBoxCambiarA.FormattingEnabled = true;
            this.comboBoxCambiarA.Items.AddRange(new object[] {
            "Pendiente",
            "Aprobada"});
            this.comboBoxCambiarA.Location = new System.Drawing.Point(758, 72);
            this.comboBoxCambiarA.Name = "comboBoxCambiarA";
            this.comboBoxCambiarA.Size = new System.Drawing.Size(121, 29);
            this.comboBoxCambiarA.TabIndex = 2;
            this.comboBoxCambiarA.Visible = false;
            this.comboBoxCambiarA.SelectedIndexChanged += new System.EventHandler(this.comboBoxCambiarA_SelectedIndexChanged);
            this.comboBoxCambiarA.Leave += new System.EventHandler(this.comboBoxCambiarA_Leave);
            // 
            // picBoxReturn
            // 
            this.picBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("picBoxReturn.Image")));
            this.picBoxReturn.Location = new System.Drawing.Point(932, 3);
            this.picBoxReturn.Name = "picBoxReturn";
            this.picBoxReturn.Size = new System.Drawing.Size(41, 33);
            this.picBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxReturn.TabIndex = 38;
            this.picBoxReturn.TabStop = false;
            this.picBoxReturn.Click += new System.EventHandler(this.picBoxReturn_Click);
            // 
            // FormAprobarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAprobarReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAprobarReservas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReservasPendientes;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox comboBoxCambiarA;
        private System.Windows.Forms.PictureBox picBoxReturn;
    }
}