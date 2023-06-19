namespace TuringMachine
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lenta = new System.Windows.Forms.DataGridView();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.numbers = new System.Windows.Forms.DataGridView();
            this.command = new System.Windows.Forms.DataGridView();
            this.alfavit = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.restart = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.lenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.command)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfavit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lenta
            // 
            this.lenta.AllowUserToAddRows = false;
            this.lenta.AllowUserToDeleteRows = false;
            this.lenta.AllowUserToResizeColumns = false;
            this.lenta.AllowUserToResizeRows = false;
            this.lenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lenta.ColumnHeadersHeight = 25;
            this.lenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lenta.ColumnHeadersVisible = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lenta.DefaultCellStyle = dataGridViewCellStyle28;
            this.lenta.Location = new System.Drawing.Point(30, 37);
            this.lenta.Name = "lenta";
            this.lenta.ReadOnly = true;
            this.lenta.RowHeadersVisible = false;
            this.lenta.RowHeadersWidth = 25;
            this.lenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lenta.Size = new System.Drawing.Size(570, 25);
            this.lenta.TabIndex = 23;
            this.lenta.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right.Location = new System.Drawing.Point(606, 37);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(19, 25);
            this.right.TabIndex = 25;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left.Location = new System.Drawing.Point(5, 37);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(19, 25);
            this.left.TabIndex = 28;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // numbers
            // 
            this.numbers.AllowUserToAddRows = false;
            this.numbers.AllowUserToDeleteRows = false;
            this.numbers.AllowUserToResizeColumns = false;
            this.numbers.AllowUserToResizeRows = false;
            this.numbers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.numbers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.numbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.numbers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.numbers.ColumnHeadersHeight = 25;
            this.numbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.numbers.ColumnHeadersVisible = false;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.numbers.DefaultCellStyle = dataGridViewCellStyle30;
            this.numbers.GridColor = System.Drawing.SystemColors.Control;
            this.numbers.Location = new System.Drawing.Point(30, 13);
            this.numbers.Name = "numbers";
            this.numbers.ReadOnly = true;
            this.numbers.RowHeadersVisible = false;
            this.numbers.RowHeadersWidth = 25;
            this.numbers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.numbers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numbers.Size = new System.Drawing.Size(570, 25);
            this.numbers.TabIndex = 30;
            // 
            // command
            // 
            this.command.AllowUserToAddRows = false;
            this.command.AllowUserToResizeColumns = false;
            this.command.AllowUserToResizeRows = false;
            this.command.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.command.Location = new System.Drawing.Point(5, 127);
            this.command.Name = "command";
            this.command.ReadOnly = true;
            this.command.Size = new System.Drawing.Size(403, 319);
            this.command.TabIndex = 33;
            this.command.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.command_CellMouseClick);
            // 
            // alfavit
            // 
            this.alfavit.AllowUserToResizeColumns = false;
            this.alfavit.AllowUserToResizeRows = false;
            this.alfavit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.alfavit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alfavit.Location = new System.Drawing.Point(414, 127);
            this.alfavit.Name = "alfavit";
            this.alfavit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.alfavit.Size = new System.Drawing.Size(201, 319);
            this.alfavit.TabIndex = 34;
            this.alfavit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alfavit_CellClick);
            this.alfavit.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.alfavit_CellEndEdit);
            this.alfavit.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.alfavit_UserDeletedRow);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb3);
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Location = new System.Drawing.Point(5, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 53);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Конструктор команд";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(14, 19);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(79, 21);
            this.cb1.TabIndex = 42;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.restart);
            this.groupBox2.Controls.Add(this.play);
            this.groupBox2.Location = new System.Drawing.Point(414, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 53);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кнопки управления";
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(34, 19);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(22, 23);
            this.restart.TabIndex = 42;
            this.restart.Text = "■";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(6, 19);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(22, 23);
            this.play.TabIndex = 41;
            this.play.Text = "▶";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(99, 19);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(79, 21);
            this.cb2.TabIndex = 43;
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(184, 18);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(79, 21);
            this.cb3.TabIndex = 44;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(43, 19);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(25, 23);
            this.minus.TabIndex = 48;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(12, 19);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(25, 23);
            this.plus.TabIndex = 47;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.minus);
            this.groupBox3.Controls.Add(this.plus);
            this.groupBox3.Location = new System.Drawing.Point(288, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 53);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Состояния";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.alfavit);
            this.Controls.Add(this.command);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.lenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Машина Тьюринга";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.command)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfavit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView lenta;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.DataGridView numbers;
        private System.Windows.Forms.DataGridView command;
        private System.Windows.Forms.DataGridView alfavit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

