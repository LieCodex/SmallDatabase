namespace SmallDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            emailTB = new TextBox();
            label6 = new Label();
            contact_numberTB = new TextBox();
            label5 = new Label();
            date_of_birthTB = new TextBox();
            label4 = new Label();
            genderTB = new TextBox();
            label3 = new Label();
            ageTB = new TextBox();
            label2 = new Label();
            LastNameTB = new TextBox();
            panel1 = new Panel();
            label8 = new Label();
            MiddleNameTB = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            FirstNameTB = new TextBox();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(37, 50);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(672, 25);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(715, 50);
            button1.Name = "button1";
            button1.Size = new Size(27, 25);
            button1.TabIndex = 1;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Verdana", 7F);
            label7.Location = new Point(26, 290);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 25;
            label7.Text = "Email: ";
            // 
            // emailTB
            // 
            emailTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailTB.BorderStyle = BorderStyle.FixedSingle;
            emailTB.Location = new Point(184, 283);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(238, 31);
            emailTB.TabIndex = 24;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Verdana", 7F);
            label6.Location = new Point(26, 253);
            label6.Name = "label6";
            label6.Size = new Size(134, 17);
            label6.TabIndex = 23;
            label6.Text = "Contact Number: ";
            // 
            // contact_numberTB
            // 
            contact_numberTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contact_numberTB.BorderStyle = BorderStyle.FixedSingle;
            contact_numberTB.Location = new Point(184, 246);
            contact_numberTB.Name = "contact_numberTB";
            contact_numberTB.Size = new Size(238, 31);
            contact_numberTB.TabIndex = 22;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Verdana", 7F);
            label5.Location = new Point(26, 216);
            label5.Name = "label5";
            label5.Size = new Size(112, 17);
            label5.TabIndex = 21;
            label5.Text = "Date Of Birth: ";
            // 
            // date_of_birthTB
            // 
            date_of_birthTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            date_of_birthTB.BorderStyle = BorderStyle.FixedSingle;
            date_of_birthTB.Location = new Point(184, 209);
            date_of_birthTB.Name = "date_of_birthTB";
            date_of_birthTB.Size = new Size(238, 31);
            date_of_birthTB.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Verdana", 7F);
            label4.Location = new Point(26, 179);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 19;
            label4.Text = "Gender: ";
            // 
            // genderTB
            // 
            genderTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            genderTB.BorderStyle = BorderStyle.FixedSingle;
            genderTB.Location = new Point(184, 172);
            genderTB.Name = "genderTB";
            genderTB.Size = new Size(238, 31);
            genderTB.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Verdana", 7F);
            label3.Location = new Point(26, 142);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 17;
            label3.Text = "Age: ";
            // 
            // ageTB
            // 
            ageTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ageTB.BorderStyle = BorderStyle.FixedSingle;
            ageTB.Location = new Point(184, 135);
            ageTB.Name = "ageTB";
            ageTB.Size = new Size(238, 31);
            ageTB.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Verdana", 7F);
            label2.Location = new Point(26, 68);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 15;
            label2.Text = "Last Name: ";
            // 
            // LastNameTB
            // 
            LastNameTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LastNameTB.BorderStyle = BorderStyle.FixedSingle;
            LastNameTB.Location = new Point(184, 61);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.Size = new Size(238, 31);
            LastNameTB.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(LastNameTB);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(MiddleNameTB);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(emailTB);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(FirstNameTB);
            panel1.Controls.Add(contact_numberTB);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(ageTB);
            panel1.Controls.Add(date_of_birthTB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(genderTB);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 337);
            panel1.TabIndex = 26;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Verdana", 7F);
            label8.Location = new Point(26, 105);
            label8.Name = "label8";
            label8.Size = new Size(106, 17);
            label8.TabIndex = 28;
            label8.Text = "Middle Name: ";
            // 
            // MiddleNameTB
            // 
            MiddleNameTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MiddleNameTB.BorderStyle = BorderStyle.FixedSingle;
            MiddleNameTB.Location = new Point(184, 98);
            MiddleNameTB.Name = "MiddleNameTB";
            MiddleNameTB.Size = new Size(238, 31);
            MiddleNameTB.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Verdana", 7F);
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(94, 17);
            label1.TabIndex = 28;
            label1.Text = "First Name: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(506, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FirstNameTB
            // 
            FirstNameTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FirstNameTB.BorderStyle = BorderStyle.FixedSingle;
            FirstNameTB.Location = new Point(184, 24);
            FirstNameTB.Name = "FirstNameTB";
            FirstNameTB.Size = new Size(238, 31);
            FirstNameTB.TabIndex = 27;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(545, 260);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 0;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Gold;
            button3.Font = new Font("Verdana", 5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(748, 48);
            button3.Name = "button3";
            button3.Size = new Size(40, 30);
            button3.TabIndex = 29;
            button3.Text = "All";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Student Info";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label7;
        private TextBox emailTB;
        private Label label6;
        private TextBox contact_numberTB;
        private Label label5;
        private TextBox date_of_birthTB;
        private Label label4;
        private TextBox genderTB;
        private Label label3;
        private TextBox ageTB;
        private Label label2;
        private TextBox LastNameTB;
        private Panel panel1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox FirstNameTB;
        private Label label8;
        private TextBox MiddleNameTB;
        private Button button3;
    }
}
