namespace CustomerDB
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
            this.lblsearch = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblfirstName = new System.Windows.Forms.Label();
            this.listCust = new System.Windows.Forms.Button();
            this.clearList = new System.Windows.Forms.Button();
            this.lbllastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxfirstName = new System.Windows.Forms.TextBox();
            this.tbxlastName = new System.Windows.Forms.TextBox();
            this.tbxphone = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(57, 32);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(191, 20);
            this.lblsearch.TabIndex = 0;
            this.lblsearch.Text = "Enter Customer Name:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(61, 55);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(241, 26);
            this.search.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(308, 54);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(121, 27);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(62, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 224);
            this.listBox1.TabIndex = 3;
            // 
            // lblfirstName
            // 
            this.lblfirstName.AutoSize = true;
            this.lblfirstName.Location = new System.Drawing.Point(450, 143);
            this.lblfirstName.Name = "lblfirstName";
            this.lblfirstName.Size = new System.Drawing.Size(101, 20);
            this.lblfirstName.TabIndex = 5;
            this.lblfirstName.Text = "First Name:";
            // 
            // listCust
            // 
            this.listCust.Location = new System.Drawing.Point(61, 347);
            this.listCust.Name = "listCust";
            this.listCust.Size = new System.Drawing.Size(146, 31);
            this.listCust.TabIndex = 13;
            this.listCust.Text = "List Customers";
            this.listCust.UseVisualStyleBackColor = true;
            this.listCust.Click += new System.EventHandler(this.listCust_Click);
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(269, 347);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(160, 31);
            this.clearList.TabIndex = 14;
            this.clearList.Text = "Clear List";
            this.clearList.UseVisualStyleBackColor = true;
            // 
            // lbllastName
            // 
            this.lbllastName.AutoSize = true;
            this.lbllastName.Location = new System.Drawing.Point(452, 186);
            this.lbllastName.Name = "lbllastName";
            this.lbllastName.Size = new System.Drawing.Size(100, 20);
            this.lbllastName.TabIndex = 6;
            this.lbllastName.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phone:";
            // 
            // tbxfirstName
            // 
            this.tbxfirstName.Location = new System.Drawing.Point(559, 140);
            this.tbxfirstName.Name = "tbxfirstName";
            this.tbxfirstName.Size = new System.Drawing.Size(180, 26);
            this.tbxfirstName.TabIndex = 8;
            // 
            // tbxlastName
            // 
            this.tbxlastName.Location = new System.Drawing.Point(559, 183);
            this.tbxlastName.Name = "tbxlastName";
            this.tbxlastName.Size = new System.Drawing.Size(180, 26);
            this.tbxlastName.TabIndex = 9;
            // 
            // tbxphone
            // 
            this.tbxphone.Location = new System.Drawing.Point(559, 230);
            this.tbxphone.Name = "tbxphone";
            this.tbxphone.Size = new System.Drawing.Size(180, 26);
            this.tbxphone.TabIndex = 10;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(467, 300);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(116, 33);
            this.update.TabIndex = 11;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(611, 300);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 33);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(467, 347);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(116, 31);
            this.delete.TabIndex = 15;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(611, 347);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(112, 31);
            this.clear.TabIndex = 16;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(435, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 186);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                          Customer Details:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.listCust);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.tbxphone);
            this.Controls.Add(this.tbxlastName);
            this.Controls.Add(this.tbxfirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbllastName);
            this.Controls.Add(this.lblfirstName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblfirstName;
        private System.Windows.Forms.Button listCust;
        private System.Windows.Forms.Button clearList;
        private System.Windows.Forms.Label lbllastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxfirstName;
        private System.Windows.Forms.TextBox tbxlastName;
        private System.Windows.Forms.TextBox tbxphone;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

