﻿using System;
namespace KNXNet
{
    public class KNXNetIPHeader
    {
        public byte HeaderSize { get; set; }
        public byte Version { get; set; }
        public short ServiceType { get; set; }
        public short Size { get; set; }

        public byte[] GetBytes()
        {
            byte[] buffer = new byte[6];

            buffer[0] = HeaderSize;
            buffer[1] = Version;
            
            Array.Copy(KNXBitConverter.GetBytes(ServiceType), 0, buffer, 2, 2);
            Array.Copy(KNXBitConverter.GetBytes(Size), 0, buffer, 4, 2);

            return buffer;
        }
    }
}