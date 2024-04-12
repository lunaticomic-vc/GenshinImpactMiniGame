
namespace GenshinLite
{
    partial class CharacterChoice
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.charactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g1DataSet = new GenshinLite.g1DataSet();
            this.charactersTableAdapter = new GenshinLite.g1DataSetTableAdapters.CharactersTableAdapter();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.artifactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g1DataSet1 = new GenshinLite.g1DataSet1();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.weaponsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g1DataSet2 = new GenshinLite.g1DataSet2();
            this.artifactsTableAdapter = new GenshinLite.g1DataSet1TableAdapters.ArtifactsTableAdapter();
            this.weaponsTableAdapter = new GenshinLite.g1DataSet2TableAdapters.WeaponsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.charactersBindingSource;
            this.listBox1.DisplayMember = "CharName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 238);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "CharName";
            // 
            // charactersBindingSource
            // 
            this.charactersBindingSource.DataMember = "Characters";
            this.charactersBindingSource.DataSource = this.g1DataSet;
            // 
            // g1DataSet
            // 
            this.g1DataSet.DataSetName = "g1DataSet";
            this.g1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // charactersTableAdapter
            // 
            this.charactersTableAdapter.ClearBeforeFill = true;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.artifactsBindingSource;
            this.listBox2.DisplayMember = "ArtifactName";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(166, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(140, 238);
            this.listBox2.TabIndex = 1;
            // 
            // artifactsBindingSource
            // 
            this.artifactsBindingSource.DataMember = "Artifacts";
            this.artifactsBindingSource.DataSource = this.g1DataSet1;
            // 
            // g1DataSet1
            // 
            this.g1DataSet1.DataSetName = "g1DataSet1";
            this.g1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox3
            // 
            this.listBox3.DataSource = this.weaponsBindingSource;
            this.listBox3.DisplayMember = "WeaponName";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(323, 43);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(140, 238);
            this.listBox3.TabIndex = 2;
            // 
            // weaponsBindingSource
            // 
            this.weaponsBindingSource.DataMember = "Weapons";
            this.weaponsBindingSource.DataSource = this.g1DataSet2;
            // 
            // g1DataSet2
            // 
            this.g1DataSet2.DataSetName = "g1DataSet2";
            this.g1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artifactsTableAdapter
            // 
            this.artifactsTableAdapter.ClearBeforeFill = true;
            // 
            // weaponsTableAdapter
            // 
            this.weaponsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose a character:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose an artifact:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose a weapon:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Let\'s go to Teyvat!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CharacterChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "CharacterChoice";
            this.Text = "CharacterChoice";
            this.Load += new System.EventHandler(this.CharacterChoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private g1DataSet g1DataSet;
        private System.Windows.Forms.BindingSource charactersBindingSource;
        private g1DataSetTableAdapters.CharactersTableAdapter charactersTableAdapter;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private g1DataSet1 g1DataSet1;
        private System.Windows.Forms.BindingSource artifactsBindingSource;
        private g1DataSet1TableAdapters.ArtifactsTableAdapter artifactsTableAdapter;
        private g1DataSet2 g1DataSet2;
        private System.Windows.Forms.BindingSource weaponsBindingSource;
        private g1DataSet2TableAdapters.WeaponsTableAdapter weaponsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}