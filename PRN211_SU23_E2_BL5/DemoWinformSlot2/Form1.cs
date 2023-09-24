namespace DemoWinformSlot2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button newButton = new Button();
            newButton.Text = "Ahihi!";
            newButton.Location = new Point(100, 100);
            this.Controls.Add(newButton);

        }
    }
}