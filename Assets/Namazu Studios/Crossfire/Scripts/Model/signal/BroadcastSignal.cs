
namespace Elements.Crossfire.Model
{
    /**
     * Represents a signal in the Crossfire signaling system.
     */
    public interface BroadcastSignal : Signal
    {

        /**
         * The profile id of the subject of the signal. This is typically the originator of the signal.
         *
         * @return the profile id
         */
        string getProfileId();

    }
}