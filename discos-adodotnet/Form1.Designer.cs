namespace discos_adodotnet
{
    partial class wfListaDiscos
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
            this.pbImagenDisco = new System.Windows.Forms.PictureBox();
            this.dgvListaDiscos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenDisco
            // 
            this.pbImagenDisco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagenDisco.Location = new System.Drawing.Point(653, 32);
            this.pbImagenDisco.Name = "pbImagenDisco";
            this.pbImagenDisco.Size = new System.Drawing.Size(275, 249);
            this.pbImagenDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenDisco.TabIndex = 0;
            this.pbImagenDisco.TabStop = false;
            // 
            // dgvListaDiscos
            // 
            this.dgvListaDiscos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDiscos.Location = new System.Drawing.Point(13, 32);
            this.dgvListaDiscos.Name = "dgvListaDiscos";
            this.dgvListaDiscos.Size = new System.Drawing.Size(634, 249);
            this.dgvListaDiscos.TabIndex = 1;
            this.dgvListaDiscos.SelectionChanged += new System.EventHandler(this.dgvListaDiscos_SelectionChanged);
            // 
            // wfListaDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 310);
            this.Controls.Add(this.dgvListaDiscos);
            this.Controls.Add(this.pbImagenDisco);
            this.Name = "wfListaDiscos";
            this.Text = "Lista Discos";
            this.Load += new System.EventHandler(this.wfListaDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDiscos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenDisco;
        private System.Windows.Forms.DataGridView dgvListaDiscos;
    }
}

