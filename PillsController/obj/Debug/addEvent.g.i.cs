﻿#pragma checksum "..\..\addEvent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8FEE7B2A4B8297EA309722D5733B8329A7254F024B8B9F4FA1E2B7D9ED757DB3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PillsController;
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


namespace PillsController {
    
    
    /// <summary>
    /// addEvent
    /// </summary>
    public partial class addEvent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\addEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label typeName;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\addEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox typeNameBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\addEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label chooseQuantity;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\addEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox quontityPerDayCB;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\addEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label choosePeriodTXT;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\addEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DurationBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\addEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\addEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\addEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image2;
        
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
            System.Uri resourceLocater = new System.Uri("/PillsController;component/addevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\addEvent.xaml"
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
            this.typeName = ((System.Windows.Controls.Label)(target));
            
            #line 10 "..\..\addEvent.xaml"
            this.typeName.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TypeName_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.typeNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.chooseQuantity = ((System.Windows.Controls.Label)(target));
            
            #line 12 "..\..\addEvent.xaml"
            this.chooseQuantity.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ChooseQuantity_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.quontityPerDayCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.choosePeriodTXT = ((System.Windows.Controls.Label)(target));
            
            #line 18 "..\..\addEvent.xaml"
            this.choosePeriodTXT.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ChoosePeriodTXT_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DurationBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.image1 = ((System.Windows.Controls.Image)(target));
            
            #line 21 "..\..\addEvent.xaml"
            this.image1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Confirm);
            
            #line default
            #line hidden
            return;
            case 9:
            this.image2 = ((System.Windows.Controls.Image)(target));
            
            #line 22 "..\..\addEvent.xaml"
            this.image2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image2_OnMouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

