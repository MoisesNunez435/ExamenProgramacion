namespace ExamenProgramacion
{
    partial class Form1
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.rtbActiveView = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 408);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 30);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // rtbActiveView
            // 
            this.rtbActiveView.Location = new System.Drawing.Point(13, 97);
            this.rtbActiveView.Name = "rtbActiveView";
            this.rtbActiveView.Size = new System.Drawing.Size(775, 271);
            this.rtbActiveView.TabIndex = 1;
            this.rtbActiveView.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbActiveView);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.RichTextBox rtbActiveView;
    }
}

