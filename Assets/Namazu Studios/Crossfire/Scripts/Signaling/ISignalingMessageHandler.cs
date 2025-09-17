
namespace Elements.Crossfire
{
    using Model;

    /// <summary>
    /// Message routing interface
    /// </summary>
    public interface ISignalingMessageHandler
    {
        void HandleMessage(SignalingMessage message);
    }
}