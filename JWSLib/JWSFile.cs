using System.Text;
using System.IO;
using OpenMcdf;
using System.Xml.Linq;

namespace JWSLib
{
    public class JWSFile
    {

        private string _fileName;

        private readonly DataInfo _info;
        private int _dataChunkSize;

        private List<double> _xData = new();
        private List<List<float>> _yDataChannels = new();

        public JWSFile(string filePath)
        {

            _fileName = Path.GetFileNameWithoutExtension(filePath);

            var jwsFile = new CompoundFile(filePath);
            var dataInfoStream = jwsFile.RootStorage.GetStream("DataInfo");

            var dataInfoBytes = dataInfoStream.GetData();
            if (dataInfoBytes == null)
            {
                throw new Exception("No DataInfo in file!");
            }

            _info = new DataInfo(dataInfoBytes);

            var yDataStream = jwsFile.RootStorage.GetStream("Y-Data");
            
            CFStream? xDataStream = null;
            if (jwsFile.RootStorage.TryGetStream("X-Data", out xDataStream))
            {
            }

            var yDataBytes = yDataStream.GetData();
            if (yDataBytes == null)
            {
                throw new Exception("No Y-Data in file!");
            }

            byte[]? xDataBytes = null;
            if (xDataStream != null)
            {
                xDataBytes = xDataStream.GetData();
            }

            var yDataSize = yDataBytes.Length;
            long yDataCur = yDataSize / 4;
            var numChannels = 1;

            while (yDataCur != _info.NumPoints)
            {
                yDataCur -= _info.NumPoints;
                numChannels++;
            }

            _dataChunkSize = yDataBytes.Length / numChannels;

            var chunks = new List<byte[]>();
            var curChannel = 0;
            for (var i = 0; i < yDataBytes.Length; i += _dataChunkSize)
            {
                chunks.Add(new byte[_dataChunkSize]);
                Array.Copy(yDataBytes, i, chunks[curChannel], 0, _dataChunkSize);
                curChannel++;
            }

            var unpackedChunks = new List<float[]>();
            var unpackedXData = new float[_info.NumPoints];
            var xDataEmpty = true;

            if (xDataBytes != null)
            {


                var xOffset = 0;
                for (int i = 0; i < _info.NumPoints; i++)
                {
                    unpackedXData[i] = BitConverter.ToSingle(xDataBytes, xOffset);
                    xOffset += 4;
                }
                
                xDataEmpty = false;

            }

            for (var i = 0; i < chunks.Count; i++)
            {

                unpackedChunks.Add(new float[_info.NumPoints]);
                var yOffset = 0;
                for (var j = 0; j < _info.NumPoints; j++)
                {
                    unpackedChunks[i][j] = BitConverter.ToSingle(chunks[i], yOffset);
                    yOffset += 4;
                }

            }

            // Add X-Data to List
            if (xDataEmpty)
            {

                if (_info.XIncrement < 0)
                {

                    var curX = _info.XMax;
                    while (curX >= _info.XMin - 0.1)
                    {
                        _xData.Add(Math.Round(curX, _info.XIncrementPrecision));
                        curX += _info.XIncrement;
                    }

                }
                else
                {

                    var curX = _info.XMin;
                    while (curX <= _info.XMax + 0.1)
                    {
                        _xData.Add(Math.Round(curX, _info.XIncrementPrecision));
                        curX += _info.XIncrement;
                    }

                }

            }
            else
            {
                for (var i = 0; i < _info.NumPoints; i++)
                {
                    _xData.Add(unpackedXData[i]);
                }
            }

            // Add Y-Data to List
            for (var i = 0; i < unpackedChunks.Count; i++)
            {

                _yDataChannels.Add(new List<float>());

                var curYDataPoint = 0;
                for (int j = 0; j < _info.NumPoints; j++)
                {
                    _yDataChannels[i].Add(unpackedChunks[i][curYDataPoint]);
                    curYDataPoint++;
                }

            }

        }

        public void ExportToCSV(string destination = "")
        {

            var csvFileBuilder = new StringBuilder();
            csvFileBuilder.Append("X-Values,");

            for (var i = 0; i < _yDataChannels.Count; i++)
            {
                csvFileBuilder.Append($"Channel {i + 1}");
                csvFileBuilder.Append(i != _yDataChannels.Count - 1 ? ',' : '\n');
            }

            for (var i = 0; i < _info.NumPoints; i++)
            {

                csvFileBuilder.Append($"{_xData[i]},");

                for (var j = 0; j < _yDataChannels.Count; j++)
                {
                    csvFileBuilder.Append(_yDataChannels[j][i]);
                    csvFileBuilder.Append(j != _yDataChannels.Count - 1 ? ',' : '\n');
                }

            }

            var path = Path.Join(destination, $"{_fileName}.csv");
            File.WriteAllText(path, csvFileBuilder.ToString());

        }

    }
}