namespace LAB_3_SE
{
    public partial class Form1 : Form
    {
        bool isDigit = true;
        public Form1()
        {
            InitializeComponent();
            //this.Load += new EventHandler(Form1_Load);
            codeSizeTxtBox.KeyDown += new KeyEventHandler(codeSizeTxtBox_KeyDown);
            codeSizeTxtBox.KeyPress += new KeyPressEventHandler(codeSizeTxtBox_KeyPress);
            solutionButton.Click += new EventHandler(solutionButton_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] projectTypes = Enum.GetNames(typeof(ProjectType));
            projectTypeComboBox.Items.AddRange(projectTypes);
            //projectTypeComboBox.Text = projectTypeComboBox.Items[0].ToString();
            effortLable.Text = "";
            timeToLable.Text = "";
            developersLable.Text = "";
            productivityLable.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void solutionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codeSizeTxtBox.Text))
            {
                return;
            }

            ProjectType projectType = (ProjectType)Enum.Parse(typeof(ProjectType), projectTypeComboBox.Text);
            int codeSize = int.Parse(codeSizeTxtBox.Text);
            effortLable.Text = string.Format("{0} {1}", BaseModel.GetEfforts(codeSize, projectType).ToString("F6"), "λώδ./μ³ρ.");
            timeToLable.Text = string.Format("{0} {1}", BaseModel.GetTimeToDevelop(projectType).ToString("F6"), "μ³ρ.");
            developersLable.Text = string.Format("{0} {1}", BaseModel.GetPersonToDevelop().ToString("F6"), "λώδ.");
            productivityLable.Text = string.Format("{0} {1}", BaseModel.GetProductivity(codeSize).ToString("F6"),"");
        }

        private void codeSizeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isDigit;
        }

        private void codeSizeTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            isDigit = ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode != Keys.Back));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}