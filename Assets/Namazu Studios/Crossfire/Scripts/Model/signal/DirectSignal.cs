namespace Elements.Crossfire.Model
{
    /**
     * Generic interface for signals that are sent to a specific recipient.
     */
    public interface DirectSignal : Signal
    {

        /**
         * The profile id of the subject of the signal. This is typically the originator of the signal.
         *
         * @return the profile id
         */
        string getProfileId();

        /**
         * Get the ID of the recipient for this signal.
         *
         * @return the profile ID of the recipient
         */
        string getRecipientProfileId();

    }
}