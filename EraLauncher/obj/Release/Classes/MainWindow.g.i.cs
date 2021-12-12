﻿#pragma checksum "..\..\..\Classes\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B039D86A906D87F9B9F022755693C834B9B51D3F6E8319BA5CAEEC8A2B8EB9BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using EraLauncher;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace EraLauncher {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Classes\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ApplicationBackground;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Classes\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PageContent;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Classes\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel UpperPanel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Classes\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Classes\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Classes\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MainPage_Btn;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Classes\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Changelog_Btn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EraLauncher;component/classes/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Classes\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ApplicationBackground = ((System.Windows.Controls.Grid)(target));
            
            #line 9 "..\..\..\Classes\MainWindow.xaml"
            this.ApplicationBackground.MouseMove += new System.Windows.Input.MouseEventHandler(this.GridBG_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PageContent = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.UpperPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 4:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Classes\MainWindow.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.Close_Button_Event);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MinimizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Classes\MainWindow.xaml"
            this.MinimizeButton.Click += new System.Windows.RoutedEventHandler(this.Minimalize_Button_Event);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MainPage_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Classes\MainWindow.xaml"
            this.MainPage_Btn.Click += new System.Windows.RoutedEventHandler(this.MainPage_Btn_Event);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Changelog_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\Classes\MainWindow.xaml"
            this.Changelog_Btn.Click += new System.Windows.RoutedEventHandler(this.Changelog_Btn_Event);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
