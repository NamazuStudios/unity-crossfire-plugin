using System;

namespace Elements.Crossfire.Model
{
    [Serializable]
    public struct NetworkStats
    {
        public float latency;
        public float packetLoss;
        public long bytesReceived;
        public long bytesSent;
        public DateTime lastUpdated;
    }
}