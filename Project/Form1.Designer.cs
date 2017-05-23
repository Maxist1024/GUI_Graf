namespace Project
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
            this.addVerButton = new System.Windows.Forms.Button();
            this.directedCheckBox = new System.Windows.Forms.CheckBox();
            this.nameVerTextbox = new System.Windows.Forms.TextBox();
            this.FromVerTextBox = new System.Windows.Forms.TextBox();
            this.ToVerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddVerLabel = new System.Windows.Forms.Label();
            this.FromToLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.foundTriLabel = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.Wierzchołki = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Krawędzie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addVerButton
            // 
            this.addVerButton.Location = new System.Drawing.Point(32, 82);
            this.addVerButton.Name = "addVerButton";
            this.addVerButton.Size = new System.Drawing.Size(116, 23);
            this.addVerButton.TabIndex = 0;
            this.addVerButton.Text = "Dodaj wierzchołek";
            this.addVerButton.UseVisualStyleBackColor = true;
            this.addVerButton.Click += new System.EventHandler(this.addVerButton_Click);
            // 
            // directedCheckBox
            // 
            this.directedCheckBox.AutoSize = true;
            this.directedCheckBox.Checked = true;
            this.directedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.directedCheckBox.Location = new System.Drawing.Point(32, 27);
            this.directedCheckBox.Name = "directedCheckBox";
            this.directedCheckBox.Size = new System.Drawing.Size(81, 17);
            this.directedCheckBox.TabIndex = 1;
            this.directedCheckBox.Text = "Skierowany";
            this.directedCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameVerTextbox
            // 
            this.nameVerTextbox.Location = new System.Drawing.Point(159, 84);
            this.nameVerTextbox.Name = "nameVerTextbox";
            this.nameVerTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameVerTextbox.TabIndex = 2;
            this.nameVerTextbox.Text = "A";
            this.nameVerTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FromVerTextBox
            // 
            this.FromVerTextBox.Location = new System.Drawing.Point(159, 165);
            this.FromVerTextBox.Name = "FromVerTextBox";
            this.FromVerTextBox.Size = new System.Drawing.Size(100, 20);
            this.FromVerTextBox.TabIndex = 3;
            this.FromVerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ToVerTextBox
            // 
            this.ToVerTextBox.Location = new System.Drawing.Point(290, 165);
            this.ToVerTextBox.Name = "ToVerTextBox";
            this.ToVerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ToVerTextBox.TabIndex = 4;
            this.ToVerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dodaj krawędź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "do";
            // 
            // AddVerLabel
            // 
            this.AddVerLabel.AutoSize = true;
            this.AddVerLabel.Location = new System.Drawing.Point(265, 87);
            this.AddVerLabel.Name = "AddVerLabel";
            this.AddVerLabel.Size = new System.Drawing.Size(115, 13);
            this.AddVerLabel.TabIndex = 8;
            this.AddVerLabel.Text = "Dodano wierzchołek:  ";
            this.AddVerLabel.Visible = false;
            // 
            // FromToLabel
            // 
            this.FromToLabel.AutoSize = true;
            this.FromToLabel.Location = new System.Drawing.Point(396, 168);
            this.FromToLabel.Name = "FromToLabel";
            this.FromToLabel.Size = new System.Drawing.Size(35, 13);
            this.FromToLabel.TabIndex = 9;
            this.FromToLabel.Text = "label3";
            this.FromToLabel.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(444, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 85);
            this.button2.TabIndex = 10;
            this.button2.Text = "Szukaj trójkątów";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // foundTriLabel
            // 
            this.foundTriLabel.AutoSize = true;
            this.foundTriLabel.Location = new System.Drawing.Point(460, 205);
            this.foundTriLabel.Name = "foundTriLabel";
            this.foundTriLabel.Size = new System.Drawing.Size(0, 13);
            this.foundTriLabel.TabIndex = 11;
            this.foundTriLabel.Visible = false;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Wierzchołki,
            this.Krawędzie});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(32, 204);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(236, 130);
            this.listView.TabIndex = 12;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Wierzchołki
            // 
            this.Wierzchołki.Text = "Wierzchołki";
            this.Wierzchołki.Width = 77;
            // 
            // Krawędzie
            // 
            this.Krawędzie.Text = "Krawędzie";
            this.Krawędzie.Width = 158;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 346);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.foundTriLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FromToLabel);
            this.Controls.Add(this.AddVerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToVerTextBox);
            this.Controls.Add(this.FromVerTextBox);
            this.Controls.Add(this.nameVerTextbox);
            this.Controls.Add(this.directedCheckBox);
            this.Controls.Add(this.addVerButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GraphTriangleSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVerButton;
        private System.Windows.Forms.CheckBox directedCheckBox;
        private System.Windows.Forms.TextBox nameVerTextbox;
        private System.Windows.Forms.TextBox FromVerTextBox;
        private System.Windows.Forms.TextBox ToVerTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AddVerLabel;
        private System.Windows.Forms.Label FromToLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label foundTriLabel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Wierzchołki;
        private System.Windows.Forms.ColumnHeader Krawędzie;
    }
}

