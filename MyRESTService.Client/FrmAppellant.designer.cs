
namespace MyRESTService.Client
{
    partial class FrmAppellant
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
            this.dgvAppellants = new System.Windows.Forms.DataGridView();
            this.btnJSON = new System.Windows.Forms.Button();
            this.btnPOX = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppellants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppellants
            // 
            this.dgvAppellants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppellants.Location = new System.Drawing.Point(145, 87);
            this.dgvAppellants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAppellants.Name = "dgvAppellants";
            this.dgvAppellants.RowHeadersWidth = 51;
            this.dgvAppellants.Size = new System.Drawing.Size(1317, 500);
            this.dgvAppellants.TabIndex = 0;
            // 
            // btnJSON
            // 
            this.btnJSON.Location = new System.Drawing.Point(145, 36);
            this.btnJSON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(100, 28);
            this.btnJSON.TabIndex = 1;
            this.btnJSON.Text = "JSON";
            this.btnJSON.UseVisualStyleBackColor = true;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // btnPOX
            // 
            this.btnPOX.Location = new System.Drawing.Point(253, 36);
            this.btnPOX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPOX.Name = "btnPOX";
            this.btnPOX.Size = new System.Drawing.Size(100, 28);
            this.btnPOX.TabIndex = 2;
            this.btnPOX.Text = "POX";
            this.btnPOX.UseVisualStyleBackColor = true;
            this.btnPOX.Click += new System.EventHandler(this.btnPOX_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(469, 36);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmAppellant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 699);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPOX);
            this.Controls.Add(this.btnJSON);
            this.Controls.Add(this.dgvAppellants);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAppellant";
            this.Text = "Appellants client API";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppellants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppellants;
        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.Button btnPOX;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}