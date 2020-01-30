namespace EIndeks.Views
{
    partial class KatalogStudentowView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_studenci = new MetroFramework.Controls.MetroGrid();
            this.colOceny = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_zapisz = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_imie = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_nrIndeksu = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_nazwisko = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime_od = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime_do = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrIndeksuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid_studenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_studenci
            // 
            this.grid_studenci.AllowUserToResizeRows = false;
            this.grid_studenci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_studenci.AutoGenerateColumns = false;
            this.grid_studenci.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_studenci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_studenci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_studenci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_studenci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_studenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_studenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.nrIndeksuDataGridViewTextBoxColumn,
            this.dataUrodzeniaDataGridViewTextBoxColumn,
            this.colOceny});
            this.grid_studenci.DataSource = this.studentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_studenci.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_studenci.EnableHeadersVisualStyles = false;
            this.grid_studenci.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_studenci.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_studenci.Location = new System.Drawing.Point(23, 154);
            this.grid_studenci.Name = "grid_studenci";
            this.grid_studenci.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_studenci.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_studenci.RowHeadersWidth = 51;
            this.grid_studenci.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_studenci.RowTemplate.Height = 24;
            this.grid_studenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_studenci.Size = new System.Drawing.Size(852, 293);
            this.grid_studenci.TabIndex = 2;
            this.grid_studenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_studenci_CellClick);
            this.grid_studenci.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.grid_studenci_UserDeletingRow);
            // 
            // colOceny
            // 
            this.colOceny.HeaderText = "Oceny";
            this.colOceny.MinimumWidth = 6;
            this.colOceny.Name = "colOceny";
            this.colOceny.Width = 50;
            // 
            // btn_zapisz
            // 
            this.btn_zapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_zapisz.Location = new System.Drawing.Point(731, 453);
            this.btn_zapisz.Name = "btn_zapisz";
            this.btn_zapisz.Size = new System.Drawing.Size(144, 23);
            this.btn_zapisz.TabIndex = 3;
            this.btn_zapisz.Text = "Zapisz";
            this.btn_zapisz.UseSelectable = true;
            this.btn_zapisz.Click += new System.EventHandler(this.btn_zapisz_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Imię";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Nazwisko";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Nr indeksu";
            // 
            // metroTextBox_imie
            // 
            // 
            // 
            // 
            this.metroTextBox_imie.CustomButton.Image = null;
            this.metroTextBox_imie.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.metroTextBox_imie.CustomButton.Name = "";
            this.metroTextBox_imie.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_imie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_imie.CustomButton.TabIndex = 1;
            this.metroTextBox_imie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_imie.CustomButton.UseSelectable = true;
            this.metroTextBox_imie.CustomButton.Visible = false;
            this.metroTextBox_imie.Lines = new string[0];
            this.metroTextBox_imie.Location = new System.Drawing.Point(220, 67);
            this.metroTextBox_imie.MaxLength = 32767;
            this.metroTextBox_imie.Name = "metroTextBox_imie";
            this.metroTextBox_imie.PasswordChar = '\0';
            this.metroTextBox_imie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_imie.SelectedText = "";
            this.metroTextBox_imie.SelectionLength = 0;
            this.metroTextBox_imie.SelectionStart = 0;
            this.metroTextBox_imie.ShortcutsEnabled = true;
            this.metroTextBox_imie.Size = new System.Drawing.Size(205, 23);
            this.metroTextBox_imie.TabIndex = 7;
            this.metroTextBox_imie.UseSelectable = true;
            this.metroTextBox_imie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_imie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_imie.TextChanged += new System.EventHandler(this.metroTextBox_imie_TextChanged);
            // 
            // metroTextBox_nrIndeksu
            // 
            // 
            // 
            // 
            this.metroTextBox_nrIndeksu.CustomButton.Image = null;
            this.metroTextBox_nrIndeksu.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.metroTextBox_nrIndeksu.CustomButton.Name = "";
            this.metroTextBox_nrIndeksu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_nrIndeksu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_nrIndeksu.CustomButton.TabIndex = 1;
            this.metroTextBox_nrIndeksu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_nrIndeksu.CustomButton.UseSelectable = true;
            this.metroTextBox_nrIndeksu.CustomButton.Visible = false;
            this.metroTextBox_nrIndeksu.Lines = new string[0];
            this.metroTextBox_nrIndeksu.Location = new System.Drawing.Point(220, 125);
            this.metroTextBox_nrIndeksu.MaxLength = 32767;
            this.metroTextBox_nrIndeksu.Name = "metroTextBox_nrIndeksu";
            this.metroTextBox_nrIndeksu.PasswordChar = '\0';
            this.metroTextBox_nrIndeksu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_nrIndeksu.SelectedText = "";
            this.metroTextBox_nrIndeksu.SelectionLength = 0;
            this.metroTextBox_nrIndeksu.SelectionStart = 0;
            this.metroTextBox_nrIndeksu.ShortcutsEnabled = true;
            this.metroTextBox_nrIndeksu.Size = new System.Drawing.Size(205, 23);
            this.metroTextBox_nrIndeksu.TabIndex = 8;
            this.metroTextBox_nrIndeksu.UseSelectable = true;
            this.metroTextBox_nrIndeksu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_nrIndeksu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_nrIndeksu.TextChanged += new System.EventHandler(this.metroTextBox_imie_TextChanged);
            // 
            // metroTextBox_nazwisko
            // 
            // 
            // 
            // 
            this.metroTextBox_nazwisko.CustomButton.Image = null;
            this.metroTextBox_nazwisko.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.metroTextBox_nazwisko.CustomButton.Name = "";
            this.metroTextBox_nazwisko.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_nazwisko.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_nazwisko.CustomButton.TabIndex = 1;
            this.metroTextBox_nazwisko.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_nazwisko.CustomButton.UseSelectable = true;
            this.metroTextBox_nazwisko.CustomButton.Visible = false;
            this.metroTextBox_nazwisko.Lines = new string[0];
            this.metroTextBox_nazwisko.Location = new System.Drawing.Point(220, 96);
            this.metroTextBox_nazwisko.MaxLength = 32767;
            this.metroTextBox_nazwisko.Name = "metroTextBox_nazwisko";
            this.metroTextBox_nazwisko.PasswordChar = '\0';
            this.metroTextBox_nazwisko.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_nazwisko.SelectedText = "";
            this.metroTextBox_nazwisko.SelectionLength = 0;
            this.metroTextBox_nazwisko.SelectionStart = 0;
            this.metroTextBox_nazwisko.ShortcutsEnabled = true;
            this.metroTextBox_nazwisko.Size = new System.Drawing.Size(205, 23);
            this.metroTextBox_nazwisko.TabIndex = 9;
            this.metroTextBox_nazwisko.UseSelectable = true;
            this.metroTextBox_nazwisko.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_nazwisko.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_nazwisko.TextChanged += new System.EventHandler(this.metroTextBox_imie_TextChanged);
            // 
            // metroDateTime_od
            // 
            this.metroDateTime_od.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDateTime_od.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTime_od.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_od.Location = new System.Drawing.Point(675, 67);
            this.metroDateTime_od.MinimumSize = new System.Drawing.Size(0, 27);
            this.metroDateTime_od.Name = "metroDateTime_od";
            this.metroDateTime_od.Size = new System.Drawing.Size(200, 27);
            this.metroDateTime_od.TabIndex = 10;
            this.metroDateTime_od.ValueChanged += new System.EventHandler(this.metroDateTime_do_ValueChanged);
            // 
            // metroDateTime_do
            // 
            this.metroDateTime_do.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDateTime_do.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTime_do.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_do.Location = new System.Drawing.Point(674, 104);
            this.metroDateTime_do.MinimumSize = new System.Drawing.Size(0, 27);
            this.metroDateTime_do.Name = "metroDateTime_do";
            this.metroDateTime_do.Size = new System.Drawing.Size(200, 27);
            this.metroDateTime_do.TabIndex = 11;
            this.metroDateTime_do.ValueChanged += new System.EventHandler(this.metroDateTime_do_ValueChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(515, 72);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 25);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Urodzeni od";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(515, 109);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(112, 25);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Urodzeni do";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.FillWeight = 1000F;
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.FillWeight = 1000F;
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // nrIndeksuDataGridViewTextBoxColumn
            // 
            this.nrIndeksuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nrIndeksuDataGridViewTextBoxColumn.DataPropertyName = "NrIndeksu";
            this.nrIndeksuDataGridViewTextBoxColumn.HeaderText = "NrIndeksu";
            this.nrIndeksuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrIndeksuDataGridViewTextBoxColumn.Name = "nrIndeksuDataGridViewTextBoxColumn";
            this.nrIndeksuDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(EIndeks.Model.Student);
            // 
            // KatalogStudentowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 501);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroDateTime_do);
            this.Controls.Add(this.metroDateTime_od);
            this.Controls.Add(this.metroTextBox_nazwisko);
            this.Controls.Add(this.metroTextBox_nrIndeksu);
            this.Controls.Add(this.metroTextBox_imie);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_zapisz);
            this.Controls.Add(this.grid_studenci);
            this.Name = "KatalogStudentowView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Katalog studentów";
            ((System.ComponentModel.ISupportInitialize)(this.grid_studenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MetroFramework.Controls.MetroGrid grid_studenci;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrIndeksuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colOceny;
        private MetroFramework.Controls.MetroButton btn_zapisz;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox_imie;
        private MetroFramework.Controls.MetroTextBox metroTextBox_nrIndeksu;
        private MetroFramework.Controls.MetroTextBox metroTextBox_nazwisko;
        private MetroFramework.Controls.MetroDateTime metroDateTime_od;
        private MetroFramework.Controls.MetroDateTime metroDateTime_do;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}