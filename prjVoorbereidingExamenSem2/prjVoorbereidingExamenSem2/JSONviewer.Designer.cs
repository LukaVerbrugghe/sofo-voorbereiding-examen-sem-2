namespace prjVoorbereidingExamenSem2
{
    partial class JSONviewer
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
            this.lsbJSONData = new System.Windows.Forms.ListBox();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbJSONData
            // 
            this.lsbJSONData.FormattingEnabled = true;
            this.lsbJSONData.Location = new System.Drawing.Point(13, 13);
            this.lsbJSONData.Name = "lsbJSONData";
            this.lsbJSONData.Size = new System.Drawing.Size(433, 407);
            this.lsbJSONData.TabIndex = 0;
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Location = new System.Drawing.Point(453, 13);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(75, 23);
            this.btnLoadJson.TabIndex = 1;
            this.btnLoadJson.Text = "Load JSON";
            this.btnLoadJson.UseVisualStyleBackColor = true;
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // JSONviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.btnLoadJson);
            this.Controls.Add(this.lsbJSONData);
            this.Name = "JSONviewer";
            this.Text = "JSONviewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbJSONData;
        private System.Windows.Forms.Button btnLoadJson;
    }
}