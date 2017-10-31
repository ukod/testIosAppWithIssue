using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using testapp.Core.ViewModels;

namespace testapp.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class MainView : MvxTabBarViewController<MainViewModel>
    {
        public MainView(IntPtr pointer) : base(pointer)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<MainView, Core.ViewModels.MainViewModel>();
            set.Bind(TextField).To(vm => vm.Text);
            set.Bind(Button).To(vm => vm.ResetTextCommand);
            set.Apply();
        }
    }
}
