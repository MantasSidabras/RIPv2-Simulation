namespace RIPv2
{
    partial class neighboursLabel
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
            this.nodesListBox = new System.Windows.Forms.ListBox();
            this.nodesLabel = new System.Windows.Forms.Label();
            this.routingTableListBox = new System.Windows.Forms.ListBox();
            this.routingTableLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.neighboursListBox = new System.Windows.Forms.ListBox();
            this.neighbourLabel = new System.Windows.Forms.Label();
            this.deleteNodeButton = new System.Windows.Forms.Button();
            this.addRouterButton = new System.Windows.Forms.Button();
            this.linkNodesButton = new System.Windows.Forms.Button();
            this.node1TextBox = new System.Windows.Forms.TextBox();
            this.node2TextBox = new System.Windows.Forms.TextBox();
            this.unlinkNodesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nodesListBox
            // 
            this.nodesListBox.FormattingEnabled = true;
            this.nodesListBox.Location = new System.Drawing.Point(54, 103);
            this.nodesListBox.Name = "nodesListBox";
            this.nodesListBox.Size = new System.Drawing.Size(120, 186);
            this.nodesListBox.TabIndex = 0;
            this.nodesListBox.SelectedIndexChanged += new System.EventHandler(this.nodesListBox_SelectedIndexChanged);
            // 
            // nodesLabel
            // 
            this.nodesLabel.AutoSize = true;
            this.nodesLabel.Location = new System.Drawing.Point(51, 69);
            this.nodesLabel.Name = "nodesLabel";
            this.nodesLabel.Size = new System.Drawing.Size(38, 13);
            this.nodesLabel.TabIndex = 1;
            this.nodesLabel.Text = "Nodes";
            // 
            // routingTableListBox
            // 
            this.routingTableListBox.FormattingEnabled = true;
            this.routingTableListBox.Location = new System.Drawing.Point(461, 103);
            this.routingTableListBox.Name = "routingTableListBox";
            this.routingTableListBox.Size = new System.Drawing.Size(299, 186);
            this.routingTableListBox.TabIndex = 2;
            // 
            // routingTableLabel
            // 
            this.routingTableLabel.AutoSize = true;
            this.routingTableLabel.Location = new System.Drawing.Point(458, 69);
            this.routingTableLabel.Name = "routingTableLabel";
            this.routingTableLabel.Size = new System.Drawing.Size(70, 13);
            this.routingTableLabel.TabIndex = 3;
            this.routingTableLabel.Text = "Routing table";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(54, 333);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update nodes";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // neighboursListBox
            // 
            this.neighboursListBox.FormattingEnabled = true;
            this.neighboursListBox.Location = new System.Drawing.Point(224, 103);
            this.neighboursListBox.Name = "neighboursListBox";
            this.neighboursListBox.Size = new System.Drawing.Size(136, 186);
            this.neighboursListBox.TabIndex = 5;
            // 
            // neighbourLabel
            // 
            this.neighbourLabel.AutoSize = true;
            this.neighbourLabel.Location = new System.Drawing.Point(221, 69);
            this.neighbourLabel.Name = "neighbourLabel";
            this.neighbourLabel.Size = new System.Drawing.Size(61, 13);
            this.neighbourLabel.TabIndex = 1;
            this.neighbourLabel.Text = "Neighbours";
            // 
            // deleteNodeButton
            // 
            this.deleteNodeButton.Location = new System.Drawing.Point(224, 384);
            this.deleteNodeButton.Name = "deleteNodeButton";
            this.deleteNodeButton.Size = new System.Drawing.Size(120, 23);
            this.deleteNodeButton.TabIndex = 6;
            this.deleteNodeButton.Text = "Delete node";
            this.deleteNodeButton.UseVisualStyleBackColor = true;
            this.deleteNodeButton.Click += new System.EventHandler(this.deleteNodeButton_Click);
            // 
            // addRouterButton
            // 
            this.addRouterButton.Location = new System.Drawing.Point(54, 384);
            this.addRouterButton.Name = "addRouterButton";
            this.addRouterButton.Size = new System.Drawing.Size(120, 23);
            this.addRouterButton.TabIndex = 7;
            this.addRouterButton.Text = "Add router";
            this.addRouterButton.UseVisualStyleBackColor = true;
            this.addRouterButton.Click += new System.EventHandler(this.addRouterButton_Click);
            // 
            // linkNodesButton
            // 
            this.linkNodesButton.Location = new System.Drawing.Point(161, 463);
            this.linkNodesButton.Name = "linkNodesButton";
            this.linkNodesButton.Size = new System.Drawing.Size(121, 23);
            this.linkNodesButton.TabIndex = 8;
            this.linkNodesButton.Text = "Link nodes";
            this.linkNodesButton.UseVisualStyleBackColor = true;
            this.linkNodesButton.Click += new System.EventHandler(this.linkNodesButton_Click);
            // 
            // node1TextBox
            // 
            this.node1TextBox.Location = new System.Drawing.Point(54, 465);
            this.node1TextBox.Name = "node1TextBox";
            this.node1TextBox.Size = new System.Drawing.Size(35, 20);
            this.node1TextBox.TabIndex = 9;
            // 
            // node2TextBox
            // 
            this.node2TextBox.Location = new System.Drawing.Point(106, 465);
            this.node2TextBox.Name = "node2TextBox";
            this.node2TextBox.Size = new System.Drawing.Size(35, 20);
            this.node2TextBox.TabIndex = 10;
            // 
            // unlinkNodesButton
            // 
            this.unlinkNodesButton.Location = new System.Drawing.Point(305, 463);
            this.unlinkNodesButton.Name = "unlinkNodesButton";
            this.unlinkNodesButton.Size = new System.Drawing.Size(121, 23);
            this.unlinkNodesButton.TabIndex = 11;
            this.unlinkNodesButton.Text = "Unlink nodes";
            this.unlinkNodesButton.UseVisualStyleBackColor = true;
            // 
            // neighboursLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.unlinkNodesButton);
            this.Controls.Add(this.node2TextBox);
            this.Controls.Add(this.node1TextBox);
            this.Controls.Add(this.linkNodesButton);
            this.Controls.Add(this.addRouterButton);
            this.Controls.Add(this.deleteNodeButton);
            this.Controls.Add(this.neighboursListBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.routingTableLabel);
            this.Controls.Add(this.routingTableListBox);
            this.Controls.Add(this.neighbourLabel);
            this.Controls.Add(this.nodesLabel);
            this.Controls.Add(this.nodesListBox);
            this.Name = "neighboursLabel";
            this.Text = "RIPv2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nodesListBox;
        private System.Windows.Forms.Label nodesLabel;
        private System.Windows.Forms.ListBox routingTableListBox;
        private System.Windows.Forms.Label routingTableLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ListBox neighboursListBox;
        private System.Windows.Forms.Label neighbourLabel;
        private System.Windows.Forms.Button deleteNodeButton;
        private System.Windows.Forms.Button addRouterButton;
        private System.Windows.Forms.Button linkNodesButton;
        private System.Windows.Forms.TextBox node1TextBox;
        private System.Windows.Forms.TextBox node2TextBox;
        private System.Windows.Forms.Button unlinkNodesButton;
    }
}

