﻿

#pragma checksum "C:\Users\Morgan\Source\Workspaces\BetaSeries W8 - Copie\BetaSeriesW8\Rechercher.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "63513E5B6DF325B8429974056CF83605"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetaSeriesW8
{
    partial class Rechercher : global::BetaSeriesW8.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 42 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click_1;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 30 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click_1;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 31 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click_2;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 32 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click_3;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 33 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click_4;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 50 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.AppBar)(target)).Closed += this.GlobalAppBar_Closed_1;
                 #line default
                 #line hidden
                #line 50 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.AppBar)(target)).Opened += this.GlobalAppBar_Opened_1;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 58 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.FilterBy_OnClick;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 173 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.Filter_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 182 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.resultsGridView_ItemClick_1;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 158 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.FilterBySerieName_OnClick;
                 #line default
                 #line hidden
                break;
            case 11:
                #line 126 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.resultsGridView_ItemClick_1;
                 #line default
                 #line hidden
                break;
            case 12:
                #line 137 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Media.Imaging.BitmapImage)(target)).ImageFailed += this.BitmapImage_OnImageFailed;
                 #line default
                 #line hidden
                break;
            case 13:
                #line 107 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.Filter_Checked;
                 #line default
                 #line hidden
                break;
            case 14:
                #line 78 "..\..\Rechercher.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


