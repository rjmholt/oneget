﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.OneGet.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.OneGet.Resources.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to bootstrap provider &apos;{0}&apos;..
        /// </summary>
        internal static string FailedProviderBootstrap {
            get {
                return ResourceManager.GetString("FailedProviderBootstrap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider &apos;{0}&apos; failed to load..
        /// </summary>
        internal static string ProviderPluginLoadFailure {
            get {
                return ResourceManager.GetString("ProviderPluginLoadFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source location &apos;{0}&apos; is not valid for this provider..
        /// </summary>
        internal static string SourceLocationNotValid_Location {
            get {
                return ResourceManager.GetString("SourceLocationNotValid_Location", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User declined to install untrusted package &apos;{0}&apos;..
        /// </summary>
        internal static string UserDeclinedUntrustedPackageInstall {
            get {
                return ResourceManager.GetString("UserDeclinedUntrustedPackageInstall", resourceCulture);
            }
        }
    }
}