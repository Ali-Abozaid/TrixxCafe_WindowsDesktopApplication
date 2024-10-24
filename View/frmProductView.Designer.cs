﻿namespace Trixx_CafeSystem.View
{
    partial class frmProductView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dvgDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.Text = "المنتجات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rgvSno,
            this.srgid,
            this.dvgName,
            this.dvgPrice,
            this.dvgCid,
            this.dvgCategory,
            this.dvgEdit,
            this.dvgDel});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(554, 171);
            this.dataGridView1.TabIndex = 7;
            // 
            // rgvSno
            // 
            this.rgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rgvSno.FillWeight = 70F;
            this.rgvSno.HeaderText = "Sr#";
            this.rgvSno.MinimumWidth = 70;
            this.rgvSno.Name = "rgvSno";
            this.rgvSno.ReadOnly = true;
            this.rgvSno.Width = 70;
            // 
            // srgid
            // 
            this.srgid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.srgid.FillWeight = 50F;
            this.srgid.HeaderText = "ID";
            this.srgid.Name = "srgid";
            this.srgid.ReadOnly = true;
            this.srgid.Visible = false;
            this.srgid.Width = 50;
            // 
            // dvgName
            // 
            this.dvgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgName.FillWeight = 70F;
            this.dvgName.HeaderText = "Name";
            this.dvgName.MinimumWidth = 70;
            this.dvgName.Name = "dvgName";
            this.dvgName.ReadOnly = true;
            this.dvgName.Width = 70;
            // 
            // dvgPrice
            // 
            this.dvgPrice.FillWeight = 70F;
            this.dvgPrice.HeaderText = "Price";
            this.dvgPrice.MinimumWidth = 70;
            this.dvgPrice.Name = "dvgPrice";
            this.dvgPrice.ReadOnly = true;
            this.dvgPrice.Width = 70;
            // 
            // dvgCid
            // 
            this.dvgCid.HeaderText = "CId";
            this.dvgCid.Name = "dvgCid";
            this.dvgCid.ReadOnly = true;
            this.dvgCid.Visible = false;
            // 
            // dvgCategory
            // 
            this.dvgCategory.FillWeight = 70F;
            this.dvgCategory.HeaderText = "Category";
            this.dvgCategory.MinimumWidth = 70;
            this.dvgCategory.Name = "dvgCategory";
            this.dvgCategory.ReadOnly = true;
            // 
            // dvgEdit
            // 
            this.dvgEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgEdit.FillWeight = 50F;
            this.dvgEdit.HeaderText = "";
            this.dvgEdit.Image = global::Trixx_CafeSystem.Properties.Resources.pen_9740241;
            this.dvgEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgEdit.MinimumWidth = 50;
            this.dvgEdit.Name = "dvgEdit";
            this.dvgEdit.ReadOnly = true;
            this.dvgEdit.Width = 50;
            // 
            // dvgDel
            // 
            this.dvgDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgDel.FillWeight = 50F;
            this.dvgDel.HeaderText = "";
            this.dvgDel.Image = global::Trixx_CafeSystem.Properties.Resources.recycle_bin;
            this.dvgDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgDel.MinimumWidth = 50;
            this.dvgDel.Name = "dvgDel";
            this.dvgDel.ReadOnly = true;
            this.dvgDel.Width = 50;
            // 
            // frmProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 364);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmProductView";
            this.Text = "frmTableView";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn srgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgCid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgCategory;
        private System.Windows.Forms.DataGridViewImageColumn dvgEdit;
        private System.Windows.Forms.DataGridViewImageColumn dvgDel;
    }
}