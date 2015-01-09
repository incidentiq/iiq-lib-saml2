﻿using System.Configuration;

namespace SAML2.Config
{
    /// <summary>
    /// SAML2 Configuration Section.
    /// </summary>
    public class Saml2Section
    {
        /// <summary>
        /// Gets the section name.
        /// </summary>
        public static string Name { get { return "saml2"; } }


        /// <summary>
        /// Gets or sets the actions to perform on successful processing.
        /// </summary>
        /// <value>The actions.</value>
        public ActionCollection Actions { get; set; }
        /// <summary>
        /// Gets or sets the allowed audience uris.
        /// </summary>
        /// <value>The allowed audience uris.</value>
        public AllowedAudienceUriCollection AllowedAudienceUris { get; set; }

        /// <summary>
        /// Gets or sets the assertion profile.
        /// </summary>
        /// <value>The assertion profile configuration.</value>
        public AssertionProfileElement AssertionProfile { get; set; }
        /// <summary>
        /// Gets or sets the common domain cookie configuration.
        /// </summary>
        /// <value>The common domain cookie configuration.</value>
        public CommonDomainCookieElement CommonDomainCookie { get; set; }

        /// <summary>
        /// Gets or sets the identity providers.
        /// </summary>
        /// <value>The identity providers.</value>
        public IdentityProviderCollection IdentityProviders { get; set; }
        /// <summary>
        /// Gets or sets the logging configuration.
        /// </summary>
        /// <value>The logging configuration.</value>
        public LoggingElement Logging { get; set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        /// <value>The metadata.</value>
        public MetadataElement Metadata { get; set; }

        /// <summary>
        /// Gets or sets the service provider.
        /// </summary>
        /// <value>The service provider.</value>
        public ServiceProviderElement ServiceProvider { get; set; }

        /// <summary>
        /// Gets a value indicating whether the <see cref="T:System.Configuration.ConfigurationElement"/> object is read-only.
        /// </summary>
        /// <returns>true if the <see cref="T:System.Configuration.ConfigurationElement"/> object is read-only; otherwise, false.</returns>
        public override bool IsReadOnly()
        {
            return false;
        }

        public class ActionCollection
        {
        }
    }
}