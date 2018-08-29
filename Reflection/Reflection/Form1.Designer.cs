namespace Reflection
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
            this.btnTypeDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.MethodList = new System.Windows.Forms.ListBox();
            this.ConstructorList = new System.Windows.Forms.ListBox();
            this.PropertyList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTypeDetails
            // 
            this.btnTypeDetails.Location = new System.Drawing.Point(432, 25);
            this.btnTypeDetails.Name = "btnTypeDetails";
            this.btnTypeDetails.Size = new System.Drawing.Size(202, 23);
            this.btnTypeDetails.TabIndex = 0;
            this.btnTypeDetails.Text = "Get Type Details";
            this.btnTypeDetails.UseVisualStyleBackColor = true;
            this.btnTypeDetails.Click += new System.EventHandler(this.btnTypeDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type Name";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(113, 27);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(303, 20);
            this.txtTypeName.TabIndex = 2;
            // 
            // MethodList
            // 
            this.MethodList.FormattingEnabled = true;
            this.MethodList.Location = new System.Drawing.Point(12, 108);
            this.MethodList.Name = "MethodList";
            this.MethodList.Size = new System.Drawing.Size(215, 264);
            this.MethodList.TabIndex = 3;
            // 
            // ConstructorList
            // 
            this.ConstructorList.FormattingEnabled = true;
            this.ConstructorList.Location = new System.Drawing.Point(265, 108);
            this.ConstructorList.Name = "ConstructorList";
            this.ConstructorList.Size = new System.Drawing.Size(215, 264);
            this.ConstructorList.TabIndex = 4;
            // 
            // PropertyList
            // 
            this.PropertyList.FormattingEnabled = true;
            this.PropertyList.Location = new System.Drawing.Point(528, 108);
            this.PropertyList.Name = "PropertyList";
            this.PropertyList.Size = new System.Drawing.Size(215, 264);
            this.PropertyList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Constructor Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Property Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Method Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 451);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PropertyList);
            this.Controls.Add(this.ConstructorList);
            this.Controls.Add(this.MethodList);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTypeDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTypeDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.ListBox MethodList;
        private System.Windows.Forms.ListBox ConstructorList;
        private System.Windows.Forms.ListBox PropertyList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

