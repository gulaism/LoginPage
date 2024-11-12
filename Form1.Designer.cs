namespace LoginPage
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            login = new Label();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Gray;
            groupBox1.Location = new Point(250, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 54);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Username";
            groupBox1.Leave += groupBox1_Leave;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(6, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 22);
            textBox1.TabIndex = 0;
            textBox1.Enter += textBox1_Enter;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = SystemColors.ActiveBorder;
            login.Location = new Point(360, 100);
            login.Name = "login";
            login.Size = new Size(139, 39);
            login.TabIndex = 2;
            login.Text = "LOGIN";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Gray;
            groupBox2.Location = new Point(250, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 54);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Password";
            groupBox2.Enter += groupBox2_Enter_1;
            groupBox2.Leave += groupBox2_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.WindowText;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(6, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(348, 22);
            textBox2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Snap ITC", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(250, 336);
            button1.Name = "button1";
            button1.Size = new Size(360, 39);
            button1.TabIndex = 1;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseHover += button1_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(842, 494);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(login);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label login;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Button button1;
    }
}
