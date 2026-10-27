namespace Task4WinForms {
  partial class Task4Page {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.GroupBox groupInfo;
    private System.Windows.Forms.Label labelPath;
    private System.Windows.Forms.TextBox boxPath;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.Button btnInfo;
    private System.Windows.Forms.Label labelCreation;
    private System.Windows.Forms.TextBox boxCreation;
    private System.Windows.Forms.Label labelAccess;
    private System.Windows.Forms.TextBox boxAccess;
    private System.Windows.Forms.Label labelWrite;
    private System.Windows.Forms.TextBox boxWrite;
    private System.Windows.Forms.Label labelSave;
    private System.Windows.Forms.TextBox boxSave;
    private System.Windows.Forms.Button btnBrowseSave;
    private System.Windows.Forms.Button btnSave;
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
      this.groupInfo = new System.Windows.Forms.GroupBox();
      this.labelPath = new System.Windows.Forms.Label();
      this.boxPath = new System.Windows.Forms.TextBox();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.btnInfo = new System.Windows.Forms.Button();
      this.labelCreation = new System.Windows.Forms.Label();
      this.boxCreation = new System.Windows.Forms.TextBox();
      this.labelAccess = new System.Windows.Forms.Label();
      this.boxAccess = new System.Windows.Forms.TextBox();
      this.labelWrite = new System.Windows.Forms.Label();
      this.boxWrite = new System.Windows.Forms.TextBox();
      this.labelSave = new System.Windows.Forms.Label();
      this.boxSave = new System.Windows.Forms.TextBox();
      this.btnBrowseSave = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.openDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveDialog = new System.Windows.Forms.SaveFileDialog();
      this.body = new System.Windows.Forms.TableLayoutPanel();
      this.groupInfo.SuspendLayout();
      this.body.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupInfo
      // 
      this.groupInfo.Controls.Add(this.labelPath);
      this.groupInfo.Controls.Add(this.boxPath);
      this.groupInfo.Controls.Add(this.btnBrowse);
      this.groupInfo.Controls.Add(this.btnInfo);
      this.groupInfo.Controls.Add(this.labelCreation);
      this.groupInfo.Controls.Add(this.boxCreation);
      this.groupInfo.Controls.Add(this.labelAccess);
      this.groupInfo.Controls.Add(this.boxAccess);
      this.groupInfo.Controls.Add(this.labelWrite);
      this.groupInfo.Controls.Add(this.boxWrite);
      this.groupInfo.Controls.Add(this.labelSave);
      this.groupInfo.Controls.Add(this.boxSave);
      this.groupInfo.Controls.Add(this.btnBrowseSave);
      this.groupInfo.Controls.Add(this.btnSave);
      this.groupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupInfo.Location = new System.Drawing.Point(3, 3);
      this.groupInfo.Name = "groupInfo";
      this.groupInfo.Size = new System.Drawing.Size(754, 414);
      this.groupInfo.TabIndex = 0;
      this.groupInfo.TabStop = false;
      this.groupInfo.Text = "Информация о файле";
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
      this.boxPath.Location = new System.Drawing.Point(160, 32);
      this.boxPath.Name = "boxPath";
      this.boxPath.Size = new System.Drawing.Size(380, 20);
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
      // btnInfo
      // 
      this.btnInfo.Location = new System.Drawing.Point(550, 65);
      this.btnInfo.Name = "btnInfo";
      this.btnInfo.Size = new System.Drawing.Size(110, 25);
      this.btnInfo.TabIndex = 3;
      this.btnInfo.Text = "Получить";
      this.btnInfo.UseVisualStyleBackColor = true;
      this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
      // 
      // labelCreation
      // 
      this.labelCreation.AutoSize = true;
      this.labelCreation.Location = new System.Drawing.Point(20, 100);
      this.labelCreation.Name = "labelCreation";
      this.labelCreation.Size = new System.Drawing.Size(95, 13);
      this.labelCreation.TabIndex = 4;
      this.labelCreation.Text = "Время создания:";
      // 
      // boxCreation
      // 
      this.boxCreation.ReadOnly = true;
      this.boxCreation.Location = new System.Drawing.Point(160, 97);
      this.boxCreation.Name = "boxCreation";
      this.boxCreation.Size = new System.Drawing.Size(200, 20);
      this.boxCreation.TabIndex = 5;
      // 
      // labelAccess
      // 
      this.labelAccess.AutoSize = true;
      this.labelAccess.Location = new System.Drawing.Point(20, 130);
      this.labelAccess.Name = "labelAccess";
      this.labelAccess.Size = new System.Drawing.Size(135, 13);
      this.labelAccess.TabIndex = 6;
      this.labelAccess.Text = "Последний доступ:";
      // 
      // boxAccess
      // 
      this.boxAccess.ReadOnly = true;
      this.boxAccess.Location = new System.Drawing.Point(160, 127);
      this.boxAccess.Name = "boxAccess";
      this.boxAccess.Size = new System.Drawing.Size(200, 20);
      this.boxAccess.TabIndex = 7;
      // 
      // labelWrite
      // 
      this.labelWrite.AutoSize = true;
      this.labelWrite.Location = new System.Drawing.Point(20, 160);
      this.labelWrite.Name = "labelWrite";
      this.labelWrite.Size = new System.Drawing.Size(135, 13);
      this.labelWrite.TabIndex = 8;
      this.labelWrite.Text = "Последняя запись:";
      // 
      // boxWrite
      // 
      this.boxWrite.ReadOnly = true;
      this.boxWrite.Location = new System.Drawing.Point(160, 157);
      this.boxWrite.Name = "boxWrite";
      this.boxWrite.Size = new System.Drawing.Size(200, 20);
      this.boxWrite.TabIndex = 9;
      // 
      // labelSave
      // 
      this.labelSave.AutoSize = true;
      this.labelSave.Location = new System.Drawing.Point(20, 200);
      this.labelSave.Name = "labelSave";
      this.labelSave.Size = new System.Drawing.Size(130, 13);
      this.labelSave.TabIndex = 10;
      this.labelSave.Text = "Сохранить в файл:";
      // 
      // boxSave
      // 
      this.boxSave.Location = new System.Drawing.Point(160, 197);
      this.boxSave.Name = "boxSave";
      this.boxSave.Size = new System.Drawing.Size(380, 20);
      this.boxSave.TabIndex = 11;
      // 
      // btnBrowseSave
      // 
      this.btnBrowseSave.Location = new System.Drawing.Point(550, 195);
      this.btnBrowseSave.Name = "btnBrowseSave";
      this.btnBrowseSave.Size = new System.Drawing.Size(110, 25);
      this.btnBrowseSave.TabIndex = 12;
      this.btnBrowseSave.Text = "Обзор...";
      this.btnBrowseSave.UseVisualStyleBackColor = true;
      this.btnBrowseSave.Click += new System.EventHandler(this.btnBrowseSave_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(550, 230);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(110, 25);
      this.btnSave.TabIndex = 13;
      this.btnSave.Text = "Сохранить";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // openDialog
      // 
      this.openDialog.Filter = "Все файлы (*.*)|*.*";
      // 
      // saveDialog
      // 
      this.saveDialog.DefaultExt = "txt";
      this.saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
      // 
      // body
      // 
      this.body.ColumnCount = 1;
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Controls.Add(this.groupInfo, 0, 0);
      this.body.Dock = System.Windows.Forms.DockStyle.Fill;
      this.body.Location = new System.Drawing.Point(0, 0);
      this.body.Name = "body";
      this.body.RowCount = 1;
      this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Size = new System.Drawing.Size(760, 420);
      this.body.TabIndex = 0;
      // 
      // Task4Page
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.body);
      this.Name = "Task4Page";
      this.Size = new System.Drawing.Size(760, 420);
      this.groupInfo.ResumeLayout(false);
      this.groupInfo.PerformLayout();
      this.body.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
