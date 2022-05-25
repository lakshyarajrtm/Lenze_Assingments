using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace DeviceApplication
{
    public partial class DeviceSecond : Form, IDevice
    {
        private String ProductName { get; } = "Switch";

        private String ProductCode { get; } = "164";

        private String FirmwareVersion { get; } = "2.0";

        private int ActualTorque { get; } = 322;

        private int ActualSpeed { get; } = 8000;

        private int ActualVoltage { get; } = 800;


        public DeviceSecond()
        {
            InitializeComponent();
            ShowDetails();
            productNameValue.Enabled = false;
            productCodeValue.Enabled = false;
            firmwareVersionValue.Enabled = false;
            actualTorqueValue.Enabled = false;
            actualSpeedValue.Enabled = false;
            actualVoltageValue.Enabled = false;
        }

        public void ShowDetails()
        {
            productNameValue.Text = ProductName;
            productCodeValue.Text = ProductCode;
            firmwareVersionValue.Text = FirmwareVersion;
            actualTorqueValue.Text = Convert.ToString(ActualTorque);
            actualSpeedValue.Text = Convert.ToString(ActualSpeed);
            actualVoltageValue.Text = Convert.ToString(ActualVoltage);

            if(ActualVoltage > 25 && (ActualSpeed < -5000 || ActualSpeed > 5000))
            {
                errorStateValue.BackColor = Color.Red;
            }
            
        }
    }
}
