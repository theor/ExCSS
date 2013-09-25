﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExCSS.Tests.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExCSS.Tests.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to @charset utf-8;
        ///
        ///@import &quot;style.css&quot;;
        ///@import url(&quot;style.css&quot;);
        ///@import url(&quot;style.css&quot;) print;
        ///@import url(&quot;style.css&quot;) projection, tv;
        ///@import url(&apos;style.css&apos;) handheld and (max-width: 400px);
        ///@import url(style.css) screen &quot;Plain style&quot;;
        ///@import url(style.css) &quot;Four-columns and dark&quot;;
        ///@import &quot;style.css&quot; &quot;Style Sheet&quot;;
        ///
        ///@namespace someexample &quot;http://css.example.org&quot;;
        ///@namespace &quot;http://example.com/test&quot;;
        ///
        ///@font-face
        ///{
        ///    font-family: testFont;
        ///    src: url(&apos;SomeFont.ttf&apos;),
        ///         url [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Css3 {
            get {
                return ResourceManager.GetString("Css3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @charset &apos;utf-8&apos;;
        ///@import url(&apos;style.css&apos;);
        ///@import url(&apos;style.css&apos;);
        ///@import url(&apos;style.css&apos;) print;
        ///@import url(&apos;style.css&apos;) projection, tv;
        ///@import url(&apos;style.css&apos;) handheld and (max-width: 400px);
        ///@import url(&apos;style.css&apos;) screen &apos;Plain style&apos;;
        ///@import url(&apos;style.css&apos;) &apos;Four-columns and dark&apos;;
        ///@import url(&apos;style.css&apos;) &apos;Style Sheet&apos;;
        ///@namespace someexample &apos;http://css.example.org&apos;;
        ///@namespace &apos;http://example.com/test&apos;;
        ///@font-face {
        ///	font-family:testFont;
        ///	src:url(&apos;SomeFont.ttf&apos;), url(&apos;SomeFon [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Css3Friendly {
            get {
                return ResourceManager.GetString("Css3Friendly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @charset &apos;utf-8&apos;;@import url(style.css);@import url(style.css);@import url(style.css) print;@import url(style.css) projection,tv;@import url(style.css) handheld and (max-width:400px);@import url(style.css) screen &apos;Plain style&apos;;@import url(style.css) &apos;Four-columns and dark&apos;;@import url(style.css) &apos;Style Sheet&apos;;@namespace someexample &apos;http://css.example.org&apos;;@namespace &apos;http://example.com/test&apos;;@font-face{font-family:testFont;src:url(SomeFont.ttf),url(SomeFont_Italic.tff)}@keyframes test-keyframes{from{top:0} [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Css3Min {
            get {
                return ResourceManager.GetString("Css3Min", resourceCulture);
            }
        }
    }
}
