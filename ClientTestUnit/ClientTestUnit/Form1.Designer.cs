using System.Drawing;

namespace ClientTestUnit
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnKill10 = new System.Windows.Forms.Button();
            this.btnKill100 = new System.Windows.Forms.Button();
            this.btnKillAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSend10 = new System.Windows.Forms.Button();
            this.btnSend100 = new System.Windows.Forms.Button();
            this.btnSendMovement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Spawn Clients";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(211, 38);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "0";
            // 
            // btnKill10
            // 
            this.btnKill10.Location = new System.Drawing.Point(13, 58);
            this.btnKill10.Name = "btnKill10";
            this.btnKill10.Size = new System.Drawing.Size(137, 40);
            this.btnKill10.TabIndex = 3;
            this.btnKill10.Text = "Kill 10 Clients";
            this.btnKill10.UseVisualStyleBackColor = true;
            this.btnKill10.Click += new System.EventHandler(this.btnKill10_Click);
            // 
            // btnKill100
            // 
            this.btnKill100.Location = new System.Drawing.Point(13, 104);
            this.btnKill100.Name = "btnKill100";
            this.btnKill100.Size = new System.Drawing.Size(137, 40);
            this.btnKill100.TabIndex = 4;
            this.btnKill100.Text = "Kill 100 Clients";
            this.btnKill100.UseVisualStyleBackColor = true;
            this.btnKill100.Click += new System.EventHandler(this.btnKill100_Click);
            // 
            // btnKillAll
            // 
            this.btnKillAll.Location = new System.Drawing.Point(12, 150);
            this.btnKillAll.Name = "btnKillAll";
            this.btnKillAll.Size = new System.Drawing.Size(137, 40);
            this.btnKillAll.TabIndex = 5;
            this.btnKillAll.Text = "Kill All Clients";
            this.btnKillAll.UseVisualStyleBackColor = true;
            this.btnKillAll.Click += new System.EventHandler(this.btnKillAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kill 1 Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSend10
            // 
            this.btnSend10.Location = new System.Drawing.Point(156, 104);
            this.btnSend10.Name = "btnSend10";
            this.btnSend10.Size = new System.Drawing.Size(137, 40);
            this.btnSend10.TabIndex = 7;
            this.btnSend10.Text = "Send 10 Messages";
            this.btnSend10.UseVisualStyleBackColor = true;
            this.btnSend10.Click += new System.EventHandler(this.btnSend10_Click);
            // 
            // btnSend100
            // 
            this.btnSend100.Location = new System.Drawing.Point(156, 150);
            this.btnSend100.Name = "btnSend100";
            this.btnSend100.Size = new System.Drawing.Size(137, 40);
            this.btnSend100.TabIndex = 8;
            this.btnSend100.Text = "Send 100 Messages";
            this.btnSend100.UseVisualStyleBackColor = true;
            this.btnSend100.Click += new System.EventHandler(this.btnSend100_Click);
            // 
            // btnSendMovement
            // 
            this.btnSendMovement.Location = new System.Drawing.Point(13, 196);
            this.btnSendMovement.Name = "btnSendMovement";
            this.btnSendMovement.Size = new System.Drawing.Size(137, 38);
            this.btnSendMovement.TabIndex = 9;
            this.btnSendMovement.Text = "Send Movement";
            this.btnSendMovement.UseVisualStyleBackColor = true;
            this.btnSendMovement.Click += new System.EventHandler(this.btnSendMovement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 646);
            this.Controls.Add(this.btnSendMovement);
            this.Controls.Add(this.btnSend100);
            this.Controls.Add(this.btnSend10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKillAll);
            this.Controls.Add(this.btnKill100);
            this.Controls.Add(this.btnKill10);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnKill10;
        private System.Windows.Forms.Button btnKill100;
        private System.Windows.Forms.Button btnKillAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSend10;
        private System.Windows.Forms.Button btnSend100;
        private System.Windows.Forms.Button btnSendMovement;
    }
}

