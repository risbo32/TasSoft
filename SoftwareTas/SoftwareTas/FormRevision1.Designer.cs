namespace SoftwareTas
{
    partial class FormRevision1
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
            this.dteNaissance = new System.Windows.Forms.DateTimePicker();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.telOther = new SoftwareTas.components.PhoneTextBox();
            this.telCamtel = new SoftwareTas.components.CamtelPhoneTextBox();
            this.telNextell = new SoftwareTas.components.NextellPhoneTextBox();
            this.telMtn = new SoftwareTas.components.MtnPhoneTextBox();
            this.telOrange = new SoftwareTas.components.OrangePhoneTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxParentSurname = new System.Windows.Forms.TextBox();
            this.txtBoxParentName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.imsdbDataSet = new SoftwareTas.imsdbDataSet();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new SoftwareTas.imsdbDataSetTableAdapters.departmentTableAdapter();
            this.tableAdapterManager = new SoftwareTas.imsdbDataSetTableAdapters.TableAdapterManager();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imsdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dteNaissance
            // 
            this.dteNaissance.Location = new System.Drawing.Point(125, 178);
            this.dteNaissance.MinDate = new System.DateTime(1998, 10, 1, 0, 0, 0, 0);
            this.dteNaissance.Name = "dteNaissance";
            this.dteNaissance.Size = new System.Drawing.Size(201, 20);
            this.dteNaissance.TabIndex = 33;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(153, 18);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.Text = "English";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(175, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 42);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(31, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Francais";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(150, 23);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(61, 17);
            this.radioFemale.TabIndex = 7;
            this.radioFemale.Text = "Feminin";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Checked = true;
            this.radioMale.Location = new System.Drawing.Point(44, 23);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(67, 17);
            this.radioMale.TabIndex = 8;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Masculin";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioFemale);
            this.groupBox2.Controls.Add(this.radioMale);
            this.groupBox2.Location = new System.Drawing.Point(505, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 48);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(626, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(468, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 472);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Langue des messages";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(379, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Prenoms";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBoxParentSurname);
            this.groupBox1.Controls.Add(this.txtBoxParentName);
            this.groupBox1.Location = new System.Drawing.Point(40, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 184);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parent";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton10);
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton9);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Controls.Add(this.radioButton8);
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.telOther);
            this.groupBox4.Controls.Add(this.telCamtel);
            this.groupBox4.Controls.Add(this.telNextell);
            this.groupBox4.Controls.Add(this.telMtn);
            this.groupBox4.Controls.Add(this.telOrange);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(19, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(662, 98);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Numero telephone";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(810, 69);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(14, 13);
            this.radioButton10.TabIndex = 47;
            this.radioButton10.TabStop = true;
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(630, 31);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(14, 13);
            this.radioButton7.TabIndex = 47;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(420, 73);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(14, 13);
            this.radioButton9.TabIndex = 47;
            this.radioButton9.TabStop = true;
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(420, 30);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 47;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(205, 68);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(14, 13);
            this.radioButton8.TabIndex = 47;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(205, 27);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 47;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // telOther
            // 
            this.telOther.colorError = System.Drawing.Color.Red;
            this.telOther.colorSucces = System.Drawing.Color.Aqua;
            this.telOther.Location = new System.Drawing.Point(291, 67);
            this.telOther.Name = "telOther";
            this.telOther.Size = new System.Drawing.Size(114, 20);
            this.telOther.TabIndex = 46;
            // 
            // telCamtel
            // 
            this.telCamtel.colorError = System.Drawing.Color.Red;
            this.telCamtel.colorSucces = System.Drawing.Color.Aqua;
            this.telCamtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telCamtel.Location = new System.Drawing.Point(92, 63);
            this.telCamtel.Mask = "000-00-00-00";
            this.telCamtel.Name = "telCamtel";
            this.telCamtel.Size = new System.Drawing.Size(100, 22);
            this.telCamtel.TabIndex = 45;
            // 
            // telNextell
            // 
            this.telNextell.colorError = System.Drawing.Color.Red;
            this.telNextell.colorSucces = System.Drawing.Color.Aqua;
            this.telNextell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telNextell.Location = new System.Drawing.Point(524, 29);
            this.telNextell.Mask = "000-00-00-00";
            this.telNextell.Name = "telNextell";
            this.telNextell.Size = new System.Drawing.Size(100, 22);
            this.telNextell.TabIndex = 44;
            // 
            // telMtn
            // 
            this.telMtn.colorError = System.Drawing.Color.Red;
            this.telMtn.colorSucces = System.Drawing.Color.Aqua;
            this.telMtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telMtn.Location = new System.Drawing.Point(291, 26);
            this.telMtn.Mask = "000-00-00-00";
            this.telMtn.Name = "telMtn";
            this.telMtn.Size = new System.Drawing.Size(95, 22);
            this.telMtn.TabIndex = 40;
            // 
            // telOrange
            // 
            this.telOrange.colorError = System.Drawing.Color.Red;
            this.telOrange.colorSucces = System.Drawing.Color.Aqua;
            this.telOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telOrange.Location = new System.Drawing.Point(92, 24);
            this.telOrange.Mask = "000-00-00-00";
            this.telOrange.Name = "telOrange";
            this.telOrange.Size = new System.Drawing.Size(106, 22);
            this.telOrange.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(480, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Nextel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Tel Mtn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(248, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Autres";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Tel Camtel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tel Orange";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Noms";
            // 
            // txtBoxParentSurname
            // 
            this.txtBoxParentSurname.Location = new System.Drawing.Point(446, 31);
            this.txtBoxParentSurname.Name = "txtBoxParentSurname";
            this.txtBoxParentSurname.Size = new System.Drawing.Size(265, 20);
            this.txtBoxParentSurname.TabIndex = 7;
            // 
            // txtBoxParentName
            // 
            this.txtBoxParentName.Location = new System.Drawing.Point(85, 29);
            this.txtBoxParentName.Name = "txtBoxParentName";
            this.txtBoxParentName.Size = new System.Drawing.Size(265, 20);
            this.txtBoxParentName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sexe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Etablissement";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(505, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(175, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Matricule eleve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Classe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Prenoms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Date de naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Noms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Code d\'enregistrement";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(514, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "001";
            // 
            // imsdbDataSet
            // 
            this.imsdbDataSet.DataSetName = "imsdbDataSet";
            this.imsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.imsdbDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aholidaydtlTableAdapter = null;
            this.tableAdapterManager.aholidayTableAdapter = null;
            this.tableAdapterManager.anleavetempTableAdapter = null;
            this.tableAdapterManager.attendlunchTableAdapter = null;
            this.tableAdapterManager.attendparamTableAdapter = null;
            this.tableAdapterManager.attendpunchTableAdapter = null;
            this.tableAdapterManager.attrpTableAdapter = null;
            this.tableAdapterManager.attsysinfoTableAdapter = null;
            this.tableAdapterManager.autoshiftTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bancidtlTableAdapter = null;
            this.tableAdapterManager.banciTableAdapter = null;
            this.tableAdapterManager.bancitypeTableAdapter = null;
            this.tableAdapterManager.basedataTableAdapter = null;
            this.tableAdapterManager.cookhouseTableAdapter = null;
            this.tableAdapterManager.dayofattTableAdapter = null;
            this.tableAdapterManager.dayofshiftTableAdapter = null;
            this.tableAdapterManager.deletebufferTableAdapter = null;
            this.tableAdapterManager.departmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.deptholidayTableAdapter = null;
            this.tableAdapterManager.deviceEmpTableAdapter = null;
            this.tableAdapterManager.deviceinfoTableAdapter = null;
            this.tableAdapterManager.deviceTableAdapter = null;
            this.tableAdapterManager.empanleaveTableAdapter = null;
            this.tableAdapterManager.empcchattachTableAdapter = null;
            this.tableAdapterManager.empeeholidayTableAdapter = null;
            this.tableAdapterManager.empholidayTableAdapter = null;
            this.tableAdapterManager.empinfoTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.empqueryTableAdapter = null;
            this.tableAdapterManager.empshiftsetTableAdapter = null;
            this.tableAdapterManager.emptempbanciTableAdapter = null;
            this.tableAdapterManager.emptreeTableAdapter = null;
            this.tableAdapterManager.empvacationTableAdapter = null;
            this.tableAdapterManager.enrollTableAdapter = null;
            this.tableAdapterManager.excelformatTableAdapter = null;
            this.tableAdapterManager.exportdataTableAdapter = null;
            this.tableAdapterManager.holitypeTableAdapter = null;
            this.tableAdapterManager.ImageReadTableAdapter = null;
            this.tableAdapterManager.langallowTableAdapter = null;
            this.tableAdapterManager.langdictTableAdapter = null;
            this.tableAdapterManager.logmsgTableAdapter = null;
            this.tableAdapterManager.logoutcardTableAdapter = null;
            this.tableAdapterManager.logrunTableAdapter = null;
            this.tableAdapterManager.lunchTableAdapter = null;
            this.tableAdapterManager.machineTableAdapter = null;
            this.tableAdapterManager.modelshiftTableAdapter = null;
            this.tableAdapterManager.modulegroupTableAdapter = null;
            this.tableAdapterManager.modulestepTableAdapter = null;
            this.tableAdapterManager.offdutyTableAdapter = null;
            this.tableAdapterManager.offdutytypeTableAdapter = null;
            this.tableAdapterManager.otrateTableAdapter = null;
            this.tableAdapterManager.ottypeTableAdapter = null;
            this.tableAdapterManager.overtimeTableAdapter = null;
            this.tableAdapterManager.payallotTableAdapter = null;
            this.tableAdapterManager.payccyTableAdapter = null;
            this.tableAdapterManager.payclassTableAdapter = null;
            this.tableAdapterManager.paydTableAdapter = null;
            this.tableAdapterManager.paygroupdTableAdapter = null;
            this.tableAdapterManager.paygroupTableAdapter = null;
            this.tableAdapterManager.payinputTableAdapter = null;
            this.tableAdapterManager.payir56bsonTableAdapter = null;
            this.tableAdapterManager.payir56bTableAdapter = null;
            this.tableAdapterManager.payitemtypeTableAdapter = null;
            this.tableAdapterManager.payobjectTableAdapter = null;
            this.tableAdapterManager.payperiodTableAdapter = null;
            this.tableAdapterManager.payresultTableAdapter = null;
            this.tableAdapterManager.payTableAdapter = null;
            this.tableAdapterManager.person2txndateTableAdapter = null;
            this.tableAdapterManager.reginfoTableAdapter = null;
            this.tableAdapterManager.rpdbTableAdapter = null;
            this.tableAdapterManager.scheobjectTableAdapter = null;
            this.tableAdapterManager.scherundTableAdapter = null;
            this.tableAdapterManager.scherunTableAdapter = null;
            this.tableAdapterManager.schetxnTableAdapter = null;
            this.tableAdapterManager.shiftdtlTableAdapter = null;
            this.tableAdapterManager.shiftplanTableAdapter = null;
            this.tableAdapterManager.shiftTableAdapter = null;
            this.tableAdapterManager.signcardTableAdapter = null;
            this.tableAdapterManager.staffpayTableAdapter = null;
            this.tableAdapterManager.sysarguTableAdapter = null;
            this.tableAdapterManager.sysinfoTableAdapter = null;
            this.tableAdapterManager.tablesidTableAdapter = null;
            this.tableAdapterManager.temEmpeeTableAdapter = null;
            this.tableAdapterManager.tempictTableAdapter = null;
            this.tableAdapterManager.temstaffdutymonthTableAdapter = null;
            this.tableAdapterManager.timebellTableAdapter = null;
            this.tableAdapterManager.timeEmpAc100TableAdapter = null;
            this.tableAdapterManager.timeempTableAdapter = null;
            this.tableAdapterManager.timegroupTableAdapter = null;
            this.tableAdapterManager.timeholidayTableAdapter = null;
            this.tableAdapterManager.timelogTableAdapter = null;
            this.tableAdapterManager.timemsgTableAdapter = null;
            this.tableAdapterManager.timeopenTableAdapter = null;
            this.tableAdapterManager.timeverifyTableAdapter = null;
            this.tableAdapterManager.timeweekTableAdapter = null;
            this.tableAdapterManager.timeworkTableAdapter = null;
            this.tableAdapterManager.timezoneTableAdapter = null;
            this.tableAdapterManager.txndateTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SoftwareTas.imsdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usedeptrightTableAdapter = null;
            this.tableAdapterManager.usedevrightTableAdapter = null;
            this.tableAdapterManager.usemoduleTableAdapter = null;
            this.tableAdapterManager.user2empNextTableAdapter = null;
            this.tableAdapterManager.user2empTableAdapter = null;
            this.tableAdapterManager.userrightTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.verifymodeTableAdapter = null;
            this.tableAdapterManager.weekdateTableAdapter = null;
            this.tableAdapterManager.xy_dayofattTableAdapter = null;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(125, 129);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(201, 20);
            this.txtBoxName.TabIndex = 34;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(508, 127);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(197, 20);
            this.txtBoxSurname.TabIndex = 35;
            // 
            // FormRevision1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.dteNaissance);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Name = "FormRevision1";
            this.Text = "FormRevision1";
            this.Load += new System.EventHandler(this.FormRevision1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imsdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dteNaissance;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxParentSurname;
        private System.Windows.Forms.TextBox txtBoxParentName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private components.PhoneTextBox telOther;
        private components.CamtelPhoneTextBox telCamtel;
        private components.NextellPhoneTextBox telNextell;
        private components.MtnPhoneTextBox telMtn;
        private components.OrangePhoneTextBox telOrange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private imsdbDataSet imsdbDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private imsdbDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private imsdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxSurname;
    }
}