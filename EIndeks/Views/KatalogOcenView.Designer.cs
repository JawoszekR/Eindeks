namespace EIndeks.Views
{
    partial class KatalogOcenView
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
            this.grid_oceny = new MetroFramework.Controls.MetroGrid();
            this.kursIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_zapisz = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid_oceny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_oceny
            // 
            this.grid_oceny.AllowUserToResizeRows = false;
            this.grid_oceny.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_oceny.AutoGenerateColumns = false;
            this.grid_oceny.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_oceny.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_oceny.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_oceny.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_oceny.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_oceny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_oceny.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kursIdDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.grid_oceny.DataSource = this.ocenaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_oceny.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_oceny.EnableHeadersVisualStyles = false;
            this.grid_oceny.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_oceny.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_oceny.Location = new System.Drawing.Point(20, 82);
            this.grid_oceny.Name = "grid_oceny";
            this.grid_oceny.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_oceny.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_oceny.RowHeadersWidth = 51;
            this.grid_oceny.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_oceny.RowTemplate.Height = 24;
            this.grid_oceny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_oceny.Size = new System.Drawing.Size(760, 311);
            this.grid_oceny.TabIndex = 0;
            // 
            // kursIdDataGridViewTextBoxColumn
            // 
            this.kursIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kursIdDataGridViewTextBoxColumn.DataPropertyName = "KursId";
            this.kursIdDataGridViewTextBoxColumn.DataSource = this.kursBindingSource;
            this.kursIdDataGridViewTextBoxColumn.DisplayMember = "Kod";
            this.kursIdDataGridViewTextBoxColumn.HeaderText = "Kurs";
            this.kursIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kursIdDataGridViewTextBoxColumn.Name = "kursIdDataGridViewTextBoxColumn";
            this.kursIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kursIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kursIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // kursBindingSource
            // 
            this.kursBindingSource.DataSource = typeof(EIndeks.Model.Kurs);
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // ocenaBindingSource
            // 
            this.ocenaBindingSource.AllowNew = true;
            this.ocenaBindingSource.DataSource = typeof(EIndeks.Model.OcenaKatalogAdapter);
            // 
            // btn_zapisz
            // 
            this.btn_zapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_zapisz.Location = new System.Drawing.Point(659, 400);
            this.btn_zapisz.Name = "btn_zapisz";
            this.btn_zapisz.Size = new System.Drawing.Size(118, 23);
            this.btn_zapisz.TabIndex = 1;
            this.btn_zapisz.Text = "Zapisz";
            this.btn_zapisz.UseSelectable = true;
            this.btn_zapisz.Click += new System.EventHandler(this.btn_zapisz_Click);
            // 
            // KatalogOcenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_zapisz);
            this.Controls.Add(this.grid_oceny);
            this.Name = "KatalogOcenView";
            this.Text = "Oceny";
            ((System.ComponentModel.ISupportInitialize)(this.grid_oceny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grid_oceny;
        private System.Windows.Forms.BindingSource ocenaBindingSource;
        private MetroFramework.Controls.MetroButton btn_zapisz;
        private System.Windows.Forms.BindingSource kursBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn kursIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}