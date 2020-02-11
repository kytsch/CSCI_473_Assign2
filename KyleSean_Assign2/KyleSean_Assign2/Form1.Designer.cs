namespace KyleSean_Assign2
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
            this.communities_groupbox = new System.Windows.Forms.GroupBox();
            this.sycamore_radio_button = new System.Windows.Forms.RadioButton();
            this.dekalb_radio_button = new System.Windows.Forms.RadioButton();
            this.toggle_for_sale_button = new System.Windows.Forms.Button();
            this.add_resident_button = new System.Windows.Forms.Button();
            this.buy_property_button = new System.Windows.Forms.Button();
            this.remove_resident_button = new System.Windows.Forms.Button();
            this.add_resident_groupbox = new System.Windows.Forms.GroupBox();
            this.add_new_resident_button = new System.Windows.Forms.Button();
            this.new_resident_residence_label = new System.Windows.Forms.Label();
            this.new_resident_residence_textBox = new System.Windows.Forms.TextBox();
            this.new_resident_birthday_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.new_resident_occupation_label = new System.Windows.Forms.Label();
            this.new_resident_occupation_textbox = new System.Windows.Forms.TextBox();
            this.new_resident_name_label = new System.Windows.Forms.Label();
            this.new_resident_name_textbox = new System.Windows.Forms.TextBox();
            this.add_property_groupbox = new System.Windows.Forms.GroupBox();
            this.new_property_garage_checkBox = new System.Windows.Forms.CheckBox();
            this.new_property_floors_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_property_floors_label = new System.Windows.Forms.Label();
            this.new_property_baths_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_property_baths_label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.new_property_bedrooms_label = new System.Windows.Forms.Label();
            this.new_property_square_footage_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_property_square_footage_label = new System.Windows.Forms.Label();
            this.new_property_apartment_label = new System.Windows.Forms.Label();
            this.new_property_apt_textbox = new System.Windows.Forms.TextBox();
            this.new_property_street_address_ = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.add_new_property_button = new System.Windows.Forms.Button();
            this.output_label = new System.Windows.Forms.Label();
            this.person_listbox = new System.Windows.Forms.ListBox();
            this.residence_listbox = new System.Windows.Forms.ListBox();
            this.person_label = new System.Windows.Forms.Label();
            this.residence_label = new System.Windows.Forms.Label();
            this.output_listbox = new System.Windows.Forms.ListBox();
            this.communities_groupbox.SuspendLayout();
            this.add_resident_groupbox.SuspendLayout();
            this.add_property_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.new_property_floors_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_property_baths_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_property_square_footage_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // communities_groupbox
            // 
            this.communities_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.communities_groupbox.Controls.Add(this.sycamore_radio_button);
            this.communities_groupbox.Controls.Add(this.dekalb_radio_button);
            this.communities_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.communities_groupbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.communities_groupbox.Location = new System.Drawing.Point(17, 16);
            this.communities_groupbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.communities_groupbox.Name = "communities_groupbox";
            this.communities_groupbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.communities_groupbox.Size = new System.Drawing.Size(205, 114);
            this.communities_groupbox.TabIndex = 0;
            this.communities_groupbox.TabStop = false;
            this.communities_groupbox.Text = "Communities";
            // 
            // sycamore_radio_button
            // 
            this.sycamore_radio_button.AutoSize = true;
            this.sycamore_radio_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sycamore_radio_button.Location = new System.Drawing.Point(8, 71);
            this.sycamore_radio_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sycamore_radio_button.Name = "sycamore_radio_button";
            this.sycamore_radio_button.Size = new System.Drawing.Size(122, 29);
            this.sycamore_radio_button.TabIndex = 1;
            this.sycamore_radio_button.TabStop = true;
            this.sycamore_radio_button.Text = "Sycamore";
            this.sycamore_radio_button.UseVisualStyleBackColor = true;
            this.sycamore_radio_button.Click += new System.EventHandler(this.sycamore_radio_button_Click);
            // 
            // dekalb_radio_button
            // 
            this.dekalb_radio_button.AutoSize = true;
            this.dekalb_radio_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dekalb_radio_button.Location = new System.Drawing.Point(8, 34);
            this.dekalb_radio_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dekalb_radio_button.Name = "dekalb_radio_button";
            this.dekalb_radio_button.Size = new System.Drawing.Size(98, 29);
            this.dekalb_radio_button.TabIndex = 11;
            this.dekalb_radio_button.TabStop = true;
            this.dekalb_radio_button.Text = "DeKalb";
            this.dekalb_radio_button.UseVisualStyleBackColor = true;
            this.dekalb_radio_button.CheckedChanged += new System.EventHandler(this.dekalb_radio_button_CheckedChanged);
            // 
            // toggle_for_sale_button
            // 
            this.toggle_for_sale_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.toggle_for_sale_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggle_for_sale_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggle_for_sale_button.Location = new System.Drawing.Point(243, 43);
            this.toggle_for_sale_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toggle_for_sale_button.Name = "toggle_for_sale_button";
            this.toggle_for_sale_button.Size = new System.Drawing.Size(148, 33);
            this.toggle_for_sale_button.TabIndex = 1;
            this.toggle_for_sale_button.Text = "Toggle For-Sale";
            this.toggle_for_sale_button.UseVisualStyleBackColor = false;
            this.toggle_for_sale_button.Click += new System.EventHandler(this.toggle_for_sale_button_Click);
            // 
            // add_resident_button
            // 
            this.add_resident_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.add_resident_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_resident_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_resident_button.Location = new System.Drawing.Point(429, 43);
            this.add_resident_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_resident_button.Name = "add_resident_button";
            this.add_resident_button.Size = new System.Drawing.Size(148, 33);
            this.add_resident_button.TabIndex = 2;
            this.add_resident_button.Text = "Add Resident";
            this.add_resident_button.UseVisualStyleBackColor = false;
            this.add_resident_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // buy_property_button
            // 
            this.buy_property_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buy_property_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy_property_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_property_button.Location = new System.Drawing.Point(243, 84);
            this.buy_property_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buy_property_button.Name = "buy_property_button";
            this.buy_property_button.Size = new System.Drawing.Size(148, 33);
            this.buy_property_button.TabIndex = 3;
            this.buy_property_button.Text = "Buy Property";
            this.buy_property_button.UseVisualStyleBackColor = false;
            // 
            // remove_resident_button
            // 
            this.remove_resident_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.remove_resident_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_resident_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_resident_button.Location = new System.Drawing.Point(429, 84);
            this.remove_resident_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remove_resident_button.Name = "remove_resident_button";
            this.remove_resident_button.Size = new System.Drawing.Size(148, 33);
            this.remove_resident_button.TabIndex = 4;
            this.remove_resident_button.Text = "Remove Resident";
            this.remove_resident_button.UseVisualStyleBackColor = false;
            this.remove_resident_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // add_resident_groupbox
            // 
            this.add_resident_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.add_resident_groupbox.Controls.Add(this.add_new_resident_button);
            this.add_resident_groupbox.Controls.Add(this.new_resident_residence_label);
            this.add_resident_groupbox.Controls.Add(this.new_resident_residence_textBox);
            this.add_resident_groupbox.Controls.Add(this.new_resident_birthday_label);
            this.add_resident_groupbox.Controls.Add(this.textBox1);
            this.add_resident_groupbox.Controls.Add(this.new_resident_occupation_label);
            this.add_resident_groupbox.Controls.Add(this.new_resident_occupation_textbox);
            this.add_resident_groupbox.Controls.Add(this.new_resident_name_label);
            this.add_resident_groupbox.Controls.Add(this.new_resident_name_textbox);
            this.add_resident_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_resident_groupbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_resident_groupbox.Location = new System.Drawing.Point(17, 155);
            this.add_resident_groupbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_resident_groupbox.Name = "add_resident_groupbox";
            this.add_resident_groupbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_resident_groupbox.Size = new System.Drawing.Size(265, 342);
            this.add_resident_groupbox.TabIndex = 2;
            this.add_resident_groupbox.TabStop = false;
            this.add_resident_groupbox.Text = "Add New Resident";
            // 
            // add_new_resident_button
            // 
            this.add_new_resident_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.add_new_resident_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_new_resident_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_resident_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_new_resident_button.Location = new System.Drawing.Point(144, 293);
            this.add_new_resident_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_new_resident_button.Name = "add_new_resident_button";
            this.add_new_resident_button.Size = new System.Drawing.Size(100, 28);
            this.add_new_resident_button.TabIndex = 8;
            this.add_new_resident_button.Text = "Add";
            this.add_new_resident_button.UseVisualStyleBackColor = false;
            // 
            // new_resident_residence_label
            // 
            this.new_resident_residence_label.AutoSize = true;
            this.new_resident_residence_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_resident_residence_label.Location = new System.Drawing.Point(5, 219);
            this.new_resident_residence_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_resident_residence_label.Name = "new_resident_residence_label";
            this.new_resident_residence_label.Size = new System.Drawing.Size(104, 25);
            this.new_resident_residence_label.TabIndex = 7;
            this.new_resident_residence_label.Text = "Residence";
            // 
            // new_resident_residence_textBox
            // 
            this.new_resident_residence_textBox.AllowDrop = true;
            this.new_resident_residence_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_resident_residence_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_resident_residence_textBox.Location = new System.Drawing.Point(9, 247);
            this.new_resident_residence_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_resident_residence_textBox.Name = "new_resident_residence_textBox";
            this.new_resident_residence_textBox.Size = new System.Drawing.Size(249, 23);
            this.new_resident_residence_textBox.TabIndex = 6;
            // 
            // new_resident_birthday_label
            // 
            this.new_resident_birthday_label.AutoSize = true;
            this.new_resident_birthday_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_resident_birthday_label.Location = new System.Drawing.Point(4, 155);
            this.new_resident_birthday_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_resident_birthday_label.Name = "new_resident_birthday_label";
            this.new_resident_birthday_label.Size = new System.Drawing.Size(83, 25);
            this.new_resident_birthday_label.TabIndex = 5;
            this.new_resident_birthday_label.Text = "Birthday";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 183);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 23);
            this.textBox1.TabIndex = 4;
            // 
            // new_resident_occupation_label
            // 
            this.new_resident_occupation_label.AutoSize = true;
            this.new_resident_occupation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_resident_occupation_label.Location = new System.Drawing.Point(4, 92);
            this.new_resident_occupation_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_resident_occupation_label.Name = "new_resident_occupation_label";
            this.new_resident_occupation_label.Size = new System.Drawing.Size(112, 25);
            this.new_resident_occupation_label.TabIndex = 3;
            this.new_resident_occupation_label.Text = "Occupation";
            // 
            // new_resident_occupation_textbox
            // 
            this.new_resident_occupation_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_resident_occupation_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_resident_occupation_textbox.Location = new System.Drawing.Point(8, 121);
            this.new_resident_occupation_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_resident_occupation_textbox.Name = "new_resident_occupation_textbox";
            this.new_resident_occupation_textbox.Size = new System.Drawing.Size(249, 23);
            this.new_resident_occupation_textbox.TabIndex = 2;
            // 
            // new_resident_name_label
            // 
            this.new_resident_name_label.AutoSize = true;
            this.new_resident_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_resident_name_label.Location = new System.Drawing.Point(4, 31);
            this.new_resident_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_resident_name_label.Name = "new_resident_name_label";
            this.new_resident_name_label.Size = new System.Drawing.Size(64, 25);
            this.new_resident_name_label.TabIndex = 1;
            this.new_resident_name_label.Text = "Name";
            // 
            // new_resident_name_textbox
            // 
            this.new_resident_name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_resident_name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_resident_name_textbox.Location = new System.Drawing.Point(8, 59);
            this.new_resident_name_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_resident_name_textbox.Name = "new_resident_name_textbox";
            this.new_resident_name_textbox.Size = new System.Drawing.Size(249, 23);
            this.new_resident_name_textbox.TabIndex = 0;
            // 
            // add_property_groupbox
            // 
            this.add_property_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.add_property_groupbox.Controls.Add(this.new_property_garage_checkBox);
            this.add_property_groupbox.Controls.Add(this.new_property_floors_numericUpDown);
            this.add_property_groupbox.Controls.Add(this.new_property_floors_label);
            this.add_property_groupbox.Controls.Add(this.new_property_baths_numericUpDown);
            this.add_property_groupbox.Controls.Add(this.new_property_baths_label);
            this.add_property_groupbox.Controls.Add(this.numericUpDown1);
            this.add_property_groupbox.Controls.Add(this.new_property_bedrooms_label);
            this.add_property_groupbox.Controls.Add(this.new_property_square_footage_numericUpDown);
            this.add_property_groupbox.Controls.Add(this.new_property_square_footage_label);
            this.add_property_groupbox.Controls.Add(this.new_property_apartment_label);
            this.add_property_groupbox.Controls.Add(this.new_property_apt_textbox);
            this.add_property_groupbox.Controls.Add(this.new_property_street_address_);
            this.add_property_groupbox.Controls.Add(this.textBox3);
            this.add_property_groupbox.Controls.Add(this.add_new_property_button);
            this.add_property_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_property_groupbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_property_groupbox.Location = new System.Drawing.Point(313, 155);
            this.add_property_groupbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_property_groupbox.Name = "add_property_groupbox";
            this.add_property_groupbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_property_groupbox.Size = new System.Drawing.Size(265, 342);
            this.add_property_groupbox.TabIndex = 3;
            this.add_property_groupbox.TabStop = false;
            this.add_property_groupbox.Text = "Add Property";
            // 
            // new_property_garage_checkBox
            // 
            this.new_property_garage_checkBox.AutoSize = true;
            this.new_property_garage_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_property_garage_checkBox.Location = new System.Drawing.Point(9, 249);
            this.new_property_garage_checkBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_property_garage_checkBox.Name = "new_property_garage_checkBox";
            this.new_property_garage_checkBox.Size = new System.Drawing.Size(95, 24);
            this.new_property_garage_checkBox.TabIndex = 23;
            this.new_property_garage_checkBox.Text = "Garage?";
            this.new_property_garage_checkBox.UseVisualStyleBackColor = true;
            // 
            // new_property_floors_numericUpDown
            // 
            this.new_property_floors_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_property_floors_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_property_floors_numericUpDown.Location = new System.Drawing.Point(192, 194);
            this.new_property_floors_numericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_property_floors_numericUpDown.Name = "new_property_floors_numericUpDown";
            this.new_property_floors_numericUpDown.Size = new System.Drawing.Size(49, 26);
            this.new_property_floors_numericUpDown.TabIndex = 22;
            // 
            // new_property_floors_label
            // 
            this.new_property_floors_label.AutoSize = true;
            this.new_property_floors_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_property_floors_label.Location = new System.Drawing.Point(188, 166);
            this.new_property_floors_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_property_floors_label.Name = "new_property_floors_label";
            this.new_property_floors_label.Size = new System.Drawing.Size(51, 18);
            this.new_property_floors_label.TabIndex = 21;
            this.new_property_floors_label.Text = "Floors";
            // 
            // new_property_baths_numericUpDown
            // 
            this.new_property_baths_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_property_baths_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_property_baths_numericUpDown.Location = new System.Drawing.Point(105, 194);
            this.new_property_baths_numericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_property_baths_numericUpDown.Name = "new_property_baths_numericUpDown";
            this.new_property_baths_numericUpDown.Size = new System.Drawing.Size(49, 26);
            this.new_property_baths_numericUpDown.TabIndex = 20;
            // 
            // new_property_baths_label
            // 
            this.new_property_baths_label.AutoSize = true;
            this.new_property_baths_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_property_baths_label.Location = new System.Drawing.Point(101, 166);
            this.new_property_baths_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_property_baths_label.Name = "new_property_baths_label";
            this.new_property_baths_label.Size = new System.Drawing.Size(46, 18);
            this.new_property_baths_label.TabIndex = 19;
            this.new_property_baths_label.Text = "Baths";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(12, 193);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown1.TabIndex = 18;
            // 
            // new_property_bedrooms_label
            // 
            this.new_property_bedrooms_label.AutoSize = true;
            this.new_property_bedrooms_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_property_bedrooms_label.Location = new System.Drawing.Point(8, 165);
            this.new_property_bedrooms_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_property_bedrooms_label.Name = "new_property_bedrooms_label";
            this.new_property_bedrooms_label.Size = new System.Drawing.Size(78, 18);
            this.new_property_bedrooms_label.TabIndex = 17;
            this.new_property_bedrooms_label.Text = "Bedrooms";
            // 
            // new_property_square_footage_numericUpDown
            // 
            this.new_property_square_footage_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_property_square_footage_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_property_square_footage_numericUpDown.Location = new System.Drawing.Point(12, 122);
            this.new_property_square_footage_numericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_property_square_footage_numericUpDown.Name = "new_property_square_footage_numericUpDown";
            this.new_property_square_footage_numericUpDown.Size = new System.Drawing.Size(111, 26);
            this.new_property_square_footage_numericUpDown.TabIndex = 16;
            // 
            // new_property_square_footage_label
            // 
            this.new_property_square_footage_label.AutoSize = true;
            this.new_property_square_footage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_property_square_footage_label.Location = new System.Drawing.Point(7, 92);
            this.new_property_square_footage_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_property_square_footage_label.Name = "new_property_square_footage_label";
            this.new_property_square_footage_label.Size = new System.Drawing.Size(153, 25);
            this.new_property_square_footage_label.TabIndex = 15;
            this.new_property_square_footage_label.Text = "Square Footage";
            // 
            // new_property_apartment_label
            // 
            this.new_property_apartment_label.AutoSize = true;
            this.new_property_apartment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_property_apartment_label.Location = new System.Drawing.Point(207, 32);
            this.new_property_apartment_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_property_apartment_label.Name = "new_property_apartment_label";
            this.new_property_apartment_label.Size = new System.Drawing.Size(42, 25);
            this.new_property_apartment_label.TabIndex = 13;
            this.new_property_apartment_label.Text = "Apt";
            // 
            // new_property_apt_textbox
            // 
            this.new_property_apt_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_property_apt_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_property_apt_textbox.Location = new System.Drawing.Point(211, 60);
            this.new_property_apt_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_property_apt_textbox.Name = "new_property_apt_textbox";
            this.new_property_apt_textbox.Size = new System.Drawing.Size(47, 23);
            this.new_property_apt_textbox.TabIndex = 12;
            // 
            // new_property_street_address_
            // 
            this.new_property_street_address_.AutoSize = true;
            this.new_property_street_address_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_property_street_address_.Location = new System.Drawing.Point(5, 32);
            this.new_property_street_address_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_property_street_address_.Name = "new_property_street_address_";
            this.new_property_street_address_.Size = new System.Drawing.Size(142, 25);
            this.new_property_street_address_.TabIndex = 11;
            this.new_property_street_address_.Text = "Street Address";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(9, 60);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 23);
            this.textBox3.TabIndex = 10;
            // 
            // add_new_property_button
            // 
            this.add_new_property_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.add_new_property_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_new_property_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_property_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_new_property_button.Location = new System.Drawing.Point(141, 293);
            this.add_new_property_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_new_property_button.Name = "add_new_property_button";
            this.add_new_property_button.Size = new System.Drawing.Size(100, 28);
            this.add_new_property_button.TabIndex = 9;
            this.add_new_property_button.Text = "Add";
            this.add_new_property_button.UseVisualStyleBackColor = false;
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.output_label.Location = new System.Drawing.Point(17, 500);
            this.output_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(84, 29);
            this.output_label.TabIndex = 5;
            this.output_label.Text = "Output";
            this.output_label.Click += new System.EventHandler(this.output_label_Click);
            // 
            // person_listbox
            // 
            this.person_listbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person_listbox.FormattingEnabled = true;
            this.person_listbox.ItemHeight = 17;
            this.person_listbox.Location = new System.Drawing.Point(596, 43);
            this.person_listbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.person_listbox.Name = "person_listbox";
            this.person_listbox.Size = new System.Drawing.Size(289, 429);
            this.person_listbox.TabIndex = 7;
            this.person_listbox.SelectedIndexChanged += new System.EventHandler(this.person_listbox_SelectedIndexChanged);
            // 
            // residence_listbox
            // 
            this.residence_listbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residence_listbox.FormattingEnabled = true;
            this.residence_listbox.ItemHeight = 17;
            this.residence_listbox.Location = new System.Drawing.Point(893, 43);
            this.residence_listbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.residence_listbox.Name = "residence_listbox";
            this.residence_listbox.Size = new System.Drawing.Size(383, 429);
            this.residence_listbox.TabIndex = 8;
            // 
            // person_label
            // 
            this.person_label.AutoSize = true;
            this.person_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person_label.ForeColor = System.Drawing.Color.White;
            this.person_label.Location = new System.Drawing.Point(591, 11);
            this.person_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.person_label.Name = "person_label";
            this.person_label.Size = new System.Drawing.Size(87, 26);
            this.person_label.TabIndex = 9;
            this.person_label.Text = "Person";
            // 
            // residence_label
            // 
            this.residence_label.AutoSize = true;
            this.residence_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residence_label.ForeColor = System.Drawing.Color.White;
            this.residence_label.Location = new System.Drawing.Point(913, 9);
            this.residence_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.residence_label.Name = "residence_label";
            this.residence_label.Size = new System.Drawing.Size(289, 26);
            this.residence_label.TabIndex = 10;
            this.residence_label.Text = "Residence (* == For Sale)";
            // 
            // output_listbox
            // 
            this.output_listbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_listbox.FormattingEnabled = true;
            this.output_listbox.ItemHeight = 17;
            this.output_listbox.Location = new System.Drawing.Point(17, 534);
            this.output_listbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output_listbox.Name = "output_listbox";
            this.output_listbox.Size = new System.Drawing.Size(1259, 89);
            this.output_listbox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1289, 682);
            this.Controls.Add(this.output_listbox);
            this.Controls.Add(this.residence_label);
            this.Controls.Add(this.person_label);
            this.Controls.Add(this.residence_listbox);
            this.Controls.Add(this.person_listbox);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.add_property_groupbox);
            this.Controls.Add(this.add_resident_groupbox);
            this.Controls.Add(this.remove_resident_button);
            this.Controls.Add(this.buy_property_button);
            this.Controls.Add(this.add_resident_button);
            this.Controls.Add(this.toggle_for_sale_button);
            this.Controls.Add(this.communities_groupbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.communities_groupbox.ResumeLayout(false);
            this.communities_groupbox.PerformLayout();
            this.add_resident_groupbox.ResumeLayout(false);
            this.add_resident_groupbox.PerformLayout();
            this.add_property_groupbox.ResumeLayout(false);
            this.add_property_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.new_property_floors_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_property_baths_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_property_square_footage_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox communities_groupbox;
        private System.Windows.Forms.RadioButton sycamore_radio_button;
        private System.Windows.Forms.RadioButton dekalb_radio_button;
        private System.Windows.Forms.Button toggle_for_sale_button;
        private System.Windows.Forms.Button add_resident_button;
        private System.Windows.Forms.Button buy_property_button;
        private System.Windows.Forms.Button remove_resident_button;
        private System.Windows.Forms.GroupBox add_resident_groupbox;
        private System.Windows.Forms.GroupBox add_property_groupbox;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.ListBox person_listbox;
        private System.Windows.Forms.ListBox residence_listbox;
        private System.Windows.Forms.Label person_label;
        private System.Windows.Forms.Label residence_label;
        private System.Windows.Forms.Button add_new_resident_button;
        private System.Windows.Forms.Label new_resident_residence_label;
        private System.Windows.Forms.TextBox new_resident_residence_textBox;
        private System.Windows.Forms.Label new_resident_birthday_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label new_resident_occupation_label;
        private System.Windows.Forms.TextBox new_resident_occupation_textbox;
        private System.Windows.Forms.Label new_resident_name_label;
        private System.Windows.Forms.TextBox new_resident_name_textbox;
        private System.Windows.Forms.CheckBox new_property_garage_checkBox;
        private System.Windows.Forms.NumericUpDown new_property_floors_numericUpDown;
        private System.Windows.Forms.Label new_property_floors_label;
        private System.Windows.Forms.NumericUpDown new_property_baths_numericUpDown;
        private System.Windows.Forms.Label new_property_baths_label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label new_property_bedrooms_label;
        private System.Windows.Forms.NumericUpDown new_property_square_footage_numericUpDown;
        private System.Windows.Forms.Label new_property_square_footage_label;
        private System.Windows.Forms.Label new_property_apartment_label;
        private System.Windows.Forms.TextBox new_property_apt_textbox;
        private System.Windows.Forms.Label new_property_street_address_;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button add_new_property_button;
        private System.Windows.Forms.ListBox output_listbox;
    }
}

