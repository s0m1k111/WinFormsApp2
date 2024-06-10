using System.Globalization;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool flag = false;
        private List<int> nums = new List<int>() { 1, 3, 4, 5, 6, 7, 9 };
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 0;
            for (; flag == false || x == 100 ;)
            {
                addElement();
                x++;
            }
            MessageBox.Show(x.ToString());
            int random = new Random().Next(10);
            MessageBox.Show(string.Join(",", nums));
        }
        private void addElement()
        {
            int random = new Random().Next(10);
            flag = true;
            for(int i = 0; i < nums.Count; i++)
            {
                if(random  == nums[i])
                {
                    flag = false;
                }
            }
            if(flag != false)
            {
                nums.Add(random);
            }
        }
    }
}
