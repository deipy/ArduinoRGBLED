namespace LEDStrips
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.port_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbar = new System.Windows.Forms.HScrollBar();
            this.R = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.gbar = new System.Windows.Forms.HScrollBar();
            this.B = new System.Windows.Forms.Label();
            this.bbar = new System.Windows.Forms.HScrollBar();
            this.close_button = new System.Windows.Forms.Button();
            this.primary_color_view = new System.Windows.Forms.PictureBox();
            this.min_button = new System.Windows.Forms.Button();
            this.b_label = new System.Windows.Forms.Label();
            this.g_label = new System.Windows.Forms.Label();
            this.r_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.set_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.serial_status = new System.Windows.Forms.RadioButton();
            this.disco_button = new System.Windows.Forms.Button();
            this.send_com = new System.Windows.Forms.Button();
            this.off = new System.Windows.Forms.Button();
            this.swipe = new System.Windows.Forms.Button();
            this.command_box = new System.Windows.Forms.TextBox();
            this.Sb_label = new System.Windows.Forms.Label();
            this.Sg_label = new System.Windows.Forms.Label();
            this.Sr_label = new System.Windows.Forms.Label();
            this.scolor_view = new System.Windows.Forms.PictureBox();
            this.SB = new System.Windows.Forms.Label();
            this.Sbbar = new System.Windows.Forms.HScrollBar();
            this.SG = new System.Windows.Forms.Label();
            this.Sgbar = new System.Windows.Forms.HScrollBar();
            this.SR = new System.Windows.Forms.Label();
            this.Srbar = new System.Windows.Forms.HScrollBar();
            this.label12 = new System.Windows.Forms.Label();
            this.secondary_color_label = new System.Windows.Forms.Label();
            this.immersion = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.Label();
            this.speed_value = new System.Windows.Forms.NumericUpDown();
            this.debug_check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.primary_color_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scolor_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_value)).BeginInit();
            this.SuspendLayout();
            // 
            // port_list
            // 
            this.port_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.port_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.port_list.FormattingEnabled = true;
            this.port_list.Location = new System.Drawing.Point(12, 69);
            this.port_list.Name = "port_list";
            this.port_list.Size = new System.Drawing.Size(121, 21);
            this.port_list.TabIndex = 0;
            this.port_list.SelectedIndexChanged += new System.EventHandler(this.port_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // rbar
            // 
            this.rbar.Location = new System.Drawing.Point(93, 137);
            this.rbar.Maximum = 264;
            this.rbar.Name = "rbar";
            this.rbar.Size = new System.Drawing.Size(199, 17);
            this.rbar.TabIndex = 2;
            this.rbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rbar_Scroll);
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.R.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.R.Location = new System.Drawing.Point(10, 136);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(18, 18);
            this.R.TabIndex = 3;
            this.R.Text = "R";
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.G.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.G.Location = new System.Drawing.Point(10, 170);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(18, 18);
            this.G.TabIndex = 7;
            this.G.Text = "G";
            // 
            // gbar
            // 
            this.gbar.Location = new System.Drawing.Point(93, 171);
            this.gbar.Maximum = 264;
            this.gbar.Name = "gbar";
            this.gbar.Size = new System.Drawing.Size(199, 17);
            this.gbar.TabIndex = 6;
            this.gbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gbar_Scroll);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.B.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.B.Location = new System.Drawing.Point(10, 204);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(18, 18);
            this.B.TabIndex = 11;
            this.B.Text = "B";
            // 
            // bbar
            // 
            this.bbar.Location = new System.Drawing.Point(93, 205);
            this.bbar.Maximum = 264;
            this.bbar.Name = "bbar";
            this.bbar.Size = new System.Drawing.Size(199, 17);
            this.bbar.TabIndex = 10;
            this.bbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bbar_Scroll);
            // 
            // close_button
            // 
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close_button.Location = new System.Drawing.Point(397, 10);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(23, 23);
            this.close_button.TabIndex = 12;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // primary_color_view
            // 
            this.primary_color_view.BackColor = System.Drawing.Color.Black;
            this.primary_color_view.Location = new System.Drawing.Point(318, 137);
            this.primary_color_view.Name = "primary_color_view";
            this.primary_color_view.Size = new System.Drawing.Size(83, 86);
            this.primary_color_view.TabIndex = 13;
            this.primary_color_view.TabStop = false;
            // 
            // min_button
            // 
            this.min_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.min_button.Location = new System.Drawing.Point(368, 10);
            this.min_button.Name = "min_button";
            this.min_button.Size = new System.Drawing.Size(23, 23);
            this.min_button.TabIndex = 14;
            this.min_button.Text = "-";
            this.min_button.UseVisualStyleBackColor = true;
            this.min_button.Click += new System.EventHandler(this.min_button_Click);
            // 
            // b_label
            // 
            this.b_label.AutoSize = true;
            this.b_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.b_label.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.b_label.Location = new System.Drawing.Point(38, 205);
            this.b_label.Name = "b_label";
            this.b_label.Size = new System.Drawing.Size(16, 18);
            this.b_label.TabIndex = 17;
            this.b_label.Text = "0";
            // 
            // g_label
            // 
            this.g_label.AutoSize = true;
            this.g_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.g_label.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.g_label.Location = new System.Drawing.Point(38, 171);
            this.g_label.Name = "g_label";
            this.g_label.Size = new System.Drawing.Size(16, 18);
            this.g_label.TabIndex = 16;
            this.g_label.Text = "0";
            // 
            // r_label
            // 
            this.r_label.AutoSize = true;
            this.r_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.r_label.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.r_label.Location = new System.Drawing.Point(38, 137);
            this.r_label.Name = "r_label";
            this.r_label.Size = new System.Drawing.Size(16, 18);
            this.r_label.TabIndex = 15;
            this.r_label.Text = "0";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button1.Location = new System.Drawing.Point(94, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cycle ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cycle_Click);
            // 
            // set_button
            // 
            this.set_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_button.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.set_button.Location = new System.Drawing.Point(12, 380);
            this.set_button.Name = "set_button";
            this.set_button.Size = new System.Drawing.Size(76, 23);
            this.set_button.TabIndex = 19;
            this.set_button.Text = "Set";
            this.set_button.UseVisualStyleBackColor = true;
            this.set_button.Click += new System.EventHandler(this.set_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label8.Font = new System.Drawing.Font("Roboto", 15F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(8, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Serial LED Controller";
            // 
            // serial_status
            // 
            this.serial_status.AutoCheck = false;
            this.serial_status.AutoSize = true;
            this.serial_status.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serial_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.serial_status.Location = new System.Drawing.Point(232, 71);
            this.serial_status.Name = "serial_status";
            this.serial_status.Size = new System.Drawing.Size(62, 19);
            this.serial_status.TabIndex = 21;
            this.serial_status.TabStop = true;
            this.serial_status.Text = "Status";
            this.serial_status.UseVisualStyleBackColor = true;
            // 
            // disco_button
            // 
            this.disco_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disco_button.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disco_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.disco_button.Location = new System.Drawing.Point(139, 69);
            this.disco_button.Name = "disco_button";
            this.disco_button.Size = new System.Drawing.Size(87, 23);
            this.disco_button.TabIndex = 22;
            this.disco_button.Text = "Disconnect";
            this.disco_button.UseVisualStyleBackColor = true;
            this.disco_button.Click += new System.EventHandler(this.disco_button_Click);
            // 
            // send_com
            // 
            this.send_com.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_com.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_com.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.send_com.Location = new System.Drawing.Point(176, 409);
            this.send_com.Name = "send_com";
            this.send_com.Size = new System.Drawing.Size(76, 23);
            this.send_com.TabIndex = 24;
            this.send_com.Text = "SEND COM";
            this.send_com.UseVisualStyleBackColor = true;
            this.send_com.Visible = false;
            this.send_com.Click += new System.EventHandler(this.send_com_Click);
            // 
            // off
            // 
            this.off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.off.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.off.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.off.Location = new System.Drawing.Point(340, 380);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(76, 23);
            this.off.TabIndex = 28;
            this.off.Text = "Off";
            this.off.UseVisualStyleBackColor = true;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // swipe
            // 
            this.swipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swipe.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.swipe.Location = new System.Drawing.Point(258, 380);
            this.swipe.Name = "swipe";
            this.swipe.Size = new System.Drawing.Size(76, 23);
            this.swipe.TabIndex = 29;
            this.swipe.Text = "Swipe";
            this.swipe.UseVisualStyleBackColor = true;
            this.swipe.Click += new System.EventHandler(this.swipe_Click);
            // 
            // command_box
            // 
            this.command_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.command_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.command_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.command_box.Location = new System.Drawing.Point(12, 409);
            this.command_box.Name = "command_box";
            this.command_box.Size = new System.Drawing.Size(158, 23);
            this.command_box.TabIndex = 25;
            this.command_box.Visible = false;
            this.command_box.WordWrap = false;
            // 
            // Sb_label
            // 
            this.Sb_label.AutoSize = true;
            this.Sb_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Sb_label.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sb_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Sb_label.Location = new System.Drawing.Point(37, 343);
            this.Sb_label.Name = "Sb_label";
            this.Sb_label.Size = new System.Drawing.Size(16, 18);
            this.Sb_label.TabIndex = 39;
            this.Sb_label.Text = "0";
            // 
            // Sg_label
            // 
            this.Sg_label.AutoSize = true;
            this.Sg_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Sg_label.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sg_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Sg_label.Location = new System.Drawing.Point(37, 309);
            this.Sg_label.Name = "Sg_label";
            this.Sg_label.Size = new System.Drawing.Size(16, 18);
            this.Sg_label.TabIndex = 38;
            this.Sg_label.Text = "0";
            // 
            // Sr_label
            // 
            this.Sr_label.AutoSize = true;
            this.Sr_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Sr_label.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sr_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Sr_label.Location = new System.Drawing.Point(37, 275);
            this.Sr_label.Name = "Sr_label";
            this.Sr_label.Size = new System.Drawing.Size(16, 18);
            this.Sr_label.TabIndex = 37;
            this.Sr_label.Text = "0";
            // 
            // scolor_view
            // 
            this.scolor_view.BackColor = System.Drawing.Color.Black;
            this.scolor_view.Location = new System.Drawing.Point(317, 275);
            this.scolor_view.Name = "scolor_view";
            this.scolor_view.Size = new System.Drawing.Size(83, 86);
            this.scolor_view.TabIndex = 36;
            this.scolor_view.TabStop = false;
            // 
            // SB
            // 
            this.SB.AutoSize = true;
            this.SB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SB.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.SB.Location = new System.Drawing.Point(9, 342);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(18, 18);
            this.SB.TabIndex = 35;
            this.SB.Text = "B";
            // 
            // Sbbar
            // 
            this.Sbbar.Location = new System.Drawing.Point(92, 343);
            this.Sbbar.Maximum = 264;
            this.Sbbar.Name = "Sbbar";
            this.Sbbar.Size = new System.Drawing.Size(199, 17);
            this.Sbbar.TabIndex = 34;
            this.Sbbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Sbbar_Scroll);
            // 
            // SG
            // 
            this.SG.AutoSize = true;
            this.SG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SG.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.SG.Location = new System.Drawing.Point(9, 308);
            this.SG.Name = "SG";
            this.SG.Size = new System.Drawing.Size(18, 18);
            this.SG.TabIndex = 33;
            this.SG.Text = "G";
            // 
            // Sgbar
            // 
            this.Sgbar.Location = new System.Drawing.Point(92, 309);
            this.Sgbar.Maximum = 264;
            this.Sgbar.Name = "Sgbar";
            this.Sgbar.Size = new System.Drawing.Size(199, 17);
            this.Sgbar.TabIndex = 32;
            this.Sgbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Sgbar_Scroll);
            // 
            // SR
            // 
            this.SR.AutoSize = true;
            this.SR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SR.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.SR.Location = new System.Drawing.Point(9, 274);
            this.SR.Name = "SR";
            this.SR.Size = new System.Drawing.Size(18, 18);
            this.SR.TabIndex = 31;
            this.SR.Text = "R";
            // 
            // Srbar
            // 
            this.Srbar.Location = new System.Drawing.Point(92, 275);
            this.Srbar.Maximum = 264;
            this.Srbar.Name = "Srbar";
            this.Srbar.Size = new System.Drawing.Size(199, 17);
            this.Srbar.TabIndex = 30;
            this.Srbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Srbar_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label12.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label12.Location = new System.Drawing.Point(9, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 18);
            this.label12.TabIndex = 40;
            this.label12.Text = "Primary Color";
            // 
            // secondary_color_label
            // 
            this.secondary_color_label.AutoSize = true;
            this.secondary_color_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.secondary_color_label.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondary_color_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.secondary_color_label.Location = new System.Drawing.Point(9, 244);
            this.secondary_color_label.Name = "secondary_color_label";
            this.secondary_color_label.Size = new System.Drawing.Size(121, 18);
            this.secondary_color_label.TabIndex = 40;
            this.secondary_color_label.Text = "Secondary Color";
            // 
            // immersion
            // 
            this.immersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.immersion.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.immersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.immersion.Location = new System.Drawing.Point(176, 380);
            this.immersion.Name = "immersion";
            this.immersion.Size = new System.Drawing.Size(76, 23);
            this.immersion.TabIndex = 27;
            this.immersion.UseVisualStyleBackColor = true;
            this.immersion.Click += new System.EventHandler(this.immersion_Click);
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.speed.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.speed.Location = new System.Drawing.Point(283, 415);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(51, 18);
            this.speed.TabIndex = 42;
            this.speed.Text = "Speed";
            // 
            // speed_value
            // 
            this.speed_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed_value.Location = new System.Drawing.Point(340, 415);
            this.speed_value.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.speed_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speed_value.Name = "speed_value";
            this.speed_value.Size = new System.Drawing.Size(76, 20);
            this.speed_value.TabIndex = 43;
            this.speed_value.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // debug_check
            // 
            this.debug_check.AutoSize = true;
            this.debug_check.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.debug_check.Location = new System.Drawing.Point(317, 73);
            this.debug_check.Name = "debug_check";
            this.debug_check.Size = new System.Drawing.Size(84, 19);
            this.debug_check.TabIndex = 26;
            this.debug_check.Text = "Text Input";
            this.debug_check.UseVisualStyleBackColor = true;
            this.debug_check.CheckedChanged += new System.EventHandler(this.debug_check_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(429, 447);
            this.Controls.Add(this.speed_value);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.secondary_color_label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Sb_label);
            this.Controls.Add(this.Sg_label);
            this.Controls.Add(this.Sr_label);
            this.Controls.Add(this.scolor_view);
            this.Controls.Add(this.SB);
            this.Controls.Add(this.Sbbar);
            this.Controls.Add(this.SG);
            this.Controls.Add(this.Sgbar);
            this.Controls.Add(this.SR);
            this.Controls.Add(this.Srbar);
            this.Controls.Add(this.swipe);
            this.Controls.Add(this.off);
            this.Controls.Add(this.immersion);
            this.Controls.Add(this.debug_check);
            this.Controls.Add(this.command_box);
            this.Controls.Add(this.send_com);
            this.Controls.Add(this.disco_button);
            this.Controls.Add(this.serial_status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.set_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_label);
            this.Controls.Add(this.g_label);
            this.Controls.Add(this.r_label);
            this.Controls.Add(this.min_button);
            this.Controls.Add(this.primary_color_view);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.B);
            this.Controls.Add(this.bbar);
            this.Controls.Add(this.G);
            this.Controls.Add(this.gbar);
            this.Controls.Add(this.R);
            this.Controls.Add(this.rbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.primary_color_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scolor_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox port_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar rbar;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.HScrollBar gbar;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.HScrollBar bbar;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.PictureBox primary_color_view;
        private System.Windows.Forms.Button min_button;
        private System.Windows.Forms.Label b_label;
        private System.Windows.Forms.Label g_label;
        private System.Windows.Forms.Label r_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button set_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton serial_status;
        private System.Windows.Forms.Button disco_button;
        private System.Windows.Forms.Button send_com;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button swipe;
        private System.Windows.Forms.TextBox command_box;
        private System.Windows.Forms.Label Sb_label;
        private System.Windows.Forms.Label Sg_label;
        private System.Windows.Forms.Label Sr_label;
        private System.Windows.Forms.PictureBox scolor_view;
        private System.Windows.Forms.Label SB;
        private System.Windows.Forms.HScrollBar Sbbar;
        private System.Windows.Forms.Label SG;
        private System.Windows.Forms.HScrollBar Sgbar;
        private System.Windows.Forms.Label SR;
        private System.Windows.Forms.HScrollBar Srbar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label secondary_color_label;
        private System.Windows.Forms.Button immersion;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.NumericUpDown speed_value;
        private System.Windows.Forms.CheckBox debug_check;
    }
}

