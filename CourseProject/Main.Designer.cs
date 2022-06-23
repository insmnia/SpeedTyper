namespace CourseProject
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оТестеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.языкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.английскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рекордыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.RandTextRB = new System.Windows.Forms.RadioButton();
            this.TextFFileRB = new System.Windows.Forms.RadioButton();
            this.textLengthLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.рекордыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(800, 24);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(800, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оТестеToolStripMenuItem});
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.тестToolStripMenuItem.Text = "Тест";
            // 
            // оТестеToolStripMenuItem
            // 
            this.оТестеToolStripMenuItem.Name = "оТестеToolStripMenuItem";
            this.оТестеToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.оТестеToolStripMenuItem.Text = "О тесте";
            this.оТестеToolStripMenuItem.Click += new System.EventHandler(this.оТестеToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темаToolStripMenuItem,
            this.языкToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // темаToolStripMenuItem
            // 
            this.темаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темнаяToolStripMenuItem,
            this.светлаяToolStripMenuItem});
            this.темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            this.темаToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.темаToolStripMenuItem.Text = "Тема";
            // 
            // темнаяToolStripMenuItem
            // 
            this.темнаяToolStripMenuItem.Name = "темнаяToolStripMenuItem";
            this.темнаяToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.темнаяToolStripMenuItem.Text = "Темная";
            this.темнаяToolStripMenuItem.Click += new System.EventHandler(this.темнаяToolStripMenuItem_Click);
            // 
            // светлаяToolStripMenuItem
            // 
            this.светлаяToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            this.светлаяToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.светлаяToolStripMenuItem.Text = "Светлая";
            this.светлаяToolStripMenuItem.Click += new System.EventHandler(this.светлаяToolStripMenuItem_Click);
            // 
            // языкToolStripMenuItem
            // 
            this.языкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.английскийToolStripMenuItem,
            this.русскийToolStripMenuItem});
            this.языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            this.языкToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.языкToolStripMenuItem.Text = "Язык";
            // 
            // английскийToolStripMenuItem
            // 
            this.английскийToolStripMenuItem.Name = "английскийToolStripMenuItem";
            this.английскийToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.английскийToolStripMenuItem.Text = "Английский";
            this.английскийToolStripMenuItem.Click += new System.EventHandler(this.английскийToolStripMenuItem_Click);
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // рекордыToolStripMenuItem
            // 
            this.рекордыToolStripMenuItem.Name = "рекордыToolStripMenuItem";
            this.рекордыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.рекордыToolStripMenuItem.Text = "История";
            this.рекордыToolStripMenuItem.Click += new System.EventHandler(this.историяToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.textLabel);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 217);
            this.panel1.TabIndex = 1;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(3, 10);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(188, 20);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Здесь будет ваш текст";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(713, 411);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 27);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // RandTextRB
            // 
            this.RandTextRB.AutoSize = true;
            this.RandTextRB.Checked = true;
            this.RandTextRB.Location = new System.Drawing.Point(463, 416);
            this.RandTextRB.Name = "RandTextRB";
            this.RandTextRB.Size = new System.Drawing.Size(111, 17);
            this.RandTextRB.TabIndex = 2;
            this.RandTextRB.TabStop = true;
            this.RandTextRB.Text = "Случайный текст";
            this.RandTextRB.UseVisualStyleBackColor = true;
            // 
            // TextFFileRB
            // 
            this.TextFFileRB.AutoSize = true;
            this.TextFFileRB.Location = new System.Drawing.Point(580, 416);
            this.TextFFileRB.Name = "TextFFileRB";
            this.TextFFileRB.Size = new System.Drawing.Size(127, 17);
            this.TextFFileRB.TabIndex = 3;
            this.TextFFileRB.TabStop = true;
            this.TextFFileRB.Text = "Загрузить из файла";
            this.TextFFileRB.UseVisualStyleBackColor = true;
            // 
            // textLengthLabel
            // 
            this.textLengthLabel.AutoSize = true;
            this.textLengthLabel.Location = new System.Drawing.Point(12, 425);
            this.textLengthLabel.Name = "textLengthLabel";
            this.textLengthLabel.Size = new System.Drawing.Size(0, 13);
            this.textLengthLabel.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(776, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(744, 247);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 16);
            this.timeLabel.TabIndex = 6;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 247);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 24);
            this.errorLabel.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textLengthLabel);
            this.Controls.Add(this.TextFFileRB);
            this.Controls.Add(this.RandTextRB);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 485);
            this.MinimumSize = new System.Drawing.Size(816, 485);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpeedType";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светлаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рекордыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem языкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem английскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RadioButton RandTextRB;
        private System.Windows.Forms.RadioButton TextFFileRB;
        private System.Windows.Forms.Label textLengthLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem оТестеToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

