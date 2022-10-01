namespace BestOil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxPetrols = new System.Windows.Forms.ComboBox();
            this.textBoxPricePetrol = new System.Windows.Forms.TextBox();
            this.radioButtonLitr = new System.Windows.Forms.RadioButton();
            this.radioButtonMoney = new System.Windows.Forms.RadioButton();
            this.LitrtextBox = new System.Windows.Forms.TextBox();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.PricePetrol = new System.Windows.Forms.Label();
            this.PetrolStation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalAmountPetrol = new System.Windows.Forms.Label();
            this.dollar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Petrol = new System.Windows.Forms.Label();
            this.HotDog = new System.Windows.Forms.CheckBox();
            this.Gamburger = new System.Windows.Forms.CheckBox();
            this.Free = new System.Windows.Forms.CheckBox();
            this.Cola = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.PriceCafe = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.AmountCafe = new System.Windows.Forms.GroupBox();
            this.TotalAmountCafe = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MiniCafe = new System.Windows.Forms.GroupBox();
            this.panelFood = new System.Windows.Forms.Panel();
            this.PanelTextBoxes = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Last = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AllAmount = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.PetrolStation.SuspendLayout();
            this.AmountGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AmountCafe.SuspendLayout();
            this.MiniCafe.SuspendLayout();
            this.panelFood.SuspendLayout();
            this.PanelTextBoxes.SuspendLayout();
            this.Last.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPetrols
            // 
            this.comboBoxPetrols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPetrols.FormattingEnabled = true;
            this.comboBoxPetrols.Items.AddRange(new object[] {
            " A-72",
            " A-76",
            " Aİ-93",
            " Aİ-95",
            " Aİ-98"});
            this.comboBoxPetrols.Location = new System.Drawing.Point(85, 31);
            this.comboBoxPetrols.Name = "comboBoxPetrols";
            this.comboBoxPetrols.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPetrols.TabIndex = 0;
            // 
            // textBoxPricePetrol
            // 
            this.textBoxPricePetrol.Location = new System.Drawing.Point(85, 80);
            this.textBoxPricePetrol.Name = "textBoxPricePetrol";
            this.textBoxPricePetrol.PlaceholderText = "0.00";
            this.textBoxPricePetrol.Size = new System.Drawing.Size(100, 23);
            this.textBoxPricePetrol.TabIndex = 1;
            this.textBoxPricePetrol.TextChanged += new System.EventHandler(this.textBoxPricePetrol_TextChanged);
            this.textBoxPricePetrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPricePetrol_KeyPress);
            // 
            // radioButtonLitr
            // 
            this.radioButtonLitr.AutoSize = true;
            this.radioButtonLitr.Location = new System.Drawing.Point(3, 3);
            this.radioButtonLitr.Name = "radioButtonLitr";
            this.radioButtonLitr.Size = new System.Drawing.Size(42, 19);
            this.radioButtonLitr.TabIndex = 2;
            this.radioButtonLitr.TabStop = true;
            this.radioButtonLitr.Tag = "LitrtextBox";
            this.radioButtonLitr.Text = "Litr";
            this.radioButtonLitr.UseVisualStyleBackColor = true;
            this.radioButtonLitr.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonMoney
            // 
            this.radioButtonMoney.AutoSize = true;
            this.radioButtonMoney.Location = new System.Drawing.Point(3, 28);
            this.radioButtonMoney.Name = "radioButtonMoney";
            this.radioButtonMoney.Size = new System.Drawing.Size(62, 19);
            this.radioButtonMoney.TabIndex = 2;
            this.radioButtonMoney.TabStop = true;
            this.radioButtonMoney.Tag = "MoneyTextBox";
            this.radioButtonMoney.Text = "Money";
            this.radioButtonMoney.UseVisualStyleBackColor = true;
            this.radioButtonMoney.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // LitrtextBox
            // 
            this.LitrtextBox.Location = new System.Drawing.Point(131, 123);
            this.LitrtextBox.Name = "LitrtextBox";
            this.LitrtextBox.ReadOnly = true;
            this.LitrtextBox.Size = new System.Drawing.Size(75, 23);
            this.LitrtextBox.TabIndex = 3;
            this.LitrtextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.LitrtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPricePetrol_KeyPress);
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Location = new System.Drawing.Point(131, 152);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.ReadOnly = true;
            this.MoneyTextBox.Size = new System.Drawing.Size(75, 23);
            this.MoneyTextBox.TabIndex = 3;
            this.MoneyTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // PricePetrol
            // 
            this.PricePetrol.AutoSize = true;
            this.PricePetrol.Location = new System.Drawing.Point(9, 88);
            this.PricePetrol.Name = "PricePetrol";
            this.PricePetrol.Size = new System.Drawing.Size(33, 15);
            this.PricePetrol.TabIndex = 4;
            this.PricePetrol.Text = "Price";
            // 
            // PetrolStation
            // 
            this.PetrolStation.Controls.Add(this.label1);
            this.PetrolStation.Controls.Add(this.label3);
            this.PetrolStation.Controls.Add(this.label2);
            this.PetrolStation.Controls.Add(this.AmountGroupBox);
            this.PetrolStation.Controls.Add(this.panel1);
            this.PetrolStation.Controls.Add(this.MoneyTextBox);
            this.PetrolStation.Controls.Add(this.comboBoxPetrols);
            this.PetrolStation.Controls.Add(this.LitrtextBox);
            this.PetrolStation.Controls.Add(this.lbl_Petrol);
            this.PetrolStation.Controls.Add(this.PricePetrol);
            this.PetrolStation.Controls.Add(this.textBoxPricePetrol);
            this.PetrolStation.Location = new System.Drawing.Point(12, 12);
            this.PetrolStation.Name = "PetrolStation";
            this.PetrolStation.Size = new System.Drawing.Size(295, 334);
            this.PetrolStation.TabIndex = 5;
            this.PetrolStation.TabStop = false;
            this.PetrolStation.Text = "PetrolStation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "litr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "$";
            // 
            // AmountGroupBox
            // 
            this.AmountGroupBox.Controls.Add(this.TotalAmountPetrol);
            this.AmountGroupBox.Controls.Add(this.dollar);
            this.AmountGroupBox.Location = new System.Drawing.Point(20, 216);
            this.AmountGroupBox.Name = "AmountGroupBox";
            this.AmountGroupBox.Size = new System.Drawing.Size(233, 112);
            this.AmountGroupBox.TabIndex = 6;
            this.AmountGroupBox.TabStop = false;
            this.AmountGroupBox.Text = "Amount";
            // 
            // TotalAmountPetrol
            // 
            this.TotalAmountPetrol.AutoSize = true;
            this.TotalAmountPetrol.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAmountPetrol.Location = new System.Drawing.Point(146, 62);
            this.TotalAmountPetrol.Name = "TotalAmountPetrol";
            this.TotalAmountPetrol.Size = new System.Drawing.Size(59, 32);
            this.TotalAmountPetrol.TabIndex = 4;
            this.TotalAmountPetrol.Text = "0.00";
            // 
            // dollar
            // 
            this.dollar.AutoSize = true;
            this.dollar.Location = new System.Drawing.Point(211, 76);
            this.dollar.Name = "dollar";
            this.dollar.Size = new System.Drawing.Size(13, 15);
            this.dollar.TabIndex = 4;
            this.dollar.Text = "$";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonLitr);
            this.panel1.Controls.Add(this.radioButtonMoney);
            this.panel1.Location = new System.Drawing.Point(6, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 67);
            this.panel1.TabIndex = 5;
            // 
            // lbl_Petrol
            // 
            this.lbl_Petrol.AutoSize = true;
            this.lbl_Petrol.Location = new System.Drawing.Point(6, 39);
            this.lbl_Petrol.Name = "lbl_Petrol";
            this.lbl_Petrol.Size = new System.Drawing.Size(64, 15);
            this.lbl_Petrol.TabIndex = 4;
            this.lbl_Petrol.Text = "Petrol type";
            // 
            // HotDog
            // 
            this.HotDog.AutoSize = true;
            this.HotDog.Location = new System.Drawing.Point(29, 13);
            this.HotDog.Name = "HotDog";
            this.HotDog.Size = new System.Drawing.Size(73, 19);
            this.HotDog.TabIndex = 6;
            this.HotDog.Text = "Hot-Dog";
            this.HotDog.UseVisualStyleBackColor = true;
            this.HotDog.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Gamburger
            // 
            this.Gamburger.AutoSize = true;
            this.Gamburger.Location = new System.Drawing.Point(29, 46);
            this.Gamburger.Name = "Gamburger";
            this.Gamburger.Size = new System.Drawing.Size(86, 19);
            this.Gamburger.TabIndex = 6;
            this.Gamburger.Text = "Gamburger";
            this.Gamburger.UseVisualStyleBackColor = true;
            this.Gamburger.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Free
            // 
            this.Free.AutoSize = true;
            this.Free.Location = new System.Drawing.Point(29, 77);
            this.Free.Name = "Free";
            this.Free.Size = new System.Drawing.Size(48, 19);
            this.Free.TabIndex = 6;
            this.Free.Text = "Free";
            this.Free.UseVisualStyleBackColor = true;
            this.Free.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Cola
            // 
            this.Cola.AutoSize = true;
            this.Cola.Location = new System.Drawing.Point(29, 110);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(82, 19);
            this.Cola.TabIndex = 6;
            this.Cola.Text = "Coca-Cola";
            this.Cola.UseVisualStyleBackColor = true;
            this.Cola.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(16, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.Tag = "HotDog";
            this.textBox1.Text = "1.50";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPricePetrol_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(16, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 23);
            this.textBox2.TabIndex = 7;
            this.textBox2.Tag = "Gamburger";
            this.textBox2.Text = "2.00";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPricePetrol_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(16, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.Tag = "Free";
            this.textBox3.Text = "5.00";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPricePetrol_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(82, 13);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(58, 23);
            this.textBox5.TabIndex = 7;
            this.textBox5.Tag = "HotDog";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPricePetrol_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(83, 42);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(58, 23);
            this.textBox6.TabIndex = 7;
            this.textBox6.Tag = "Gamburger";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPricePetrol_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(83, 75);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(58, 23);
            this.textBox8.TabIndex = 7;
            this.textBox8.Tag = "Free";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPricePetrol_KeyPress);
            // 
            // PriceCafe
            // 
            this.PriceCafe.AutoSize = true;
            this.PriceCafe.Location = new System.Drawing.Point(208, 0);
            this.PriceCafe.Name = "PriceCafe";
            this.PriceCafe.Size = new System.Drawing.Size(33, 15);
            this.PriceCafe.TabIndex = 8;
            this.PriceCafe.Text = "Price";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(275, 0);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(40, 15);
            this.Count.TabIndex = 8;
            this.Count.Text = "Count";
            // 
            // AmountCafe
            // 
            this.AmountCafe.Controls.Add(this.TotalAmountCafe);
            this.AmountCafe.Controls.Add(this.label7);
            this.AmountCafe.Location = new System.Drawing.Point(108, 208);
            this.AmountCafe.Name = "AmountCafe";
            this.AmountCafe.Size = new System.Drawing.Size(233, 112);
            this.AmountCafe.TabIndex = 9;
            this.AmountCafe.TabStop = false;
            this.AmountCafe.Text = "Amount";
            // 
            // TotalAmountCafe
            // 
            this.TotalAmountCafe.AutoSize = true;
            this.TotalAmountCafe.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAmountCafe.Location = new System.Drawing.Point(146, 62);
            this.TotalAmountCafe.Name = "TotalAmountCafe";
            this.TotalAmountCafe.Size = new System.Drawing.Size(59, 32);
            this.TotalAmountCafe.TabIndex = 4;
            this.TotalAmountCafe.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "$";
            // 
            // MiniCafe
            // 
            this.MiniCafe.Controls.Add(this.panelFood);
            this.MiniCafe.Controls.Add(this.PanelTextBoxes);
            this.MiniCafe.Controls.Add(this.AmountCafe);
            this.MiniCafe.Controls.Add(this.Count);
            this.MiniCafe.Controls.Add(this.PriceCafe);
            this.MiniCafe.Location = new System.Drawing.Point(356, 12);
            this.MiniCafe.Name = "MiniCafe";
            this.MiniCafe.Size = new System.Drawing.Size(406, 331);
            this.MiniCafe.TabIndex = 10;
            this.MiniCafe.TabStop = false;
            this.MiniCafe.Text = "Mini-Kafe";
            // 
            // panelFood
            // 
            this.panelFood.Controls.Add(this.Cola);
            this.panelFood.Controls.Add(this.Free);
            this.panelFood.Controls.Add(this.Gamburger);
            this.panelFood.Controls.Add(this.HotDog);
            this.panelFood.Location = new System.Drawing.Point(57, 26);
            this.panelFood.Name = "panelFood";
            this.panelFood.Size = new System.Drawing.Size(126, 137);
            this.panelFood.TabIndex = 11;
            // 
            // PanelTextBoxes
            // 
            this.PanelTextBoxes.Controls.Add(this.textBox5);
            this.PanelTextBoxes.Controls.Add(this.textBox6);
            this.PanelTextBoxes.Controls.Add(this.textBox1);
            this.PanelTextBoxes.Controls.Add(this.textBox8);
            this.PanelTextBoxes.Controls.Add(this.textBox2);
            this.PanelTextBoxes.Controls.Add(this.textBox7);
            this.PanelTextBoxes.Controls.Add(this.textBox3);
            this.PanelTextBoxes.Controls.Add(this.textBox4);
            this.PanelTextBoxes.Location = new System.Drawing.Point(192, 28);
            this.PanelTextBoxes.Name = "PanelTextBoxes";
            this.PanelTextBoxes.Size = new System.Drawing.Size(163, 138);
            this.PanelTextBoxes.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(83, 112);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(58, 23);
            this.textBox7.TabIndex = 7;
            this.textBox7.Tag = "Cola";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPricePetrol_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(16, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(44, 23);
            this.textBox4.TabIndex = 7;
            this.textBox4.Tag = "Cola";
            this.textBox4.Text = "1.00";
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPricePetrol_KeyPress);
            // 
            // Last
            // 
            this.Last.Controls.Add(this.button1);
            this.Last.Controls.Add(this.label4);
            this.Last.Controls.Add(this.AllAmount);
            this.Last.Controls.Add(this.Calculate);
            this.Last.Location = new System.Drawing.Point(12, 352);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(750, 138);
            this.Last.TabIndex = 11;
            this.Last.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(9, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 95);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "$";
            // 
            // AllAmount
            // 
            this.AllAmount.AutoSize = true;
            this.AllAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllAmount.Location = new System.Drawing.Point(579, 80);
            this.AllAmount.Name = "AllAmount";
            this.AllAmount.Size = new System.Drawing.Size(59, 32);
            this.AllAmount.TabIndex = 1;
            this.AllAmount.Text = "0.00";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(166, 43);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(149, 69);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.MiniCafe);
            this.Controls.Add(this.PetrolStation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PetrolStation.ResumeLayout(false);
            this.PetrolStation.PerformLayout();
            this.AmountGroupBox.ResumeLayout(false);
            this.AmountGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AmountCafe.ResumeLayout(false);
            this.AmountCafe.PerformLayout();
            this.MiniCafe.ResumeLayout(false);
            this.MiniCafe.PerformLayout();
            this.panelFood.ResumeLayout(false);
            this.panelFood.PerformLayout();
            this.PanelTextBoxes.ResumeLayout(false);
            this.PanelTextBoxes.PerformLayout();
            this.Last.ResumeLayout(false);
            this.Last.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxPetrols;
        private TextBox textBoxPricePetrol;
        private RadioButton radioButtonLitr;
        private RadioButton radioButtonMoney;
        private TextBox LitrtextBox;
        private TextBox MoneyTextBox;
        private Label PricePetrol;
        private GroupBox PetrolStation;
        private GroupBox AmountGroupBox;
        private Label TotalAmountPetrol;
        private Panel panel1;
        private Label lbl_Petrol;
        private Label dollar;
        private Label label1;
        private Label label3;
        private Label label2;
        private CheckBox HotDog;
        private CheckBox Gamburger;
        private CheckBox Free;
        private CheckBox Cola;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private Label PriceCafe;
        private Label Count;
        private GroupBox AmountCafe;
        private Label TotalAmountCafe;
        private Label label7;
        private GroupBox MiniCafe;
        private Panel PanelTextBoxes;
        private Panel panelFood;
        private TextBox textBox4;
        private TextBox textBox7;
        private GroupBox Last;
        private Button button1;
        private Label label4;
        private Label AllAmount;
        private Button Calculate;
    }
}