namespace Task1WinForms {
  partial class Task1Page {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.GroupBox groupCreate;
    private System.Windows.Forms.Label labelPath;
    private System.Windows.Forms.TextBox boxPath;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.Label labelNumbers;
    private System.Windows.Forms.TextBox boxNumbers;
    private System.Windows.Forms.Label labelCount;
    private System.Windows.Forms.TextBox boxCount;
    private System.Windows.Forms.Button btnRandom;
    private System.Windows.Forms.Button btnCreate;

    private System.Windows.Forms.GroupBox groupResult;
    private System.Windows.Forms.Label labelContent;
    private System.Windows.Forms.TextBox boxContent;
    private System.Windows.Forms.Label labelEvenCount;
    private System.Windows.Forms.TextBox boxEvenCount;
    private System.Windows.Forms.Label labelProduct;
    private System.Windows.Forms.TextBox boxProduct;
    private System.Windows.Forms.Button btnCalculate;

    private System.Windows.Forms.SaveFileDialog saveDialog;
    private System.Windows.Forms.TableLayoutPanel body;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.groupCreate = new System.Windows.Forms.GroupBox();
      this.labelPath = new System.Windows.Forms.Label();
      this.boxPath = new System.Windows.Forms.TextBox();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.labelNumbers = new System.Windows.Forms.Label();
      this.boxNumbers = new System.Windows.Forms.TextBox();
      this.labelCount = new System.Windows.Forms.Label();
      this.boxCount = new System.Windows.Forms.TextBox();
      this.btnRandom = new System.Windows.Forms.Button();
      this.btnCreate = new System.Windows.Forms.Button();
      this.groupResult = new System.Windows.Forms.GroupBox();
      this.labelContent = new System.Windows.Forms.Label();
      this.boxContent = new System.Windows.Forms.TextBox();
      this.labelEvenCount = new System.Windows.Forms.Label();
      this.boxEvenCount = new System.Windows.Forms.TextBox();
      this.labelProduct = new System.Windows.Forms.Label();
      this.boxProduct = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.saveDialog = new System.Windows.Forms.SaveFileDialog();
      this.body = new System.Windows.Forms.TableLayoutPanel();
      this.groupCreate.SuspendLayout();
      this.groupResult.SuspendLayout();
      this.body.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupCreate
      // 
      this.groupCreate.Controls.Add(this.labelPath);
      this.groupCreate.Controls.Add(this.boxPath);
      this.groupCreate.Controls.Add(this.btnBrowse);
      this.groupCreate.Controls.Add(this.labelNumbers);
      this.groupCreate.Controls.Add(this.boxNumbers);
      this.groupCreate.Controls.Add(this.labelCount);
      this.groupCreate.Controls.Add(this.boxCount);
      this.groupCreate.Controls.Add(this.btnRandom);
      this.groupCreate.Controls.Add(this.btnCreate);
      this.groupCreate.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupCreate.Location = new System.Drawing.Point(3, 3);
      this.groupCreate.Name = "groupCreate";
      this.groupCreate.Size = new System.Drawing.Size(754, 200);
      this.groupCreate.TabIndex = 0;
      this.groupCreate.TabStop = false;
      this.groupCreate.Text = "1. Создание двоичного файла с целыми числами";
      // 
      // labelPath
      // 
      this.labelPath.AutoSize = true;
      this.labelPath.Location = new System.Drawing.Point(20, 35);
      this.labelPath.Name = "labelPath";
      this.labelPath.Size = new System.Drawing.Size(34, 13);
      this.labelPath.TabIndex = 0;
      this.labelPath.Text = "Файл:";
      // 
      // boxPath
      // 
      this.boxPath.Location = new System.Drawing.Point(110, 32);
      this.boxPath.Name = "boxPath";
      this.boxPath.Size = new System.Drawing.Size(430, 20);
      this.boxPath.TabIndex = 1;
      // 
      // btnBrowse
      // 
      this.btnBrowse.Location = new System.Drawing.Point(550, 30);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(110, 25);
      this.btnBrowse.TabIndex = 2;
      this.btnBrowse.Text = "Обзор...";
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // labelNumbers
      // 
      this.labelNumbers.AutoSize = true;
      this.labelNumbers.Location = new System.Drawing.Point(20, 70);
      this.labelNumbers.Name = "labelNumbers";
      this.labelNumbers.Size = new System.Drawing.Size(40, 13);
      this.labelNumbers.TabIndex = 3;
      this.labelNumbers.Text = "Числа:";
      // 
      // boxNumbers
      // 
      this.boxNumbers.Multiline = true;
      this.boxNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.boxNumbers.Location = new System.Drawing.Point(110, 67);
      this.boxNumbers.Name = "boxNumbers";
      this.boxNumbers.Size = new System.Drawing.Size(550, 60);
      this.boxNumbers.TabIndex = 4;
      // 
      // labelCount
      // 
      this.labelCount.AutoSize = true;
      this.labelCount.Location = new System.Drawing.Point(20, 145);
      this.labelCount.Name = "labelCount";
      this.labelCount.Size = new System.Drawing.Size(70, 13);
      this.labelCount.TabIndex = 5;
      this.labelCount.Text = "Количество:";
      // 
      // boxCount
      // 
      this.boxCount.Location = new System.Drawing.Point(110, 142);
      this.boxCount.Name = "boxCount";
      this.boxCount.Size = new System.Drawing.Size(80, 20);
      this.boxCount.TabIndex = 6;
      this.boxCount.Text = "10";
      // 
      // btnRandom
      // 
      this.btnRandom.Location = new System.Drawing.Point(200, 140);
      this.btnRandom.Name = "btnRandom";
      this.btnRandom.Size = new System.Drawing.Size(160, 25);
      this.btnRandom.TabIndex = 7;
      this.btnRandom.Text = "Случайные числа";
      this.btnRandom.UseVisualStyleBackColor = true;
      this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
      // 
      // btnCreate
      // 
      this.btnCreate.Location = new System.Drawing.Point(500, 140);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(160, 25);
      this.btnCreate.TabIndex = 8;
      this.btnCreate.Text = "Создать файл";
      this.btnCreate.UseVisualStyleBackColor = true;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      // 
      // groupResult
      // 
      this.groupResult.Controls.Add(this.labelContent);
      this.groupResult.Controls.Add(this.boxContent);
      this.groupResult.Controls.Add(this.labelEvenCount);
      this.groupResult.Controls.Add(this.boxEvenCount);
      this.groupResult.Controls.Add(this.labelProduct);
      this.groupResult.Controls.Add(this.boxProduct);
      this.groupResult.Controls.Add(this.btnCalculate);
      this.groupResult.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupResult.Location = new System.Drawing.Point(3, 3);
      this.groupResult.Name = "groupResult";
      this.groupResult.Size = new System.Drawing.Size(754, 200);
      this.groupResult.TabIndex = 1;
      this.groupResult.TabStop = false;
      this.groupResult.Text = "2. Произведение чётных чисел из двоичного файла";
      // 
      // labelContent
      // 
      this.labelContent.AutoSize = true;
      this.labelContent.Location = new System.Drawing.Point(20, 35);
      this.labelContent.Name = "labelContent";
      this.labelContent.Size = new System.Drawing.Size(88, 13);
      this.labelContent.TabIndex = 0;
      this.labelContent.Text = "Числа в файле:";
      // 
      // boxContent
      // 
      this.boxContent.Multiline = true;
      this.boxContent.ReadOnly = true;
      this.boxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.boxContent.Location = new System.Drawing.Point(110, 32);
      this.boxContent.Name = "boxContent";
      this.boxContent.Size = new System.Drawing.Size(550, 60);
      this.boxContent.TabIndex = 1;
      // 
      // labelEvenCount
      // 
      this.labelEvenCount.AutoSize = true;
      this.labelEvenCount.Location = new System.Drawing.Point(20, 110);
      this.labelEvenCount.Name = "labelEvenCount";
      this.labelEvenCount.Size = new System.Drawing.Size(82, 13);
      this.labelEvenCount.TabIndex = 2;
      this.labelEvenCount.Text = "Чётных чисел:";
      // 
      // boxEvenCount
      // 
      this.boxEvenCount.ReadOnly = true;
      this.boxEvenCount.Location = new System.Drawing.Point(110, 107);
      this.boxEvenCount.Name = "boxEvenCount";
      this.boxEvenCount.Size = new System.Drawing.Size(80, 20);
      this.boxEvenCount.TabIndex = 3;
      // 
      // labelProduct
      // 
      this.labelProduct.AutoSize = true;
      this.labelProduct.Location = new System.Drawing.Point(200, 110);
      this.labelProduct.Name = "labelProduct";
      this.labelProduct.Size = new System.Drawing.Size(82, 13);
      this.labelProduct.TabIndex = 4;
      this.labelProduct.Text = "Произведение:";
      // 
      // boxProduct
      // 
      this.boxProduct.ReadOnly = true;
      this.boxProduct.Location = new System.Drawing.Point(290, 107);
      this.boxProduct.Name = "boxProduct";
      this.boxProduct.Size = new System.Drawing.Size(200, 20);
      this.boxProduct.TabIndex = 5;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(500, 105);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(160, 25);
      this.btnCalculate.TabIndex = 6;
      this.btnCalculate.Text = "Вычислить";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // saveDialog
      // 
      this.saveDialog.DefaultExt = "dat";
      this.saveDialog.Filter = "Двоичные файлы (*.dat)|*.dat|Все файлы (*.*)|*.*";
      // 
      // body
      // 
      this.body.ColumnCount = 1;
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Controls.Add(this.groupCreate, 0, 0);
      this.body.Controls.Add(this.groupResult, 0, 1);
      this.body.Dock = System.Windows.Forms.DockStyle.Fill;
      this.body.Location = new System.Drawing.Point(0, 0);
      this.body.Name = "body";
      this.body.RowCount = 2;
      this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.body.Size = new System.Drawing.Size(760, 420);
      this.body.TabIndex = 0;
      // 
      // Task1Page
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.body);
      this.Name = "Task1Page";
      this.Size = new System.Drawing.Size(760, 420);
      this.groupCreate.ResumeLayout(false);
      this.groupCreate.PerformLayout();
      this.groupResult.ResumeLayout(false);
      this.groupResult.PerformLayout();
      this.body.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
