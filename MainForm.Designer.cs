
namespace lofi_moods
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lofiMoodsView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.lofiMoodsView)).BeginInit();
            this.SuspendLayout();
            // 
            // lofiMoodsView
            // 
            this.lofiMoodsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lofiMoodsView.CreationProperties = null;
            this.lofiMoodsView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.lofiMoodsView.Location = new System.Drawing.Point(0, 0);
            this.lofiMoodsView.Name = "lofiMoodsView";
            this.lofiMoodsView.Size = new System.Drawing.Size(1164, 713);
            this.lofiMoodsView.Source = new System.Uri("https://jeromelalunio.tech/lofi-moods", System.UriKind.Absolute);
            this.lofiMoodsView.TabIndex = 0;
            this.lofiMoodsView.ZoomFactor = 1D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 711);
            this.Controls.Add(this.lofiMoodsView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lofi Moods";
            ((System.ComponentModel.ISupportInitialize)(this.lofiMoodsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 lofiMoodsView;
    }
}

