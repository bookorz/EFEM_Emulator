using EFEM_Emulator.UI_Update;
using EFEMInterface;
using EFEMInterface.MessageInterface;
using SANWA.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferControl.Engine;
using TransferControl.Management;

namespace EFEM_Emulator
{
    public partial class FormMain : Form, IEFEMControl, IUserInterfaceReport
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
            RouteControl RTCtrl = new RouteControl(this, ctrl);
            RTCtrl.ConnectAll();
        }

       
        public void On_Command_Excuted(Node Node, Transaction Txn, ReturnMessage Msg)
        {
           
        }

        public void On_Command_Error(Node Node, Transaction Txn, ReturnMessage Msg)
        {
            
        }

        public void On_Command_Finished(Node Node, Transaction Txn, ReturnMessage Msg)
        {
          
        }

        public void On_Command_TimeOut(Node Node, Transaction Txn)
        {
           
        }

        public void On_Event_Trigger(Node Node, ReturnMessage Msg)
        {
            
        }

        public void On_Node_State_Changed(Node Node, string Status)
        {

        }

        public void On_Eqp_State_Changed(string OldStatus, string NewStatus)
        {
            
        }

        public void On_Controller_State_Changed(string Device_ID, string Status)
        {
            FormMainUpdate.LogUpdate(Device_ID + ":" + Status);
        }

        public void On_Port_Begin(string PortName, string FormName)
        {
            
        }

        public void On_Port_Finished(string PortName, string FormName)
        {
            
        }

        public void On_Task_Finished(string FormName, string LapsedTime, int LapsedWfCount, int LapsedLotCount)
        {
           
        }

        public void On_Job_Location_Changed(Job Job)
        {
            
        }

        public void On_Script_Finished(Node Node, string ScriptName, string FormName)
        {
           
        }

        public void On_InterLock_Report(Node Node, bool InterLock)
        {
            
        }

        public void On_Mode_Changed(string Mode)
        {
           
        }
    }
}
