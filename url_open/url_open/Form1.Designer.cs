namespace url_open
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_url = new System.Windows.Forms.TextBox();
            this.lb_url = new System.Windows.Forms.ListBox();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_open = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_allopen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_url
            // 
            this.tb_url.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb_url.Location = new System.Drawing.Point(12, 12);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(324, 35);
            this.tb_url.TabIndex = 0;
            // 
            // lb_url
            // 
            this.lb_url.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_url.FormattingEnabled = true;
            this.lb_url.ItemHeight = 24;
            this.lb_url.Location = new System.Drawing.Point(12, 55);
            this.lb_url.Name = "lb_url";
            this.lb_url.Size = new System.Drawing.Size(324, 148);
            this.lb_url.TabIndex = 2;
            this.lb_url.SelectedIndexChanged += new System.EventHandler(this.Lb_url_SelectedIndexChanged);
            // 
            // bt_insert
            // 
            this.bt_insert.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_insert.Location = new System.Drawing.Point(351, 12);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(170, 90);
            this.bt_insert.TabIndex = 1;
            this.bt_insert.Text = "Insert";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.Bt_insert_Click);
            // 
            // bt_open
            // 
            this.bt_open.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_open.Location = new System.Drawing.Point(351, 116);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(170, 90);
            this.bt_open.TabIndex = 3;
            this.bt_open.Text = "Open";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.Bt_open_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_delete.Location = new System.Drawing.Point(527, 12);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(170, 90);
            this.bt_delete.TabIndex = 4;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // bt_allopen
            // 
            this.bt_allopen.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_allopen.Location = new System.Drawing.Point(527, 116);
            this.bt_allopen.Name = "bt_allopen";
            this.bt_allopen.Size = new System.Drawing.Size(170, 90);
            this.bt_allopen.TabIndex = 5;
            this.bt_allopen.Text = "All Open";
            this.bt_allopen.UseVisualStyleBackColor = true;
            this.bt_allopen.Click += new System.EventHandler(this.Bt_allopen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 219);
            this.Controls.Add(this.bt_allopen);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.lb_url);
            this.Controls.Add(this.tb_url);
            this.Name = "Form1";
            this.Text = "URL Opener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.ListBox lb_url;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_allopen;
    }
}

