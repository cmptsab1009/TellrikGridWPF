﻿#pragma checksum "..\..\..\Window1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "692E6BC8A4A1FFC3D1E437C4095ED1F3603128EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Animation;
using Telerik.Windows.Controls.Behaviors;
using Telerik.Windows.Controls.DragDrop;
using Telerik.Windows.Controls.GridView;
using Telerik.Windows.Controls.Legend;
using Telerik.Windows.Controls.MultiColumnComboBox;
using Telerik.Windows.Controls.Primitives;
using Telerik.Windows.Controls.TransitionEffects;
using Telerik.Windows.Controls.TreeListView;
using Telerik.Windows.Data;
using Telerik.Windows.DragDrop;
using Telerik.Windows.DragDrop.Behaviors;
using Telerik.Windows.Input.Touch;
using Telerik.Windows.Shapes;
using TelerikWpfApp1;


namespace TelerikWpfApp1 {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadGridView playersGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/TelerikWpfApp1;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window1.xaml"
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
            this.playersGrid = ((Telerik.Windows.Controls.RadGridView)(target));
            
            #line 15 "..\..\..\Window1.xaml"
            this.playersGrid.FilterOperatorsLoading += new System.EventHandler<Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs>(this.playersGrid_FilterOperatorsLoading);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

