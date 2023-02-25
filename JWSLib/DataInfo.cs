using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWSLib
{
    internal class DataInfo
    {

        private byte[] _data;
        internal uint NumPoints { get; }
        internal double XMax { get; }
        internal double XMin { get; }
        internal double XIncrement { get; }
        internal int XIncrementPrecision { get; }

        internal DataInfo(byte[] data)
        {

            _data = data;
            if (data.Length < 96)
            {
                throw new Exception("DataInfo block should be at least 96 bytes!");
            }

            NumPoints = BitConverter.ToUInt32(_data, 20);
            double xFirst = BitConverter.ToDouble(_data, 24);
            double xLast = BitConverter.ToDouble(_data, 32);
            XIncrement = BitConverter.ToDouble(_data, 40);

            if (xFirst > xLast)
            {
                XMax = xFirst;
                XMin = xLast;
            }
            else
            {
                XMax = xLast;
                XMin = xFirst;
            }

            var xIncrementStr = XIncrement.ToString(CultureInfo.InvariantCulture);
            var xIncrementDecimalDigits = xIncrementStr.Split('.');
            if (xIncrementDecimalDigits.Length == 2)
            {
                XIncrementPrecision = xIncrementDecimalDigits[1].Length;
            }

        }

    }
}
