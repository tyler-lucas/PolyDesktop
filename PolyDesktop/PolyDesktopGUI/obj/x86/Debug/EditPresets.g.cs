﻿#pragma checksum "C:\Users\lucas\Documents\PolyDesktop\PolyDesktop\PolyDesktopGUI\EditPresets.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "66F9799C8513C2E98A9567B970E4207E1827A4FB47D1938F30E7D3AF5005B771"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PolyDesktopGUI
{
    partial class EditPresets : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class EditPresets_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IEditPresets_Bindings
        {
            private global::PolyDesktopGUI.EditPresets dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj3;
            private global::Windows.UI.Xaml.Controls.ListView obj7;
            private global::Windows.UI.Xaml.Controls.ListView obj16;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3ItemsSourceDisabled = false;
            private static bool isobj7ItemsSourceDisabled = false;
            private static bool isobj16ItemsSourceDisabled = false;

            public EditPresets_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 16 && columnNumber == 62)
                {
                    isobj3ItemsSourceDisabled = true;
                }
                else if (lineNumber == 27 && columnNumber == 159)
                {
                    isobj7ItemsSourceDisabled = true;
                }
                else if (lineNumber == 51 && columnNumber == 138)
                {
                    isobj16ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // EditPresets.xaml line 16
                        this.obj3 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 7: // EditPresets.xaml line 27
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 16: // EditPresets.xaml line 51
                        this.obj16 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IEditPresets_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::PolyDesktopGUI.EditPresets)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::PolyDesktopGUI.EditPresets obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Presets(obj.Presets, phase);
                        this.Update_Computers(obj.Computers, phase);
                        this.Update_AllComputers(obj.AllComputers, phase);
                    }
                }
            }
            private void Update_Presets(global::PolyDesktopGUI.Preset[] obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // EditPresets.xaml line 16
                    if (!isobj3ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj3, obj, null);
                    }
                }
            }
            private void Update_Computers(global::PolyDesktopGUI.Computer[] obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // EditPresets.xaml line 27
                    if (!isobj7ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                    }
                }
            }
            private void Update_AllComputers(global::PolyDesktopGUI.Computer[] obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // EditPresets.xaml line 51
                    if (!isobj16ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj16, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // EditPresets.xaml line 13
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
                }
                break;
            case 3: // EditPresets.xaml line 16
                {
                    this.PresetList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.PresetList).SelectionChanged += this.ListView_SelectionChanged;
                }
                break;
            case 4: // EditPresets.xaml line 17
                {
                    this.ModeBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.ModeBox).SelectionChanged += this.ModeBox_SelectionChanged;
                }
                break;
            case 5: // EditPresets.xaml line 23
                {
                    this.PresetSaveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PresetSaveButton).Click += this.PresetSaveButton_Click;
                }
                break;
            case 6: // EditPresets.xaml line 24
                {
                    this.NameBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // EditPresets.xaml line 27
                {
                    this.ComputerTable = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ComputerTable).SelectionChanged += this.ComputerTable_SelectionChanged;
                }
                break;
            case 8: // EditPresets.xaml line 45
                {
                    this.TestButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TestButton).Click += this.TestButton_Click;
                }
                break;
            case 9: // EditPresets.xaml line 46
                {
                    this.AddComputerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AddComputerButton).Click += this.AddComputerButton_Click;
                }
                break;
            case 10: // EditPresets.xaml line 56
                {
                    this.NumberOfComputersLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // EditPresets.xaml line 57
                {
                    this.NumBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // EditPresets.xaml line 58
                {
                    this.DeletePresetButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DeletePresetButton).Click += this.DeletePresetButton_Click;
                }
                break;
            case 13: // EditPresets.xaml line 63
                {
                    this.FlyoutDeletePresetButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.FlyoutDeletePresetButton).Click += this.FlyoutDeletePresetButton_Click;
                }
                break;
            case 14: // EditPresets.xaml line 48
                {
                    this.AddComputerFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 15: // EditPresets.xaml line 50
                {
                    this.search = (global::Windows.UI.Xaml.Controls.SearchBox)(target);
                    ((global::Windows.UI.Xaml.Controls.SearchBox)this.search).QueryChanged += this.search_QueryChanged;
                }
                break;
            case 16: // EditPresets.xaml line 51
                {
                    this.SearchListBox = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.SearchListBox).SelectionChanged += this.SearchListBox_SelectionChanged;
                }
                break;
            case 17: // EditPresets.xaml line 32
                {
                    this.FlyoutIDBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // EditPresets.xaml line 34
                {
                    this.FlyoutNameBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // EditPresets.xaml line 36
                {
                    this.FlyoutNicknameBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20: // EditPresets.xaml line 38
                {
                    this.NicknameChangeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.NicknameChangeButton).Click += this.NicknameChangeButton_Click;
                }
                break;
            case 21: // EditPresets.xaml line 39
                {
                    this.RemoveComputerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.RemoveComputerButton).Click += this.RemoveComputerButton_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // EditPresets.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    EditPresets_obj1_Bindings bindings = new EditPresets_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
