namespace WFA_beadando_0104
{
    partial class FilmekMain
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mufaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiadas_eve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldCim = new System.Windows.Forms.TextBox();
            this.fieldLeiras = new System.Windows.Forms.TextBox();
            this.fieldMufaj = new System.Windows.Forms.TextBox();
            this.fieldEv = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fieldUjcim = new System.Windows.Forms.TextBox();
            this.fieldUjmufaj = new System.Windows.Forms.TextBox();
            this.fieldUjkiev = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.fieldPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.adatlapCim = new System.Windows.Forms.TextBox();
            this.adatlapLeiras = new System.Windows.Forms.TextBox();
            this.adatlapEv = new System.Windows.Forms.TextBox();
            this.adatlapSzereplo = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cime,
            this.mufaja,
            this.kiadas_eve});
            this.dgv.Location = new System.Drawing.Point(90, 37);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(848, 477);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // cime
            // 
            this.cime.HeaderText = "Címe";
            this.cime.MinimumWidth = 6;
            this.cime.Name = "cime";
            // 
            // mufaja
            // 
            this.mufaja.HeaderText = "Műfaja";
            this.mufaja.MinimumWidth = 6;
            this.mufaja.Name = "mufaja";
            // 
            // kiadas_eve
            // 
            this.kiadas_eve.HeaderText = "Kiadás éve";
            this.kiadas_eve.MinimumWidth = 6;
            this.kiadas_eve.Name = "kiadas_eve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Új film hozzáadása:";
            // 
            // txtCim
            // 
            this.txtCim.AutoSize = true;
            this.txtCim.Location = new System.Drawing.Point(90, 599);
            this.txtCim.Name = "txtCim";
            this.txtCim.Size = new System.Drawing.Size(38, 20);
            this.txtCim.TabIndex = 2;
            this.txtCim.Text = "Cím:";
            this.txtCim.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 645);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rövid ismertető:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 696);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Műfaja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 753);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kiadás éve:";
            // 
            // fieldCim
            // 
            this.fieldCim.Location = new System.Drawing.Point(242, 595);
            this.fieldCim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldCim.Name = "fieldCim";
            this.fieldCim.Size = new System.Drawing.Size(259, 27);
            this.fieldCim.TabIndex = 6;
            // 
            // fieldLeiras
            // 
            this.fieldLeiras.Location = new System.Drawing.Point(242, 641);
            this.fieldLeiras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldLeiras.Name = "fieldLeiras";
            this.fieldLeiras.Size = new System.Drawing.Size(259, 27);
            this.fieldLeiras.TabIndex = 7;
            // 
            // fieldMufaj
            // 
            this.fieldMufaj.Location = new System.Drawing.Point(240, 696);
            this.fieldMufaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldMufaj.Name = "fieldMufaj";
            this.fieldMufaj.Size = new System.Drawing.Size(261, 27);
            this.fieldMufaj.TabIndex = 8;
            // 
            // fieldEv
            // 
            this.fieldEv.Location = new System.Drawing.Point(240, 753);
            this.fieldEv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldEv.Name = "fieldEv";
            this.fieldEv.Size = new System.Drawing.Size(261, 27);
            this.fieldEv.TabIndex = 9;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.GreenYellow;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(240, 844);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(263, 55);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Film hozzáadása";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(586, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Meglévő módosítása:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 625);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Új cím:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(586, 696);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Új műfaj:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 757);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kiadás éve:";
            // 
            // fieldUjcim
            // 
            this.fieldUjcim.Location = new System.Drawing.Point(675, 625);
            this.fieldUjcim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldUjcim.Name = "fieldUjcim";
            this.fieldUjcim.Size = new System.Drawing.Size(277, 27);
            this.fieldUjcim.TabIndex = 15;
            // 
            // fieldUjmufaj
            // 
            this.fieldUjmufaj.Location = new System.Drawing.Point(680, 696);
            this.fieldUjmufaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldUjmufaj.Name = "fieldUjmufaj";
            this.fieldUjmufaj.Size = new System.Drawing.Size(273, 27);
            this.fieldUjmufaj.TabIndex = 16;
            // 
            // fieldUjkiev
            // 
            this.fieldUjkiev.Location = new System.Drawing.Point(675, 759);
            this.fieldUjkiev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldUjkiev.Name = "fieldUjkiev";
            this.fieldUjkiev.Size = new System.Drawing.Size(277, 27);
            this.fieldUjkiev.TabIndex = 17;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUpdate.Location = new System.Drawing.Point(675, 813);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(278, 64);
            this.BtnUpdate.TabIndex = 18;
            this.BtnUpdate.Text = "Módosítás";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 805);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Borítókép neve + kiterjesztése:";
            // 
            // fieldPath
            // 
            this.fieldPath.Location = new System.Drawing.Point(297, 801);
            this.fieldPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldPath.Name = "fieldPath";
            this.fieldPath.Size = new System.Drawing.Size(204, 27);
            this.fieldPath.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1045, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 37);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sor törlése:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnDelete.Location = new System.Drawing.Point(1045, 625);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 125);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Sor törlése";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(969, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 37);
            this.label11.TabIndex = 23;
            this.label11.Text = "Film adatlap:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(985, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Cím:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(985, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Ismertető:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(985, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "kiadás éve:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(985, 349);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Főszereplő:";
            // 
            // adatlapCim
            // 
            this.adatlapCim.Location = new System.Drawing.Point(1090, 141);
            this.adatlapCim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adatlapCim.Name = "adatlapCim";
            this.adatlapCim.Size = new System.Drawing.Size(219, 27);
            this.adatlapCim.TabIndex = 28;
            // 
            // adatlapLeiras
            // 
            this.adatlapLeiras.Location = new System.Drawing.Point(1090, 208);
            this.adatlapLeiras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adatlapLeiras.Name = "adatlapLeiras";
            this.adatlapLeiras.Size = new System.Drawing.Size(219, 27);
            this.adatlapLeiras.TabIndex = 29;
            // 
            // adatlapEv
            // 
            this.adatlapEv.Location = new System.Drawing.Point(1090, 275);
            this.adatlapEv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adatlapEv.Name = "adatlapEv";
            this.adatlapEv.Size = new System.Drawing.Size(219, 27);
            this.adatlapEv.TabIndex = 30;
            // 
            // adatlapSzereplo
            // 
            this.adatlapSzereplo.Location = new System.Drawing.Point(1087, 339);
            this.adatlapSzereplo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adatlapSzereplo.Name = "adatlapSzereplo";
            this.adatlapSzereplo.Size = new System.Drawing.Size(222, 27);
            this.adatlapSzereplo.TabIndex = 31;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfo.Location = new System.Drawing.Point(1087, 411);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(223, 77);
            this.btnInfo.TabIndex = 32;
            this.btnInfo.Text = "Megtekintés";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FilmekMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 928);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.adatlapSzereplo);
            this.Controls.Add(this.adatlapEv);
            this.Controls.Add(this.adatlapLeiras);
            this.Controls.Add(this.adatlapCim);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fieldPath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.fieldUjkiev);
            this.Controls.Add(this.fieldUjmufaj);
            this.Controls.Add(this.fieldUjcim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.fieldEv);
            this.Controls.Add(this.fieldMufaj);
            this.Controls.Add(this.fieldLeiras);
            this.Controls.Add(this.fieldCim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FilmekMain";
            this.Text = "Filmek";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn cime;
        private DataGridViewTextBoxColumn mufaja;
        private DataGridViewTextBoxColumn kiadas_eve;
        private Label label1;
        private Label txtCim;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox fieldCim;
        private TextBox fieldLeiras;
        private TextBox fieldMufaj;
        private TextBox fieldEv;
        private Button btnInsert;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox fieldUjcim;
        private TextBox fieldUjmufaj;
        private TextBox fieldUjkiev;
        private Button BtnUpdate;
        private Label label9;
        private TextBox fieldPath;
        private Label label10;
        private Button btnDelete;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox adatlapCim;
        private TextBox adatlapLeiras;
        private TextBox adatlapEv;
        private TextBox adatlapSzereplo;
        private Button btnInfo;
    }
}