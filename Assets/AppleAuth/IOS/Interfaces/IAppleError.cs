namespace AppleAuth.IOS.Interfaces
{
    public interface IAppleError
    {
        /// <summary>
        /// "Default implementation provided" (errorCode)
        /// </summary>
        int Code { get; }

        /// <summary>
        /// "Default implementation provided" (errorDomain)
        /// </summary>
        string Domain { get; }

        /// <summary>
        /// Retrieve the localized description for this error
        /// </summary>
        string LocalizedDescription { get; }

        /// <summary>
        /// Provides a set of possible recovery options to present to the user
        /// </summary>
        string[] LocalizedRecoveryOptions { get; }

        /// <summary>
        /// "Default implementation provided"
        /// </summary>
        string LocalizedRecoverySuggestion { get; }

        /// <summary>
        /// "Default implementation provided"
        /// </summary>
        string LocalizedFailureReason { get; }
    }
}
