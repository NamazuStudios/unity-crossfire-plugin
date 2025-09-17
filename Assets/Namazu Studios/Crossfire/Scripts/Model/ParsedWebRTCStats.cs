using System;

namespace Elements.Crossfire.Model
{
    [Serializable]
    public class ParsedWebRTCStats
    {
        public float currentRoundTripTime;
        public long packetsLost;
        public long packetsReceived;
        public long bytesReceived;
        public long bytesSent;
        public string candidatePairState;
        public DateTime timestamp;

        public float GetPacketLossRatio()
        {
            var total = packetsLost + packetsReceived;
            return total > 0 ? (float)packetsLost / total : 0f;
        }

        public float GetLatencyMs()
        {
            return currentRoundTripTime * 1000f;
        }
    }
}