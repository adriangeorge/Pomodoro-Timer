using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            infoBox.Text = ""; //default text for info box
        }

        int second, minute, hour, isStarted = 0, option; //declaration of variables
        bool isPause; //flag to determine whether it is pause time or work time

        private void playaudio() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Pomodoro.Properties.Resources.alarm); 
            audio.Play();
        }

        //click start button to start the timer
        private void startButton_Click(object sender, EventArgs e)
        {
            if(hour + minute + second != 0)  //only starts if there is a preset selected
                isStarted = 1;
            startButton.BackColor = Color.LightSkyBlue;
            stopButton.BackColor = Color.Silver;
        }

        private void stopButton_Click(object sender, EventArgs e) //sets isStarted flag to 0, timer stops
        {
            isStarted = 0;
            startButton.BackColor = Color.Silver;
            stopButton.BackColor = Color.LightSkyBlue;
        }

        private void option1_MouseEnter(object sender, EventArgs e)
        {
            
            infoLabel.Text = "Easy work session: 25 minutes of work and 5 minutes of break \n";
        }

        private void option2_MouseEnter(object sender, EventArgs e)
        {
            infoLabel.Text = "Moderate work session: 50 minutes of work and 10 minutes of break \n";
        }

        private void option3_MouseEnter(object sender, EventArgs e)
        {
            infoLabel.Text = "Wow, you're really being productive today huh? 1 hour and 15 minutes of work and a well deserved break of 15 minutes \n";
        }

        //function to calculate work time and pause time according to selected preset
        private void setClock(int option, bool isPause)
        {
            second = 0;
            minute = 0;
            hour = 0;
            if (isPause == false)
            {
                second = 0;
                minute = 25 * option;
                if (minute / 60 > 0)
                {
                    hour = minute / 60;
                    minute = minute - hour * 60;
                }
                state.Text = "Work Time! ";
                stateColor.BackColor = Color.Red;
            }
            else
            {
                second = 0;
                minute = 5 * option;
                hour = 0;
                state.Text = "Pause Time! ";
                stateColor.BackColor = Color.LightGreen;
            }


            hourDisplay.Text = hour.ToString();
            minuteDisplay.Text = minute.ToString();
            secondDisplay.Text = second.ToString();

        }

        private void status(int isPause)
        {

        }

        private void option3_Click(object sender, EventArgs e)
        {
            option = 3;
            isPause = false;
            setClock(option, isPause);

        }

        private void option2_Click(object sender, EventArgs e)
        {
            option = 2;
            isPause = false;
            setClock(option, isPause);


        }

        private void option1_Click(object sender, EventArgs e)
        {
            option = 1;
            isPause = false;
            setClock(option, isPause);


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isStarted == 1)
            {

                if (second == 0)
                {

                    if (minute > 0)
                    {
                        minute--;
                        second = 59;
                    }
                    if (minute == 0)
                    {
                        if (hour > 0)
                        {
                            hour--;
                            minute = 59;
                        }
                        if(hour == 0)
                        {

                            isPause = !isPause;
                            setClock(option, isPause);
                            playaudio();
                            
                        }
                        
                    }
                }
                else
                    second--;

            
            }
            hourDisplay.Text = hour.ToString();
            minuteDisplay.Text = minute.ToString();
            secondDisplay.Text = second.ToString();

        }
       
    }
}
