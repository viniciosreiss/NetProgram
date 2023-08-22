namespace WindowsFormsApp1
{
    partial class testNet
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testNet));
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addNumber = new System.Windows.Forms.Button();
            this.txtGenerate = new System.Windows.Forms.Button();
            this.listInput = new System.Windows.Forms.ListBox();
            this.openArchive = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.loadGrid = new System.Windows.Forms.Button();
            this.jsonGenerator = new System.Windows.Forms.Button();
            this.Page3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.searchCEP = new System.Windows.Forms.Button();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.inputCEP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Page4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLoadBanks = new System.Windows.Forms.Button();
            this.dataGridViewBanks = new System.Windows.Forms.DataGridView();
            this.Page5 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxBase64 = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnDownloadAndShowImage = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Page1.SuspendLayout();
            this.Page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Page3.SuspendLayout();
            this.Page4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanks)).BeginInit();
            this.Page5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(115, 52);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(134, 20);
            this.inputNumber.TabIndex = 0;
            this.inputNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputNumber.TextChanged += new System.EventHandler(this.inputNumber_TextChanged);
            this.inputNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um número:";
            // 
            // addNumber
            // 
            this.addNumber.Location = new System.Drawing.Point(255, 50);
            this.addNumber.Name = "addNumber";
            this.addNumber.Size = new System.Drawing.Size(75, 23);
            this.addNumber.TabIndex = 2;
            this.addNumber.Text = "Add";
            this.addNumber.UseVisualStyleBackColor = true;
            this.addNumber.Click += new System.EventHandler(this.addNumber_Click);
            // 
            // txtGenerate
            // 
            this.txtGenerate.Location = new System.Drawing.Point(48, 414);
            this.txtGenerate.Name = "txtGenerate";
            this.txtGenerate.Size = new System.Drawing.Size(113, 27);
            this.txtGenerate.TabIndex = 4;
            this.txtGenerate.Text = "Gerar Arquivo";
            this.txtGenerate.UseVisualStyleBackColor = true;
            this.txtGenerate.Click += new System.EventHandler(this.txtGenerate_Click);
            // 
            // listInput
            // 
            this.listInput.FormattingEnabled = true;
            this.listInput.Location = new System.Drawing.Point(20, 79);
            this.listInput.Name = "listInput";
            this.listInput.Size = new System.Drawing.Size(310, 329);
            this.listInput.TabIndex = 6;
            this.listInput.SelectedIndexChanged += new System.EventHandler(this.listInput_SelectedIndexChanged);
            // 
            // openArchive
            // 
            this.openArchive.Location = new System.Drawing.Point(167, 414);
            this.openArchive.Name = "openArchive";
            this.openArchive.Size = new System.Drawing.Size(113, 27);
            this.openArchive.TabIndex = 7;
            this.openArchive.Text = "Abrir Arquivo";
            this.openArchive.UseVisualStyleBackColor = true;
            this.openArchive.Click += new System.EventHandler(this.openArchive_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page1);
            this.tabControl1.Controls.Add(this.Page2);
            this.tabControl1.Controls.Add(this.Page3);
            this.tabControl1.Controls.Add(this.Page4);
            this.tabControl1.Controls.Add(this.Page5);
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 476);
            this.tabControl1.TabIndex = 8;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.label4);
            this.Page1.Controls.Add(this.label3);
            this.Page1.Controls.Add(this.inputNumber);
            this.Page1.Controls.Add(this.openArchive);
            this.Page1.Controls.Add(this.label1);
            this.Page1.Controls.Add(this.listInput);
            this.Page1.Controls.Add(this.addNumber);
            this.Page1.Controls.Add(this.txtGenerate);
            this.Page1.Location = new System.Drawing.Point(4, 22);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(809, 450);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Q1 e Q2";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "2. Agora grave os números visualizados cada 1 em uma linha em um arquivo texto \r\n" +
    "na pasta raiz da aplicação de nome numeros_ordenar.txt.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "1. Faça a aplicação permitir a digitação de números e mostre esses números em tel" +
    "a de forma\r\nordenada.\r\n";
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.label5);
            this.Page2.Controls.Add(this.dataGridView);
            this.Page2.Controls.Add(this.loadGrid);
            this.Page2.Controls.Add(this.jsonGenerator);
            this.Page2.Location = new System.Drawing.Point(4, 22);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(809, 450);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Q3, Q4 e Q5";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(469, 104);
            this.label5.TabIndex = 3;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(59, 181);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(690, 251);
            this.dataGridView.TabIndex = 2;
            // 
            // loadGrid
            // 
            this.loadGrid.Location = new System.Drawing.Point(396, 152);
            this.loadGrid.Name = "loadGrid";
            this.loadGrid.Size = new System.Drawing.Size(212, 23);
            this.loadGrid.TabIndex = 1;
            this.loadGrid.Text = "Carregar Grid";
            this.loadGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadGrid.UseVisualStyleBackColor = true;
            this.loadGrid.Click += new System.EventHandler(this.loadGrid_Click);
            // 
            // jsonGenerator
            // 
            this.jsonGenerator.Location = new System.Drawing.Point(178, 152);
            this.jsonGenerator.Name = "jsonGenerator";
            this.jsonGenerator.Size = new System.Drawing.Size(212, 23);
            this.jsonGenerator.TabIndex = 0;
            this.jsonGenerator.Text = "Gerar arquivo data.json";
            this.jsonGenerator.UseVisualStyleBackColor = true;
            this.jsonGenerator.Click += new System.EventHandler(this.jsonGenerator_Click);
            // 
            // Page3
            // 
            this.Page3.Controls.Add(this.label6);
            this.Page3.Controls.Add(this.searchCEP);
            this.Page3.Controls.Add(this.rtbAddress);
            this.Page3.Controls.Add(this.inputCEP);
            this.Page3.Controls.Add(this.label2);
            this.Page3.Location = new System.Drawing.Point(4, 22);
            this.Page3.Name = "Page3";
            this.Page3.Size = new System.Drawing.Size(809, 450);
            this.Page3.TabIndex = 2;
            this.Page3.Text = "Q6";
            this.Page3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(490, 52);
            this.label6.TabIndex = 4;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // searchCEP
            // 
            this.searchCEP.Location = new System.Drawing.Point(282, 129);
            this.searchCEP.Name = "searchCEP";
            this.searchCEP.Size = new System.Drawing.Size(91, 23);
            this.searchCEP.TabIndex = 3;
            this.searchCEP.Text = "Consultar";
            this.searchCEP.UseVisualStyleBackColor = true;
            this.searchCEP.Click += new System.EventHandler(this.searchCEP_Click);
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(72, 157);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(618, 261);
            this.rtbAddress.TabIndex = 2;
            this.rtbAddress.Text = "";
            this.rtbAddress.TextChanged += new System.EventHandler(this.rtbAddress_TextChanged);
            // 
            // inputCEP
            // 
            this.inputCEP.Location = new System.Drawing.Point(170, 131);
            this.inputCEP.Name = "inputCEP";
            this.inputCEP.Size = new System.Drawing.Size(106, 20);
            this.inputCEP.TabIndex = 1;
            this.inputCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputCEP.TextChanged += new System.EventHandler(this.inputCEP_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consulte seu CEP:";
            // 
            // Page4
            // 
            this.Page4.Controls.Add(this.label7);
            this.Page4.Controls.Add(this.btnLoadBanks);
            this.Page4.Controls.Add(this.dataGridViewBanks);
            this.Page4.Location = new System.Drawing.Point(4, 22);
            this.Page4.Name = "Page4";
            this.Page4.Size = new System.Drawing.Size(809, 450);
            this.Page4.TabIndex = 3;
            this.Page4.Text = "Q7";
            this.Page4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(409, 52);
            this.label7.TabIndex = 2;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // btnLoadBanks
            // 
            this.btnLoadBanks.Location = new System.Drawing.Point(58, 155);
            this.btnLoadBanks.Name = "btnLoadBanks";
            this.btnLoadBanks.Size = new System.Drawing.Size(133, 23);
            this.btnLoadBanks.TabIndex = 1;
            this.btnLoadBanks.Text = "Consultar e Mostrar";
            this.btnLoadBanks.UseVisualStyleBackColor = true;
            this.btnLoadBanks.Click += new System.EventHandler(this.btnLoadBanks_Click);
            // 
            // dataGridViewBanks
            // 
            this.dataGridViewBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanks.Location = new System.Drawing.Point(58, 184);
            this.dataGridViewBanks.Name = "dataGridViewBanks";
            this.dataGridViewBanks.Size = new System.Drawing.Size(694, 246);
            this.dataGridViewBanks.TabIndex = 0;
            this.dataGridViewBanks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBanks_CellContentClick);
            // 
            // Page5
            // 
            this.Page5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Page5.Controls.Add(this.label8);
            this.Page5.Controls.Add(this.richTextBoxBase64);
            this.Page5.Controls.Add(this.pictureBox);
            this.Page5.Controls.Add(this.btnDownloadAndShowImage);
            this.Page5.Location = new System.Drawing.Point(4, 22);
            this.Page5.Name = "Page5";
            this.Page5.Size = new System.Drawing.Size(809, 450);
            this.Page5.TabIndex = 4;
            this.Page5.Text = "Q8";
            this.Page5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(590, 39);
            this.label8.TabIndex = 3;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // richTextBoxBase64
            // 
            this.richTextBoxBase64.Location = new System.Drawing.Point(60, 169);
            this.richTextBoxBase64.Name = "richTextBoxBase64";
            this.richTextBoxBase64.Size = new System.Drawing.Size(482, 226);
            this.richTextBoxBase64.TabIndex = 2;
            this.richTextBoxBase64.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(548, 169);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(208, 226);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btnDownloadAndShowImage
            // 
            this.btnDownloadAndShowImage.Location = new System.Drawing.Point(305, 395);
            this.btnDownloadAndShowImage.Name = "btnDownloadAndShowImage";
            this.btnDownloadAndShowImage.Size = new System.Drawing.Size(166, 23);
            this.btnDownloadAndShowImage.TabIndex = 0;
            this.btnDownloadAndShowImage.Text = "Gerar e Baixar imagem";
            this.btnDownloadAndShowImage.UseVisualStyleBackColor = true;
            this.btnDownloadAndShowImage.Click += new System.EventHandler(this.btnDownloadAndShowImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 522);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Teste .NET";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.Page2.ResumeLayout(false);
            this.Page2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Page3.ResumeLayout(false);
            this.Page3.PerformLayout();
            this.Page4.ResumeLayout(false);
            this.Page4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanks)).EndInit();
            this.Page5.ResumeLayout(false);
            this.Page5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNumber;
        private System.Windows.Forms.Button txtGenerate;
        private System.Windows.Forms.ListBox listInput;
        private System.Windows.Forms.Button openArchive;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.Button jsonGenerator;
        private System.Windows.Forms.Button loadGrid;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage Page3;
        private System.Windows.Forms.TextBox inputCEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchCEP;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.TabPage Page4;
        private System.Windows.Forms.Button btnLoadBanks;
        private System.Windows.Forms.DataGridView dataGridViewBanks;
        private System.Windows.Forms.TabPage Page5;
        private System.Windows.Forms.Button btnDownloadAndShowImage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox richTextBoxBase64;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

