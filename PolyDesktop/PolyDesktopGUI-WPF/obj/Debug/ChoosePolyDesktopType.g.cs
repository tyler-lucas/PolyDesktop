﻿#pragma checksum "..\..\ChoosePolyDesktopType.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "67E770D10AAC92A98B06F36AA9AC030BEC7865F15CCC18FD65F340D8B938676F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PolyDesktopGUI_WPF;
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


namespace PolyDesktopGUI_WPF {
    
    
    /// <summary>
    /// ChoosePolyDesktopType
    /// </summary>
    public partial class ChoosePolyDesktopType : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\ChoosePolyDesktopType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdMessageBox;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\ChoosePolyDesktopType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbMessageBoxMessage;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ChoosePolyDesktopType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BasicModeButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ChoosePolyDesktopType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TabModeButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ChoosePolyDesktopType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GroupModeButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PolyDesktopGUI-WPF;component/choosepolydesktoptype.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChoosePolyDesktopType.xaml"
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
            this.grdMessageBox = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.tbMessageBoxMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BasicModeButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\ChoosePolyDesktopType.xaml"
            this.BasicModeButton.Click += new System.Windows.RoutedEventHandler(this.BasicModeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TabModeButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.GroupModeButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

