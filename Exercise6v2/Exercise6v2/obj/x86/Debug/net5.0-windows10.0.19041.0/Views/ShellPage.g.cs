﻿#pragma checksum "C:\Users\Ando\source\repos\Exercise6v2\Exercise6v2\Views\ShellPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "84333C9D212079CA169045D4921F6AC9A146E4668EBB55E90602E0127AF401ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using WinRT;

namespace Exercise6v2.Views
{
    partial class ShellPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_NavigationView_IsBackEnabled(global::Microsoft.UI.Xaml.Controls.NavigationView obj, global::System.Boolean value)
            {
                obj.IsBackEnabled = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_NavigationView_SelectedItem(global::Microsoft.UI.Xaml.Controls.NavigationView obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_NavigationView_Header(global::Microsoft.UI.Xaml.Controls.NavigationView obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Header = value;
            }
            public static void Set_Exercise6v2_Behaviors_NavigationViewHeaderBehavior_DefaultHeader(global::Exercise6v2.Behaviors.NavigationViewHeaderBehavior obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.DefaultHeader = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ShellPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IShellPage_Bindings
        {
            private global::Exercise6v2.Views.ShellPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.NavigationView obj2;
            private global::Exercise6v2.Behaviors.NavigationViewHeaderBehavior obj4;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2IsBackEnabledDisabled = false;
            private static bool isobj2SelectedItemDisabled = false;
            private static bool isobj2HeaderDisabled = false;
            private static bool isobj4DefaultHeaderDisabled = false;

            private ShellPage_obj1_BindingsTracking bindingsTracking;

            public ShellPage_obj1_Bindings()
            {
                this.bindingsTracking = new ShellPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 16 && columnNumber == 9)
                {
                    isobj2IsBackEnabledDisabled = true;
                }
                else if (lineNumber == 17 && columnNumber == 9)
                {
                    isobj2SelectedItemDisabled = true;
                }
                else if (lineNumber == 20 && columnNumber == 9)
                {
                    isobj2HeaderDisabled = true;
                }
                else if (lineNumber == 44 && columnNumber == 17)
                {
                    isobj4DefaultHeaderDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\ShellPage.xaml line 13
                        this.obj2 = target.As<Microsoft.UI.Xaml.Controls.NavigationView>();
                        break;
                    case 4: // Views\ShellPage.xaml line 43
                        this.obj4 = target.As<Exercise6v2.Behaviors.NavigationViewHeaderBehavior>();
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
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

            // IShellPage_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = newDataRoot.As<Exercise6v2.Views.ShellPage>();
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Exercise6v2.Views.ShellPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Exercise6v2.ViewModels.ShellViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_IsBackEnabled(obj.IsBackEnabled, phase);
                        this.Update_ViewModel_Selected(obj.Selected, phase);
                    }
                }
            }
            private void Update_ViewModel_IsBackEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ShellPage.xaml line 13
                    if (!isobj2IsBackEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_NavigationView_IsBackEnabled(this.obj2, obj);
                    }
                }
            }
            private void Update_ViewModel_Selected(global::System.Object obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Selected_Cast_Selected_To_ContentControl((global::Microsoft.UI.Xaml.Controls.ContentControl)obj, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ShellPage.xaml line 13
                    if (!isobj2SelectedItemDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_NavigationView_SelectedItem(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Selected_Cast_Selected_To_ContentControl(global::Microsoft.UI.Xaml.Controls.ContentControl obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Selected_Cast_Selected_To_ContentControl(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Selected_Cast_Selected_To_ContentControl_Content(obj.Content, phase);
                    }
                }
            }
            private void Update_ViewModel_Selected_Cast_Selected_To_ContentControl_Content(global::System.Object obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ShellPage.xaml line 13
                    if (!isobj2HeaderDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_NavigationView_Header(this.obj2, obj, null);
                    }
                    // Views\ShellPage.xaml line 43
                    if (!isobj4DefaultHeaderDisabled)
                    {
                        XamlBindingSetters.Set_Exercise6v2_Behaviors_NavigationViewHeaderBehavior_DefaultHeader(this.obj4, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ShellPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ShellPage_obj1_Bindings> weakRefToBindingObj; 

                public ShellPage_obj1_BindingsTracking(ShellPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ShellPage_obj1_Bindings>(obj);
                }

                public ShellPage_obj1_Bindings TryGetBindingObject()
                {
                    ShellPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_Selected_Cast_Selected_To_ContentControl(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ShellPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Exercise6v2.ViewModels.ShellViewModel obj = sender as global::Exercise6v2.ViewModels.ShellViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_IsBackEnabled(obj.IsBackEnabled, DATA_CHANGED);
                                bindings.Update_ViewModel_Selected(obj.Selected, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsBackEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsBackEnabled(obj.IsBackEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Selected":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Selected(obj.Selected, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Exercise6v2.ViewModels.ShellViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::Exercise6v2.ViewModels.ShellViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void DependencyPropertyChanged_ViewModel_Selected_Cast_Selected_To_ContentControl_Content(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    ShellPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.ContentControl obj = sender as global::Microsoft.UI.Xaml.Controls.ContentControl;
                        if (obj != null)
                        {
                            bindings.Update_ViewModel_Selected_Cast_Selected_To_ContentControl_Content(obj.Content, DATA_CHANGED);
                        }
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.ContentControl cache_ViewModel_Selected_Cast_Selected_To_ContentControl = null;
                private long tokenDPC_ViewModel_Selected_Cast_Selected_To_ContentControl_Content = 0;
                public void UpdateChildListeners_ViewModel_Selected_Cast_Selected_To_ContentControl(global::Microsoft.UI.Xaml.Controls.ContentControl obj)
                {
                    if (obj != cache_ViewModel_Selected_Cast_Selected_To_ContentControl)
                    {
                        if (cache_ViewModel_Selected_Cast_Selected_To_ContentControl != null)
                        {
                            cache_ViewModel_Selected_Cast_Selected_To_ContentControl.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ContentControl.ContentProperty, tokenDPC_ViewModel_Selected_Cast_Selected_To_ContentControl_Content);
                            cache_ViewModel_Selected_Cast_Selected_To_ContentControl = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_Selected_Cast_Selected_To_ContentControl = obj;
                            tokenDPC_ViewModel_Selected_Cast_Selected_To_ContentControl_Content = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ContentControl.ContentProperty, DependencyPropertyChanged_ViewModel_Selected_Cast_Selected_To_ContentControl_Content);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\ShellPage.xaml line 1
                {
                    global::Microsoft.UI.Xaml.Controls.Page element1 = target.As<Microsoft.UI.Xaml.Controls.Page>();
                    ((global::Microsoft.UI.Xaml.Controls.Page)element1).Loaded += this.OnLoaded;
                }
                break;
            case 2: // Views\ShellPage.xaml line 13
                {
                    this.navigationView = target.As<Microsoft.UI.Xaml.Controls.NavigationView>();
                }
                break;
            case 6: // Views\ShellPage.xaml line 58
                {
                    this.shellFrame = target.As<Microsoft.UI.Xaml.Controls.Frame>();
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\ShellPage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    ShellPage_obj1_Bindings bindings = new ShellPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

