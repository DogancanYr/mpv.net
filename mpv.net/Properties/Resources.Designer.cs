﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mpvnet.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("mpvnet.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to 
        ///[[settings]]
        ///name = &quot;hwdec&quot;
        ///file = &quot;mpv&quot;
        ///default = &quot;no&quot;
        ///filter = &quot;Video&quot;
        ///url = &quot;https://mpv.io/manual/master/#options-hwdec&quot;
        ///help = &quot;Specify the hardware video decoding API that should be used if possible. Whether hardware decoding is actually done depends on the video codec. If hardware decoding is not possible, mpv will fall back on software decoding.\n\nFor more information visit:&quot;
        ///options = [{ name = &quot;no&quot;,           help = &quot;always use software decoding&quot; },
        ///           { name = &quot;auto&quot;,         h [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string editor_toml {
            get {
                return ResourceManager.GetString("editor_toml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        /// # This file defines the key and mouse bindings and the context menu
        /// # of mpv.net. A input and config editor can be found in mpv.nets
        /// # context menu under &apos;Settings&apos;. The defaults of this file can be found at:
        ///
        /// # https://github.com/stax76/mpv.net/blob/master/mpv.net/Resources/inputConf.txt
        ///
        /// # The defaults of mpv can be found at:
        ///
        /// # https://github.com/mpv-player/mpv/blob/master/etc/input.conf
        ///
        /// # mpv.net&apos;s defaults of mpv.conf contain: &apos;input-default-bindings = no&apos;
        /// # which disables mpv&apos;s i [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string input_conf {
            get {
                return ResourceManager.GetString("input_conf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///input-default-bindings = no
        ///input-ar-delay = 500
        ///input-ar-rate = 20
        ///keep-open = yes
        ///keep-open-pause = no
        ///osd-duration = 2000
        ///osd-playing-msg = &apos;${filename}&apos;
        ///script-opts = osc-scalewindowed=1.5,osc-hidetimeout=2000,console-scale=1
        ///screenshot-directory = &apos;~~desktop/&apos;
        ///hwdec = yes
        ///
        ///[protocol.https]
        ///osd-playing-msg = &apos;${media-title}&apos;
        ///.
        /// </summary>
        internal static string mpv_conf {
            get {
                return ResourceManager.GetString("mpv_conf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap mpvnet {
            get {
                object obj = ResourceManager.GetObject("mpvnet", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///[dark]
        ///
        ///heading     = #3C8CC8
        ///foreground  = #DDDDDD
        ///foreground2 = #AAAAAA
        ///background  = #323232
        ///
        ///menu-foreground = #DDDDDD
        ///menu-background = #323232
        ///menu-highlight  = #505050
        ///menu-border     = #FFFFFF
        ///menu-checked    = #5A5A5A
        ///
        ///
        ///[light]
        ///
        ///heading     = #0068B2
        ///foreground  = #000000
        ///foreground2 = #4C4C4C
        ///background  = #F7F7F7
        ///
        ///menu-foreground = #000000
        ///menu-background = #DFDFDF
        ///menu-highlight  = #BFBFBF
        ///menu-border     = #6A6A6A
        ///menu-checked    = #AAAAAA
        ///.
        /// </summary>
        internal static string theme {
            get {
                return ResourceManager.GetString("theme", resourceCulture);
            }
        }
    }
}
