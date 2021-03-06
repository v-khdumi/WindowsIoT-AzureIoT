﻿using Microsoft.Azure.Devices.Client;
using MotionDetector.UWP.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionDetector.UWP.Services
{
    public class AzureIoTHubService
    {
        private DeviceClient _deviceClient;

        public AzureIoTHubService()
        {
            _deviceClient = DeviceClient.CreateFromConnectionString("<<Azure IoT Hub Connection String>>", TransportType.Http1);
        }

        public async Task<bool> SendDataToAzure(MotionEvent motionEvent)
        {
            var messageString = JsonConvert.SerializeObject(motionEvent);
            var message = new Message(Encoding.ASCII.GetBytes(messageString));

            await _deviceClient.SendEventAsync(message);

            Debug.WriteLine("{0} > Sending telemetry: {1}", DateTime.Now, messageString);
            return true;
        }
    }
}
