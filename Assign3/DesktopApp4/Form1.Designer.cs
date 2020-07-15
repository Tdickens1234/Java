using System;

namespace DesktopApp4
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
            this.ClassComboClass = new System.Windows.Forms.ComboBox();
            this.ServerComboClass = new System.Windows.Forms.ComboBox();
            this.RacePercentButton = new System.Windows.Forms.Button();
            this.ServerComboRace = new System.Windows.Forms.ComboBox();
            this.RoleComboRole = new System.Windows.Forms.ComboBox();
            this.ServerComboRole = new System.Windows.Forms.ComboBox();
            this.RoleTypesButton = new System.Windows.Forms.Button();
            this.ClassTypesButton = new System.Windows.Forms.Button();
            this.MinNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxNumeric = new System.Windows.Forms.NumericUpDown();
            this.TypeComboGuild = new System.Windows.Forms.ComboBox();
            this.GuildButton = new System.Windows.Forms.Button();
            this.TankRadio = new System.Windows.Forms.RadioButton();
            this.HealerRadio = new System.Windows.Forms.RadioButton();
            this.DamageRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerRoleButton = new System.Windows.Forms.Button();
            this.MaxLevelPercentButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassComboClass
            // 
            this.ClassComboClass.FormattingEnabled = true;
            this.ClassComboClass.Location = new System.Drawing.Point(11, 53);
            this.ClassComboClass.Name = "ClassComboClass";
            this.ClassComboClass.Size = new System.Drawing.Size(127, 21);
            this.ClassComboClass.TabIndex = 0;
            // 
            // ServerComboClass
            // 
            this.ServerComboClass.FormattingEnabled = true;
            this.ServerComboClass.Location = new System.Drawing.Point(172, 53);
            this.ServerComboClass.Name = "ServerComboClass";
            this.ServerComboClass.Size = new System.Drawing.Size(125, 21);
            this.ServerComboClass.TabIndex = 1;
            this.ServerComboClass.SelectedIndexChanged += new System.EventHandler(this.ServerComboClass_SelectedIndexChanged);
            // 
            // RacePercentButton
            // 
            this.RacePercentButton.Location = new System.Drawing.Point(348, 135);
            this.RacePercentButton.Name = "RacePercentButton";
            this.RacePercentButton.Size = new System.Drawing.Size(88, 21);
            this.RacePercentButton.TabIndex = 2;
            this.RacePercentButton.Text = "Show Results";
            this.RacePercentButton.UseVisualStyleBackColor = true;
            this.RacePercentButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ServerComboRace
            // 
            this.ServerComboRace.FormattingEnabled = true;
            this.ServerComboRace.Location = new System.Drawing.Point(172, 136);
            this.ServerComboRace.Name = "ServerComboRace";
            this.ServerComboRace.Size = new System.Drawing.Size(125, 21);
            this.ServerComboRace.TabIndex = 3;
            this.ServerComboRace.SelectedIndexChanged += new System.EventHandler(this.ServerComboRace_SelectedIndexChanged);
            // 
            // RoleComboRole
            // 
            this.RoleComboRole.FormattingEnabled = true;
            this.RoleComboRole.Location = new System.Drawing.Point(10, 214);
            this.RoleComboRole.Name = "RoleComboRole";
            this.RoleComboRole.Size = new System.Drawing.Size(127, 21);
            this.RoleComboRole.TabIndex = 4;
            // 
            // ServerComboRole
            // 
            this.ServerComboRole.FormattingEnabled = true;
            this.ServerComboRole.Location = new System.Drawing.Point(175, 214);
            this.ServerComboRole.Name = "ServerComboRole";
            this.ServerComboRole.Size = new System.Drawing.Size(125, 21);
            this.ServerComboRole.TabIndex = 5;
            // 
            // RoleTypesButton
            // 
            this.RoleTypesButton.Location = new System.Drawing.Point(348, 215);
            this.RoleTypesButton.Name = "RoleTypesButton";
            this.RoleTypesButton.Size = new System.Drawing.Size(88, 20);
            this.RoleTypesButton.TabIndex = 6;
            this.RoleTypesButton.Text = "Show Results";
            this.RoleTypesButton.UseVisualStyleBackColor = true;
            this.RoleTypesButton.Click += new System.EventHandler(this.RoleTypesButton_Click);
            // 
            // ClassTypesButton
            // 
            this.ClassTypesButton.Location = new System.Drawing.Point(348, 52);
            this.ClassTypesButton.Name = "ClassTypesButton";
            this.ClassTypesButton.Size = new System.Drawing.Size(88, 20);
            this.ClassTypesButton.TabIndex = 7;
            this.ClassTypesButton.Text = "Show Results";
            this.ClassTypesButton.UseVisualStyleBackColor = true;
            this.ClassTypesButton.Click += new System.EventHandler(this.ClassTypesButton_Click);
            // 
            // MinNumeric
            // 
            this.MinNumeric.Location = new System.Drawing.Point(12, 268);
            this.MinNumeric.Name = "MinNumeric";
            this.MinNumeric.Size = new System.Drawing.Size(40, 20);
            this.MinNumeric.TabIndex = 8;
            this.MinNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MaxNumeric
            // 
            this.MaxNumeric.Location = new System.Drawing.Point(96, 268);
            this.MaxNumeric.Name = "MaxNumeric";
            this.MaxNumeric.Size = new System.Drawing.Size(43, 20);
            this.MaxNumeric.TabIndex = 9;
            this.MaxNumeric.ValueChanged += new System.EventHandler(this.MaxNumeric_ValueChanged_1);
            // 
            // TypeComboGuild
            // 
            this.TypeComboGuild.FormattingEnabled = true;
            this.TypeComboGuild.Location = new System.Drawing.Point(10, 349);
            this.TypeComboGuild.Name = "TypeComboGuild";
            this.TypeComboGuild.Size = new System.Drawing.Size(126, 21);
            this.TypeComboGuild.TabIndex = 10;
            this.TypeComboGuild.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // GuildButton
            // 
            this.GuildButton.Location = new System.Drawing.Point(348, 349);
            this.GuildButton.Name = "GuildButton";
            this.GuildButton.Size = new System.Drawing.Size(88, 21);
            this.GuildButton.TabIndex = 11;
            this.GuildButton.Text = "Show Results";
            this.GuildButton.UseVisualStyleBackColor = true;
            this.GuildButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // TankRadio
            // 
            this.TankRadio.AutoSize = true;
            this.TankRadio.Location = new System.Drawing.Point(15, 25);
            this.TankRadio.Name = "TankRadio";
            this.TankRadio.Size = new System.Drawing.Size(50, 17);
            this.TankRadio.TabIndex = 12;
            this.TankRadio.TabStop = true;
            this.TankRadio.Text = "Tank";
            this.TankRadio.UseVisualStyleBackColor = true;
            // 
            // HealerRadio
            // 
            this.HealerRadio.AutoSize = true;
            this.HealerRadio.Location = new System.Drawing.Point(71, 25);
            this.HealerRadio.Name = "HealerRadio";
            this.HealerRadio.Size = new System.Drawing.Size(56, 17);
            this.HealerRadio.TabIndex = 13;
            this.HealerRadio.TabStop = true;
            this.HealerRadio.Text = "Healer";
            this.HealerRadio.UseVisualStyleBackColor = true;
            // 
            // DamageRadio
            // 
            this.DamageRadio.AutoSize = true;
            this.DamageRadio.Location = new System.Drawing.Point(133, 25);
            this.DamageRadio.Name = "DamageRadio";
            this.DamageRadio.Size = new System.Drawing.Size(65, 17);
            this.DamageRadio.TabIndex = 14;
            this.DamageRadio.TabStop = true;
            this.DamageRadio.Text = "Damage";
            this.DamageRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.DamageRadio);
            this.groupBox1.Controls.Add(this.HealerRadio);
            this.groupBox1.Controls.Add(this.TankRadio);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(6, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 67);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PlayerRoleButton
            // 
            this.PlayerRoleButton.Location = new System.Drawing.Point(348, 445);
            this.PlayerRoleButton.Name = "PlayerRoleButton";
            this.PlayerRoleButton.Size = new System.Drawing.Size(88, 19);
            this.PlayerRoleButton.TabIndex = 16;
            this.PlayerRoleButton.Text = "Show Results";
            this.PlayerRoleButton.UseVisualStyleBackColor = true;
            this.PlayerRoleButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // MaxLevelPercentButton
            // 
            this.MaxLevelPercentButton.Location = new System.Drawing.Point(348, 537);
            this.MaxLevelPercentButton.Name = "MaxLevelPercentButton";
            this.MaxLevelPercentButton.Size = new System.Drawing.Size(88, 20);
            this.MaxLevelPercentButton.TabIndex = 17;
            this.MaxLevelPercentButton.Text = "Show Results";
            this.MaxLevelPercentButton.UseVisualStyleBackColor = true;
            this.MaxLevelPercentButton.Click += new System.EventHandler(this.MaxLevelPercentButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(475, 52);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(784, 504);
            this.OutputBox.TabIndex = 18;
            this.OutputBox.Text = "";
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "All Class Types From a Single Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(172, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(11, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Percentage of Each Race From a Single Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(172, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(11, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(412, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "All Role Types From a Single Server Within a Level Range";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(11, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(174, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Server";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(11, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(95, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(12, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "All Guilds of a Single Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(7, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(372, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "All Players Who Could Fill a Role But Currently Aren\'t";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(12, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(8, 507);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(322, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "Percentage of Max Level Players in All Guilds";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(472, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "Query";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1311, 626);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.MaxLevelPercentButton);
            this.Controls.Add(this.PlayerRoleButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GuildButton);
            this.Controls.Add(this.TypeComboGuild);
            this.Controls.Add(this.MaxNumeric);
            this.Controls.Add(this.MinNumeric);
            this.Controls.Add(this.ClassTypesButton);
            this.Controls.Add(this.RoleTypesButton);
            this.Controls.Add(this.ServerComboRole);
            this.Controls.Add(this.RoleComboRole);
            this.Controls.Add(this.ServerComboRace);
            this.Controls.Add(this.RacePercentButton);
            this.Controls.Add(this.ServerComboClass);
            this.Controls.Add(this.ClassComboClass);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "World of ConflictCraft Querying System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassComboClass;
        private System.Windows.Forms.ComboBox ServerComboClass;
        private System.Windows.Forms.Button RacePercentButton;
        private System.Windows.Forms.ComboBox ServerComboRace;
        private System.Windows.Forms.ComboBox RoleComboRole;
        private System.Windows.Forms.ComboBox ServerComboRole;
        private System.Windows.Forms.Button RoleTypesButton;
        private System.Windows.Forms.Button ClassTypesButton;
        private System.Windows.Forms.NumericUpDown MinNumeric;
        private System.Windows.Forms.NumericUpDown MaxNumeric;
        private System.Windows.Forms.ComboBox TypeComboGuild;
        private System.Windows.Forms.Button GuildButton;
        private System.Windows.Forms.RadioButton TankRadio;
        private System.Windows.Forms.RadioButton HealerRadio;
        private System.Windows.Forms.RadioButton DamageRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PlayerRoleButton;
        private System.Windows.Forms.Button MaxLevelPercentButton;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

