using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Playground
{
    public class Program
    {
        public static void Main()
        {
            var ledPort = new OutputPort(Pins.ONBOARD_LED, false);
            var switchPort = new InputPort(Pins.ONBOARD_BTN, false, Port.ResistorMode.Disabled);

            while (true)
            {
                ledPort.Write(switchPort.Read());
                Thread.Sleep(500);
            }
        }

    }
}
