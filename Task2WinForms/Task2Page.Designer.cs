namespace Task2WinForms {
  partial class Task2Page {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.GroupBox groupInsert;
    private System.Windows.Forms.Label labelPath;
    private System.Windows.Forms.TextBox boxPath;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.Button btnRead;
    private System.Windows.Forms.Label labelBefore;
    private System.Windows.Forms.TextBox boxBefore;
    private System.Windows.Forms.Label labelNumber;
    private System.Windows.Forms.TextBox boxNumber;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Label labelPosition;
    private System.Windows.Forms.TextBox boxPosition;
    private System.Windows.Forms.Label labelAfter;
    private System.Windows.Forms.TextBox boxAfter;
    private System.Windows.Forms.OpenFileDialog openDialog;

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
      this.groupInsert = new System.Windows.Forms.GroupBox();
      this.labelPath = new System.Windows.Forms.Label();
      this.boxPath = new System.Windows.Forms.TextBox();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.btnRead = new System.Windows.Forms.Button();
      this.labelBefore = new System.Windows.Forms.Label();
      this.boxBefore = new System.Windows.Forms.TextBox();
      this.labelNumber = new System.Windows.Forms.Label();
      this.boxNumber = new System.Windows.Forms.TextBox();
      this.btnInsert = new System.Windows.Forms.Button();
      this.labelPosition = new System.Windows.Forms.Label();
      this.boxPosition = new System.Windows.Forms.TextBox();
      this.labelAfter = new System.Windows.Forms.Label();
      this.boxAfter = new System.Windows.Forms.TextBox();
      this.openDialog = new System.Windows.Forms.OpenFileDialog();
      this.body = new System.Windows.Forms.TableLayoutPanel();
      this.groupInsert.SuspendLayout();
      this.body.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupInsert
      // 
      this.groupInsert.Controls.Add(this.labelPath);
      this.groupInsert.Controls.Add(this.boxPath);
      this.groupInsert.Controls.Add(this.btnBrowse);
      this.groupInsert.Controls.Add(this.btnRead);
      this.groupInsert.Controls.Add(this.labelBefore);
      this.groupInsert.Controls.Add(this.boxBefore);
      this.groupInsert.Controls.Add(this.labelNumber);
      this.groupInsert.Controls.Add(this.boxNumber);
      this.groupInsert.Controls.Add(this.btnInsert);
      this.groupInsert.Controls.Add(this.labelPosition);
      this.groupInsert.Controls.Add(this.boxPosition);
      this.groupInsert.Controls.Add(this.labelAfter);
      this.groupInsert.Controls.Add(this.boxAfter);
      this.groupInsert.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupInsert.Location = new System.Drawing.Point(3, 3);
      this.groupInsert.Name = "groupInsert";
      this.groupInsert.Size = new System.Drawing.Size(754, 414);
      this.groupInsert.TabIndex = 0;
      this.groupInsert.TabStop = false;
      this.groupInsert.Text = "Вставка числа в случайную позицию двоичного файла";
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
      this.boxPath.Location = new System.Drawing.Point(130, 32);
      this.boxPath.Name = "boxPath";
      this.boxPath.Size = new System.Drawing.Size(410, 20);
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
      // btnRead
      // 
      this.btnRead.Location = new System.Drawing.Point(550, 65);
      this.btnRead.Name = "btnRead";
      this.btnRead.Size = new System.Drawing.Size(110, 25);
      this.btnRead.TabIndex = 3;
      this.btnRead.Text = "Прочитать";
      this.btnRead.UseVisualStyleBackColor = true;
      this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
      // 
      // labelBefore
      // 
      this.labelBefore.AutoSize = true;
      this.labelBefore.Location = new System.Drawing.Point(20, 100);
      this.labelBefore.Name = "labelBefore";
      this.labelBefore.Size = new System.Drawing.Size(70, 13);
      this.labelBefore.TabIndex = 4;
      this.labelBefore.Text = "До вставки:";
      // 
      // boxBefore
      // 
      this.boxBefore.Multiline = true;
      this.boxBefore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.boxBefore.ReadOnly = true;
      this.boxBefore.Location = new System.Drawing.Point(130, 97);
      this.boxBefore.Name = "boxBefore";
      this.boxBefore.Size = new System.Drawing.Size(530, 60);
      this.boxBefore.TabIndex = 5;
      // 
      // labelNumber
      // 
      this.labelNumber.AutoSize = true;
      this.labelNumber.Location = new System.Drawing.Point(20, 180);
      this.labelNumber.Name = "labelNumber";
      this.labelNumber.Size = new System.Drawing.Size(40, 13);
      this.labelNumber.TabIndex = 6;
      this.labelNumber.Text = "Число:";
      // 
      // boxNumber
      // 
      this.boxNumber.Location = new System.Drawing.Point(130, 177);
      this.boxNumber.Name = "boxNumber";
      this.boxNumber.Size = new System.Drawing.Size(100, 20);
      this.boxNumber.TabIndex = 7;
      // 
      // btnInsert
      // 
      this.btnInsert.Location = new System.Drawing.Point(550, 175);
      this.btnInsert.Name = "btnInsert";
      this.btnInsert.Size = new System.Drawing.Size(110, 25);
      this.btnInsert.TabIndex = 8;
      this.btnInsert.Text = "Вставить";
      this.btnInsert.UseVisualStyleBackColor = true;
      this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
      // 
      // labelPosition
      // 
      this.labelPosition.AutoSize = true;
      this.labelPosition.Location = new System.Drawing.Point(20, 215);
      this.labelPosition.Name = "labelPosition";
      this.labelPosition.Size = new System.Drawing.Size(55, 13);
      this.labelPosition.TabIndex = 9;
      this.labelPosition.Text = "Позиция:";
      // 
      // boxPosition
      // 
      this.boxPosition.ReadOnly = true;
      this.boxPosition.Location = new System.Drawing.Point(130, 212);
      this.boxPosition.Name = "boxPosition";
      this.boxPosition.Size = new System.Drawing.Size(200, 20);
      this.boxPosition.TabIndex = 10;
      // 
      // labelAfter
      // 
      this.labelAfter.AutoSize = true;
      this.labelAfter.Location = new System.Drawing.Point(20, 250);
      this.labelAfter.Name = "labelAfter";
      this.labelAfter.Size = new System.Drawing.Size(90, 13);
      this.labelAfter.TabIndex = 11;
      this.labelAfter.Text = "После вставки:";
      // 
      // boxAfter
      // 
      this.boxAfter.Multiline = true;
      this.boxAfter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.boxAfter.ReadOnly = true;
      this.boxAfter.Location = new System.Drawing.Point(130, 247);
      this.boxAfter.Name = "boxAfter";
      this.boxAfter.Size = new System.Drawing.Size(530, 60);
      this.boxAfter.TabIndex = 12;
      // 
      // openDialog
      // 
      this.openDialog.Filter = "Двоичные файлы (*.dat)|*.dat|Все файлы (*.*)|*.*";
      // 
      // body
      // 
      this.body.ColumnCount = 1;
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Controls.Add(this.groupInsert, 0, 0);
      this.body.Dock = System.Windows.Forms.DockStyle.Fill;
      this.body.Location = new System.Drawing.Point(0, 0);
      this.body.Name = "body";
      this.body.RowCount = 1;
      this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Size = new System.Drawing.Size(760, 420);
      this.body.TabIndex = 0;
      // 
      // Task2Page
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.body);
      this.Name = "Task2Page";
      this.Size = new System.Drawing.Size(760, 420);
      this.groupInsert.ResumeLayout(false);
      this.groupInsert.PerformLayout();
      this.body.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
