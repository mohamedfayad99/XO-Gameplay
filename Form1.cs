namespace XOGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void radx2_Click(object sender, EventArgs e)
        {
            rado1.Checked = true;
        }

        private void rado2_Click(object sender, EventArgs e)
        {
            radx1.Checked = true;
        }

        private void radx1_Click(object sender, EventArgs e)
        {
            rado2.Checked = true;
        }

        private void rado1_Click(object sender, EventArgs e)
        {
            radx2.Checked = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtp1.Text == string.Empty || txtp2.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Players Names! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return  ;
            }
          DialogResult result=  MessageBox.Show($"Player {txtp1.Text} wil be {(radx1.Checked ? " X" : " O")}\n"+
                                                $"Player {txtp2.Text} wil be {(rado2.Checked ? " O" : " X")} ", "Sart Game",  MessageBoxButtons.OKCancel, MessageBoxIcon.Information);                ;
            if (result == DialogResult.OK)
            {
                this.Hide();
                string player1 = radx1.Checked ? txtp1.Text : txtp2.Text;
                string player2 = rado2.Checked ? txtp2.Text : txtp1.Text;
                Bordform bord = new Bordform(player1,player2);
                bord.ShowDialog();
                this.Close();
            }
        
        
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.BackColor= Color.Maroon;
            btnStart.ForeColor= Color.White;

        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.SandyBrown;
            btnStart.ForeColor = Color.Maroon;
        }
    }
}