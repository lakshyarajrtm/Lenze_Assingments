using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeviceApplication
{
    public partial class selectDeviceForm : Form
    {
        public selectDeviceForm()
        {
            InitializeComponent();
        }

        private void deviceOneButton_Click(object sender, EventArgs e)
        {
            Device_One one = new Device_One();
            one.Show();

        }

        private void deviceSecondButton_Click(object sender, EventArgs e)
        {
            DeviceSecond two = new DeviceSecond();
            two.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
