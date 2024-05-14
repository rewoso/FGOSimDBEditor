using FGOSDBE.Core;
using FGOSDBE.Core.Mvvm;
using FGOSDBE.Models.SDBEModel;
using FGOSDBE.Modules.ModuleName.Models;
using FGOSDBE.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FGOSDBE.Modules.ModuleName.ViewModels
{
    public class ServantDBInputViewModel : RegionViewModelBase
    {
        public ReactiveCommand SelectCancelCommand { get; }
        public ReactiveCommand ReloadCommand { get; }
        public ReactiveCommand SelectEndCommand { get; }

        /// <summary>
        /// サーヴァントDBからコピペしたテキスト
        /// </summary>
        public ReactiveProperty<string> ServantDBText { get; }

        public string Target { get; set; }

        public ServantDBInputViewModel(IRegionManager regionManager, IDBEditorService dbeditorservice) : base(regionManager)
        {
            SelectCancelCommand = new ReactiveCommand();
            SelectCancelCommand.Subscribe(_ => SelectCancel());
            SelectEndCommand = new ReactiveCommand();
            SelectEndCommand.Subscribe(_ => SelectEnd());

            ServantDBText = new ReactiveProperty<string>("");

        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            if (navigationContext.Parameters.ContainsKey("Target"))
            {
                Target = (string)navigationContext.Parameters["Target"];
            }

            ServantDBText.Value = "";
        }

        private void SelectCancel()
        {
            RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(Views.ViewA));
        }

        private void SelectEnd()
        {
            // 入力されていない場合はNG
            if (ServantDBText.Value.Trim().Length == 0)
            {
                System.Windows.Forms.MessageBox.Show("テキストを入力してください");
                return;
            }

            var param = new NavigationParameters();
            param.Add("Target", Target);
            param.Add("ServantDBText", ServantDBText.Value);

            RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(Views.ViewA), param);
        }

    }
}
