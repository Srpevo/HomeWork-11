using HomeWork_11.Core.Classes.Search_Engine;
using HomeWork_11.Core.Classes.Student;
using HomeWork_11.Core.Classes.Ui_Tools;
using HomeWork_11.Core.Enums.ObjectType;

namespace HomeWork_11
{
    public partial class MainWND : Form
    {
        public MainWND()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (string.IsNullOrEmpty(searchBox.Text)) return;
                SearchEngine.FindObject(ref serachResult, _students, x => x.Name == searchBox.Text);
                UiTools.Clear(searchBox);
            }
        }

        private void objectTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                UiTools.Clear(textBox_0, textBox_1, textBox_2, textBox_3, textBox_4);
                UiTools.ChangeType(ref objectTypeCombo, out _currentObjType);
                SettingInputFields();
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (CheckTheCorrectness())
                    CreateObject();
                UiTools.Clear(textBox_0, textBox_1, textBox_2, textBox_3, textBox_4);
            }
        }
    }
}
