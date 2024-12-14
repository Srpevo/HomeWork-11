using HomeWork_11.Core.Classes.Student;
using HomeWork_11.Core.Classes.Ui_Tools;
using HomeWork_11.Core.Classes.University;
using HomeWork_11.Core.Enums.Adjust_Visibility_Options;
using HomeWork_11.Core.Enums.ObjectType;
using HomeWork_11.Utils.Validators.StudentValidator;
using HomeWork_11.Utils.Validators.UniversityValidator;

namespace HomeWork_11
{
    partial class MainWND
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Student> _students = new List<Student>();
        private List<University> _universities = new List<University>();
        private ObjectType _currentObjType = ObjectType.None;

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

        private void SettingInputFields()
        {
            switch (_currentObjType)
            {
                case ObjectType.Student:
                    UiTools.SetFieldsVisibility(Visibility.Visible, new string[] { "surname" }, new Control[] { label_2 }, textBox_3, textBox_4, label_3, label_4);
                    break;
                case ObjectType.University:
                    UiTools.SetFieldsVisibility(Visibility.Invisible, new string[] { "description" }, new Control[] { label_2 }, textBox_3, textBox_4, label_3, label_4);
                    break;
            }
        }

        private void CreateObject()
        {
            switch (_currentObjType)
            {
                case ObjectType.Student:

                    if (StudentValidator.CheckStudentParams(textBox_0.Text, textBox_1.Text, textBox_2.Text, textBox_3.Text, textBox_4.Text, _universities))
                    {
                        Student student = new(Int32.Parse(textBox_0.Text), textBox_1.Text, textBox_2.Text, textBox_3.Text, textBox_4.Text);
                        _students.Add(student);
                        UiTools.AddToList(objectBox, student);
                    }
                    else
                        MessageBox.Show("fill in the fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case ObjectType.University:

                    if (UniversityValidator.CheckUniversityParams(textBox_0.Text, textBox_1.Text, textBox_2.Text))
                    {
                        University university = new(Int32.Parse(textBox_0.Text), textBox_1.Text, textBox_2.Text);
                        _universities.Add(university);
                        UiTools.AddToList(objectBox, university);
                    }
                    else
                        MessageBox.Show("fill in the fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private bool CheckTheCorrectness()
        {
            bool result = true;
            switch (_currentObjType)
            {
                case ObjectType.Student:
                    result = UiTools.CheckFields("Fields are empty!", MessageBoxIcon.Error, textBox_0, textBox_1, textBox_2, textBox_3, textBox_4);
                    break;
                case ObjectType.University:
                    result = UiTools.CheckFields("Fields are empty!", MessageBoxIcon.Error, textBox_0, textBox_1, textBox_2);
                    break;
            }
            return result;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            objectBox = new ListBox();
            createBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label_4 = new Label();
            textBox_4 = new TextBox();
            label_3 = new Label();
            textBox_3 = new TextBox();
            label_2 = new Label();
            textBox_2 = new TextBox();
            label_1 = new Label();
            textBox_1 = new TextBox();
            label_0 = new Label();
            textBox_0 = new TextBox();
            objectTypeCombo = new ComboBox();
            tabPage2 = new TabPage();
            label9 = new Label();
            searchBtn = new Button();
            searchBox = new TextBox();
            rLabel = new Label();
            serachResult = new ListBox();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1318, 570);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(objectBox);
            tabPage1.Controls.Add(createBtn);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(objectTypeCombo);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1302, 516);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create Objects";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(866, 6);
            label3.Name = "label3";
            label3.Size = new Size(94, 32);
            label3.TabIndex = 6;
            label3.Text = "Objects";
            // 
            // objectBox
            // 
            objectBox.FormattingEnabled = true;
            objectBox.Location = new Point(866, 41);
            objectBox.Name = "objectBox";
            objectBox.Size = new Size(410, 452);
            objectBox.TabIndex = 5;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(16, 456);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(242, 40);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 6);
            label2.Name = "label2";
            label2.Size = new Size(211, 32);
            label2.TabIndex = 3;
            label2.Text = "Filling in the fields";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 6);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 2;
            label1.Text = "Object Type";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label_4);
            panel1.Controls.Add(textBox_4);
            panel1.Controls.Add(label_3);
            panel1.Controls.Add(textBox_3);
            panel1.Controls.Add(label_2);
            panel1.Controls.Add(textBox_2);
            panel1.Controls.Add(label_1);
            panel1.Controls.Add(textBox_1);
            panel1.Controls.Add(label_0);
            panel1.Controls.Add(textBox_0);
            panel1.Location = new Point(277, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 455);
            panel1.TabIndex = 1;
            // 
            // label_4
            // 
            label_4.AutoSize = true;
            label_4.Location = new Point(22, 310);
            label_4.Name = "label_4";
            label_4.Size = new Size(184, 32);
            label_4.TabIndex = 16;
            label_4.Text = "university name";
            // 
            // textBox_4
            // 
            textBox_4.BorderStyle = BorderStyle.FixedSingle;
            textBox_4.Location = new Point(22, 345);
            textBox_4.Name = "textBox_4";
            textBox_4.Size = new Size(248, 39);
            textBox_4.TabIndex = 15;
            // 
            // label_3
            // 
            label_3.AutoSize = true;
            label_3.Location = new Point(22, 234);
            label_3.Name = "label_3";
            label_3.Size = new Size(72, 32);
            label_3.TabIndex = 14;
            label_3.Text = "email";
            // 
            // textBox_3
            // 
            textBox_3.BorderStyle = BorderStyle.FixedSingle;
            textBox_3.Location = new Point(22, 269);
            textBox_3.Name = "textBox_3";
            textBox_3.Size = new Size(248, 39);
            textBox_3.TabIndex = 13;
            // 
            // label_2
            // 
            label_2.AutoSize = true;
            label_2.Location = new Point(22, 159);
            label_2.Name = "label_2";
            label_2.Size = new Size(106, 32);
            label_2.TabIndex = 12;
            label_2.Text = "surname";
            // 
            // textBox_2
            // 
            textBox_2.BorderStyle = BorderStyle.FixedSingle;
            textBox_2.Location = new Point(22, 194);
            textBox_2.Name = "textBox_2";
            textBox_2.Size = new Size(248, 39);
            textBox_2.TabIndex = 11;
            // 
            // label_1
            // 
            label_1.AutoSize = true;
            label_1.Location = new Point(22, 83);
            label_1.Name = "label_1";
            label_1.Size = new Size(74, 32);
            label_1.TabIndex = 10;
            label_1.Text = "name";
            // 
            // textBox_1
            // 
            textBox_1.BorderStyle = BorderStyle.FixedSingle;
            textBox_1.Location = new Point(22, 118);
            textBox_1.Name = "textBox_1";
            textBox_1.Size = new Size(248, 39);
            textBox_1.TabIndex = 9;
            // 
            // label_0
            // 
            label_0.AutoSize = true;
            label_0.Location = new Point(22, 8);
            label_0.Name = "label_0";
            label_0.Size = new Size(34, 32);
            label_0.TabIndex = 8;
            label_0.Text = "id";
            // 
            // textBox_0
            // 
            textBox_0.BorderStyle = BorderStyle.FixedSingle;
            textBox_0.Location = new Point(22, 43);
            textBox_0.Name = "textBox_0";
            textBox_0.Size = new Size(248, 39);
            textBox_0.TabIndex = 7;
            // 
            // objectTypeCombo
            // 
            objectTypeCombo.FormattingEnabled = true;
            objectTypeCombo.Items.AddRange(new object[] { "University", "Student" });
            objectTypeCombo.Location = new Point(16, 41);
            objectTypeCombo.Name = "objectTypeCombo";
            objectTypeCombo.Size = new Size(242, 40);
            objectTypeCombo.TabIndex = 0;
            objectTypeCombo.SelectedIndexChanged += objectTypeCombo_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(searchBtn);
            tabPage2.Controls.Add(searchBox);
            tabPage2.Controls.Add(rLabel);
            tabPage2.Controls.Add(serachResult);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1302, 516);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Search";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 6);
            label9.Name = "label9";
            label9.Size = new Size(168, 32);
            label9.TabIndex = 6;
            label9.Text = "Student Name";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(16, 456);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(242, 40);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Location = new Point(18, 41);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(235, 39);
            searchBox.TabIndex = 2;
            // 
            // rLabel
            // 
            rLabel.AutoSize = true;
            rLabel.Location = new Point(277, 6);
            rLabel.Name = "rLabel";
            rLabel.Size = new Size(78, 32);
            rLabel.TabIndex = 1;
            rLabel.Text = "Result";
            // 
            // serachResult
            // 
            serachResult.FormattingEnabled = true;
            serachResult.Location = new Point(277, 41);
            serachResult.Name = "serachResult";
            serachResult.Size = new Size(992, 452);
            serachResult.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 414);
            label4.Name = "label4";
            label4.Size = new Size(469, 25);
            label4.TabIndex = 17;
            label4.Text = "to create a student you first need to create a university";
            // 
            // MainWND
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1315, 571);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWND";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private ComboBox objectTypeCombo;
        private Label label2;
        private Label label1;
        private Button createBtn;
        private ListBox objectBox;
        private Label label3;
        private Label label_0;
        private TextBox textBox_0;
        private Label label_2;
        private TextBox textBox_2;
        private Label label_1;
        private TextBox textBox_1;
        private Label label_4;
        private TextBox textBox_4;
        private Label label_3;
        private TextBox textBox_3;
        private ListBox serachResult;
        private TextBox searchBox;
        private Label rLabel;
        private Label label9;
        private Button searchBtn;
        private Label label4;
    }
}
