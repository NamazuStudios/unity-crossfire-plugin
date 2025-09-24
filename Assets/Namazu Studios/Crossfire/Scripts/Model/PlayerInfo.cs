using System;

namespace Elements.Crossfire.Model
{
    [Serializable]
    public class PlayerInfo
    {
        public string profileId;
        public ulong networkId;
        public bool isHost;
        public ConnectionState connectionState;
        public ConnectionQuality connectionQuality;

        public override string ToString()
        {
            return "PlayerInfo \n" +
                $"profileId: {profileId},\n" +
                $"networkId: {networkId},\n" +
                $"isHost: {isHost},\n" +
                $"connectionState: {connectionState},\n" +
                $"connectionQuality: {connectionQuality}";
        }
    }
}