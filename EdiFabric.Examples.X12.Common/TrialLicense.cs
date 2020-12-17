﻿using System;
using System.IO;

namespace EdiFabric.Examples.X12.Common
{
    public class TrialLicense
    {
        public static string SerialNumber { get; set; }
        static TrialLicense()
        {
            var serialKeyPath = @"../../../../edifabric-trial/serial.key";

            if (!File.Exists(serialKeyPath))
                throw new Exception("Set the path to the serial.key file in project EdiFabric.Examples.X12.Common, file License.cs!");

            SerialNumber = File.ReadAllText(serialKeyPath).Trim(new[] { ' ', '\r', '\n' });
        }
    }
}
