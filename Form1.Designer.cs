
namespace stoper
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.licznik = new System.Windows.Forms.Label();
            this.off = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.rekord = new System.Windows.Forms.Label();
            this.napis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.LightGray;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start.Location = new System.Drawing.Point(12, 44);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(85, 75);
            this.start.TabIndex = 1;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.LightGray;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reset.Location = new System.Drawing.Point(12, 126);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(85, 75);
            this.reset.TabIndex = 1;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // licznik
            // 
            this.licznik.AutoSize = true;
            this.licznik.BackColor = System.Drawing.Color.Transparent;
            this.licznik.Font = new System.Drawing.Font("Georgia", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.licznik.ForeColor = System.Drawing.Color.Silver;
            this.licznik.Location = new System.Drawing.Point(103, 44);
            this.licznik.Name = "licznik";
            this.licznik.Size = new System.Drawing.Size(605, 109);
            this.licznik.TabIndex = 2;
            this.licznik.Text = "00:00:00,00";
            // 
            // off
            // 
            this.off.BackColor = System.Drawing.Color.Silver;
            this.off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.off.Font = new System.Drawing.Font("Georgia", 10F);
            this.off.Location = new System.Drawing.Point(12, 12);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(85, 25);
            this.off.TabIndex = 3;
            this.off.Text = "OFF";
            this.off.UseVisualStyleBackColor = false;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // rekord
            // 
            this.rekord.AutoSize = true;
            this.rekord.BackColor = System.Drawing.Color.Transparent;
            this.rekord.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rekord.ForeColor = System.Drawing.Color.Silver;
            this.rekord.Location = new System.Drawing.Point(585, 176);
            this.rekord.Name = "rekord";
            this.rekord.Size = new System.Drawing.Size(123, 24);
            this.rekord.TabIndex = 4;
            this.rekord.Text = "00:00:00,00";
            // 
            // napis
            // 
            this.napis.AutoSize = true;
            this.napis.BackColor = System.Drawing.Color.Transparent;
            this.napis.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napis.ForeColor = System.Drawing.Color.Silver;
            this.napis.Location = new System.Drawing.Point(504, 177);
            this.napis.Name = "napis";
            this.napis.Size = new System.Drawing.Size(75, 24);
            this.napis.TabIndex = 5;
            this.napis.Text = "rekord:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stoper.Properties.Resources.pexels_stein_egil_liland_3374210_1_;
            this.ClientSize = new System.Drawing.Size(724, 214);
            this.Controls.Add(this.napis);
            this.Controls.Add(this.rekord);
            this.Controls.Add(this.off);
            this.Controls.Add(this.licznik);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.start);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "stoper";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label licznik;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label rekord;
        private System.Windows.Forms.Label napis;
    }
}

