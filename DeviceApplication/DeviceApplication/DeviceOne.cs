using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeviceApplication
{
    public partial class Device_One : Form, IDevice
    {

        public String ProductName { get; set; } = "Router";

        public String ProductCode { get; set; } = "132";

        public String FirmwareVersion { get; set; } = "1.0";

        public int SwitchingFrequency { get; set; } = 200;

        public int StartFrequency { get; set; } = 6000;

        public int DelayTime { get; set; } = 200;

        public Device_One()
        {
            InitializeComponent();
            ShowDetails();
            productNameValue.Enabled = false;
            productCodeValue.Enabled = false;
            firmwareVersionValue.Enabled = false;
            switchingFrequencyValue.Enabled = false;
            startFrequencyValue.Enabled = false;
            delayTimeValue.Enabled = false;
        }

        public void ShowDetails()
        {
            productNameValue.Text = ProductName;
            productCodeValue.Text = ProductCode;
            firmwareVersionValue.Text = FirmwareVersion;
            switchingFrequencyValue.Text = Convert.ToString(SwitchingFrequency);
            startFrequencyValue.Text = Convert.ToString(StartFrequency);
            delayTimeValue.Text = Convert.ToString(DelayTime);

            if (StartFrequency > 250 && SwitchingFrequency > 500)
            {
                errorStateValue.BackColor = Color.Red;
            }
        }
    }
}
