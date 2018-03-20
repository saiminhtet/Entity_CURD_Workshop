namespace EntityFramework_CURD
{
    partial class frm_movie_lst
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
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.dtaGV = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_edit_die_hard = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.Location = new System.Drawing.Point(12, 12);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(75, 33);
            this.btn_retrieve.TabIndex = 9;
            this.btn_retrieve.Text = "Retrieve";
            this.btn_retrieve.UseVisualStyleBackColor = true;
            this.btn_retrieve.Click += new System.EventHandler(this.btn_retrieve_Click);
            // 
            // dtaGV
            // 
            this.dtaGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGV.Location = new System.Drawing.Point(93, 12);
            this.dtaGV.Name = "dtaGV";
            this.dtaGV.Size = new System.Drawing.Size(635, 500);
            this.dtaGV.TabIndex = 8;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(12, 68);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 33);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(12, 119);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 33);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(12, 170);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 33);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 515);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // btn_edit_die_hard
            // 
            this.btn_edit_die_hard.Location = new System.Drawing.Point(12, 223);
            this.btn_edit_die_hard.Name = "btn_edit_die_hard";
            this.btn_edit_die_hard.Size = new System.Drawing.Size(75, 47);
            this.btn_edit_die_hard.TabIndex = 14;
            this.btn_edit_die_hard.Text = "Edit Die Hard";
            this.btn_edit_die_hard.UseVisualStyleBackColor = true;
            this.btn_edit_die_hard.Click += new System.EventHandler(this.btn_edit_die_hard_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(12, 290);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 33);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frm_movie_lst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 540);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit_die_hard);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_retrieve);
            this.Controls.Add(this.dtaGV);
            this.Name = "frm_movie_lst";
            this.Text = "Movie";
            ((System.ComponentModel.ISupportInitialize)(this.dtaGV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_retrieve;
        private System.Windows.Forms.DataGridView dtaGV;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btn_edit_die_hard;
        private System.Windows.Forms.Button btn_delete;
    }
}