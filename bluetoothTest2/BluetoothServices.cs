using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace bluetoothTest2
{
    class BluetoothServicecs
    {


        public List<Bluetooth> lanYaList;
        public List<BluetoothAddress> devicesMACList;
        public BluetoothClient client;
        Guid mGUID1;
        Guid mGUID2;
        public string remoteDeviceName;
        public bool hasConnected;
        public BluetoothServicecs()
        {
            this.lanYaList = new List<Bluetooth>();
            this.devicesMACList = new List<BluetoothAddress>();
            this.client = new BluetoothClient();
            this.mGUID1 = BluetoothService.Handsfree; //藍芽服務的uuid
            this.mGUID2 = Guid.Parse("00001101-0000-1000-8000-00805F9B34FB"); //藍芽串列埠服務的uuiid
            this.remoteDeviceName = null; // 遠端連線中裝置名稱
            this.hasConnected = false;
        }


        public void DiscoverDevices()
        {
            BluetoothRadio radio = BluetoothRadio.PrimaryRadio; //獲取藍芽介面卡
            radio.Mode = RadioMode.Connectable;
            Console.WriteLine("搜尋藍芽裝置中....");
            BluetoothDeviceInfo[] devices = client.DiscoverDevices();//搜尋藍芽 10秒鐘
            Console.WriteLine("找到裝置數量：" + devices.Count().ToString());
            ;
            foreach (var item in devices)
            {
                //item.ShowDialog();
                lanYaList.Add(new Bluetooth { blueName = item.DeviceName, blueAddress = item.DeviceAddress, blueClassOfDevice = item.ClassOfDevice, IsBlueAuth = item.Authenticated, IsBlueRemembered = item.Remembered,IsConnected = item.Connected, blueLastSeen = item.LastSeen, blueLastUsed = item.LastUsed });//把搜尋到的藍芽新增到集合中
            }

            lanYaList.ForEach(Lanya => { Console.WriteLine("裝置名稱： " + Lanya.blueName + " " + "裝置MAC： " + Lanya.blueAddress.ToString()); });
        }

        public bool isConnected()
        {
            hasConnected = client.Connected;
            Console.WriteLine("isConnect",client.Connected.ToString());
            return hasConnected;
        }

        public bool ConnectToRemoteDevice(BluetoothAddress blueAddress)
        {
            try
            {
                if(!client.Connected)
                {
                    Console.WriteLine("連接中....");
                    client.Connect(blueAddress, mGUID1);   //開始配對 藍芽4.0不需要setpin
                    Console.WriteLine("連接成功....");
                    hasConnected = client.Connected;
                    Console.WriteLine("" + hasConnected.ToString());
                    if(hasConnected)
                    {
                        remoteDeviceName = client.RemoteMachineName;
                    }
                }
                else
                {
                    Console.WriteLine("裝置已連線" + client.RemoteMachineName);
                }
             
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return hasConnected;

        }

        public void SendDataStreanFromClient()
        {
            var stream = client.GetStream();
            byte[] sendData = Encoding.Default.GetBytes("人生苦短，我用python");
            stream.Write(sendData, 0, sendData.Length);       //傳送
        }

        public void ReceiveDataStream()
        {
            BluetoothListener bluetoothListener = new BluetoothListener(mGUID2);
            bluetoothListener.Start();
            BluetoothClient acceptClient = bluetoothListener.AcceptBluetoothClient();

            while (true)
            {
                byte[] buffer = new byte[100];
                var peerStream = acceptClient.GetStream();
                peerStream.Read(buffer, 0, buffer.Length);

                string data = Encoding.UTF8.GetString(buffer).ToString().Replace("\0", "");//去掉後面的\0位元組
            }


        }


    }
}
