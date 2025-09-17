using Unity.WebRTC;

namespace Elements.Crossfire
{
    using Model;

    public interface IWebRtcTransportStats
    {
        float GetPeerLatency(ulong clientId);
        float GetPeerPacketLoss(ulong clientId);
        long GetBytesReceived(ulong clientId);
        long GetBytesSent(ulong clientId);
        RTCStatsReportAsyncOperation GetRTCStatsAsync(ulong clientId);
        ParsedWebRTCStats GetParsedStats(ulong clientId);
    }
}