namespace RecentlyVisitedSites
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.link1 = new System.Windows.Forms.LinkLabel();
            this.link2 = new System.Windows.Forms.LinkLabel();
            this.link3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // link1
            // 
            this.link1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.link1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.link1.Location = new System.Drawing.Point(28, 9);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(224, 86);
            this.link1.TabIndex = 0;
            this.link1.TabStop = true;
            this.link1.Text = "Facebook";
            this.link1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link1_LinkClicked);
            this.link1.MouseLeave += new System.EventHandler(this.link1_MouseLeave);
            this.link1.MouseHover += new System.EventHandler(this.link1_MouseHover);
            // 
            // link2
            // 
            this.link2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.link2.Location = new System.Drawing.Point(28, 104);
            this.link2.Name = "link2";
            this.link2.Size = new System.Drawing.Size(224, 86);
            this.link2.TabIndex = 1;
            this.link2.TabStop = true;
            this.link2.Text = "Instagram";
            this.link2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link2_LinkClicked);
            this.link2.MouseLeave += new System.EventHandler(this.link2_MouseLeave);
            this.link2.MouseHover += new System.EventHandler(this.link2_MouseHover);
            // 
            // link3
            // 
            this.link3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.link3.Location = new System.Drawing.Point(28, 202);
            this.link3.Name = "link3";
            this.link3.Size = new System.Drawing.Size(224, 89);
            this.link3.TabIndex = 2;
            this.link3.TabStop = true;
            this.link3.Text = "Twitter";
            this.link3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link3_LinkClicked);
            this.link3.MouseLeave += new System.EventHandler(this.link3_MouseLeave);
            this.link3.MouseHover += new System.EventHandler(this.link3_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.link1);
            this.Controls.Add(this.link3);
            this.Controls.Add(this.link2);
            this.Name = "Form1";
            this.Text = "RecentlyVisitedSites";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel link1;
        private System.Windows.Forms.LinkLabel link2;
        private System.Windows.Forms.LinkLabel link3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

