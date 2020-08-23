using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LEDStrips
{
    public partial class Form1 : Form
    {

        #region Make the window moveable
        //Make the window Moveable ---------------------
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //--------------------------------------------------
        #endregion

        SerialPort port = new SerialPort();  
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                port_list.Items.Add(port);
            }
        }

        private void min_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            port.Close();
            Close();
        }

        private void rbar_Scroll(object sender, ScrollEventArgs e)
        {
            r_label.Text = rbar.Value.ToString();
            primary_color_view.BackColor = Color.FromArgb(rbar.Value, gbar.Value, bbar.Value);
        }

        private void gbar_Scroll(object sender, ScrollEventArgs e)
        {
            g_label.Text = gbar.Value.ToString();
            primary_color_view.BackColor = Color.FromArgb(rbar.Value, gbar.Value, bbar.Value);
        }

        private void bbar_Scroll(object sender, ScrollEventArgs e)
        {
            b_label.Text = bbar.Value.ToString();
            primary_color_view.BackColor = Color.FromArgb(rbar.Value, gbar.Value, bbar.Value);
        }

        private void port_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close();
            }
            port = new SerialPort(port_list.SelectedItem.ToString(), 9600);
            try
            {
                port.Open();
                port.ReadTimeout = 3000;
                port.Write("CTRLR");
                string rep = port.ReadLine();
                if (rep.Contains("200"))
                {
                    Console.WriteLine("Connected !");
                    serial_status.Checked = true;
                }
                else
                {
                    Console.WriteLine("Couldn't connect");
                    serial_status.Checked = false;
                }
                
            }
            catch(System.UnauthorizedAccessException){
                MessageBox.Show("Error : Couldn't open port, access denied");
                serial_status.Checked = false;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Error : Connection timed out");
                serial_status.Checked = false;
            }
        }

        private void cycle_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write("mode_cycle$"+speed_value.Value);
            }
            else
            {
                MessageBox.Show("Error : Serial port not opened");
            }
        }

        private void set_button_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write("color$" + rbar.Value + "$" + gbar.Value + "$" + bbar.Value);
            }
            else
            {
                MessageBox.Show("Error : Serial port not opened");
            }
        }

        private void disco_button_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close();
                serial_status.Checked = false;
            }
        }

        private void debug_check_CheckedChanged(object sender, EventArgs e)
        {
            debug_check.Checked = debug_check.Checked;
            send_com.Visible = debug_check.Checked;
            command_box.Visible = debug_check.Checked;
        }

        private void send_com_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write(command_box.Text);
                command_box.Text = "";
            }
            else
            {
                command_box.Text = "";
                MessageBox.Show("Error: Serial port not opened");
            }
        }

        private void immersion_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write("mode_immersion");
            }
            else
            {
                MessageBox.Show("Error : Serial port not opened");
            }

        }

        private void off_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write("color$0$0$0");
            }
            else
            {
                MessageBox.Show("Error : Serial port not opened");
            }
        }

        private void Srbar_Scroll(object sender, ScrollEventArgs e)
        {
            Sr_label.Text = Srbar.Value.ToString();
            scolor_view.BackColor = Color.FromArgb(Srbar.Value, Sgbar.Value, Sbbar.Value);
        }

        private void Sgbar_Scroll(object sender, ScrollEventArgs e)
        {
            Sg_label.Text = Sgbar.Value.ToString();
            scolor_view.BackColor = Color.FromArgb(Srbar.Value, Sgbar.Value, Sbbar.Value);
        }

        private void Sbbar_Scroll(object sender, ScrollEventArgs e)
        {
            Sb_label.Text = Sbbar.Value.ToString();
            scolor_view.BackColor = Color.FromArgb(Srbar.Value, Sgbar.Value, Sbbar.Value);
        }

        private void swipe_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write("mode_swipe$" + rbar.Value + "$" + gbar.Value + "$" + bbar.Value + "$" + Srbar.Value + "$" + Sgbar.Value + "$" + Sbbar.Value + "$" + speed_value.Value);
            }
            else
            {
                MessageBox.Show("Error : Serial port not opened");
            }
        }
    }
}
