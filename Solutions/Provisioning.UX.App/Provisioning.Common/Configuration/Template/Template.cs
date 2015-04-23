﻿using Provisioning.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Provisioning.Common.Configuration.Template
{
    /// <summary>
    /// Domain Object for the MasterTemplate
    /// </summary>
    [XmlRoot(ElementName = "Template")]
    public partial class Template
    {
        #region Properties
        /// <summary>
        /// Gets the Title of the tempalte
        /// </summary>
        [XmlAttribute]
        public string Title { get; set; }

        /// <summary>
        /// Gets the Description of the template
        /// </summary>
        [XmlAttribute]
        public string Description { get; set; }

        [XmlAttribute]
        public string ImageUrl { get; set; }
    
        /// <summary>
        /// Defines the SharePoint Site Template used by the custom site template
        /// </summary>
        [XmlAttribute]
        public string RootTemplate { get; set; }
       
        /// <summary>
        /// Defines the Host path
        /// </summary>
        [XmlAttribute]
        public string HostPath { get; set; }

        /// <summary>
        /// Defines the Tenant Admin Site Url 
        /// </summary>
        [XmlAttribute]
        public string TenantAdminUrl { get; set; }

        /// <summary>
        /// Defines if the Site is targeting SharePoint On-Premises or MT
        /// </summary>
        [XmlAttribute]
        public bool SharePointOnPremises { get; set; }

        /// <summary>
        /// Defines the Managed Path. Only Sites and Teams should be used
        /// </summary>
        [XmlAttribute]
        public string ManagedPath { get; set; }

        /// <summary>
        /// Defines if the template is available on subsites
        /// </summary>
        [XmlAttribute] 
        public bool RootWebOnly { get; set; }

        /// <summary>
        /// Defines if the tempalte is on the subweb only
        /// </summary>
        [XmlAttribute]
        public bool SubWebOnly { get; set; }

        /// <summary>
        /// Gets or sets the storage quota of the new site.
        /// Not used in SharePoint On-premises builds
        /// </summary>
        [XmlAttribute]
        public long StorageMaximumLevel { get; set; }

        /// <summary>
        /// Gets or sets the amount of storage usage on the new site that triggers a warning.
        /// Not used in SharePoint On-premises builds
        /// </summary>
        [XmlAttribute]
        public long StorageWarningLevel { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of machine resources that can be used by user code on the new site.
        /// Not used in SharePoint On-premises builds
        /// </summary>
        [XmlAttribute]
        public long UserCodeMaximumLevel { get; set; }

        /// <summary>
        /// Gets or sets the amount of machine resources used by user code that triggers a warning.
        /// Not used in SharePoint On-premises builds
        /// </summary>
        [XmlAttribute]
        public long UserCodeWarningLevel { get; set; }

        /// <summary>
        /// Gets if the Temmplate is enabled
        /// </summary>
        [XmlAttribute]
        public bool Enabled { get; set; }
       
        /// <summary>
        /// Gets or Sets the Template Configuration
        /// </summary>
        [XmlAttribute]
        public string ProvisioningTemplateContainer { get; set; }

        [XmlAttribute]
        public string ProvisioningTemplate { get; set; }

  
        #endregion
    }
}
