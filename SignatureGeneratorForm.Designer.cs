namespace GloRemit.Rsp.SignGenerator
{
    partial class SignatureGeneratorForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtRspSignature = new System.Windows.Forms.TextBox();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.tabDo_BillPayment = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.txtBPbIssuerCode = new System.Windows.Forms.TextBox();
            this.txtBPbAccNum = new System.Windows.Forms.TextBox();
            this.txtBPsCurrency = new System.Windows.Forms.TextBox();
            this.txtBPTrxValue = new System.Windows.Forms.TextBox();
            this.txtBPbCurrency = new System.Windows.Forms.TextBox();
            this.txtBPsLastName = new System.Windows.Forms.TextBox();
            this.txtBPsFirstName = new System.Windows.Forms.TextBox();
            this.txtBPsIDNum = new System.Windows.Forms.TextBox();
            this.txtBPTransID = new System.Windows.Forms.TextBox();
            this.txtBPUID = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tabDo_BillInquiry = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.txtBIbIssuerCode = new System.Windows.Forms.TextBox();
            this.txtBIbAccNum = new System.Windows.Forms.TextBox();
            this.txtBIsIDNum = new System.Windows.Forms.TextBox();
            this.txtBITransID = new System.Windows.Forms.TextBox();
            this.txtBIUID = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tabDoTransfer = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTbIssuerCOde = new System.Windows.Forms.TextBox();
            this.txtTbAccNum = new System.Windows.Forms.TextBox();
            this.txtTbAccType = new System.Windows.Forms.TextBox();
            this.txtTbLastName = new System.Windows.Forms.TextBox();
            this.txtTbFirstName = new System.Windows.Forms.TextBox();
            this.txtTbIDNum = new System.Windows.Forms.TextBox();
            this.txtTsCurr = new System.Windows.Forms.TextBox();
            this.trxTTrxValue = new System.Windows.Forms.TextBox();
            this.txtTbCurrency = new System.Windows.Forms.TextBox();
            this.txtTsLastName = new System.Windows.Forms.TextBox();
            this.txtTsFirstName = new System.Windows.Forms.TextBox();
            this.txtTsIDNum = new System.Windows.Forms.TextBox();
            this.txtTTransID = new System.Windows.Forms.TextBox();
            this.txtTUID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabGetValidation = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbIssuerCode = new System.Windows.Forms.TextBox();
            this.txtbAccNum = new System.Windows.Forms.TextBox();
            this.txtbAccType = new System.Windows.Forms.TextBox();
            this.txtSIDNum = new System.Windows.Forms.TextBox();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabActionType = new System.Windows.Forms.TabControl();
            this.tabDo_BillPayment.SuspendLayout();
            this.tabDo_BillInquiry.SuspendLayout();
            this.tabDoTransfer.SuspendLayout();
            this.tabGetValidation.SuspendLayout();
            this.tabActionType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(381, 459);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(178, 28);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Rsp Signature";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtRspSignature
            // 
            this.txtRspSignature.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRspSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRspSignature.Location = new System.Drawing.Point(15, 460);
            this.txtRspSignature.Name = "txtRspSignature";
            this.txtRspSignature.ReadOnly = true;
            this.txtRspSignature.Size = new System.Drawing.Size(360, 23);
            this.txtRspSignature.TabIndex = 3;
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretKey.Location = new System.Drawing.Point(99, 15);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(460, 23);
            this.txtSecretKey.TabIndex = 4;
            // 
            // lblSecretKey
            // 
            this.lblSecretKey.AutoSize = true;
            this.lblSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretKey.Location = new System.Drawing.Point(16, 18);
            this.lblSecretKey.Name = "lblSecretKey";
            this.lblSecretKey.Size = new System.Drawing.Size(81, 17);
            this.lblSecretKey.TabIndex = 5;
            this.lblSecretKey.Text = "Secret Key:";
            // 
            // tabDo_BillPayment
            // 
            this.tabDo_BillPayment.Controls.Add(this.label28);
            this.tabDo_BillPayment.Controls.Add(this.txtBPbIssuerCode);
            this.tabDo_BillPayment.Controls.Add(this.txtBPbAccNum);
            this.tabDo_BillPayment.Controls.Add(this.txtBPsCurrency);
            this.tabDo_BillPayment.Controls.Add(this.txtBPTrxValue);
            this.tabDo_BillPayment.Controls.Add(this.txtBPbCurrency);
            this.tabDo_BillPayment.Controls.Add(this.txtBPsLastName);
            this.tabDo_BillPayment.Controls.Add(this.txtBPsFirstName);
            this.tabDo_BillPayment.Controls.Add(this.txtBPsIDNum);
            this.tabDo_BillPayment.Controls.Add(this.txtBPTransID);
            this.tabDo_BillPayment.Controls.Add(this.txtBPUID);
            this.tabDo_BillPayment.Controls.Add(this.label27);
            this.tabDo_BillPayment.Controls.Add(this.label32);
            this.tabDo_BillPayment.Controls.Add(this.label33);
            this.tabDo_BillPayment.Controls.Add(this.label34);
            this.tabDo_BillPayment.Controls.Add(this.label35);
            this.tabDo_BillPayment.Controls.Add(this.label36);
            this.tabDo_BillPayment.Controls.Add(this.label37);
            this.tabDo_BillPayment.Controls.Add(this.label38);
            this.tabDo_BillPayment.Controls.Add(this.label39);
            this.tabDo_BillPayment.Location = new System.Drawing.Point(4, 22);
            this.tabDo_BillPayment.Name = "tabDo_BillPayment";
            this.tabDo_BillPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabDo_BillPayment.Size = new System.Drawing.Size(540, 379);
            this.tabDo_BillPayment.TabIndex = 5;
            this.tabDo_BillPayment.Text = "Do_BillPayment";
            this.tabDo_BillPayment.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(21, 256);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 13);
            this.label28.TabIndex = 66;
            this.label28.Text = "bIssuerCode";
            // 
            // txtBPbIssuerCode
            // 
            this.txtBPbIssuerCode.Location = new System.Drawing.Point(162, 253);
            this.txtBPbIssuerCode.Name = "txtBPbIssuerCode";
            this.txtBPbIssuerCode.Size = new System.Drawing.Size(286, 20);
            this.txtBPbIssuerCode.TabIndex = 65;
            // 
            // txtBPbAccNum
            // 
            this.txtBPbAccNum.Location = new System.Drawing.Point(162, 226);
            this.txtBPbAccNum.Name = "txtBPbAccNum";
            this.txtBPbAccNum.Size = new System.Drawing.Size(286, 20);
            this.txtBPbAccNum.TabIndex = 63;
            // 
            // txtBPsCurrency
            // 
            this.txtBPsCurrency.Location = new System.Drawing.Point(162, 93);
            this.txtBPsCurrency.Name = "txtBPsCurrency";
            this.txtBPsCurrency.Size = new System.Drawing.Size(286, 20);
            this.txtBPsCurrency.TabIndex = 44;
            // 
            // txtBPTrxValue
            // 
            this.txtBPTrxValue.Location = new System.Drawing.Point(162, 67);
            this.txtBPTrxValue.Name = "txtBPTrxValue";
            this.txtBPTrxValue.Size = new System.Drawing.Size(286, 20);
            this.txtBPTrxValue.TabIndex = 42;
            // 
            // txtBPbCurrency
            // 
            this.txtBPbCurrency.Location = new System.Drawing.Point(162, 197);
            this.txtBPbCurrency.Name = "txtBPbCurrency";
            this.txtBPbCurrency.Size = new System.Drawing.Size(286, 20);
            this.txtBPbCurrency.TabIndex = 51;
            // 
            // txtBPsLastName
            // 
            this.txtBPsLastName.Location = new System.Drawing.Point(162, 171);
            this.txtBPsLastName.Name = "txtBPsLastName";
            this.txtBPsLastName.Size = new System.Drawing.Size(286, 20);
            this.txtBPsLastName.TabIndex = 49;
            // 
            // txtBPsFirstName
            // 
            this.txtBPsFirstName.Location = new System.Drawing.Point(162, 145);
            this.txtBPsFirstName.Name = "txtBPsFirstName";
            this.txtBPsFirstName.Size = new System.Drawing.Size(286, 20);
            this.txtBPsFirstName.TabIndex = 46;
            // 
            // txtBPsIDNum
            // 
            this.txtBPsIDNum.Location = new System.Drawing.Point(162, 119);
            this.txtBPsIDNum.Name = "txtBPsIDNum";
            this.txtBPsIDNum.Size = new System.Drawing.Size(286, 20);
            this.txtBPsIDNum.TabIndex = 45;
            // 
            // txtBPTransID
            // 
            this.txtBPTransID.Location = new System.Drawing.Point(162, 41);
            this.txtBPTransID.Name = "txtBPTransID";
            this.txtBPTransID.Size = new System.Drawing.Size(286, 20);
            this.txtBPTransID.TabIndex = 40;
            // 
            // txtBPUID
            // 
            this.txtBPUID.Location = new System.Drawing.Point(162, 15);
            this.txtBPUID.Name = "txtBPUID";
            this.txtBPUID.Size = new System.Drawing.Size(286, 20);
            this.txtBPUID.TabIndex = 39;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(21, 229);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 13);
            this.label27.TabIndex = 64;
            this.label27.Text = "bAccNum";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(21, 96);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(31, 13);
            this.label32.TabIndex = 54;
            this.label32.Text = "sCurr";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(21, 70);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(49, 13);
            this.label33.TabIndex = 53;
            this.label33.Text = "TrxValue";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(21, 200);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(55, 13);
            this.label34.TabIndex = 52;
            this.label34.Text = "bCurrency";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(21, 174);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(60, 13);
            this.label35.TabIndex = 50;
            this.label35.Text = "sLastName";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(21, 148);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(59, 13);
            this.label36.TabIndex = 48;
            this.label36.Text = "sFirstName";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(21, 122);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(45, 13);
            this.label37.TabIndex = 47;
            this.label37.Text = "sIDNum";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(21, 44);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(45, 13);
            this.label38.TabIndex = 43;
            this.label38.Text = "TransID";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(21, 18);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(26, 13);
            this.label39.TabIndex = 41;
            this.label39.Text = "UID";
            // 
            // tabDo_BillInquiry
            // 
            this.tabDo_BillInquiry.Controls.Add(this.label29);
            this.tabDo_BillInquiry.Controls.Add(this.txtBIbIssuerCode);
            this.tabDo_BillInquiry.Controls.Add(this.txtBIbAccNum);
            this.tabDo_BillInquiry.Controls.Add(this.txtBIsIDNum);
            this.tabDo_BillInquiry.Controls.Add(this.txtBITransID);
            this.tabDo_BillInquiry.Controls.Add(this.txtBIUID);
            this.tabDo_BillInquiry.Controls.Add(this.label30);
            this.tabDo_BillInquiry.Controls.Add(this.label31);
            this.tabDo_BillInquiry.Controls.Add(this.label40);
            this.tabDo_BillInquiry.Controls.Add(this.label41);
            this.tabDo_BillInquiry.Location = new System.Drawing.Point(4, 22);
            this.tabDo_BillInquiry.Name = "tabDo_BillInquiry";
            this.tabDo_BillInquiry.Padding = new System.Windows.Forms.Padding(3);
            this.tabDo_BillInquiry.Size = new System.Drawing.Size(540, 379);
            this.tabDo_BillInquiry.TabIndex = 4;
            this.tabDo_BillInquiry.Text = "Do_BillInquiry";
            this.tabDo_BillInquiry.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(23, 122);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(66, 13);
            this.label29.TabIndex = 76;
            this.label29.Text = "bIssuerCode";
            // 
            // txtBIbIssuerCode
            // 
            this.txtBIbIssuerCode.Location = new System.Drawing.Point(164, 119);
            this.txtBIbIssuerCode.Name = "txtBIbIssuerCode";
            this.txtBIbIssuerCode.Size = new System.Drawing.Size(286, 20);
            this.txtBIbIssuerCode.TabIndex = 75;
            // 
            // txtBIbAccNum
            // 
            this.txtBIbAccNum.Location = new System.Drawing.Point(164, 92);
            this.txtBIbAccNum.Name = "txtBIbAccNum";
            this.txtBIbAccNum.Size = new System.Drawing.Size(286, 20);
            this.txtBIbAccNum.TabIndex = 73;
            // 
            // txtBIsIDNum
            // 
            this.txtBIsIDNum.Location = new System.Drawing.Point(164, 66);
            this.txtBIsIDNum.Name = "txtBIsIDNum";
            this.txtBIsIDNum.Size = new System.Drawing.Size(286, 20);
            this.txtBIsIDNum.TabIndex = 71;
            // 
            // txtBITransID
            // 
            this.txtBITransID.Location = new System.Drawing.Point(164, 40);
            this.txtBITransID.Name = "txtBITransID";
            this.txtBITransID.Size = new System.Drawing.Size(286, 20);
            this.txtBITransID.TabIndex = 68;
            // 
            // txtBIUID
            // 
            this.txtBIUID.Location = new System.Drawing.Point(164, 14);
            this.txtBIUID.Name = "txtBIUID";
            this.txtBIUID.Size = new System.Drawing.Size(286, 20);
            this.txtBIUID.TabIndex = 67;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(23, 95);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 13);
            this.label30.TabIndex = 74;
            this.label30.Text = "bAccNum";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(23, 69);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(45, 13);
            this.label31.TabIndex = 72;
            this.label31.Text = "sIDNum";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(23, 43);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(45, 13);
            this.label40.TabIndex = 70;
            this.label40.Text = "TransID";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(23, 17);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(26, 13);
            this.label41.TabIndex = 69;
            this.label41.Text = "UID";
            // 
            // tabDoTransfer
            // 
            this.tabDoTransfer.Controls.Add(this.label18);
            this.tabDoTransfer.Controls.Add(this.txtTbIssuerCOde);
            this.tabDoTransfer.Controls.Add(this.txtTbAccNum);
            this.tabDoTransfer.Controls.Add(this.txtTbAccType);
            this.tabDoTransfer.Controls.Add(this.txtTbLastName);
            this.tabDoTransfer.Controls.Add(this.txtTbFirstName);
            this.tabDoTransfer.Controls.Add(this.txtTbIDNum);
            this.tabDoTransfer.Controls.Add(this.txtTsCurr);
            this.tabDoTransfer.Controls.Add(this.trxTTrxValue);
            this.tabDoTransfer.Controls.Add(this.txtTbCurrency);
            this.tabDoTransfer.Controls.Add(this.txtTsLastName);
            this.tabDoTransfer.Controls.Add(this.txtTsFirstName);
            this.tabDoTransfer.Controls.Add(this.txtTsIDNum);
            this.tabDoTransfer.Controls.Add(this.txtTTransID);
            this.tabDoTransfer.Controls.Add(this.txtTUID);
            this.tabDoTransfer.Controls.Add(this.label19);
            this.tabDoTransfer.Controls.Add(this.label20);
            this.tabDoTransfer.Controls.Add(this.label15);
            this.tabDoTransfer.Controls.Add(this.label16);
            this.tabDoTransfer.Controls.Add(this.label17);
            this.tabDoTransfer.Controls.Add(this.label14);
            this.tabDoTransfer.Controls.Add(this.label13);
            this.tabDoTransfer.Controls.Add(this.label7);
            this.tabDoTransfer.Controls.Add(this.label8);
            this.tabDoTransfer.Controls.Add(this.label9);
            this.tabDoTransfer.Controls.Add(this.label10);
            this.tabDoTransfer.Controls.Add(this.label11);
            this.tabDoTransfer.Controls.Add(this.label12);
            this.tabDoTransfer.Location = new System.Drawing.Point(4, 22);
            this.tabDoTransfer.Name = "tabDoTransfer";
            this.tabDoTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoTransfer.Size = new System.Drawing.Size(540, 379);
            this.tabDoTransfer.TabIndex = 1;
            this.tabDoTransfer.Text = "Do_Transfer";
            this.tabDoTransfer.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 352);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "bIssuerCode";
            // 
            // txtTbIssuerCOde
            // 
            this.txtTbIssuerCOde.Location = new System.Drawing.Point(157, 349);
            this.txtTbIssuerCOde.Name = "txtTbIssuerCOde";
            this.txtTbIssuerCOde.Size = new System.Drawing.Size(286, 20);
            this.txtTbIssuerCOde.TabIndex = 39;
            // 
            // txtTbAccNum
            // 
            this.txtTbAccNum.Location = new System.Drawing.Point(157, 323);
            this.txtTbAccNum.Name = "txtTbAccNum";
            this.txtTbAccNum.Size = new System.Drawing.Size(286, 20);
            this.txtTbAccNum.TabIndex = 37;
            // 
            // txtTbAccType
            // 
            this.txtTbAccType.Location = new System.Drawing.Point(157, 297);
            this.txtTbAccType.Name = "txtTbAccType";
            this.txtTbAccType.Size = new System.Drawing.Size(286, 20);
            this.txtTbAccType.TabIndex = 35;
            // 
            // txtTbLastName
            // 
            this.txtTbLastName.Location = new System.Drawing.Point(157, 271);
            this.txtTbLastName.Name = "txtTbLastName";
            this.txtTbLastName.Size = new System.Drawing.Size(286, 20);
            this.txtTbLastName.TabIndex = 33;
            // 
            // txtTbFirstName
            // 
            this.txtTbFirstName.Location = new System.Drawing.Point(157, 245);
            this.txtTbFirstName.Name = "txtTbFirstName";
            this.txtTbFirstName.Size = new System.Drawing.Size(286, 20);
            this.txtTbFirstName.TabIndex = 31;
            // 
            // txtTbIDNum
            // 
            this.txtTbIDNum.Location = new System.Drawing.Point(157, 219);
            this.txtTbIDNum.Name = "txtTbIDNum";
            this.txtTbIDNum.Size = new System.Drawing.Size(286, 20);
            this.txtTbIDNum.TabIndex = 29;
            // 
            // txtTsCurr
            // 
            this.txtTsCurr.Location = new System.Drawing.Point(157, 89);
            this.txtTsCurr.Name = "txtTsCurr";
            this.txtTsCurr.Size = new System.Drawing.Size(286, 20);
            this.txtTsCurr.TabIndex = 16;
            // 
            // trxTTrxValue
            // 
            this.trxTTrxValue.Location = new System.Drawing.Point(157, 63);
            this.trxTTrxValue.Name = "trxTTrxValue";
            this.trxTTrxValue.Size = new System.Drawing.Size(286, 20);
            this.trxTTrxValue.TabIndex = 15;
            // 
            // txtTbCurrency
            // 
            this.txtTbCurrency.Location = new System.Drawing.Point(157, 193);
            this.txtTbCurrency.Name = "txtTbCurrency";
            this.txtTbCurrency.Size = new System.Drawing.Size(286, 20);
            this.txtTbCurrency.TabIndex = 23;
            // 
            // txtTsLastName
            // 
            this.txtTsLastName.Location = new System.Drawing.Point(157, 167);
            this.txtTsLastName.Name = "txtTsLastName";
            this.txtTsLastName.Size = new System.Drawing.Size(286, 20);
            this.txtTsLastName.TabIndex = 21;
            // 
            // txtTsFirstName
            // 
            this.txtTsFirstName.Location = new System.Drawing.Point(157, 141);
            this.txtTsFirstName.Name = "txtTsFirstName";
            this.txtTsFirstName.Size = new System.Drawing.Size(286, 20);
            this.txtTsFirstName.TabIndex = 18;
            // 
            // txtTsIDNum
            // 
            this.txtTsIDNum.Location = new System.Drawing.Point(157, 115);
            this.txtTsIDNum.Name = "txtTsIDNum";
            this.txtTsIDNum.Size = new System.Drawing.Size(286, 20);
            this.txtTsIDNum.TabIndex = 17;
            // 
            // txtTTransID
            // 
            this.txtTTransID.Location = new System.Drawing.Point(157, 37);
            this.txtTTransID.Name = "txtTTransID";
            this.txtTTransID.Size = new System.Drawing.Size(286, 20);
            this.txtTTransID.TabIndex = 14;
            // 
            // txtTUID
            // 
            this.txtTUID.Location = new System.Drawing.Point(157, 11);
            this.txtTUID.Name = "txtTUID";
            this.txtTUID.Size = new System.Drawing.Size(286, 20);
            this.txtTUID.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 326);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "bAccNum";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 300);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "bAccType";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "bLastName";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "bFirstName";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "bIDNum";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "sCurr";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "TrxValue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "bCurrency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "sLastName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "sFirstName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "sIDNum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "TransID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "UID";
            // 
            // tabGetValidation
            // 
            this.tabGetValidation.Controls.Add(this.label6);
            this.tabGetValidation.Controls.Add(this.txtbIssuerCode);
            this.tabGetValidation.Controls.Add(this.txtbAccNum);
            this.tabGetValidation.Controls.Add(this.txtbAccType);
            this.tabGetValidation.Controls.Add(this.txtSIDNum);
            this.tabGetValidation.Controls.Add(this.txtTransID);
            this.tabGetValidation.Controls.Add(this.txtUID);
            this.tabGetValidation.Controls.Add(this.label5);
            this.tabGetValidation.Controls.Add(this.label4);
            this.tabGetValidation.Controls.Add(this.label3);
            this.tabGetValidation.Controls.Add(this.label2);
            this.tabGetValidation.Controls.Add(this.label1);
            this.tabGetValidation.Location = new System.Drawing.Point(4, 22);
            this.tabGetValidation.Name = "tabGetValidation";
            this.tabGetValidation.Padding = new System.Windows.Forms.Padding(3);
            this.tabGetValidation.Size = new System.Drawing.Size(540, 379);
            this.tabGetValidation.TabIndex = 0;
            this.tabGetValidation.Text = "Get_Validation";
            this.tabGetValidation.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "bIssuerCode";
            // 
            // txtbIssuerCode
            // 
            this.txtbIssuerCode.Location = new System.Drawing.Point(158, 140);
            this.txtbIssuerCode.Name = "txtbIssuerCode";
            this.txtbIssuerCode.Size = new System.Drawing.Size(286, 20);
            this.txtbIssuerCode.TabIndex = 11;
            // 
            // txtbAccNum
            // 
            this.txtbAccNum.Location = new System.Drawing.Point(158, 114);
            this.txtbAccNum.Name = "txtbAccNum";
            this.txtbAccNum.Size = new System.Drawing.Size(286, 20);
            this.txtbAccNum.TabIndex = 9;
            // 
            // txtbAccType
            // 
            this.txtbAccType.Location = new System.Drawing.Point(158, 88);
            this.txtbAccType.Name = "txtbAccType";
            this.txtbAccType.Size = new System.Drawing.Size(286, 20);
            this.txtbAccType.TabIndex = 7;
            // 
            // txtSIDNum
            // 
            this.txtSIDNum.Location = new System.Drawing.Point(158, 62);
            this.txtSIDNum.Name = "txtSIDNum";
            this.txtSIDNum.Size = new System.Drawing.Size(286, 20);
            this.txtSIDNum.TabIndex = 5;
            // 
            // txtTransID
            // 
            this.txtTransID.Location = new System.Drawing.Point(158, 36);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(286, 20);
            this.txtTransID.TabIndex = 3;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(158, 10);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(286, 20);
            this.txtUID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "bAccNum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "bAccType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "sIdNum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TransID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UID";
            // 
            // tabActionType
            // 
            this.tabActionType.Controls.Add(this.tabGetValidation);
            this.tabActionType.Controls.Add(this.tabDoTransfer);
            this.tabActionType.Controls.Add(this.tabDo_BillInquiry);
            this.tabActionType.Controls.Add(this.tabDo_BillPayment);
            this.tabActionType.Location = new System.Drawing.Point(15, 48);
            this.tabActionType.Name = "tabActionType";
            this.tabActionType.SelectedIndex = 0;
            this.tabActionType.Size = new System.Drawing.Size(548, 405);
            this.tabActionType.TabIndex = 1;
            // 
            // SignatureGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 495);
            this.Controls.Add(this.lblSecretKey);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.txtRspSignature);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tabActionType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignatureGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signature Generator Form";
            this.tabDo_BillPayment.ResumeLayout(false);
            this.tabDo_BillPayment.PerformLayout();
            this.tabDo_BillInquiry.ResumeLayout(false);
            this.tabDo_BillInquiry.PerformLayout();
            this.tabDoTransfer.ResumeLayout(false);
            this.tabDoTransfer.PerformLayout();
            this.tabGetValidation.ResumeLayout(false);
            this.tabGetValidation.PerformLayout();
            this.tabActionType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtRspSignature;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label lblSecretKey;
        private System.Windows.Forms.TabPage tabDo_BillPayment;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtBPbIssuerCode;
        private System.Windows.Forms.TextBox txtBPbAccNum;
        private System.Windows.Forms.TextBox txtBPsCurrency;
        private System.Windows.Forms.TextBox txtBPTrxValue;
        private System.Windows.Forms.TextBox txtBPbCurrency;
        private System.Windows.Forms.TextBox txtBPsLastName;
        private System.Windows.Forms.TextBox txtBPsFirstName;
        private System.Windows.Forms.TextBox txtBPsIDNum;
        private System.Windows.Forms.TextBox txtBPTransID;
        private System.Windows.Forms.TextBox txtBPUID;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TabPage tabDo_BillInquiry;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtBIbIssuerCode;
        private System.Windows.Forms.TextBox txtBIbAccNum;
        private System.Windows.Forms.TextBox txtBIsIDNum;
        private System.Windows.Forms.TextBox txtBITransID;
        private System.Windows.Forms.TextBox txtBIUID;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TabPage tabDoTransfer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTbIssuerCOde;
        private System.Windows.Forms.TextBox txtTbAccNum;
        private System.Windows.Forms.TextBox txtTbAccType;
        private System.Windows.Forms.TextBox txtTbLastName;
        private System.Windows.Forms.TextBox txtTbFirstName;
        private System.Windows.Forms.TextBox txtTbIDNum;
        private System.Windows.Forms.TextBox txtTsCurr;
        private System.Windows.Forms.TextBox trxTTrxValue;
        private System.Windows.Forms.TextBox txtTbCurrency;
        private System.Windows.Forms.TextBox txtTsLastName;
        private System.Windows.Forms.TextBox txtTsFirstName;
        private System.Windows.Forms.TextBox txtTsIDNum;
        private System.Windows.Forms.TextBox txtTTransID;
        private System.Windows.Forms.TextBox txtTUID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabGetValidation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbIssuerCode;
        private System.Windows.Forms.TextBox txtbAccNum;
        private System.Windows.Forms.TextBox txtbAccType;
        private System.Windows.Forms.TextBox txtSIDNum;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabActionType;

    }
}

