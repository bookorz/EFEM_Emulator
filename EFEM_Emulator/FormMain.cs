using EFEM_Emulator.UI_Update;
using EFEMInterface;
using EFEMInterface.MessageInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EFEM_Emulator
{
    public partial class FormMain : Form, IEFEMControl
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void On_CommandMessage(string msg)
        { 
            FormMainUpdate.LogUpdate(msg);
        }

        public void On_Connection_Connected()
        {
            FormMainUpdate.ConnectUpdate("Connected");
            FormMainUpdate.LogUpdate("Connected");
        }

        public void On_Connection_Connecting()
        {
            FormMainUpdate.ConnectUpdate("Connecting");
            FormMainUpdate.LogUpdate("Connecting");
        }

        public void On_Connection_Disconnected()
        {
            FormMainUpdate.ConnectUpdate("Disconnected");
            FormMainUpdate.LogUpdate("Disconnected");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RorzeInterface ctrl = new RorzeInterface(this);
        }

        private void EVTSend_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
