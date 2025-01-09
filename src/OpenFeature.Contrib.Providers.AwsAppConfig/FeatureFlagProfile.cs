using System;

namespace OpenFeature.Contrib.Providers.AwsAppConfig
{
    /// <summary>
    /// Represents a configuration profile for AWS AppConfig feature flags.
    /// This class contains the necessary identifiers to uniquely identify and access
    /// a feature flag configuration in AWS AppConfig.
    /// </summary>
    public class FeatureFlagProfile
    {
        /// <summary>
        /// Gets or sets the AWS AppConfig application identifier.
        /// This is the unique identifier for the application in AWS AppConfig.
        /// </summary>
        public string ApplicationIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the AWS AppConfig environment identifier.
        /// This represents the deployment environment (e.g., development, production) in AWS AppConfig.
        /// </summary>
        public string EnvironmentIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the AWS AppConfig configuration profile identifier.
        /// This identifies the specific configuration profile containing the feature flags.
        /// </summary>
        public string ConfigurationProfileIdentifier { get; set; }

        /// <summary>
        /// Gets a value indicating whether the profile is valid.
        /// A profile is considered valid when all identifiers (Application, Environment, and Configuration Profile)
        /// are non-null and non-empty.
        /// </summary>
        public bool IsValid => !(string.IsNullOrEmpty(ApplicationIdentifier) || 
                               string.IsNullOrEmpty(EnvironmentIdentifier) || 
                               string.IsNullOrEmpty(ConfigurationProfileIdentifier));

        /// <summary>
        /// Returns a string representation of the feature flag profile.
        /// The format is "ApplicationIdentifier+EnvironmentIdentifier+ConfigurationProfileIdentifier".
        /// </summary>
        /// <returns>A string containing all three identifiers concatenated with '+' characters.</returns>
        public override string ToString()
        {
            return $"{ApplicationIdentifier}_{EnvironmentIdentifier}_{ConfigurationProfileIdentifier}";
        }
    }
}
