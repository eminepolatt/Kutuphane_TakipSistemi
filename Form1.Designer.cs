namespace Kutuphane_TakipSistemi_Form
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.txtUyeId = new System.Windows.Forms.TextBox();
            this.groupBoxKitap = new System.Windows.Forms.GroupBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.rbRoman = new System.Windows.Forms.RadioButton();
            this.rbDersKitabi = new System.Windows.Forms.RadioButton();
            this.lblYayinevi = new System.Windows.Forms.Label();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBoxUye = new System.Windows.Forms.GroupBox();
            this.btnUyeKaydet = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.txtUyeAd = new System.Windows.Forms.TextBox();
            this.groupBoxOdunc = new System.Windows.Forms.GroupBox();
            this.btnOduncVer = new System.Windows.Forms.Button();
            this.btnIadeAl = new System.Windows.Forms.Button();
            this.btnGeciken = new System.Windows.Forms.Button();
            this.groupBoxVeri = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYukle = new System.Windows.Forms.Button();
            this.groupBoxGenel = new System.Windows.Forms.GroupBox();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxKitap.SuspendLayout();
            this.groupBoxUye.SuspendLayout();
            this.groupBoxOdunc.SuspendLayout();
            this.groupBoxVeri.SuspendLayout();
            this.groupBoxGenel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKitapId
            // 
            this.txtKitapId.Location = new System.Drawing.Point(0, 0);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.Size = new System.Drawing.Size(100, 22);
            this.txtKitapId.TabIndex = 0;
            // 
            // txtUyeId
            // 
            this.txtUyeId.Location = new System.Drawing.Point(0, 0);
            this.txtUyeId.Name = "txtUyeId";
            this.txtUyeId.Size = new System.Drawing.Size(100, 22);
            this.txtUyeId.TabIndex = 0;
            // 
            // groupBoxKitap
            // 
            this.groupBoxKitap.Controls.Add(this.lblAd);
            this.groupBoxKitap.Controls.Add(this.txtAd);
            this.groupBoxKitap.Controls.Add(this.lblYazar);
            this.groupBoxKitap.Controls.Add(this.txtYazar);
            this.groupBoxKitap.Controls.Add(this.lblTur);
            this.groupBoxKitap.Controls.Add(this.txtTur);
            this.groupBoxKitap.Controls.Add(this.rbRoman);
            this.groupBoxKitap.Controls.Add(this.rbDersKitabi);
            this.groupBoxKitap.Controls.Add(this.lblYayinevi);
            this.groupBoxKitap.Controls.Add(this.txtYayinevi);
            this.groupBoxKitap.Controls.Add(this.lblDersAdi);
            this.groupBoxKitap.Controls.Add(this.txtDersAdi);
            this.groupBoxKitap.Controls.Add(this.btnKitapEkle);
            this.groupBoxKitap.Location = new System.Drawing.Point(30, 30);
            this.groupBoxKitap.Name = "groupBoxKitap";
            this.groupBoxKitap.Size = new System.Drawing.Size(356, 300);
            this.groupBoxKitap.TabIndex = 0;
            this.groupBoxKitap.TabStop = false;
            this.groupBoxKitap.Text = "Kitap Bilgisi";
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(20, 30);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(100, 23);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Kitap Adı:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(161, 31);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // lblYazar
            // 
            this.lblYazar.Location = new System.Drawing.Point(20, 65);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(100, 23);
            this.lblYazar.TabIndex = 2;
            this.lblYazar.Text = "Yazar:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(161, 66);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 22);
            this.txtYazar.TabIndex = 3;
            this.txtYazar.TextChanged += new System.EventHandler(this.txtYazar_TextChanged);
            // 
            // lblTur
            // 
            this.lblTur.Location = new System.Drawing.Point(20, 100);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(100, 23);
            this.lblTur.TabIndex = 4;
            this.lblTur.Text = "Tür:";
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(161, 101);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(100, 22);
            this.txtTur.TabIndex = 5;
            this.txtTur.TextChanged += new System.EventHandler(this.txtTur_TextChanged);
            // 
            // rbRoman
            // 
            this.rbRoman.Location = new System.Drawing.Point(71, 130);
            this.rbRoman.Name = "rbRoman";
            this.rbRoman.Size = new System.Drawing.Size(104, 24);
            this.rbRoman.TabIndex = 6;
            this.rbRoman.Text = "Roman";
            // 
            // rbDersKitabi
            // 
            this.rbDersKitabi.Location = new System.Drawing.Point(180, 130);
            this.rbDersKitabi.Name = "rbDersKitabi";
            this.rbDersKitabi.Size = new System.Drawing.Size(104, 24);
            this.rbDersKitabi.TabIndex = 7;
            this.rbDersKitabi.Text = "Ders Kitabı";
            // 
            // lblYayinevi
            // 
            this.lblYayinevi.Location = new System.Drawing.Point(20, 165);
            this.lblYayinevi.Name = "lblYayinevi";
            this.lblYayinevi.Size = new System.Drawing.Size(100, 23);
            this.lblYayinevi.TabIndex = 8;
            this.lblYayinevi.Text = "Yayınevi:";
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(161, 165);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(100, 22);
            this.txtYayinevi.TabIndex = 9;
            this.txtYayinevi.TextChanged += new System.EventHandler(this.txtYayinevi_TextChanged);
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.Location = new System.Drawing.Point(20, 200);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(100, 23);
            this.lblDersAdi.TabIndex = 10;
            this.lblDersAdi.Text = "Ders Adı:";
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(161, 201);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(100, 22);
            this.txtDersAdi.TabIndex = 11;
            this.txtDersAdi.TextChanged += new System.EventHandler(this.txtDersAdi_TextChanged);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.Color.RosyBrown;
            this.btnKitapEkle.Location = new System.Drawing.Point(116, 250);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(130, 33);
            this.btnKitapEkle.TabIndex = 12;
            this.btnKitapEkle.Text = "Kitabı Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // groupBoxUye
            // 
            this.groupBoxUye.Controls.Add(this.label2);
            this.groupBoxUye.Controls.Add(this.label1);
            this.groupBoxUye.Controls.Add(this.btnUyeListele);
            this.groupBoxUye.Controls.Add(this.btnUyeEkle);
            this.groupBoxUye.Controls.Add(this.txtTelefon);
            this.groupBoxUye.Controls.Add(this.txtUyeAd);
            this.groupBoxUye.Location = new System.Drawing.Point(29, 353);
            this.groupBoxUye.Name = "groupBoxUye";
            this.groupBoxUye.Size = new System.Drawing.Size(357, 100);
            this.groupBoxUye.TabIndex = 1;
            this.groupBoxUye.TabStop = false;
            this.groupBoxUye.Text = "Üye";
            // 
            // btnUyeKaydet
            // 
            this.btnUyeKaydet.Location = new System.Drawing.Point(409, 407);
            this.btnUyeKaydet.Name = "btnUyeKaydet";
            this.btnUyeKaydet.Size = new System.Drawing.Size(119, 39);
            this.btnUyeKaydet.TabIndex = 7;
            this.btnUyeKaydet.Text = "Kaydet";
            this.btnUyeKaydet.UseVisualStyleBackColor = true;
            this.btnUyeKaydet.Click += new System.EventHandler(this.btnUyeKaydet_Click_1);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(252, 70);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Üye Ekle";
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(108, 72);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 6;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.Location = new System.Drawing.Point(217, 32);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(140, 23);
            this.btnUyeListele.TabIndex = 1;
            this.btnUyeListele.Text = "Üyeleri Listele";
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // txtUyeAd
            // 
            this.txtUyeAd.Location = new System.Drawing.Point(108, 33);
            this.txtUyeAd.Name = "txtUyeAd";
            this.txtUyeAd.Size = new System.Drawing.Size(100, 22);
            this.txtUyeAd.TabIndex = 5;
            this.txtUyeAd.TextChanged += new System.EventHandler(this.txtUyeAd_TextChanged);
            // 
            // groupBoxOdunc
            // 
            this.groupBoxOdunc.Controls.Add(this.btnOduncVer);
            this.groupBoxOdunc.Controls.Add(this.btnIadeAl);
            this.groupBoxOdunc.Controls.Add(this.btnGeciken);
            this.groupBoxOdunc.Location = new System.Drawing.Point(426, 33);
            this.groupBoxOdunc.Name = "groupBoxOdunc";
            this.groupBoxOdunc.Size = new System.Drawing.Size(235, 120);
            this.groupBoxOdunc.TabIndex = 2;
            this.groupBoxOdunc.TabStop = false;
            this.groupBoxOdunc.Text = "Ödünç/İade";
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.Location = new System.Drawing.Point(20, 20);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(140, 23);
            this.btnOduncVer.TabIndex = 0;
            this.btnOduncVer.Text = "Ödünç Ver";
            this.btnOduncVer.Click += new System.EventHandler(this.btnOduncVer_Click);
            // 
            // btnIadeAl
            // 
            this.btnIadeAl.Location = new System.Drawing.Point(20, 50);
            this.btnIadeAl.Name = "btnIadeAl";
            this.btnIadeAl.Size = new System.Drawing.Size(140, 23);
            this.btnIadeAl.TabIndex = 1;
            this.btnIadeAl.Text = "İade Al";
            this.btnIadeAl.Click += new System.EventHandler(this.btnIadeAl_Click);
            // 
            // btnGeciken
            // 
            this.btnGeciken.Location = new System.Drawing.Point(20, 80);
            this.btnGeciken.Name = "btnGeciken";
            this.btnGeciken.Size = new System.Drawing.Size(140, 23);
            this.btnGeciken.TabIndex = 2;
            this.btnGeciken.Text = "Geciken Kitaplar";
            this.btnGeciken.Click += new System.EventHandler(this.btnGeciken_Click);
            // 
            // groupBoxVeri
            // 
            this.groupBoxVeri.Controls.Add(this.btnKaydet);
            this.groupBoxVeri.Controls.Add(this.btnYukle);
            this.groupBoxVeri.Location = new System.Drawing.Point(426, 163);
            this.groupBoxVeri.Name = "groupBoxVeri";
            this.groupBoxVeri.Size = new System.Drawing.Size(235, 100);
            this.groupBoxVeri.TabIndex = 3;
            this.groupBoxVeri.TabStop = false;
            this.groupBoxVeri.Text = "Veri İşlemleri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(20, 20);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Verileri Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(20, 50);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(140, 23);
            this.btnYukle.TabIndex = 1;
            this.btnYukle.Text = "Verileri Yükle";
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // groupBoxGenel
            // 
            this.groupBoxGenel.Controls.Add(this.btnKitapListele);
            this.groupBoxGenel.Controls.Add(this.btnCikis);
            this.groupBoxGenel.Location = new System.Drawing.Point(426, 273);
            this.groupBoxGenel.Name = "groupBoxGenel";
            this.groupBoxGenel.Size = new System.Drawing.Size(235, 90);
            this.groupBoxGenel.TabIndex = 4;
            this.groupBoxGenel.TabStop = false;
            this.groupBoxGenel.Text = "Genel";
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Location = new System.Drawing.Point(20, 20);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(140, 23);
            this.btnKitapListele.TabIndex = 0;
            this.btnKitapListele.Text = "Kitapları Listele";
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(20, 50);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(140, 23);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefon";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(712, 500);
            this.Controls.Add(this.groupBoxKitap);
            this.Controls.Add(this.groupBoxUye);
            this.Controls.Add(this.btnUyeKaydet);
            this.Controls.Add(this.groupBoxOdunc);
            this.Controls.Add(this.groupBoxVeri);
            this.Controls.Add(this.groupBoxGenel);
            this.Name = "Form1";
            this.Text = "Kütüphane Takip Sistemi";
            this.groupBoxKitap.ResumeLayout(false);
            this.groupBoxKitap.PerformLayout();
            this.groupBoxUye.ResumeLayout(false);
            this.groupBoxUye.PerformLayout();
            this.groupBoxOdunc.ResumeLayout(false);
            this.groupBoxVeri.ResumeLayout(false);
            this.groupBoxGenel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.GroupBox groupBoxKitap;
        private System.Windows.Forms.GroupBox groupBoxUye;
        private System.Windows.Forms.GroupBox groupBoxOdunc;
        private System.Windows.Forms.GroupBox groupBoxVeri;
        private System.Windows.Forms.GroupBox groupBoxGenel;
        private System.Windows.Forms.Label lblAd, lblYazar, lblTur, lblYayinevi, lblDersAdi;
        private System.Windows.Forms.TextBox txtAd, txtYazar, txtTur, txtYayinevi, txtDersAdi;
        private System.Windows.Forms.RadioButton rbRoman, rbDersKitabi;
        private System.Windows.Forms.Button btnKitapEkle, btnUyeEkle, btnUyeListele, btnOduncVer,
                                            btnIadeAl, btnGeciken, btnKaydet, btnYukle,
                                            btnKitapListele, btnCikis;
        private System.Windows.Forms.TextBox txtUyeAd;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnUyeKaydet;
        private System.Windows.Forms.TextBox txtKitapId;
        private System.Windows.Forms.TextBox txtUyeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
