﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tik4Net.ApiGenerator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tik4Net.ApiGenerator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to //*********************************************************
        /////  Autogenerated %DateTime%
        /////*********************************************************
        ///using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///
        ////*
        ///	%EntityDataRow%
        ///*/
        ///namespace Tik4Net%EntityDotedPath%
        ///{
        ///    /// &lt;summary&gt;
        ///    /// Represents one row in %EntityPath% on mikrotik router.
        ///    /// &lt;/summary&gt;
        ///    [TikEntity(&quot;%EntityPath%&quot;)]    
        ///    public sealed partial class %EntityName%: TikEntityBase
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AutoClassTemplate {
            get {
                return ResourceManager.GetString("AutoClassTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         /// &lt;summary&gt;
        ///        /// Row %PropertyDataName% property.
        ///        /// &lt;/summary&gt;
        ///        [TikProperty(&quot;%PropertyDataName%&quot;, typeof(%FieldType%), %Mandatory%)]
        ///        public %FieldType% %PropertyName% 
        ///        { 
        ///            get { return Properties.%GetMethod%(&quot;%PropertyDataName%&quot;); }
        ///            set { Properties.SetAttribute(&quot;%PropertyDataName%&quot;, value); }
        ///        }        	.
        /// </summary>
        internal static string AutoPropertyTemplate {
            get {
                return ResourceManager.GetString("AutoPropertyTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///
        ////*
        ///	%EntityDataRow%
        ///*/
        ///namespace Tik4Net%EntityDotedPath%
        ///{   
        ///    /// &lt;summary&gt;
        ///    /// Represents one row in %EntityPath% on mikrotik router.
        ///    /// &lt;/summary&gt;
        ///    [TikEntity(&quot;%EntityPath%&quot;)]    
        ///    public sealed partial class %EntityName%: TikEntityBase
        ///    {
        ///        %EntityProperties%
        ///    }
        ///
        ///    /// &lt;summary&gt;
        ///    /// Represents list of rows in %EntityPath% on mikrotik router - CUSTOM CODE.
        ///    / [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CustomClassTemplate {
            get {
                return ResourceManager.GetString("CustomClassTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         /// &lt;summary&gt;
        ///        /// Row %PropertyDataName% property.
        ///        /// &lt;/summary&gt;
        ///        [TikProperty(&quot;%PropertyDataName%&quot;, typeof(%FieldType%), %Mandatory%)]
        ///        public %FieldType% %PropertyName% 
        ///        { 
        ///            get { throw new NotImplementedException(&quot;TODO&quot;); /*TODO DataProperty: %PropertyDataName% */ }
        ///            set { throw new NotImplementedException(&quot;TODO&quot;); }
        ///        }        	.
        /// </summary>
        internal static string CustomPropertyTemplate {
            get {
                return ResourceManager.GetString("CustomPropertyTemplate", resourceCulture);
            }
        }
    }
}
