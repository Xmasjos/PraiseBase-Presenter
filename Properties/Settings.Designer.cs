﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pbp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string dataDirectory {
            get {
                return ((string)(this["dataDirectory"]));
            }
            set {
                this["dataDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Calibri, 60pt, style=Bold")]
        public global::System.Drawing.Font projectionMasterFont {
            get {
                return ((global::System.Drawing.Font)(this["projectionMasterFont"]));
            }
            set {
                this["projectionMasterFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color projectionBackColor {
            get {
                return ((global::System.Drawing.Color)(this["projectionBackColor"]));
            }
            set {
                this["projectionBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color projectionMasterFontColor {
            get {
                return ((global::System.Drawing.Color)(this["projectionMasterFontColor"]));
            }
            set {
                this["projectionMasterFontColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color projectionOutlineColor {
            get {
                return ((global::System.Drawing.Color)(this["projectionOutlineColor"]));
            }
            set {
                this["projectionOutlineColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool projectionFontScaling {
            get {
                return ((bool)(this["projectionFontScaling"]));
            }
            set {
                this["projectionFontScaling"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80")]
        public int projectionPadding {
            get {
                return ((int)(this["projectionPadding"]));
            }
            set {
                this["projectionPadding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Deutsch</string>
  <string>Englisch</string>
  <string>Französisch</string>
  <string>Italienisch</string>
  <string>Schweizerdeutsch</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection languages {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["languages"]));
            }
            set {
                this["languages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Lobpreis</string>
  <string>Anbetung</string>
  <string>Trost</string>
  <string>Hingabe</string>
  <string>Heiliger Geist</string>
  <string>Segen</string>
  <string>Dank</string>
  <string>Bitte</string>
  <string>Evangelisation</string>
  <string>Vertrauen</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection tags {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["tags"]));
            }
            set {
                this["tags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Refrain</string>
  <string>Strophe 1</string>
  <string>Strophe 2</string>
  <string>Strophe 3</string>
  <string>Teil 1</string>
  <string>Teil 2</string>
  <string>Teil 3</string>
  <string>Instrumentalteil</string>
  <string>Bridge</string>
  <string>Schluss</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection songParts {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["songParts"]));
            }
            set {
                this["songParts"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("songs")]
        public string songDir {
            get {
                return ((string)(this["songDir"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("backgrounds")]
        public string imageDir {
            get {
                return ((string)(this["imageDir"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Praisebase Presenter")]
        public string dataDirDefaultName {
            get {
                return ((string)(this["dataDirDefaultName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Calibri, 40pt, style=Bold")]
        public global::System.Drawing.Font projectionMasterFontTranslation {
            get {
                return ((global::System.Drawing.Font)(this["projectionMasterFontTranslation"]));
            }
            set {
                this["projectionMasterFontTranslation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int projectionMasterLineSpacing {
            get {
                return ((int)(this["projectionMasterLineSpacing"]));
            }
            set {
                this["projectionMasterLineSpacing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color projectionMasterTranslationColor {
            get {
                return ((global::System.Drawing.Color)(this["projectionMasterTranslationColor"]));
            }
            set {
                this["projectionMasterTranslationColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int settingsLastTabIndex {
            get {
                return ((int)(this["settingsLastTabIndex"]));
            }
            set {
                this["settingsLastTabIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color projectionShadowColor {
            get {
                return ((global::System.Drawing.Color)(this["projectionShadowColor"]));
            }
            set {
                this["projectionShadowColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int projectionOutlineSize {
            get {
                return ((int)(this["projectionOutlineSize"]));
            }
            set {
                this["projectionOutlineSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int projectionShadowSize {
            get {
                return ((int)(this["projectionShadowSize"]));
            }
            set {
                this["projectionShadowSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool projectionUseMaster {
            get {
                return ((bool)(this["projectionUseMaster"]));
            }
            set {
                this["projectionUseMaster"] = value;
            }
        }
    }
}
