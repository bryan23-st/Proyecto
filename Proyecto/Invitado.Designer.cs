namespace Proyecto
{
    partial class Invitado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invitado));
            this.panellateral = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelcentral = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panellateral.SuspendLayout();
            this.panelcentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panellateral
            // 
            this.panellateral.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panellateral.Controls.Add(this.button3);
            this.panellateral.Controls.Add(this.label3);
            this.panellateral.Controls.Add(this.button2);
            this.panellateral.Controls.Add(this.label2);
            this.panellateral.Controls.Add(this.button1);
            this.panellateral.Controls.Add(this.label1);
            this.panellateral.Controls.Add(this.panel1);
            this.panellateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellateral.Location = new System.Drawing.Point(0, 0);
            this.panellateral.Name = "panellateral";
            this.panellateral.Size = new System.Drawing.Size(124, 505);
            this.panellateral.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "Valor a pagar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Compra";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 55);
            this.panel1.TabIndex = 0;
            // 
            // panelcentral
            // 
            this.panelcentral.BackColor = System.Drawing.Color.LightBlue;
            this.panelcentral.Controls.Add(this.pictureBox1);
            this.panelcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentral.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelcentral.Location = new System.Drawing.Point(124, 0);
            this.panelcentral.Name = "panelcentral";
            this.panelcentral.Size = new System.Drawing.Size(765, 505);
            this.panelcentral.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Invitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 505);
            this.Controls.Add(this.panelcentral);
            this.Controls.Add(this.panellateral);
            this.Name = "Invitado";
            this.Text = "Invitado";
            this.panellateral.ResumeLayout(false);
            this.panellateral.PerformLayout();
            this.panelcentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellateral;
        private System.Windows.Forms.Panel panelcentral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}