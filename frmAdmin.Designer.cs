
namespace Aromatherapy_Master
{
    partial class frmAdmin
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
            this.txtPlantName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBreederName = new System.Windows.Forms.Label();
            this.txtBreeder = new System.Windows.Forms.TextBox();
            this.lblPlantName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbEnergetic = new System.Windows.Forms.ComboBox();
            this.cbHungry = new System.Windows.Forms.ComboBox();
            this.cbUplifted = new System.Windows.Forms.ComboBox();
            this.cbEuphoric = new System.Windows.Forms.ComboBox();
            this.cbHappy = new System.Windows.Forms.ComboBox();
            this.lblRelaxed = new System.Windows.Forms.Label();
            this.lblHappy = new System.Windows.Forms.Label();
            this.lblEuphoric = new System.Windows.Forms.Label();
            this.lblEnergetic = new System.Windows.Forms.Label();
            this.lblHungry = new System.Windows.Forms.Label();
            this.lblUplifted = new System.Windows.Forms.Label();
            this.cbRelaxed = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbDryEyes = new System.Windows.Forms.ComboBox();
            this.cbDryMouth = new System.Windows.Forms.ComboBox();
            this.cbParanoid = new System.Windows.Forms.ComboBox();
            this.cbDizzy = new System.Windows.Forms.ComboBox();
            this.cbAnxious = new System.Windows.Forms.ComboBox();
            this.lblDryEyes = new System.Windows.Forms.Label();
            this.lblDryMouth = new System.Windows.Forms.Label();
            this.lblParanoid = new System.Windows.Forms.Label();
            this.lblHeadache = new System.Windows.Forms.Label();
            this.lblAnxious = new System.Windows.Forms.Label();
            this.lblDizzy = new System.Windows.Forms.Label();
            this.cbHeadache = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbNoApetite = new System.Windows.Forms.ComboBox();
            this.cbInsomnia = new System.Windows.Forms.ComboBox();
            this.cbDepression = new System.Windows.Forms.ComboBox();
            this.cbPain = new System.Windows.Forms.ComboBox();
            this.cbAnxiety = new System.Windows.Forms.ComboBox();
            this.cbStress = new System.Windows.Forms.ComboBox();
            this.lblStress = new System.Windows.Forms.Label();
            this.lblAnxiety = new System.Windows.Forms.Label();
            this.lblPain = new System.Windows.Forms.Label();
            this.lblNoApetite = new System.Windows.Forms.Label();
            this.lblInsomnia = new System.Windows.Forms.Label();
            this.lblDepression = new System.Windows.Forms.Label();
            this.lblFeelings = new System.Windows.Forms.Label();
            this.lblNegatives = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.AddPlant = new System.Windows.Forms.Button();
            this.btnMainPanel = new System.Windows.Forms.Button();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnPromote = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlantName
            // 
            this.txtPlantName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPlantName.Location = new System.Drawing.Point(108, 96);
            this.txtPlantName.Name = "txtPlantName";
            this.txtPlantName.Size = new System.Drawing.Size(100, 20);
            this.txtPlantName.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.lblBreederName, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtPlantName, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtBreeder, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblPlantName, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.lblFeelings, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblNegatives, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblHelp, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.txtTemperature, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblTemperature, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.AddPlant, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnMainPanel, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(30, 24);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(949, 595);
            this.tableLayoutPanel5.TabIndex = 23;
            // 
            // lblBreederName
            // 
            this.lblBreederName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBreederName.AutoSize = true;
            this.lblBreederName.Location = new System.Drawing.Point(452, 119);
            this.lblBreederName.Name = "lblBreederName";
            this.lblBreederName.Size = new System.Drawing.Size(44, 13);
            this.lblBreederName.TabIndex = 25;
            this.lblBreederName.Text = "Breeder";
            // 
            // txtBreeder
            // 
            this.txtBreeder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBreeder.Location = new System.Drawing.Point(424, 96);
            this.txtBreeder.Name = "txtBreeder";
            this.txtBreeder.Size = new System.Drawing.Size(100, 20);
            this.txtBreeder.TabIndex = 22;
            // 
            // lblPlantName
            // 
            this.lblPlantName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlantName.AutoSize = true;
            this.lblPlantName.Location = new System.Drawing.Point(127, 119);
            this.lblPlantName.Name = "lblPlantName";
            this.lblPlantName.Size = new System.Drawing.Size(62, 13);
            this.lblPlantName.TabIndex = 24;
            this.lblPlantName.Text = "Plant Name";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.cbEnergetic, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.cbHungry, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbUplifted, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbEuphoric, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbHappy, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRelaxed, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblHappy, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblEuphoric, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblEnergetic, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblHungry, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblUplifted, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbRelaxed, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 299);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(310, 228);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // cbEnergetic
            // 
            this.cbEnergetic.FormattingEnabled = true;
            this.cbEnergetic.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbEnergetic.Location = new System.Drawing.Point(196, 188);
            this.cbEnergetic.Name = "cbEnergetic";
            this.cbEnergetic.Size = new System.Drawing.Size(111, 21);
            this.cbEnergetic.TabIndex = 17;
            // 
            // cbHungry
            // 
            this.cbHungry.FormattingEnabled = true;
            this.cbHungry.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbHungry.Location = new System.Drawing.Point(196, 151);
            this.cbHungry.Name = "cbHungry";
            this.cbHungry.Size = new System.Drawing.Size(111, 21);
            this.cbHungry.TabIndex = 16;
            // 
            // cbUplifted
            // 
            this.cbUplifted.FormattingEnabled = true;
            this.cbUplifted.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbUplifted.Location = new System.Drawing.Point(196, 114);
            this.cbUplifted.Name = "cbUplifted";
            this.cbUplifted.Size = new System.Drawing.Size(111, 21);
            this.cbUplifted.TabIndex = 15;
            // 
            // cbEuphoric
            // 
            this.cbEuphoric.FormattingEnabled = true;
            this.cbEuphoric.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbEuphoric.Location = new System.Drawing.Point(196, 77);
            this.cbEuphoric.Name = "cbEuphoric";
            this.cbEuphoric.Size = new System.Drawing.Size(111, 21);
            this.cbEuphoric.TabIndex = 14;
            // 
            // cbHappy
            // 
            this.cbHappy.FormattingEnabled = true;
            this.cbHappy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbHappy.Location = new System.Drawing.Point(196, 40);
            this.cbHappy.Name = "cbHappy";
            this.cbHappy.Size = new System.Drawing.Size(111, 21);
            this.cbHappy.TabIndex = 13;
            // 
            // lblRelaxed
            // 
            this.lblRelaxed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRelaxed.AutoSize = true;
            this.lblRelaxed.Location = new System.Drawing.Point(73, 12);
            this.lblRelaxed.Name = "lblRelaxed";
            this.lblRelaxed.Size = new System.Drawing.Size(46, 13);
            this.lblRelaxed.TabIndex = 11;
            this.lblRelaxed.Text = "Relaxed";
            // 
            // lblHappy
            // 
            this.lblHappy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHappy.AutoSize = true;
            this.lblHappy.Location = new System.Drawing.Point(77, 49);
            this.lblHappy.Name = "lblHappy";
            this.lblHappy.Size = new System.Drawing.Size(38, 13);
            this.lblHappy.TabIndex = 11;
            this.lblHappy.Text = "Happy";
            // 
            // lblEuphoric
            // 
            this.lblEuphoric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEuphoric.AutoSize = true;
            this.lblEuphoric.Location = new System.Drawing.Point(72, 86);
            this.lblEuphoric.Name = "lblEuphoric";
            this.lblEuphoric.Size = new System.Drawing.Size(49, 13);
            this.lblEuphoric.TabIndex = 11;
            this.lblEuphoric.Text = "Euphoric";
            // 
            // lblEnergetic
            // 
            this.lblEnergetic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnergetic.AutoSize = true;
            this.lblEnergetic.Location = new System.Drawing.Point(70, 200);
            this.lblEnergetic.Name = "lblEnergetic";
            this.lblEnergetic.Size = new System.Drawing.Size(52, 13);
            this.lblEnergetic.TabIndex = 11;
            this.lblEnergetic.Text = "Energetic";
            // 
            // lblHungry
            // 
            this.lblHungry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHungry.AutoSize = true;
            this.lblHungry.Location = new System.Drawing.Point(76, 160);
            this.lblHungry.Name = "lblHungry";
            this.lblHungry.Size = new System.Drawing.Size(41, 13);
            this.lblHungry.TabIndex = 11;
            this.lblHungry.Text = "Hungry";
            // 
            // lblUplifted
            // 
            this.lblUplifted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUplifted.AutoSize = true;
            this.lblUplifted.Location = new System.Drawing.Point(75, 123);
            this.lblUplifted.Name = "lblUplifted";
            this.lblUplifted.Size = new System.Drawing.Size(43, 13);
            this.lblUplifted.TabIndex = 11;
            this.lblUplifted.Text = "Uplifted";
            // 
            // cbRelaxed
            // 
            this.cbRelaxed.FormattingEnabled = true;
            this.cbRelaxed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbRelaxed.Location = new System.Drawing.Point(196, 3);
            this.cbRelaxed.Name = "cbRelaxed";
            this.cbRelaxed.Size = new System.Drawing.Size(111, 21);
            this.cbRelaxed.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Controls.Add(this.cbDryEyes, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbDryMouth, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbParanoid, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.cbDizzy, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.cbAnxious, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblDryEyes, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblDryMouth, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblParanoid, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblHeadache, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.lblAnxious, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblDizzy, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.cbHeadache, 1, 5);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(319, 299);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(310, 228);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // cbDryEyes
            // 
            this.cbDryEyes.FormattingEnabled = true;
            this.cbDryEyes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbDryEyes.Location = new System.Drawing.Point(196, 3);
            this.cbDryEyes.Name = "cbDryEyes";
            this.cbDryEyes.Size = new System.Drawing.Size(111, 21);
            this.cbDryEyes.TabIndex = 24;
            // 
            // cbDryMouth
            // 
            this.cbDryMouth.FormattingEnabled = true;
            this.cbDryMouth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbDryMouth.Location = new System.Drawing.Point(196, 40);
            this.cbDryMouth.Name = "cbDryMouth";
            this.cbDryMouth.Size = new System.Drawing.Size(111, 21);
            this.cbDryMouth.TabIndex = 24;
            // 
            // cbParanoid
            // 
            this.cbParanoid.FormattingEnabled = true;
            this.cbParanoid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbParanoid.Location = new System.Drawing.Point(196, 77);
            this.cbParanoid.Name = "cbParanoid";
            this.cbParanoid.Size = new System.Drawing.Size(111, 21);
            this.cbParanoid.TabIndex = 24;
            // 
            // cbDizzy
            // 
            this.cbDizzy.FormattingEnabled = true;
            this.cbDizzy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbDizzy.Location = new System.Drawing.Point(196, 114);
            this.cbDizzy.Name = "cbDizzy";
            this.cbDizzy.Size = new System.Drawing.Size(111, 21);
            this.cbDizzy.TabIndex = 24;
            // 
            // cbAnxious
            // 
            this.cbAnxious.FormattingEnabled = true;
            this.cbAnxious.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbAnxious.Location = new System.Drawing.Point(196, 151);
            this.cbAnxious.Name = "cbAnxious";
            this.cbAnxious.Size = new System.Drawing.Size(111, 21);
            this.cbAnxious.TabIndex = 24;
            // 
            // lblDryEyes
            // 
            this.lblDryEyes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDryEyes.AutoSize = true;
            this.lblDryEyes.Location = new System.Drawing.Point(72, 12);
            this.lblDryEyes.Name = "lblDryEyes";
            this.lblDryEyes.Size = new System.Drawing.Size(49, 13);
            this.lblDryEyes.TabIndex = 11;
            this.lblDryEyes.Text = "Dry Eyes";
            // 
            // lblDryMouth
            // 
            this.lblDryMouth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDryMouth.AutoSize = true;
            this.lblDryMouth.Location = new System.Drawing.Point(68, 49);
            this.lblDryMouth.Name = "lblDryMouth";
            this.lblDryMouth.Size = new System.Drawing.Size(56, 13);
            this.lblDryMouth.TabIndex = 11;
            this.lblDryMouth.Text = "Dry Mouth";
            // 
            // lblParanoid
            // 
            this.lblParanoid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParanoid.AutoSize = true;
            this.lblParanoid.Location = new System.Drawing.Point(72, 86);
            this.lblParanoid.Name = "lblParanoid";
            this.lblParanoid.Size = new System.Drawing.Size(49, 13);
            this.lblParanoid.TabIndex = 11;
            this.lblParanoid.Text = "Paranoid";
            // 
            // lblHeadache
            // 
            this.lblHeadache.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeadache.AutoSize = true;
            this.lblHeadache.Location = new System.Drawing.Point(68, 200);
            this.lblHeadache.Name = "lblHeadache";
            this.lblHeadache.Size = new System.Drawing.Size(57, 13);
            this.lblHeadache.TabIndex = 11;
            this.lblHeadache.Text = "Headache";
            // 
            // lblAnxious
            // 
            this.lblAnxious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnxious.AutoSize = true;
            this.lblAnxious.Location = new System.Drawing.Point(74, 160);
            this.lblAnxious.Name = "lblAnxious";
            this.lblAnxious.Size = new System.Drawing.Size(44, 13);
            this.lblAnxious.TabIndex = 11;
            this.lblAnxious.Text = "Anxious";
            // 
            // lblDizzy
            // 
            this.lblDizzy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDizzy.AutoSize = true;
            this.lblDizzy.Location = new System.Drawing.Point(80, 123);
            this.lblDizzy.Name = "lblDizzy";
            this.lblDizzy.Size = new System.Drawing.Size(32, 13);
            this.lblDizzy.TabIndex = 11;
            this.lblDizzy.Text = "Dizzy";
            // 
            // cbHeadache
            // 
            this.cbHeadache.FormattingEnabled = true;
            this.cbHeadache.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbHeadache.Location = new System.Drawing.Point(196, 188);
            this.cbHeadache.Name = "cbHeadache";
            this.cbHeadache.Size = new System.Drawing.Size(111, 21);
            this.cbHeadache.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.cbNoApetite, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.cbInsomnia, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.cbDepression, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbPain, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbAnxiety, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbStress, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblStress, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblAnxiety, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblPain, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblNoApetite, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblInsomnia, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblDepression, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(635, 299);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(311, 228);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // cbNoApetite
            // 
            this.cbNoApetite.FormattingEnabled = true;
            this.cbNoApetite.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbNoApetite.Location = new System.Drawing.Point(197, 188);
            this.cbNoApetite.Name = "cbNoApetite";
            this.cbNoApetite.Size = new System.Drawing.Size(111, 21);
            this.cbNoApetite.TabIndex = 24;
            // 
            // cbInsomnia
            // 
            this.cbInsomnia.FormattingEnabled = true;
            this.cbInsomnia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbInsomnia.Location = new System.Drawing.Point(197, 151);
            this.cbInsomnia.Name = "cbInsomnia";
            this.cbInsomnia.Size = new System.Drawing.Size(111, 21);
            this.cbInsomnia.TabIndex = 24;
            // 
            // cbDepression
            // 
            this.cbDepression.FormattingEnabled = true;
            this.cbDepression.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbDepression.Location = new System.Drawing.Point(197, 114);
            this.cbDepression.Name = "cbDepression";
            this.cbDepression.Size = new System.Drawing.Size(111, 21);
            this.cbDepression.TabIndex = 24;
            // 
            // cbPain
            // 
            this.cbPain.FormattingEnabled = true;
            this.cbPain.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbPain.Location = new System.Drawing.Point(197, 77);
            this.cbPain.Name = "cbPain";
            this.cbPain.Size = new System.Drawing.Size(111, 21);
            this.cbPain.TabIndex = 24;
            // 
            // cbAnxiety
            // 
            this.cbAnxiety.FormattingEnabled = true;
            this.cbAnxiety.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbAnxiety.Location = new System.Drawing.Point(197, 40);
            this.cbAnxiety.Name = "cbAnxiety";
            this.cbAnxiety.Size = new System.Drawing.Size(111, 21);
            this.cbAnxiety.TabIndex = 24;
            // 
            // cbStress
            // 
            this.cbStress.FormattingEnabled = true;
            this.cbStress.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbStress.Location = new System.Drawing.Point(197, 3);
            this.cbStress.Name = "cbStress";
            this.cbStress.Size = new System.Drawing.Size(111, 21);
            this.cbStress.TabIndex = 24;
            // 
            // lblStress
            // 
            this.lblStress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStress.AutoSize = true;
            this.lblStress.Location = new System.Drawing.Point(79, 12);
            this.lblStress.Name = "lblStress";
            this.lblStress.Size = new System.Drawing.Size(36, 13);
            this.lblStress.TabIndex = 11;
            this.lblStress.Text = "Stress";
            // 
            // lblAnxiety
            // 
            this.lblAnxiety.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnxiety.AutoSize = true;
            this.lblAnxiety.Location = new System.Drawing.Point(76, 49);
            this.lblAnxiety.Name = "lblAnxiety";
            this.lblAnxiety.Size = new System.Drawing.Size(41, 13);
            this.lblAnxiety.TabIndex = 11;
            this.lblAnxiety.Text = "Anxiety";
            // 
            // lblPain
            // 
            this.lblPain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPain.AutoSize = true;
            this.lblPain.Location = new System.Drawing.Point(83, 86);
            this.lblPain.Name = "lblPain";
            this.lblPain.Size = new System.Drawing.Size(28, 13);
            this.lblPain.TabIndex = 11;
            this.lblPain.Text = "Pain";
            // 
            // lblNoApetite
            // 
            this.lblNoApetite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoApetite.AutoSize = true;
            this.lblNoApetite.Location = new System.Drawing.Point(68, 200);
            this.lblNoApetite.Name = "lblNoApetite";
            this.lblNoApetite.Size = new System.Drawing.Size(57, 13);
            this.lblNoApetite.TabIndex = 11;
            this.lblNoApetite.Text = "No Apetite";
            // 
            // lblInsomnia
            // 
            this.lblInsomnia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInsomnia.AutoSize = true;
            this.lblInsomnia.Location = new System.Drawing.Point(72, 160);
            this.lblInsomnia.Name = "lblInsomnia";
            this.lblInsomnia.Size = new System.Drawing.Size(49, 13);
            this.lblInsomnia.TabIndex = 11;
            this.lblInsomnia.Text = "Insomnia";
            // 
            // lblDepression
            // 
            this.lblDepression.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepression.AutoSize = true;
            this.lblDepression.Location = new System.Drawing.Point(67, 123);
            this.lblDepression.Name = "lblDepression";
            this.lblDepression.Size = new System.Drawing.Size(60, 13);
            this.lblDepression.TabIndex = 11;
            this.lblDepression.Text = "Depression";
            // 
            // lblFeelings
            // 
            this.lblFeelings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFeelings.AutoSize = true;
            this.lblFeelings.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFeelings.Location = new System.Drawing.Point(73, 243);
            this.lblFeelings.Name = "lblFeelings";
            this.lblFeelings.Size = new System.Drawing.Size(170, 46);
            this.lblFeelings.TabIndex = 11;
            this.lblFeelings.Text = "Feelings";
            // 
            // lblNegatives
            // 
            this.lblNegatives.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNegatives.AutoSize = true;
            this.lblNegatives.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblNegatives.Location = new System.Drawing.Point(376, 243);
            this.lblNegatives.Name = "lblNegatives";
            this.lblNegatives.Size = new System.Drawing.Size(196, 46);
            this.lblNegatives.TabIndex = 11;
            this.lblNegatives.Text = "Negatives";
            // 
            // lblHelp
            // 
            this.lblHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblHelp.Location = new System.Drawing.Point(684, 243);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(213, 46);
            this.lblHelp.TabIndex = 11;
            this.lblHelp.Text = "Helps With";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTemperature.Location = new System.Drawing.Point(740, 96);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtTemperature.TabIndex = 24;
            // 
            // lblTemperature
            // 
            this.lblTemperature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(729, 119);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(123, 13);
            this.lblTemperature.TabIndex = 24;
            this.lblTemperature.Text = "Vaping Temperature (°C)";
            // 
            // AddPlant
            // 
            this.AddPlant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddPlant.Location = new System.Drawing.Point(753, 196);
            this.AddPlant.Name = "AddPlant";
            this.AddPlant.Size = new System.Drawing.Size(75, 23);
            this.AddPlant.TabIndex = 23;
            this.AddPlant.Text = "Add Plant";
            this.AddPlant.UseVisualStyleBackColor = true;
            this.AddPlant.Click += new System.EventHandler(this.AddPlant_Click);
            // 
            // btnMainPanel
            // 
            this.btnMainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMainPanel.Location = new System.Drawing.Point(120, 196);
            this.btnMainPanel.Name = "btnMainPanel";
            this.btnMainPanel.Size = new System.Drawing.Size(75, 23);
            this.btnMainPanel.TabIndex = 24;
            this.btnMainPanel.Text = "Main Panel";
            this.btnMainPanel.UseVisualStyleBackColor = true;
            this.btnMainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMainPanel_MouseClick);
            // 
            // dtgUsers
            // 
            this.dtgUsers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Location = new System.Drawing.Point(6, 47);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.Size = new System.Drawing.Size(337, 714);
            this.dtgUsers.TabIndex = 24;
            this.dtgUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsers_CellDoubleClick);
            // 
            // btnBan
            // 
            this.btnBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBan.Location = new System.Drawing.Point(139, 4);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(62, 23);
            this.btnBan.TabIndex = 25;
            this.btnBan.Text = "Ban User";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnPromote
            // 
            this.btnPromote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPromote.Location = new System.Drawing.Point(207, 4);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(130, 23);
            this.btnPromote.TabIndex = 26;
            this.btnPromote.Text = "Promote to Admin";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblUser.Location = new System.Drawing.Point(68, 3);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 24);
            this.lblUser.TabIndex = 27;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.lblUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPromote, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBan, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 30);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.dtgUsers, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(998, 24);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.782609F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.21739F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(346, 772);
            this.tableLayoutPanel6.TabIndex = 29;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 956);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlantName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbEnergetic;
        private System.Windows.Forms.ComboBox cbHungry;
        private System.Windows.Forms.ComboBox cbUplifted;
        private System.Windows.Forms.ComboBox cbEuphoric;
        private System.Windows.Forms.ComboBox cbHappy;
        private System.Windows.Forms.Label lblRelaxed;
        private System.Windows.Forms.Label lblHappy;
        private System.Windows.Forms.Label lblEuphoric;
        private System.Windows.Forms.Label lblEnergetic;
        private System.Windows.Forms.Label lblHungry;
        private System.Windows.Forms.Label lblUplifted;
        private System.Windows.Forms.ComboBox cbRelaxed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cbDryEyes;
        private System.Windows.Forms.ComboBox cbDryMouth;
        private System.Windows.Forms.ComboBox cbParanoid;
        private System.Windows.Forms.ComboBox cbDizzy;
        private System.Windows.Forms.ComboBox cbAnxious;
        private System.Windows.Forms.Label lblDryEyes;
        private System.Windows.Forms.Label lblDryMouth;
        private System.Windows.Forms.Label lblParanoid;
        private System.Windows.Forms.Label lblHeadache;
        private System.Windows.Forms.Label lblAnxious;
        private System.Windows.Forms.Label lblDizzy;
        private System.Windows.Forms.ComboBox cbHeadache;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbNoApetite;
        private System.Windows.Forms.ComboBox cbInsomnia;
        private System.Windows.Forms.ComboBox cbDepression;
        private System.Windows.Forms.ComboBox cbPain;
        private System.Windows.Forms.ComboBox cbAnxiety;
        private System.Windows.Forms.ComboBox cbStress;
        private System.Windows.Forms.Label lblStress;
        private System.Windows.Forms.Label lblAnxiety;
        private System.Windows.Forms.Label lblPain;
        private System.Windows.Forms.Label lblNoApetite;
        private System.Windows.Forms.Label lblInsomnia;
        private System.Windows.Forms.Label lblDepression;
        private System.Windows.Forms.Label lblFeelings;
        private System.Windows.Forms.Label lblNegatives;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.TextBox txtBreeder;
        private System.Windows.Forms.Button AddPlant;
        private System.Windows.Forms.Label lblBreederName;
        private System.Windows.Forms.Label lblPlantName;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Button btnMainPanel;
        private System.Windows.Forms.DataGridView dtgUsers;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}