using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjGreenhouse
{
    public class Network
    {
        public string deviceName {  get; set; }
        public List<Network> ConnectedDevices { get; set; }

        public Network(string name) 
        {
           deviceName = name;
            ConnectedDevices = new List<Network>();
        }

        public static Network operator +(Network mainDevice, Network attachedDevice)
        {
            mainDevice.ConnectedDevices.Add(attachedDevice);
            return mainDevice;
        }
    }
}
