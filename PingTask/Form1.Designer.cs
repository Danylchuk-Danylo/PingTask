namespace PingTask
{
    partial class Form1
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
            txtIpInput = new TextBox();
            btnAdd = new Button();
            lstIps = new ListBox();
            btnRemove = new Button();
            btnPing = new Button();
            lstResults = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIpInput
            // 
            txtIpInput.Location = new Point(22, 31);
            txtIpInput.Name = "txtIpInput";
            txtIpInput.Size = new Size(143, 39);
            txtIpInput.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(196, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 39);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lstIps
            // 
            lstIps.FormattingEnabled = true;
            lstIps.Location = new Point(22, 108);
            lstIps.Name = "lstIps";
            lstIps.Size = new Size(324, 324);
            lstIps.TabIndex = 2;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(22, 460);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(150, 46);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnPing
            // 
            btnPing.Location = new Point(196, 460);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(150, 46);
            btnPing.TabIndex = 4;
            btnPing.Text = "Ping";
            btnPing.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.Location = new Point(380, 70);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(513, 420);
            lstResults.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 20);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 6;
            label1.Text = "Ping result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 518);
            Controls.Add(label1);
            Controls.Add(lstResults);
            Controls.Add(btnPing);
            Controls.Add(btnRemove);
            Controls.Add(lstIps);
            Controls.Add(btnAdd);
            Controls.Add(txtIpInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIpInput;
        private Button btnAdd;
        private ListBox lstIps;
        private Button btnRemove;
        private Button btnPing;
        private ListBox lstResults;
        private Label label1;
    }
}
