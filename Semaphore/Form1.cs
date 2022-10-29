namespace WinFormsApp1
{
    public partial class Form1 : Form
    {   
        //int machineState = 0;
        int cntTimer = 0;
        int cntTimer2 = 0;
        enum state : int
        {
            allRed = 0,
            a_green = 1,
            a_yellow = 2,
            a_red = 3,
            b_green = 4,
            b_yellow = 5
        }

        state machineState;
        public Form1()
        {

            
            InitializeComponent();
        }

        private async void button_start_Click(object sender, EventArgs e)
        {
            
            if (button_start.Text == "START")
            {

                button_start.Enabled = false; 
                button_start.Text = "RESET";

                timer_100ms.Enabled = true;
            }

            
        }

        private void timer_yellow_Tick(object sender, EventArgs e)
        {
        }

        private void timer_100ms_Tick(object sender, EventArgs e)
        {
            cntTimer++;

            switch(machineState)
            {
                case state.allRed:

                    pictureBox_semaphoreB.Visible = false;
                    pictureBox_semaphore.Visible = false;
                    pictureBox_red.Visible = true;
                    pictureBox_redB.Visible = true;
                    pictureBox_green.Visible = false;
                    pictureBox_greenB.Visible = false;
                    pictureBox_yellow.Visible =false;
                    pictureBox_yellowB.Visible = false;

                    if (cntTimer > 20)
                    {
                        cntTimer = 0;
                        machineState = state.a_green;
                    }

                    break;

                case state.a_green:

                    pictureBox_semaphoreB.Visible = false;
                    pictureBox_semaphore.Visible = false;
                    pictureBox_red.Visible = false;
                    pictureBox_redB.Visible = true;
                    pictureBox_green.Visible = true;
                    pictureBox_greenB.Visible = false;
                    pictureBox_yellow.Visible = false;
                    pictureBox_yellowB.Visible = false;

                    if (cntTimer > 100)
                    {
                        cntTimer = 0;
                        machineState = state.a_yellow;
                    }

                    break;

                case state.a_yellow:

                    pictureBox_semaphoreB.Visible = false;
                    pictureBox_semaphore.Visible = false;
                    pictureBox_red.Visible = false;
                    pictureBox_redB.Visible = true;
                    pictureBox_green.Visible = false;
                    pictureBox_greenB.Visible = false;
                    pictureBox_yellow.Visible = true;
                    pictureBox_yellowB.Visible = false;

                    if (cntTimer > 40)
                    {
                        cntTimer = 0;
                        machineState = state.a_red;
                    }

                    break;

                case state.a_red:

                    pictureBox_semaphoreB.Visible = false;
                    pictureBox_semaphore.Visible = false;
                    pictureBox_red.Visible = true;
                    pictureBox_redB.Visible = true;
                    pictureBox_green.Visible = false;
                    pictureBox_greenB.Visible = false;
                    pictureBox_yellow.Visible = false;
                    pictureBox_yellowB.Visible = false;

                    if (cntTimer > 20)
                    {
                        cntTimer = 0;
                        machineState = state.b_green;
                    }

                    break;

                case state.b_green:

                    pictureBox_semaphoreB.Visible = false;
                    pictureBox_semaphore.Visible = false;
                    pictureBox_red.Visible = true;
                    pictureBox_redB.Visible = false;
                    pictureBox_green.Visible = false;
                    pictureBox_greenB.Visible = true;
                    pictureBox_yellow.Visible = false;
                    pictureBox_yellowB.Visible = false;

                    if (cntTimer > 100)
                    {
                        cntTimer = 0;
                        machineState = state.b_yellow;
                    }

                    break;

                case state.b_yellow:

                    pictureBox_semaphoreB.Visible = false;
                    pictureBox_semaphore.Visible = false;
                    pictureBox_red.Visible = true;
                    pictureBox_redB.Visible = false;
                    pictureBox_green.Visible = false;
                    pictureBox_greenB.Visible = false;
                    pictureBox_yellow.Visible = false;
                    pictureBox_yellowB.Visible = true;

                    if (cntTimer > 40)
                    {
                        cntTimer = 0;
                        machineState = state.allRed;
                    }

                    break;

                default:

                    cntTimer = 0;
                    machineState = state.allRed;

                    break;
            }
        }
    }
}