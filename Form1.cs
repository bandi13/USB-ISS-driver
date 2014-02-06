using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            foreach (string s in ISSComm.getPorts()) comboBox_comport.Items.Add(s);
        }

        private void comboBox_comport_SelectedIndexChanged(object sender, EventArgs e) {
            if (ISSComm.getComm().connect(comboBox_comport.Text)) comboBox_comport.Text = "";
            txtMode.Text = "";
            ISSComm.ISS_VERSION data = new ISSComm.ISS_VERSION();

            if ((!data.isValid) || (data.moduleID != 7)) { // if the module id is not that of the USB-ISS
                lblDeviceData.Text = "Not Found";
                return;
            }
            lblDeviceData.Text = "USB-ISS V" + data.fwVersion + ", SN: " + (new ISSComm.GET_SER_NUM()).getSerNum(); //print the software version on screen
            switch (data.operMode & 0xFE) {
                case (int)ISSComm.ISS_MODE.ISS_MODES.IO_MODE: txtMode.Text = "IO_MODE"; break;
                case (int)ISSComm.ISS_MODE.ISS_MODES_I2C.I2C_H_1000KHZ: txtMode.Text = "I2C 1MHz HW"; break;
                case (int)ISSComm.ISS_MODE.ISS_MODES_I2C.I2C_H_100KHZ: txtMode.Text = "I2C 100KHz HW"; break;
                case (int)ISSComm.ISS_MODE.ISS_MODES_I2C.I2C_H_400KHZ: txtMode.Text = "I2C 400KHz HW"; break;
                case (int)ISSComm.ISS_MODE.ISS_MODES_I2C.I2C_S_100KHZ: txtMode.Text = "I2C 100KHz SW"; break;
                case (int)ISSComm.ISS_MODE.ISS_MODES_I2C.I2C_S_20KHZ: txtMode.Text = "I2C 20KHz SW"; break;
                case (int)ISSComm.ISS_MODE.ISS_MODES_I2C.I2C_S_500KHZ: txtMode.Text = "I2C 500KHz SW"; break;
                case (int)ISSComm.ISS_MODE.ISS_MODES_I2C.I2C_S_50KHZ: txtMode.Text = "I2C 50KHz SW"; break;
                case (int)ISSComm.ISS_MODE.ISS_MODES_SPI.A2I_L: txtMode.Text = "SPI TX on Act->Idle, Clock idle = low"; break;
                case (int)ISSComm.ISS_MODE.ISS_MODES_SPI.A2I_H: txtMode.Text = "SPI TX on Act->Idle, Clock idle = high"; break;
                case (int)ISSComm.ISS_MODE.ISS_MODES_SPI.I2A_L: txtMode.Text = "SPI TX on Idle->Act, Clock idle = low"; break;
                case (int)ISSComm.ISS_MODE.ISS_MODES_SPI.I2A_H: txtMode.Text = "SPI TX on Idle->Act, Clock idle = high"; break;
                default: txtMode.Text = "Unknown mode: 0x" + data.operMode.ToString("X2"); break;
            }
            if((data.operMode & (int)ISSComm.ISS_MODE.ISS_MODES.SERIAL) == (int)ISSComm.ISS_MODE.ISS_MODES.SERIAL) txtMode.Text += ", with Serial";
        }
    }
}
