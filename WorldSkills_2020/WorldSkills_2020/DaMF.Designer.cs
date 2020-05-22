namespace WorldSkills_2020
{
    partial class DaMF
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ширинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комментарийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изделиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.артикулDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.ширинаDataGridViewTextBoxColumn,
            this.длинаDataGridViewTextBoxColumn,
            this.изображениеDataGridViewTextBoxColumn,
            this.комментарийDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.изделиеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 312);
            this.dataGridView1.TabIndex = 1;
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // ширинаDataGridViewTextBoxColumn
            // 
            this.ширинаDataGridViewTextBoxColumn.DataPropertyName = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.HeaderText = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.Name = "ширинаDataGridViewTextBoxColumn";
            // 
            // длинаDataGridViewTextBoxColumn
            // 
            this.длинаDataGridViewTextBoxColumn.DataPropertyName = "Длина";
            this.длинаDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.длинаDataGridViewTextBoxColumn.Name = "длинаDataGridViewTextBoxColumn";
            // 
            // изображениеDataGridViewTextBoxColumn
            // 
            this.изображениеDataGridViewTextBoxColumn.DataPropertyName = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.HeaderText = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.Name = "изображениеDataGridViewTextBoxColumn";
            // 
            // комментарийDataGridViewTextBoxColumn
            // 
            this.комментарийDataGridViewTextBoxColumn.DataPropertyName = "Комментарий";
            this.комментарийDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.комментарийDataGridViewTextBoxColumn.Name = "комментарийDataGridViewTextBoxColumn";
            // 
            // изделиеBindingSource
            // 
            this.изделиеBindingSource.DataMember = "Изделие";
            // 
            // 
            // изделиеTableAdapter
            // 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Изделие";
            // 
            // DaMF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "DaMF";
            this.Text = "Список изделий";
            this.Load += new System.EventHandler(this.STF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource изделиеBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ширинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn изображениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комментарийDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}