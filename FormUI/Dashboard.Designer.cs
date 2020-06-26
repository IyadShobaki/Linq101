namespace FormUI
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.allPeopleDropdown = new System.Windows.Forms.ComboBox();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.filterListLabel = new System.Windows.Forms.Label();
            this.yearsExperiencePicker = new System.Windows.Forms.NumericUpDown();
            this.filteredPeopleList = new System.Windows.Forms.ListBox();
            this.updatePersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperiencePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linq 101 Demo";
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleLabel.Location = new System.Drawing.Point(87, 118);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(150, 41);
            this.peopleLabel.TabIndex = 1;
            this.peopleLabel.Text = "All People";
            // 
            // allPeopleDropdown
            // 
            this.allPeopleDropdown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPeopleDropdown.FormattingEnabled = true;
            this.allPeopleDropdown.Location = new System.Drawing.Point(94, 174);
            this.allPeopleDropdown.Name = "allPeopleDropdown";
            this.allPeopleDropdown.Size = new System.Drawing.Size(306, 49);
            this.allPeopleDropdown.TabIndex = 2;
            this.allPeopleDropdown.SelectedIndexChanged += new System.EventHandler(this.allPeopleDropdown_SelectedIndexChanged);
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsLabel.Location = new System.Drawing.Point(87, 248);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(237, 41);
            this.yearsLabel.TabIndex = 3;
            this.yearsLabel.Text = "Years Experience";
            // 
            // filterListLabel
            // 
            this.filterListLabel.AutoSize = true;
            this.filterListLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterListLabel.Location = new System.Drawing.Point(506, 119);
            this.filterListLabel.Name = "filterListLabel";
            this.filterListLabel.Size = new System.Drawing.Size(169, 41);
            this.filterListLabel.TabIndex = 4;
            this.filterListLabel.Text = "Filtered List";
            // 
            // yearsExperiencePicker
            // 
            this.yearsExperiencePicker.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsExperiencePicker.Location = new System.Drawing.Point(94, 293);
            this.yearsExperiencePicker.Name = "yearsExperiencePicker";
            this.yearsExperiencePicker.Size = new System.Drawing.Size(103, 47);
            this.yearsExperiencePicker.TabIndex = 5;
            // 
            // filteredPeopleList
            // 
            this.filteredPeopleList.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteredPeopleList.FormattingEnabled = true;
            this.filteredPeopleList.ItemHeight = 37;
            this.filteredPeopleList.Location = new System.Drawing.Point(513, 174);
            this.filteredPeopleList.Name = "filteredPeopleList";
            this.filteredPeopleList.Size = new System.Drawing.Size(421, 374);
            this.filteredPeopleList.TabIndex = 6;
            // 
            // updatePersonButton
            // 
            this.updatePersonButton.BackColor = System.Drawing.Color.White;
            this.updatePersonButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePersonButton.Location = new System.Drawing.Point(189, 391);
            this.updatePersonButton.Name = "updatePersonButton";
            this.updatePersonButton.Size = new System.Drawing.Size(191, 64);
            this.updatePersonButton.TabIndex = 7;
            this.updatePersonButton.Text = "Update";
            this.updatePersonButton.UseVisualStyleBackColor = false;
            this.updatePersonButton.Click += new System.EventHandler(this.updatePersonButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 598);
            this.Controls.Add(this.updatePersonButton);
            this.Controls.Add(this.filteredPeopleList);
            this.Controls.Add(this.yearsExperiencePicker);
            this.Controls.Add(this.filterListLabel);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.allPeopleDropdown);
            this.Controls.Add(this.peopleLabel);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Linq 101 Demo";
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperiencePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.ComboBox allPeopleDropdown;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Label filterListLabel;
        private System.Windows.Forms.NumericUpDown yearsExperiencePicker;
        private System.Windows.Forms.ListBox filteredPeopleList;
        private System.Windows.Forms.Button updatePersonButton;
    }
}