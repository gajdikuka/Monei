﻿#pragma checksum "..\..\..\Views\RegistrationView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "14A1254CFEDFEF7065749F90C173E680"
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
using monei_project;
using monei_project.Rules;
using monei_project.ViewModels;


namespace monei_project.Views {
    
    
    /// <summary>
    /// RegistrationView
    /// </summary>
    public partial class RegistrationView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 84 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsername;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUsername;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pwdPassword;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPassword;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pwdPasswordConformation;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPasswordRepeat;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastName;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLastName;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtForename;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblForename;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSecurityQuestion;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSecurityQuestion;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAnswerToSecurityQuestion;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAnswerToSecutiryQuestion;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegistration;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\Views\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/monei project;component/views/registrationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\RegistrationView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.txtUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.lblUsername = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.pwdPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.lblPassword = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.pwdPasswordConformation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.lblPasswordRepeat = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.lblLastName = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.txtForename = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.lblForename = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.txtSecurityQuestion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.lblSecurityQuestion = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.txtAnswerToSecurityQuestion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.lblAnswerToSecutiryQuestion = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.btnRegistration = ((System.Windows.Controls.Button)(target));
            
            #line 154 "..\..\..\Views\RegistrationView.xaml"
            this.btnRegistration.Click += new System.Windows.RoutedEventHandler(this.register);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 155 "..\..\..\Views\RegistrationView.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.back);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

