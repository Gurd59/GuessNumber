namespace Hádám_číslo
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_mysli = new System.Windows.Forms.Button();
            this.btn_hadam = new System.Windows.Forms.Button();
            this.nmr_cislo = new System.Windows.Forms.NumericUpDown();
            this.win = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_cislo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mysli
            // 
            this.btn_mysli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_mysli.Location = new System.Drawing.Point(46, 47);
            this.btn_mysli.Name = "btn_mysli";
            this.btn_mysli.Size = new System.Drawing.Size(255, 140);
            this.btn_mysli.TabIndex = 0;
            this.btn_mysli.Text = "Mysli si číslo";
            this.btn_mysli.UseVisualStyleBackColor = true;
            this.btn_mysli.Click += new System.EventHandler(this.btn_mysli_Click);
            // 
            // btn_hadam
            // 
            this.btn_hadam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_hadam.Location = new System.Drawing.Point(46, 267);
            this.btn_hadam.Name = "btn_hadam";
            this.btn_hadam.Size = new System.Drawing.Size(255, 140);
            this.btn_hadam.TabIndex = 1;
            this.btn_hadam.Text = "Hádám tohle číslo";
            this.btn_hadam.UseVisualStyleBackColor = true;
            this.btn_hadam.Click += new System.EventHandler(this.btn_hadam_Click);
            // 
            // nmr_cislo
            // 
            this.nmr_cislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.nmr_cislo.Location = new System.Drawing.Point(46, 209);
            this.nmr_cislo.Name = "nmr_cislo";
            this.nmr_cislo.Size = new System.Drawing.Size(255, 31);
            this.nmr_cislo.TabIndex = 2;
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Location = new System.Drawing.Point(332, 217);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(0, 13);
            this.win.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.win);
            this.Controls.Add(this.nmr_cislo);
            this.Controls.Add(this.btn_hadam);
            this.Controls.Add(this.btn_mysli);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmr_cislo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mysli;
        private System.Windows.Forms.Button btn_hadam;
        private System.Windows.Forms.NumericUpDown nmr_cislo;
        private System.Windows.Forms.Label win;
    }
}

