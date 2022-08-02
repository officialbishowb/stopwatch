namespace stopwatch
{
    public partial class stopwatch : Form
    {

        int hour,minute,second;
        string time,h,m,s;
        bool isActive;
        public stopwatch()
        {
            InitializeComponent();
            StartTime();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void counter_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                second++;
                if (second >= 60)
                {
                    minute++;
                    second = 0;
                    if(minute >= 60)
                    {
                        hour++;
                        minute = 0;
                    }
                }
            }

            h = Convert.ToString(hour);
            m = Convert.ToString(second);
            s = Convert.ToString(second);

            if (second < 10) s = "0" + second;
            if (minute < 10) m = "0" + minute;
            if (hour < 10) h = "0" + hour;



            time = String.Format("{0}:{1}:{2}", h, m, s);

            ShowTimeLbl();
        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            StartTime();
        }


        private void StartTime()
        {
            isActive = false;
            hour = 0;
            minute = 0;
            second = 0;
            time = "00:00:00";
            timer.Text = time;
        }

        private void ShowTimeLbl()
        {
            timer.Text = time;
        }


    }
}