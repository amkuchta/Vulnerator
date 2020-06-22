﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vulnerator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Vulnerator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to (?&lt;=(?:\w{2})\s{2})(?:\w+(?:-?\.?\+*)*)+.
        /// </summary>
        internal static string RegexAcasDebianSoftwareName {
            get {
                return ResourceManager.GetString("RegexAcasDebianSoftwareName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:\s{10,})(?:\d+(?:\w*(?:-?\.?\+*\:?\~?)*)*)+.
        /// </summary>
        internal static string RegexAcasDebianSoftwareVersion {
            get {
                return ResourceManager.GetString("RegexAcasDebianSoftwareVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^(\w)+(-?\.?[A-Za-z]+)*.
        /// </summary>
        internal static string RegexAcasLinuxSoftwareName {
            get {
                return ResourceManager.GetString("RegexAcasLinuxSoftwareName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:(?:\d+\.?-?)+(?:(?:\w+)?\.?-?)+)+(?=\|).
        /// </summary>
        internal static string RegexAcasLinuxSoftwareVersion {
            get {
                return ResourceManager.GetString("RegexAcasLinuxSoftwareVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;=\[installed on\s)(?:\d{2,4}\/\d{1,2}\/\d{1,2})(?=\]).
        /// </summary>
        internal static string RegexAcasSoftwareInstallDate {
            get {
                return ResourceManager.GetString("RegexAcasSoftwareInstallDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^(?:\w)+(?:-?(?:\w?)+)+.
        /// </summary>
        internal static string RegexAcasSolarisSoftwareName {
            get {
                return ResourceManager.GetString("RegexAcasSolarisSoftwareName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:\d+\.?)+,?(?:REV=(?:\d+\.?)+)?.
        /// </summary>
        internal static string RegexAcasSolarisSoftwareVersion {
            get {
                return ResourceManager.GetString("RegexAcasSolarisSoftwareVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^.+?((?=\[)|(?=\r?\n)).
        /// </summary>
        internal static string RegexAcasWindowsSoftwareName {
            get {
                return ResourceManager.GetString("RegexAcasWindowsSoftwareName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;=\[version\s)(?:\d+(?:(?:(?:\.|-?)\d*)*)|(?:\w+))(?=\]).
        /// </summary>
        internal static string RegexAcasWindowsSoftwareVersion {
            get {
                return ResourceManager.GetString("RegexAcasWindowsSoftwareVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CAT\s(?:I{1,3}(?:V)?)(?:,\s)*.
        /// </summary>
        internal static string RegexCatText {
            get {
                return ResourceManager.GetString("RegexCatText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:CCI-\d*).
        /// </summary>
        internal static string RegexCciSelector {
            get {
                return ResourceManager.GetString("RegexCciSelector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:(\r?)\n){2,}(?:\t){2,}.
        /// </summary>
        internal static string RegexExcessiveNewLineAndTab {
            get {
                return ResourceManager.GetString("RegexExcessiveNewLineAndTab", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:\r)*\n\s{4,}.
        /// </summary>
        internal static string RegexIndentedMidlineNewLine {
            get {
                return ResourceManager.GetString("RegexIndentedMidlineNewLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:(?:[0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}(?:[0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]){1,3}.
        /// </summary>
        internal static string RegexIPv4 {
            get {
                return ResourceManager.GetString("RegexIPv4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]| [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RegexIPv6 {
            get {
                return ResourceManager.GetString("RegexIPv6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:[0-9A-Fa-f]{1,2}[:-]){5}(?:[0-9A-Fa-f]{2}).
        /// </summary>
        internal static string RegexMAC {
            get {
                return ResourceManager.GetString("RegexMAC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:(?&lt;!\r\n)(?&lt;=[^(\r)])(?:\r\n)(?=[a-z0-9])|(?:(?&lt;!\r)\n)(?=[a-z0-9])).
        /// </summary>
        internal static string RegexMidlineNewLine {
            get {
                return ResourceManager.GetString("RegexMidlineNewLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;=Release: )\d+(?=\s).
        /// </summary>
        internal static string RegexRawStigRelease {
            get {
                return ResourceManager.GetString("RegexRawStigRelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \d{2}\s\D{3}\s\d{4}.
        /// </summary>
        internal static string RegexStigDate {
            get {
                return ResourceManager.GetString("RegexStigDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:(?:\w)+(?:-|\.|_)?)+.
        /// </summary>
        internal static string RegexStigId {
            get {
                return ResourceManager.GetString("RegexStigId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:(?&lt;=\s)\n(?=\s|$)).
        /// </summary>
        internal static string RegexTrailingNewLine {
            get {
                return ResourceManager.GetString("RegexTrailingNewLine", resourceCulture);
            }
        }
    }
}
