﻿#pragma checksum "..\..\..\Views\EditProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A6840BC864E154892AA721160E34E834409B2AB9BB106E41905DA80EB83D6F7F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace VideoGamesStore.Views {
    
    
    /// <summary>
    /// EditProduct
    /// </summary>
    public partial class EditProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Views\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backToCatalog;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleTextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox developerComboBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox categoryComboBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DiscountTextBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image editProductImage;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Views\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenDialogButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\EditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveEditForm;
        
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
            System.Uri resourceLocater = new System.Uri("/VideoGamesStore;component/views/editproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\EditProduct.xaml"
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
            this.backToCatalog = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Views\EditProduct.xaml"
            this.backToCatalog.Click += new System.Windows.RoutedEventHandler(this.BackToCatalog);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TitleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.developerComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\..\Views\EditProduct.xaml"
            this.developerComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LoadDevelopersIntoComboBox);
            
            #line default
            #line hidden
            return;
            case 4:
            this.categoryComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\..\Views\EditProduct.xaml"
            this.categoryComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LoadCategoryIntoComboBox);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DiscountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.DescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.editProductImage = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.OpenDialogButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Views\EditProduct.xaml"
            this.OpenDialogButton.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenDialog);
            
            #line default
            #line hidden
            return;
            case 10:
            this.saveEditForm = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Views\EditProduct.xaml"
            this.saveEditForm.Click += new System.Windows.RoutedEventHandler(this.SaveEditForm);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

