﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PraiseBase.Presenter.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DataDirectory {
            get {
                return ((string)(this["DataDirectory"]));
            }
            set {
                this["DataDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Calibri, 50.25pt, style=Bold")]
        public global::System.Drawing.Font ProjectionMasterFont {
            get {
                return ((global::System.Drawing.Font)(this["ProjectionMasterFont"]));
            }
            set {
                this["ProjectionMasterFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color ProjectionBackColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionBackColor"]));
            }
            set {
                this["ProjectionBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color ProjectionMasterFontColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionMasterFontColor"]));
            }
            set {
                this["ProjectionMasterFontColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color ProjectionMasterOutlineColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionMasterOutlineColor"]));
            }
            set {
                this["ProjectionMasterOutlineColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ProjectionFontScaling {
            get {
                return ((bool)(this["ProjectionFontScaling"]));
            }
            set {
                this["ProjectionFontScaling"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80")]
        public int ProjectionMasterHorizontalTextPadding {
            get {
                return ((int)(this["ProjectionMasterHorizontalTextPadding"]));
            }
            set {
                this["ProjectionMasterHorizontalTextPadding"] = value;
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
        public global::System.Collections.Specialized.StringCollection Languages {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Languages"]));
            }
            set {
                this["Languages"] = value;
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
        public global::System.Collections.Specialized.StringCollection Tags {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Tags"]));
            }
            set {
                this["Tags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Refrain</string>
  <string>Pre-Chorus</string>
  <string>Chorus</string>
  <string>Strophe 1</string>
  <string>Strophe 2</string>
  <string>Strophe 3</string>
  <string>Teil 1</string>
  <string>Teil 2</string>
  <string>Teil 3</string>
  <string>Instrumental</string>
  <string>Bridge</string>
  <string>Schluss</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SongParts {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SongParts"]));
            }
            set {
                this["SongParts"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Songs")]
        public string SongDir {
            get {
                return ((string)(this["SongDir"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Backgrounds")]
        public string ImageDir {
            get {
                return ((string)(this["ImageDir"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PraiseBase Presenter")]
        public string DataDirDefaultName {
            get {
                return ((string)(this["DataDirDefaultName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Calibri, 30pt, style=Italic")]
        public global::System.Drawing.Font ProjectionMasterFontTranslation {
            get {
                return ((global::System.Drawing.Font)(this["ProjectionMasterFontTranslation"]));
            }
            set {
                this["ProjectionMasterFontTranslation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ProjectionMasterLineSpacing {
            get {
                return ((int)(this["ProjectionMasterLineSpacing"]));
            }
            set {
                this["ProjectionMasterLineSpacing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color ProjectionMasterTranslationColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionMasterTranslationColor"]));
            }
            set {
                this["ProjectionMasterTranslationColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SettingsLastTabIndex {
            get {
                return ((int)(this["SettingsLastTabIndex"]));
            }
            set {
                this["SettingsLastTabIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color ProjectionMasterShadowColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionMasterShadowColor"]));
            }
            set {
                this["ProjectionMasterShadowColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ProjectionMasterOutlineSize {
            get {
                return ((int)(this["ProjectionMasterOutlineSize"]));
            }
            set {
                this["ProjectionMasterOutlineSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int ProjectionMasterShadowDistance {
            get {
                return ((int)(this["ProjectionMasterShadowDistance"]));
            }
            set {
                this["ProjectionMasterShadowDistance"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ProjectionUseMaster {
            get {
                return ((bool)(this["ProjectionUseMaster"]));
            }
            set {
                this["ProjectionUseMaster"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState ViewerWindowState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["ViewerWindowState"]));
            }
            set {
                this["ViewerWindowState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState EditorWindowState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["EditorWindowState"]));
            }
            set {
                this["EditorWindowState"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://praisebase.org")]
        public string Weburl {
            get {
                return ((string)(this["Weburl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Setlists")]
        public string SetListDir {
            get {
                return ((string)(this["SetListDir"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int ProjectionFadeTime {
            get {
                return ((int)(this["ProjectionFadeTime"]));
            }
            set {
                this["ProjectionFadeTime"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/PraiseBase-Presenter/PraiseBase-Presenter/issues/new")]
        public string BugReportUrl {
            get {
                return ((string)(this["BugReportUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80, 60")]
        public global::System.Drawing.Size ThumbSize {
            get {
                return ((global::System.Drawing.Size)(this["ThumbSize"]));
            }
            set {
                this["ThumbSize"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Thumbs")]
        public string ThumbDir {
            get {
                return ((string)(this["ThumbDir"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowLoadingScreen {
            get {
                return ((bool)(this["ShowLoadingScreen"]));
            }
            set {
                this["ShowLoadingScreen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LinkLayers {
            get {
                return ((bool)(this["LinkLayers"]));
            }
            set {
                this["LinkLayers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.ArrayList ImageFavorites {
            get {
                return ((global::System.Collections.ArrayList)(this["ImageFavorites"]));
            }
            set {
                this["ImageFavorites"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://praisebase.org/dokumentation")]
        public string HelpUrl {
            get {
                return ((string)(this["HelpUrl"]));
            }
            set {
                this["HelpUrl"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://praisebase.org/ws/version.xml")]
        public string UpdateCheckUrl {
            get {
                return ((string)(this["UpdateCheckUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TitleAndText")]
        public global::PraiseBase.Presenter.Manager.SongSearchMode SongSearchMode {
            get {
                return ((global::PraiseBase.Presenter.Manager.SongSearchMode)(this["SongSearchMode"]));
            }
            set {
                this["SongSearchMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int ProjectionFadeTimeLayer1 {
            get {
                return ((int)(this["ProjectionFadeTimeLayer1"]));
            }
            set {
                this["ProjectionFadeTimeLayer1"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Neues Lied")]
        public string SongDefaultName {
            get {
                return ((string)(this["SongDefaultName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Deutsch")]
        public string SongDefaultLanguage {
            get {
                return ((string)(this["SongDefaultLanguage"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Teil 1")]
        public string SongPartDefaultName {
            get {
                return ((string)(this["SongPartDefaultName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int SelectedProjectionScreen {
            get {
                return ((int)(this["SelectedProjectionScreen"]));
            }
            set {
                this["SelectedProjectionScreen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HideUpdateVersion {
            get {
                return ((string)(this["HideUpdateVersion"]));
            }
            set {
                this["HideUpdateVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("de-CH")]
        public string SelectedCulture {
            get {
                return ((string)(this["SelectedCulture"]));
            }
            set {
                this["SelectedCulture"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("displayswitch.exe")]
        public string DisplaySwitchCommand {
            get {
                return ((string)(this["DisplaySwitchCommand"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("desk.cpl,@0,4")]
        public string DisplayControlCommand {
            get {
                return ((string)(this["DisplayControlCommand"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("control")]
        public string SystemControlCommand {
            get {
                return ((string)(this["SystemControlCommand"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1024, 768")]
        public global::System.Drawing.Size MainWindowSize {
            get {
                return ((global::System.Drawing.Size)(this["MainWindowSize"]));
            }
            set {
                this["MainWindowSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1024, 768")]
        public global::System.Drawing.Size EditorWindowSize {
            get {
                return ((global::System.Drawing.Size)(this["EditorWindowSize"]));
            }
            set {
                this["EditorWindowSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Calibri, 24pt")]
        public global::System.Drawing.Font ProjectionMasterCopyrightFont {
            get {
                return ((global::System.Drawing.Font)(this["ProjectionMasterCopyrightFont"]));
            }
            set {
                this["ProjectionMasterCopyrightFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Calibri, 36pt")]
        public global::System.Drawing.Font ProjectionMasterSourceFont {
            get {
                return ((global::System.Drawing.Font)(this["ProjectionMasterSourceFont"]));
            }
            set {
                this["ProjectionMasterSourceFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color ProjectionMasterCopyrightColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionMasterCopyrightColor"]));
            }
            set {
                this["ProjectionMasterCopyrightColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color ProjectionMasterSourceColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionMasterSourceColor"]));
            }
            set {
                this["ProjectionMasterSourceColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ProjectionMasterTranslationLineSpacing {
            get {
                return ((int)(this["ProjectionMasterTranslationLineSpacing"]));
            }
            set {
                this["ProjectionMasterTranslationLineSpacing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("135")]
        public int ProjectionMasterShadowDirection {
            get {
                return ((int)(this["ProjectionMasterShadowDirection"]));
            }
            set {
                this["ProjectionMasterShadowDirection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ProjectionMasterOutlineEnabled {
            get {
                return ((bool)(this["ProjectionMasterOutlineEnabled"]));
            }
            set {
                this["ProjectionMasterOutlineEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ProjectionMasterShadowEnabled {
            get {
                return ((bool)(this["ProjectionMasterShadowEnabled"]));
            }
            set {
                this["ProjectionMasterShadowEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80")]
        public int ProjectionMasterVerticalTextPadding {
            get {
                return ((int)(this["ProjectionMasterVerticalTextPadding"]));
            }
            set {
                this["ProjectionMasterVerticalTextPadding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int ProjectionMasterHorizontalHeaderPadding {
            get {
                return ((int)(this["ProjectionMasterHorizontalHeaderPadding"]));
            }
            set {
                this["ProjectionMasterHorizontalHeaderPadding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        public int ProjectionMasterVerticalHeaderPadding {
            get {
                return ((int)(this["ProjectionMasterVerticalHeaderPadding"]));
            }
            set {
                this["ProjectionMasterVerticalHeaderPadding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int ProjectionMasterHorizontalFooterPadding {
            get {
                return ((int)(this["ProjectionMasterHorizontalFooterPadding"]));
            }
            set {
                this["ProjectionMasterHorizontalFooterPadding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        public int ProjectionMasterVerticalFooterPadding {
            get {
                return ((int)(this["ProjectionMasterVerticalFooterPadding"]));
            }
            set {
                this["ProjectionMasterVerticalFooterPadding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Center")]
        public global::PraiseBase.Presenter.Model.HorizontalOrientation ProjectionMasterHorizontalTextOrientation {
            get {
                return ((global::PraiseBase.Presenter.Model.HorizontalOrientation)(this["ProjectionMasterHorizontalTextOrientation"]));
            }
            set {
                this["ProjectionMasterHorizontalTextOrientation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Middle")]
        public global::PraiseBase.Presenter.Model.VerticalOrientation ProjectionMasterVerticalTextOrientation {
            get {
                return ((global::PraiseBase.Presenter.Model.VerticalOrientation)(this["ProjectionMasterVerticalTextOrientation"]));
            }
            set {
                this["ProjectionMasterVerticalTextOrientation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Right")]
        public global::PraiseBase.Presenter.Model.HorizontalOrientation ProjectionMasterHorizontalHeaderOrientation {
            get {
                return ((global::PraiseBase.Presenter.Model.HorizontalOrientation)(this["ProjectionMasterHorizontalHeaderOrientation"]));
            }
            set {
                this["ProjectionMasterHorizontalHeaderOrientation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Left")]
        public global::PraiseBase.Presenter.Model.HorizontalOrientation ProjectionMasterHorizontalFooterOrientation {
            get {
                return ((global::PraiseBase.Presenter.Model.HorizontalOrientation)(this["ProjectionMasterHorizontalFooterOrientation"]));
            }
            set {
                this["ProjectionMasterHorizontalFooterOrientation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ProjectionMasterShadowSize {
            get {
                return ((int)(this["ProjectionMasterShadowSize"]));
            }
            set {
                this["ProjectionMasterShadowSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("LastSlide")]
        public global::PraiseBase.Presenter.Model.AdditionalInformationPosition ProjectionMasterCopyrightPosition {
            get {
                return ((global::PraiseBase.Presenter.Model.AdditionalInformationPosition)(this["ProjectionMasterCopyrightPosition"]));
            }
            set {
                this["ProjectionMasterCopyrightPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FirstSlide")]
        public global::PraiseBase.Presenter.Model.AdditionalInformationPosition ProjectionMasterSourcePosition {
            get {
                return ((global::PraiseBase.Presenter.Model.AdditionalInformationPosition)(this["ProjectionMasterSourcePosition"]));
            }
            set {
                this["ProjectionMasterSourcePosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Inline")]
        public global::PraiseBase.Presenter.Model.TranslationPosition ProjectionMasteTranslationPosition {
            get {
                return ((global::PraiseBase.Presenter.Model.TranslationPosition)(this["ProjectionMasteTranslationPosition"]));
            }
            set {
                this["ProjectionMasteTranslationPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ProjectionSmoothShadow {
            get {
                return ((bool)(this["ProjectionSmoothShadow"]));
            }
            set {
                this["ProjectionSmoothShadow"] = value;
            }
        }
    }
}
