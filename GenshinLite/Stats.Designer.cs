
namespace GenshinLite
{
    partial class Stats
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.g1DataSet6 = new GenshinLite.g1DataSet6();
            this.charactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.charactersTableAdapter = new GenshinLite.g1DataSet6TableAdapters.CharactersTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.g1DataSet9 = new GenshinLite.g1DataSet9();
            this.selectAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectAllTableAdapter = new GenshinLite.g1DataSet9TableAdapters.SelectAllTableAdapter();
            this.charNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtifactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeaponType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.charNameDataGridViewTextBoxColumn,
            this.ArtifactName,
            this.ElementName,
            this.WeaponType,
            this.BirthMonth,
            this.charLevelDataGridViewTextBoxColumn,
            this.charHPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.selectAllBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // g1DataSet6
            // 
            this.g1DataSet6.DataSetName = "g1DataSet6";
            this.g1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // charactersBindingSource
            // 
            this.charactersBindingSource.DataMember = "Characters";
            this.charactersBindingSource.DataSource = this.g1DataSet6;
            // 
            // charactersTableAdapter
            // 
            this.charactersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.selectAllBindingSource;
            this.comboBox1.DisplayMember = "CharName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 357);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // g1DataSet9
            // 
            this.g1DataSet9.DataSetName = "g1DataSet9";
            this.g1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectAllBindingSource
            // 
            this.selectAllBindingSource.DataMember = "SelectAll";
            this.selectAllBindingSource.DataSource = this.g1DataSet9;
            // 
            // selectAllTableAdapter
            // 
            this.selectAllTableAdapter.ClearBeforeFill = true;
            // 
            // charNameDataGridViewTextBoxColumn
            // 
            this.charNameDataGridViewTextBoxColumn.DataPropertyName = "CharName";
            this.charNameDataGridViewTextBoxColumn.HeaderText = "CharName";
            this.charNameDataGridViewTextBoxColumn.Name = "charNameDataGridViewTextBoxColumn";
            // 
            // ArtifactName
            // 
            this.ArtifactName.DataPropertyName = "ArtifactName";
            this.ArtifactName.HeaderText = "ArtifactName";
            this.ArtifactName.Name = "ArtifactName";
            // 
            // ElementName
            // 
            this.ElementName.DataPropertyName = "ElementName";
            this.ElementName.HeaderText = "ElementName";
            this.ElementName.Name = "ElementName";
            // 
            // WeaponType
            // 
            this.WeaponType.DataPropertyName = "WeaponType";
            this.WeaponType.HeaderText = "WeaponType";
            this.WeaponType.Name = "WeaponType";
            // 
            // BirthMonth
            // 
            this.BirthMonth.DataPropertyName = "BirthMonth";
            this.BirthMonth.HeaderText = "BirthMonth";
            this.BirthMonth.Name = "BirthMonth";
            this.BirthMonth.ReadOnly = true;
            // 
            // charLevelDataGridViewTextBoxColumn
            // 
            this.charLevelDataGridViewTextBoxColumn.DataPropertyName = "CharLevel";
            this.charLevelDataGridViewTextBoxColumn.HeaderText = "CharLevel";
            this.charLevelDataGridViewTextBoxColumn.Name = "charLevelDataGridViewTextBoxColumn";
            // 
            // charHPDataGridViewTextBoxColumn
            // 
            this.charHPDataGridViewTextBoxColumn.DataPropertyName = "CharHP";
            this.charHPDataGridViewTextBoxColumn.HeaderText = "CharHP";
            this.charHPDataGridViewTextBoxColumn.Name = "charHPDataGridViewTextBoxColumn";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.selectAllBindingSource;
            this.comboBox2.DisplayMember = "CharLevel";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 403);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.selectAllBindingSource;
            this.comboBox3.DisplayMember = "ArtifactName";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(164, 357);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.selectAllBindingSource;
            this.comboBox4.DisplayMember = "CharHP";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(164, 403);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 4;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.selectAllBindingSource;
            this.comboBox5.DisplayMember = "ElementName";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(310, 357);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 5;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.selectAllBindingSource;
            this.comboBox6.DisplayMember = "WeaponType";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(310, 403);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 6;
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.selectAllBindingSource;
            this.comboBox7.DisplayMember = "BirthMonth";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(466, 380);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 67);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stats";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.Stats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private g1DataSet6 g1DataSet6;
        private System.Windows.Forms.BindingSource charactersBindingSource;
        private g1DataSet6TableAdapters.CharactersTableAdapter charactersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private g1DataSet9 g1DataSet9;
        private System.Windows.Forms.BindingSource selectAllBindingSource;
        private g1DataSet9TableAdapters.SelectAllTableAdapter selectAllTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn charNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtifactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeaponType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn charLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Button button1;
    }
}