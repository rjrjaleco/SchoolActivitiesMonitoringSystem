﻿#pragma checksum "..\..\ToDoListHistoryWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "12F12E2DFE8A5AFBFFC03643DD3F8DCB"
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


namespace I_Need_That_A {
    
    
    /// <summary>
    /// ToDoListHistoryWindow
    /// </summary>
    public partial class ToDoListHistoryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\ToDoListHistoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClear;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ToDoListHistoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LbListSemester;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\ToDoListHistoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MIUrgency;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\ToDoListHistoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MIUrgencyDescend;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\ToDoListHistoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MIImportance;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\ToDoListHistoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MIImportanceDescend;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\ToDoListHistoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReturn;
        
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
            System.Uri resourceLocater = new System.Uri("/I Need That A;component/todolisthistorywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ToDoListHistoryWindow.xaml"
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
            this.BtnClear = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\ToDoListHistoryWindow.xaml"
            this.BtnClear.Click += new System.Windows.RoutedEventHandler(this.BtnClear_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LbListSemester = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.MIUrgency = ((System.Windows.Controls.MenuItem)(target));
            
            #line 170 "..\..\ToDoListHistoryWindow.xaml"
            this.MIUrgency.Click += new System.Windows.RoutedEventHandler(this.MIUrgency_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MIUrgencyDescend = ((System.Windows.Controls.MenuItem)(target));
            
            #line 171 "..\..\ToDoListHistoryWindow.xaml"
            this.MIUrgencyDescend.Click += new System.Windows.RoutedEventHandler(this.MIUrgencyDescend_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MIImportance = ((System.Windows.Controls.MenuItem)(target));
            
            #line 172 "..\..\ToDoListHistoryWindow.xaml"
            this.MIImportance.Click += new System.Windows.RoutedEventHandler(this.MIImportance_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MIImportanceDescend = ((System.Windows.Controls.MenuItem)(target));
            
            #line 173 "..\..\ToDoListHistoryWindow.xaml"
            this.MIImportanceDescend.Click += new System.Windows.RoutedEventHandler(this.MIImportanceDescend_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnReturn = ((System.Windows.Controls.Button)(target));
            
            #line 189 "..\..\ToDoListHistoryWindow.xaml"
            this.BtnReturn.Click += new System.Windows.RoutedEventHandler(this.BtnReturn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

