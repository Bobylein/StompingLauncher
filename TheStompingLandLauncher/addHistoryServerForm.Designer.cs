﻿namespace TheStompingLandLauncher
{
    partial class addHistoryServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addHistoryServerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TBaddServerIP = new System.Windows.Forms.TextBox();
            this.BaddServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBaddServerDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TBaddServerIP
            // 
            resources.ApplyResources(this.TBaddServerIP, "TBaddServerIP");
            this.TBaddServerIP.Name = "TBaddServerIP";
            this.TBaddServerIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBaddServerIP_KeyPress);
            // 
            // BaddServer
            // 
            resources.ApplyResources(this.BaddServer, "BaddServer");
            this.BaddServer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BaddServer.Name = "BaddServer";
            this.BaddServer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TBaddServerDesc
            // 
            resources.ApplyResources(this.TBaddServerDesc, "TBaddServerDesc");
            this.TBaddServerDesc.Name = "TBaddServerDesc";
            // 
            // addHistoryServerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TBaddServerDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BaddServer);
            this.Controls.Add(this.TBaddServerIP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addHistoryServerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TBaddServerIP;
        public System.Windows.Forms.Button BaddServer;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TBaddServerDesc;
    }
}