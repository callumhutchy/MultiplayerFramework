using SGSclient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace ClientTestUnit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        List<SGSClient> clientList;
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            clientList = new List<SGSClient>();
            for (int i = 0; i <200; i++)
            {
                SGSClient sgsClient = new SGSClient(i);
                //Thread thread = new Thread(() => sgsClient.Start(i));
                //thread.Start();
                
                clientList.Add(sgsClient);
                lblCount.Text = clientList.Count.ToString();
            }

            

        }
        
        

        private void btnKill10_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10;i++)
            {
                clientList[0].Closing();
                clientList.RemoveAt(0);
                Thread.Sleep(100);
            }
            
            lblCount.Text = clientList.Count.ToString();
        }

        private void btnKill100_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                clientList[0].Closing();
                clientList.RemoveAt(0);

                Thread.Sleep(100);
            }
            lblCount.Text = clientList.Count.ToString();
        }

        private void btnKillAll_Click(object sender, EventArgs e)
        {
            int count = clientList.Count;
            for (int i = 0; i < count; i++)
            {
                clientList[0].Closing();
                clientList.RemoveAt(0);

                Thread.Sleep(100);
            }
            lblCount.Text = clientList.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientList[0].Closing();
            clientList.RemoveAt(0);
            lblCount.Text = clientList.Count.ToString();
        }

        private void btnSend10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                clientList[i].SendMessage();
                Thread.Sleep(50);
            }
            
        }

        private void btnSend100_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                clientList[i].SendMessage();
                Thread.Sleep(50);
            }
        }

        static Random rand = new Random();

        private void btnSendMovement_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 100; i++)
            {
               
                clientList[i].SendRandomMovement(rand.Next(600), rand.Next(250));
            }
        }
    }
}
