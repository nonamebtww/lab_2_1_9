namespace Task3WinForms {
  partial class Task3Page {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.GroupBox groupCopy;
    private System.Windows.Forms.Label labelSource;
    private System.Windows.Forms.TextBox boxSource;
    private System.Windows.Forms.Button btnBrowseSource;
    private System.Windows.Forms.Label labelDest;
    private System.Windows.Forms.TextBox boxDest;
    private System.Windows.Forms.Button btnBrowseDest;
    private System.Windows.Forms.CheckBox checkOverwrite;
    private System.Windows.Forms.Button btnCopy;
    private System.Windows.Forms.Label labelResult;
    private System.Windows.Forms.TextBox boxResult;
    private System.Windows.Forms.OpenFileDialog openDialog;
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
      this.groupCopy = new System.Windows.Forms.GroupBox();
      this.labelSource = new System.Windows.Forms.Label();
      this.boxSource = new System.Windows.Forms.TextBox();
      this.btnBrowseSource = new System.Windows.Forms.Button();
      this.labelDest = new System.Windows.Forms.Label();
      this.boxDest = new System.Windows.Forms.TextBox();
      this.btnBrowseDest = new System.Windows.Forms.Button();
      this.checkOverwrite = new System.Windows.Forms.CheckBox();
      this.btnCopy = new System.Windows.Forms.Button();
      this.labelResult = new System.Windows.Forms.Label();
      this.boxResult = new System.Windows.Forms.TextBox();
      this.openDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveDialog = new System.Windows.Forms.SaveFileDialog();
      this.body = new System.Windows.Forms.TableLayoutPanel();
      this.groupCopy.SuspendLayout();
      this.body.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupCopy
      // 
      this.groupCopy.Controls.Add(this.labelSource);
      this.groupCopy.Controls.Add(this.boxSource);
      this.groupCopy.Controls.Add(this.btnBrowseSource);
      this.groupCopy.Controls.Add(this.labelDest);
      this.groupCopy.Controls.Add(this.boxDest);
      this.groupCopy.Controls.Add(this.btnBrowseDest);
      this.groupCopy.Controls.Add(this.checkOverwrite);
      this.groupCopy.Controls.Add(this.btnCopy);
      this.groupCopy.Controls.Add(this.labelResult);
      this.groupCopy.Controls.Add(this.boxResult);
      this.groupCopy.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupCopy.Location = new System.Drawing.Point(3, 3);
      this.groupCopy.Name = "groupCopy";
      this.groupCopy.Size = new System.Drawing.Size(754, 414);
      this.groupCopy.TabIndex = 0;
      this.groupCopy.TabStop = false;
      this.groupCopy.Text = "Копирование файла";
      // 
      // labelSource
      // 
      this.labelSource.AutoSize = true;
      this.labelSource.Location = new System.Drawing.Point(20, 35);
      this.labelSource.Name = "labelSource";
      this.labelSource.Size = new System.Drawing.Size(95, 13);
      this.labelSource.TabIndex = 0;
      this.labelSource.Text = "Исходный файл:";
      // 
      // boxSource
      // 
      this.boxSource.Location = new System.Drawing.Point(130, 32);
      this.boxSource.Name = "boxSource";
      this.boxSource.Size = new System.Drawing.Size(410, 20);
      this.boxSource.TabIndex = 1;
      // 
      // btnBrowseSource
      // 
      this.btnBrowseSource.Location = new System.Drawing.Point(550, 30);
      this.btnBrowseSource.Name = "btnBrowseSource";
      this.btnBrowseSource.Size = new System.Drawing.Size(110, 25);
      this.btnBrowseSource.TabIndex = 2;
      this.btnBrowseSource.Text = "Обзор...";
      this.btnBrowseSource.UseVisualStyleBackColor = true;
      this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
      // 
      // labelDest
      // 
      this.labelDest.AutoSize = true;
      this.labelDest.Location = new System.Drawing.Point(20, 70);
      this.labelDest.Name = "labelDest";
      this.labelDest.Size = new System.Drawing.Size(70, 13);
      this.labelDest.TabIndex = 3;
      this.labelDest.Text = "Копия:";
      // 
      // boxDest
      // 
      this.boxDest.Location = new System.Drawing.Point(130, 67);
      this.boxDest.Name = "boxDest";
      this.boxDest.Size = new System.Drawing.Size(410, 20);
      this.boxDest.TabIndex = 4;
      // 
      // btnBrowseDest
      // 
      this.btnBrowseDest.Location = new System.Drawing.Point(550, 65);
      this.btnBrowseDest.Name = "btnBrowseDest";
      this.btnBrowseDest.Size = new System.Drawing.Size(110, 25);
      this.btnBrowseDest.TabIndex = 5;
      this.btnBrowseDest.Text = "Обзор...";
      this.btnBrowseDest.UseVisualStyleBackColor = true;
      this.btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);
      // 
      // checkOverwrite
      // 
      this.checkOverwrite.AutoSize = true;
      this.checkOverwrite.Location = new System.Drawing.Point(130, 100);
      this.checkOverwrite.Name = "checkOverwrite";
      this.checkOverwrite.Size = new System.Drawing.Size(200, 17);
      this.checkOverwrite.TabIndex = 6;
      this.checkOverwrite.Text = "Перезаписать, если существует";
      this.checkOverwrite.UseVisualStyleBackColor = true;
      // 
      // btnCopy
      // 
      this.btnCopy.Location = new System.Drawing.Point(550, 100);
      this.btnCopy.Name = "btnCopy";
      this.btnCopy.Size = new System.Drawing.Size(110, 25);
      this.btnCopy.TabIndex = 7;
      this.btnCopy.Text = "Копировать";
      this.btnCopy.UseVisualStyleBackColor = true;
      this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
      // 
      // labelResult
      // 
      this.labelResult.AutoSize = true;
      this.labelResult.Location = new System.Drawing.Point(20, 140);
      this.labelResult.Name = "labelResult";
      this.labelResult.Size = new System.Drawing.Size(65, 13);
      this.labelResult.TabIndex = 8;
      this.labelResult.Text = "Результат:";
      // 
      // boxResult
      // 
      this.boxResult.Multiline = true;
      this.boxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.boxResult.ReadOnly = true;
      this.boxResult.Location = new System.Drawing.Point(130, 137);
      this.boxResult.Name = "boxResult";
      this.boxResult.Size = new System.Drawing.Size(530, 60);
      this.boxResult.TabIndex = 9;
      // 
      // openDialog
      // 
      this.openDialog.Filter = "Все файлы (*.*)|*.*";
      // 
      // saveDialog
      // 
      this.saveDialog.Filter = "Все файлы (*.*)|*.*";
      this.saveDialog.OverwritePrompt = false;
      // 
      // body
      // 
      this.body.ColumnCount = 1;
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Controls.Add(this.groupCopy, 0, 0);
      this.body.Dock = System.Windows.Forms.DockStyle.Fill;
      this.body.Location = new System.Drawing.Point(0, 0);
      this.body.Name = "body";
      this.body.RowCount = 1;
      this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Size = new System.Drawing.Size(760, 420);
      this.body.TabIndex = 0;
      // 
      // Task3Page
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.body);
      this.Name = "Task3Page";
      this.Size = new System.Drawing.Size(760, 420);
      this.groupCopy.ResumeLayout(false);
      this.groupCopy.PerformLayout();
      this.body.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
