namespace SmallDatabase
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            studentImage = new PictureBox();
            student_name = new TextBox();
            panel1 = new Panel();
            MiddleNameTB = new TextBox();
            LastNameTB = new TextBox();
            deleteBTN = new Button();
            saveBTN = new Button();
            editBTN = new Button();
            emailTB = new TextBox();
            ContactNumberTB = new TextBox();
            DateOfBirthTB = new TextBox();
            GenderTB = new TextBox();
            AgeTB = new TextBox();
            FirstNameTB = new TextBox();
            IDTB = new TextBox();
            middle_name_label = new Label();
            last_name_label = new Label();
            EmailLabel = new Label();
            ContactNumberLabel = new Label();
            dateOfBirthLabel = new Label();
            genderLabel = new Label();
            ageLabel = new Label();
            First_name_label = new Label();
            IDlabel = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // studentImage
            // 
            studentImage.BorderStyle = BorderStyle.Fixed3D;
            studentImage.Image = (Image)resources.GetObject("studentImage.Image");
            studentImage.Location = new Point(38, 82);
            studentImage.Name = "studentImage";
            studentImage.Size = new Size(195, 195);
            studentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            studentImage.TabIndex = 0;
            studentImage.TabStop = false;
            // 
            // student_name
            // 
            student_name.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_name.Location = new Point(59, 314);
            student_name.Name = "student_name";
            student_name.ReadOnly = true;
            student_name.Size = new Size(150, 29);
            student_name.TabIndex = 1;
            student_name.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(MiddleNameTB);
            panel1.Controls.Add(LastNameTB);
            panel1.Controls.Add(deleteBTN);
            panel1.Controls.Add(saveBTN);
            panel1.Controls.Add(editBTN);
            panel1.Controls.Add(emailTB);
            panel1.Controls.Add(ContactNumberTB);
            panel1.Controls.Add(DateOfBirthTB);
            panel1.Controls.Add(GenderTB);
            panel1.Controls.Add(AgeTB);
            panel1.Controls.Add(FirstNameTB);
            panel1.Controls.Add(IDTB);
            panel1.Controls.Add(middle_name_label);
            panel1.Controls.Add(last_name_label);
            panel1.Controls.Add(EmailLabel);
            panel1.Controls.Add(ContactNumberLabel);
            panel1.Controls.Add(dateOfBirthLabel);
            panel1.Controls.Add(genderLabel);
            panel1.Controls.Add(ageLabel);
            panel1.Controls.Add(First_name_label);
            panel1.Controls.Add(IDlabel);
            panel1.Location = new Point(272, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 426);
            panel1.TabIndex = 2;
            // 
            // MiddleNameTB
            // 
            MiddleNameTB.BorderStyle = BorderStyle.FixedSingle;
            MiddleNameTB.Location = new Point(141, 129);
            MiddleNameTB.Name = "MiddleNameTB";
            MiddleNameTB.ReadOnly = true;
            MiddleNameTB.Size = new Size(333, 31);
            MiddleNameTB.TabIndex = 19;
            // 
            // LastNameTB
            // 
            LastNameTB.BorderStyle = BorderStyle.FixedSingle;
            LastNameTB.Location = new Point(141, 92);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.ReadOnly = true;
            LastNameTB.Size = new Size(333, 31);
            LastNameTB.TabIndex = 17;
            // 
            // deleteBTN
            // 
            deleteBTN.BackColor = Color.Gold;
            deleteBTN.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBTN.Location = new Point(366, 376);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(112, 34);
            deleteBTN.TabIndex = 16;
            deleteBTN.Text = "DELETE";
            deleteBTN.UseVisualStyleBackColor = false;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // saveBTN
            // 
            saveBTN.BackColor = Color.Gold;
            saveBTN.Enabled = false;
            saveBTN.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBTN.Location = new Point(204, 376);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new Size(112, 34);
            saveBTN.TabIndex = 15;
            saveBTN.Text = "SAVE";
            saveBTN.UseVisualStyleBackColor = false;
            saveBTN.Click += saveBTN_Click;
            // 
            // editBTN
            // 
            editBTN.BackColor = Color.Gold;
            editBTN.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editBTN.Location = new Point(35, 376);
            editBTN.Name = "editBTN";
            editBTN.Size = new Size(112, 34);
            editBTN.TabIndex = 14;
            editBTN.Text = "EDIT";
            editBTN.UseVisualStyleBackColor = false;
            editBTN.Click += editBTN_Click;
            // 
            // emailTB
            // 
            emailTB.BorderStyle = BorderStyle.FixedSingle;
            emailTB.Location = new Point(141, 314);
            emailTB.Name = "emailTB";
            emailTB.ReadOnly = true;
            emailTB.Size = new Size(333, 31);
            emailTB.TabIndex = 12;
            // 
            // ContactNumberTB
            // 
            ContactNumberTB.BorderStyle = BorderStyle.FixedSingle;
            ContactNumberTB.Location = new Point(141, 277);
            ContactNumberTB.Name = "ContactNumberTB";
            ContactNumberTB.ReadOnly = true;
            ContactNumberTB.Size = new Size(333, 31);
            ContactNumberTB.TabIndex = 10;
            // 
            // DateOfBirthTB
            // 
            DateOfBirthTB.BorderStyle = BorderStyle.FixedSingle;
            DateOfBirthTB.Location = new Point(141, 240);
            DateOfBirthTB.Name = "DateOfBirthTB";
            DateOfBirthTB.ReadOnly = true;
            DateOfBirthTB.Size = new Size(333, 31);
            DateOfBirthTB.TabIndex = 8;
            // 
            // GenderTB
            // 
            GenderTB.BorderStyle = BorderStyle.FixedSingle;
            GenderTB.Location = new Point(141, 203);
            GenderTB.Name = "GenderTB";
            GenderTB.ReadOnly = true;
            GenderTB.Size = new Size(333, 31);
            GenderTB.TabIndex = 6;
            // 
            // AgeTB
            // 
            AgeTB.BorderStyle = BorderStyle.FixedSingle;
            AgeTB.Location = new Point(141, 166);
            AgeTB.Name = "AgeTB";
            AgeTB.ReadOnly = true;
            AgeTB.Size = new Size(333, 31);
            AgeTB.TabIndex = 4;
            // 
            // FirstNameTB
            // 
            FirstNameTB.BorderStyle = BorderStyle.FixedSingle;
            FirstNameTB.Location = new Point(141, 55);
            FirstNameTB.Name = "FirstNameTB";
            FirstNameTB.ReadOnly = true;
            FirstNameTB.Size = new Size(333, 31);
            FirstNameTB.TabIndex = 2;
            // 
            // IDTB
            // 
            IDTB.BorderStyle = BorderStyle.FixedSingle;
            IDTB.Location = new Point(141, 18);
            IDTB.Name = "IDTB";
            IDTB.ReadOnly = true;
            IDTB.Size = new Size(333, 31);
            IDTB.TabIndex = 0;
            // 
            // middle_name_label
            // 
            middle_name_label.AutoSize = true;
            middle_name_label.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            middle_name_label.Location = new Point(9, 136);
            middle_name_label.Name = "middle_name_label";
            middle_name_label.Size = new Size(106, 17);
            middle_name_label.TabIndex = 20;
            middle_name_label.Text = "Middle Name: ";
            // 
            // last_name_label
            // 
            last_name_label.AutoSize = true;
            last_name_label.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            last_name_label.Location = new Point(9, 99);
            last_name_label.Name = "last_name_label";
            last_name_label.Size = new Size(93, 17);
            last_name_label.TabIndex = 18;
            last_name_label.Text = "Last Name: ";
            last_name_label.Click += label1_Click;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(9, 321);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(55, 17);
            EmailLabel.TabIndex = 13;
            EmailLabel.Text = "Email: ";
            // 
            // ContactNumberLabel
            // 
            ContactNumberLabel.AutoSize = true;
            ContactNumberLabel.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactNumberLabel.Location = new Point(9, 284);
            ContactNumberLabel.Name = "ContactNumberLabel";
            ContactNumberLabel.Size = new Size(134, 17);
            ContactNumberLabel.TabIndex = 11;
            ContactNumberLabel.Text = "Contact Number: ";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateOfBirthLabel.Location = new Point(9, 247);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(112, 17);
            dateOfBirthLabel.TabIndex = 9;
            dateOfBirthLabel.Text = "Date Of Birth: ";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderLabel.Location = new Point(9, 210);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(70, 17);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender: ";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageLabel.Location = new Point(9, 173);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(46, 17);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Age: ";
            // 
            // First_name_label
            // 
            First_name_label.AutoSize = true;
            First_name_label.Font = new Font("Verdana", 7F);
            First_name_label.Location = new Point(9, 62);
            First_name_label.Name = "First_name_label";
            First_name_label.Size = new Size(94, 17);
            First_name_label.TabIndex = 3;
            First_name_label.Text = "First Name: ";
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Font = new Font("Verdana", 7F);
            IDlabel.Location = new Point(9, 25);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(35, 17);
            IDlabel.TabIndex = 1;
            IDlabel.Text = "ID: ";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Gold;
            label8.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 46);
            label8.Margin = new Padding(5, 0, 3, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(5, 0, 0, 0);
            label8.Size = new Size(195, 25);
            label8.TabIndex = 17;
            label8.Text = "STUDENT INFO ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(student_name);
            Controls.Add(studentImage);
            Name = "Form2";
            Text = "Student Info";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)studentImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox studentImage;
        private TextBox student_name;
        private Panel panel1;
        private TextBox IDTB;
        private Label IDlabel;
        private Label EmailLabel;
        private TextBox emailTB;
        private Label ContactNumberLabel;
        private TextBox ContactNumberTB;
        private Label dateOfBirthLabel;
        private TextBox DateOfBirthTB;
        private Label genderLabel;
        private TextBox GenderTB;
        private Label ageLabel;
        private TextBox AgeTB;
        private Label First_name_label;
        private TextBox FirstNameTB;
        private Button deleteBTN;
        private Button saveBTN;
        private Button editBTN;
        private Label label8;
        private Label middle_name_label;
        private TextBox MiddleNameTB;
        private Label last_name_label;
        private TextBox LastNameTB;
    }
}