﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFEM_Emulator.UI_Update
{
    public class FormMainUpdate
    {
        
        delegate void UpdateLog(string msg);

        public static void ConnectUpdate(string state)
        {
            try
            {
                Form form = Application.OpenForms["FormMain"];
                Label W;
                if (form == null)
                    return;

                W = form.Controls.Find("ConnectStatus_lb", true).FirstOrDefault() as Label;
                if (W == null)
                    return;

                if (W.InvokeRequired)
                {
                    UpdateLog ph = new UpdateLog(ConnectUpdate);
                    W.BeginInvoke(ph, state);
                }
                else
                {
                    switch(state.ToUpper())
                    {
                        case "CONNECTED":
                            W.BackColor = Color.Lime;
                            break;
                        case "DISCONNECTED":
                            W.BackColor = Color.Red;
                            break;
                        case "CONNECTING":
                            W.BackColor = Color.Yellow;
                            break;
                    }
                    
                }
            }
            catch
            {

            }
        }

        public static void LogUpdate(string msg)
        {
            try
            {
                Form form = Application.OpenForms["FormMain"];
                RichTextBox W;
                if (form == null)
                    return;

                W = form.Controls.Find("Log_rt", true).FirstOrDefault() as RichTextBox;
                if (W == null)
                    return;

                if (W.InvokeRequired)
                {
                    UpdateLog ph = new UpdateLog(LogUpdate);
                    W.BeginInvoke(ph, msg);
                }
                else
                {
                    W.AppendText(msg+"\n");
                    if (W.Lines.Length > 1000)
                    {
                        W.Select(0, W.GetFirstCharIndexFromLine(W.Lines.Length - 1000));
                        W.SelectedText = "";
                    }
                    W.ScrollToCaret();
                }
            }
            catch
            {
                
            }
        }
    }
}
