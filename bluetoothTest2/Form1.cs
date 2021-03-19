using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bluetoothTest2
{
    
    public partial class Form1 : Form
    {
        private delegate void DelShowDeviceLsit(string blueName, string blueAddress, string isConneted);
        BluetoothServicecs BluetoothServicecs;

        bool isDiscovering = false;
        public Form1()
        {
            InitializeComponent();
            this.BluetoothServicecs = new BluetoothServicecs();
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            listBoxDeviceList.Items.Clear();
            if (isDiscovering)
            {
                MessageBox.Show("正在搜尋中! 請物重覆點擊!");
                return;
            }
            Thread t = new Thread(StartDiscover);
            t.Start();
            isDiscovering = true;
        }

        private void StartDiscover()
        {
            BluetoothServicecs.DiscoverDevices();
            BluetoothServicecs.lanYaList.ForEach(device =>
            {
                DelShowDeviceLsit del = new DelShowDeviceLsit(AddDevicetoListBox);
                this.Invoke(del,device.blueName, device.blueAddress.ToString(),device.IsConnected.ToString());
                
            });
            isDiscovering = false;
            BluetoothServicecs.lanYaList.Clear();
        }

        private void AddDevicetoListBox(string blueName, string blueAddress, string isConnected)
        {
            listBoxDeviceList.Items.Add("裝置名稱： " + blueName + "   " + "裝置MAC： " + blueAddress + "   " + "連線中： " + isConnected);
        }
    }
}
