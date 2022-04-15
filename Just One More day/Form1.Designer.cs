
namespace Just_One_More_day
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.POV = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Item3 = new System.Windows.Forms.PictureBox();
            this.Item2 = new System.Windows.Forms.PictureBox();
            this.Item1 = new System.Windows.Forms.PictureBox();
            this.OknoDialogu = new System.Windows.Forms.RichTextBox();
            this.OknoWyboru = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Item3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.POV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(91, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.88742F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.11258F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // POV
            // 
            this.POV.Image = global::Just_One_More_day.Properties.Resources.Menu1;
            this.POV.Location = new System.Drawing.Point(3, 3);
            this.POV.Name = "POV";
            this.POV.Size = new System.Drawing.Size(610, 278);
            this.POV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.POV.TabIndex = 0;
            this.POV.TabStop = false;
            this.POV.Click += new System.EventHandler(this.POV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Item3);
            this.panel1.Controls.Add(this.Item2);
            this.panel1.Controls.Add(this.Item1);
            this.panel1.Controls.Add(this.OknoDialogu);
            this.panel1.Controls.Add(this.OknoWyboru);
            this.panel1.Location = new System.Drawing.Point(3, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 136);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "--->";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "<---";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Item3
            // 
            this.Item3.Image = global::Just_One_More_day.Properties.Resources.Inventory_slot;
            this.Item3.Location = new System.Drawing.Point(545, 25);
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(42, 44);
            this.Item3.TabIndex = 6;
            this.Item3.TabStop = false;
            // 
            // Item2
            // 
            this.Item2.Image = global::Just_One_More_day.Properties.Resources.Inventory_slot;
            this.Item2.Location = new System.Drawing.Point(488, 25);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(42, 44);
            this.Item2.TabIndex = 5;
            this.Item2.TabStop = false;
            // 
            // Item1
            // 
            this.Item1.Image = global::Just_One_More_day.Properties.Resources.Inventory_slot;
            this.Item1.Location = new System.Drawing.Point(431, 25);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(42, 44);
            this.Item1.TabIndex = 4;
            this.Item1.TabStop = false;
            this.Item1.Click += new System.EventHandler(this.Item1_Click);
            // 
            // OknoDialogu
            // 
            this.OknoDialogu.Location = new System.Drawing.Point(132, 3);
            this.OknoDialogu.Name = "OknoDialogu";
            this.OknoDialogu.Size = new System.Drawing.Size(283, 136);
            this.OknoDialogu.TabIndex = 3;
            this.OknoDialogu.Text = "";
            this.OknoDialogu.TextChanged += new System.EventHandler(this.OknoDialogu_TextChanged);
            // 
            // OknoWyboru
            // 
            this.OknoWyboru.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OknoWyboru.FormattingEnabled = true;
            this.OknoWyboru.ItemHeight = 19;
            this.OknoWyboru.Location = new System.Drawing.Point(0, 3);
            this.OknoWyboru.Name = "OknoWyboru";
            this.OknoWyboru.Size = new System.Drawing.Size(126, 137);
            this.OknoWyboru.TabIndex = 2;
            this.OknoWyboru.SelectedIndexChanged += new System.EventHandler(this.OknoWyboru_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just One More day";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.POV)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Item3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox POV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Item3;
        private System.Windows.Forms.PictureBox Item2;
        private System.Windows.Forms.PictureBox Item1;
        private System.Windows.Forms.RichTextBox OknoDialogu;
        private System.Windows.Forms.ListBox OknoWyboru;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

