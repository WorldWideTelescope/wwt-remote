namespace WWTRemoteControl
{
    partial class NodeListEditor
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
            this.MacAddress = new System.Windows.Forms.TextBox();
            this.nodeList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mac = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MacAddress
            // 
            this.MacAddress.Location = new System.Drawing.Point(12, 256);
            this.MacAddress.Name = "MacAddress";
            this.MacAddress.Size = new System.Drawing.Size(219, 20);
            this.MacAddress.TabIndex = 0;
            // 
            // nodeList
            // 
            this.nodeList.FormattingEnabled = true;
            this.nodeList.Location = new System.Drawing.Point(12, 23);
            this.nodeList.Name = "nodeList";
            this.nodeList.Size = new System.Drawing.Size(219, 199);
            this.nodeList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nodes to Wake";
            // 
            // Mac
            // 
            this.Mac.AutoSize = true;
            this.Mac.Location = new System.Drawing.Point(12, 240);
            this.Mac.Name = "Mac";
            this.Mac.Size = new System.Drawing.Size(69, 13);
            this.Mac.TabIndex = 2;
            this.Mac.Text = "Mac Address";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(237, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(156, 295);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(237, 254);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(237, 199);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 4;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // NodeListEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 333);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nodeList);
            this.Controls.Add(this.MacAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NodeListEditor";
            this.ShowInTaskbar = false;
            this.Text = "Wake on Lan Node List Editor";
            this.Load += new System.EventHandler(this.NodeListEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MacAddress;
        private System.Windows.Forms.ListBox nodeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Mac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button remove;
    }
}