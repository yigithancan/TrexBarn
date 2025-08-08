namespace TrexBarn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMeatCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarMeat = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBarMilk = new System.Windows.Forms.ProgressBar();
            this.progressBarEgg = new System.Windows.Forms.ProgressBar();
            this.btnSellMeat = new System.Windows.Forms.Button();
            this.txtSellMeat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMilkCount = new System.Windows.Forms.Label();
            this.lblEggCount = new System.Windows.Forms.Label();
            this.txtSellMilk = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSellEgg = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSellMilk = new System.Windows.Forms.Button();
            this.btnSellEgg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.milkTimer = new System.Windows.Forms.Timer(this.components);
            this.meatTimer = new System.Windows.Forms.Timer(this.components);
            this.eggTimer = new System.Windows.Forms.Timer(this.components);
            this.lifeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBuyStraw = new System.Windows.Forms.Button();
            this.progressBarStraw1 = new System.Windows.Forms.ProgressBar();
            this.progressBarGras1 = new System.Windows.Forms.ProgressBar();
            this.btnBuyGrass = new System.Windows.Forms.Button();
            this.progressBarBait1 = new System.Windows.Forms.ProgressBar();
            this.btnBuyBait = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animal Species :";
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(195, 37);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(121, 28);
            this.cmbSpecies.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAge.Location = new System.Drawing.Point(195, 78);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(121, 27);
            this.txtAge.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnAdd.Location = new System.Drawing.Point(195, 160);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(102, 27);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Red;
            this.groupBox1.Controls.Add(this.lblMeatCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(238, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblMeatCount
            // 
            this.lblMeatCount.AutoSize = true;
            this.lblMeatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMeatCount.Location = new System.Drawing.Point(85, 71);
            this.lblMeatCount.Name = "lblMeatCount";
            this.lblMeatCount.Size = new System.Drawing.Size(21, 22);
            this.lblMeatCount.TabIndex = 2;
            this.lblMeatCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(74, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Meat";
            // 
            // progressBarMeat
            // 
            this.progressBarMeat.Location = new System.Drawing.Point(840, 265);
            this.progressBarMeat.Name = "progressBarMeat";
            this.progressBarMeat.Size = new System.Drawing.Size(164, 49);
            this.progressBarMeat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Animal Age :";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(195, 117);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 28);
            this.cmbGender.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(732, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sheep  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(723, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chicken :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(756, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cow :";
            // 
            // progressBarMilk
            // 
            this.progressBarMilk.Location = new System.Drawing.Point(840, 333);
            this.progressBarMilk.Name = "progressBarMilk";
            this.progressBarMilk.Size = new System.Drawing.Size(164, 49);
            this.progressBarMilk.TabIndex = 13;
            // 
            // progressBarEgg
            // 
            this.progressBarEgg.Location = new System.Drawing.Point(840, 399);
            this.progressBarEgg.Name = "progressBarEgg";
            this.progressBarEgg.Size = new System.Drawing.Size(164, 51);
            this.progressBarEgg.TabIndex = 14;
            // 
            // btnSellMeat
            // 
            this.btnSellMeat.BackColor = System.Drawing.Color.Lavender;
            this.btnSellMeat.Location = new System.Drawing.Point(342, 451);
            this.btnSellMeat.Name = "btnSellMeat";
            this.btnSellMeat.Size = new System.Drawing.Size(98, 28);
            this.btnSellMeat.TabIndex = 16;
            this.btnSellMeat.Text = "Sell";
            this.btnSellMeat.UseVisualStyleBackColor = false;
            this.btnSellMeat.Click += new System.EventHandler(this.btnSellMeat_Click);
            // 
            // txtSellMeat
            // 
            this.txtSellMeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSellMeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSellMeat.Location = new System.Drawing.Point(238, 451);
            this.txtSellMeat.Name = "txtSellMeat";
            this.txtSellMeat.Size = new System.Drawing.Size(98, 27);
            this.txtSellMeat.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(74, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Egg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(74, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Milk";
            // 
            // lblMilkCount
            // 
            this.lblMilkCount.AutoSize = true;
            this.lblMilkCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMilkCount.Location = new System.Drawing.Point(85, 55);
            this.lblMilkCount.Name = "lblMilkCount";
            this.lblMilkCount.Size = new System.Drawing.Size(21, 22);
            this.lblMilkCount.TabIndex = 3;
            this.lblMilkCount.Text = "0";
            // 
            // lblEggCount
            // 
            this.lblEggCount.AutoSize = true;
            this.lblEggCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEggCount.Location = new System.Drawing.Point(85, 59);
            this.lblEggCount.Name = "lblEggCount";
            this.lblEggCount.Size = new System.Drawing.Size(21, 22);
            this.lblEggCount.TabIndex = 4;
            this.lblEggCount.Text = "0";
            // 
            // txtSellMilk
            // 
            this.txtSellMilk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSellMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSellMilk.Location = new System.Drawing.Point(12, 451);
            this.txtSellMilk.Name = "txtSellMilk";
            this.txtSellMilk.Size = new System.Drawing.Size(98, 27);
            this.txtSellMilk.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblMilkCount);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 108);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // txtSellEgg
            // 
            this.txtSellEgg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSellEgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSellEgg.Location = new System.Drawing.Point(470, 451);
            this.txtSellEgg.Name = "txtSellEgg";
            this.txtSellEgg.Size = new System.Drawing.Size(98, 27);
            this.txtSellEgg.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.lblEggCount);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(470, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 108);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // btnSellMilk
            // 
            this.btnSellMilk.BackColor = System.Drawing.Color.Lavender;
            this.btnSellMilk.Location = new System.Drawing.Point(116, 451);
            this.btnSellMilk.Name = "btnSellMilk";
            this.btnSellMilk.Size = new System.Drawing.Size(98, 28);
            this.btnSellMilk.TabIndex = 23;
            this.btnSellMilk.Text = "Sell";
            this.btnSellMilk.UseVisualStyleBackColor = false;
            this.btnSellMilk.Click += new System.EventHandler(this.btnSellMilk_Click);
            // 
            // btnSellEgg
            // 
            this.btnSellEgg.BackColor = System.Drawing.Color.Lavender;
            this.btnSellEgg.Location = new System.Drawing.Point(574, 451);
            this.btnSellEgg.Name = "btnSellEgg";
            this.btnSellEgg.Size = new System.Drawing.Size(98, 28);
            this.btnSellEgg.TabIndex = 24;
            this.btnSellEgg.Text = "Sell";
            this.btnSellEgg.UseVisualStyleBackColor = false;
            this.btnSellEgg.Click += new System.EventHandler(this.btnSellEgg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(594, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 206);
            this.dataGridView1.TabIndex = 25;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.lblCash);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(342, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 150);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCash.ForeColor = System.Drawing.Color.White;
            this.lblCash.Location = new System.Drawing.Point(72, 88);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(62, 29);
            this.lblCash.TabIndex = 2;
            this.lblCash.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(16, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cash Amount";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // milkTimer
            // 
            this.milkTimer.Tick += new System.EventHandler(this.milkTimer_Tick);
            // 
            // eggTimer
            // 
            this.eggTimer.Tick += new System.EventHandler(this.eggTimer_Tick);
            // 
            // lifeTimer
            // 
            this.lifeTimer.Tick += new System.EventHandler(this.lifeTimer_Tick);
            // 
            // btnBuyStraw
            // 
            this.btnBuyStraw.BackColor = System.Drawing.Color.Lime;
            this.btnBuyStraw.Location = new System.Drawing.Point(74, 286);
            this.btnBuyStraw.Name = "btnBuyStraw";
            this.btnBuyStraw.Size = new System.Drawing.Size(93, 29);
            this.btnBuyStraw.TabIndex = 27;
            this.btnBuyStraw.Text = "Straw";
            this.btnBuyStraw.UseVisualStyleBackColor = false;
            this.btnBuyStraw.Click += new System.EventHandler(this.btnBuyStraw_Click);
            // 
            // progressBarStraw1
            // 
            this.progressBarStraw1.Location = new System.Drawing.Point(12, 245);
            this.progressBarStraw1.Name = "progressBarStraw1";
            this.progressBarStraw1.Size = new System.Drawing.Size(202, 35);
            this.progressBarStraw1.TabIndex = 28;
            this.progressBarStraw1.Click += new System.EventHandler(this.progressBarStraw1_Click);
            // 
            // progressBarGras1
            // 
            this.progressBarGras1.Location = new System.Drawing.Point(238, 245);
            this.progressBarGras1.Name = "progressBarGras1";
            this.progressBarGras1.Size = new System.Drawing.Size(202, 35);
            this.progressBarGras1.TabIndex = 30;
            // 
            // btnBuyGrass
            // 
            this.btnBuyGrass.BackColor = System.Drawing.Color.Lime;
            this.btnBuyGrass.Location = new System.Drawing.Point(294, 286);
            this.btnBuyGrass.Name = "btnBuyGrass";
            this.btnBuyGrass.Size = new System.Drawing.Size(93, 29);
            this.btnBuyGrass.TabIndex = 29;
            this.btnBuyGrass.Text = "Grass";
            this.btnBuyGrass.UseVisualStyleBackColor = false;
            this.btnBuyGrass.Click += new System.EventHandler(this.btnBuyGrass_Click);
            // 
            // progressBarBait1
            // 
            this.progressBarBait1.Location = new System.Drawing.Point(470, 245);
            this.progressBarBait1.Name = "progressBarBait1";
            this.progressBarBait1.Size = new System.Drawing.Size(202, 35);
            this.progressBarBait1.TabIndex = 32;
            // 
            // btnBuyBait
            // 
            this.btnBuyBait.BackColor = System.Drawing.Color.Lime;
            this.btnBuyBait.Location = new System.Drawing.Point(526, 285);
            this.btnBuyBait.Name = "btnBuyBait";
            this.btnBuyBait.Size = new System.Drawing.Size(93, 29);
            this.btnBuyBait.TabIndex = 31;
            this.btnBuyBait.Text = "Bait";
            this.btnBuyBait.UseVisualStyleBackColor = false;
            this.btnBuyBait.Click += new System.EventHandler(this.btnBuyBait_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1061, 495);
            this.Controls.Add(this.progressBarBait1);
            this.Controls.Add(this.btnBuyBait);
            this.Controls.Add(this.progressBarGras1);
            this.Controls.Add(this.btnBuyGrass);
            this.Controls.Add(this.progressBarStraw1);
            this.Controls.Add(this.btnBuyStraw);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSellEgg);
            this.Controls.Add(this.btnSellMilk);
            this.Controls.Add(this.txtSellEgg);
            this.Controls.Add(this.txtSellMilk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSellMeat);
            this.Controls.Add(this.btnSellMeat);
            this.Controls.Add(this.progressBarEgg);
            this.Controls.Add(this.progressBarMilk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarMeat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.cmbSpecies);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Trex Barn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBarMeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBarMilk;
        private System.Windows.Forms.ProgressBar progressBarEgg;
        private System.Windows.Forms.Button btnSellMeat;
        private System.Windows.Forms.TextBox txtSellMeat;
        private System.Windows.Forms.Label lblMeatCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMilkCount;
        private System.Windows.Forms.Label lblEggCount;
        private System.Windows.Forms.TextBox txtSellMilk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSellEgg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSellMilk;
        private System.Windows.Forms.Button btnSellEgg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer milkTimer;
        private System.Windows.Forms.Timer meatTimer;
        private System.Windows.Forms.Timer eggTimer;
        private System.Windows.Forms.Timer lifeTimer;
        private System.Windows.Forms.Button btnBuyStraw;
        private System.Windows.Forms.ProgressBar progressBarStraw;
        private System.Windows.Forms.ProgressBar progressBarGrass;
        private System.Windows.Forms.Button btnBuyGrass;
        private System.Windows.Forms.ProgressBar progressBarBait;
        private System.Windows.Forms.Button btnBuyBait;
        private System.Windows.Forms.ProgressBar progressBarStraw1;
        private System.Windows.Forms.ProgressBar progressBarGras1;
        private System.Windows.Forms.ProgressBar progressBarBait1;
    }
}

