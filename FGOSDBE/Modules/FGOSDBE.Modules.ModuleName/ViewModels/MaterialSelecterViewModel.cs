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
    public class MaterialSelecterViewModel : RegionViewModelBase
    {
        public ReactiveCommand SelectCancelCommand { get; }
        public ReactiveCommand ReloadCommand { get; }
        public ReactiveCommand SelectEndCommand { get; }

        public ReactiveProperty<List<MaterialModel>> MaterialList { get; }

        public string Target { get; set; }
        public string Type { get; set; }

        public List<UseMaterialModel> SelectedMaterial { get; set; }

        public MaterialSelecterViewModel(IRegionManager regionManager, IDBEditorService dbeditorservice) : base(regionManager)
        {
            SelectCancelCommand = new ReactiveCommand();
            SelectCancelCommand.Subscribe(_ => SelectCancel());
            ReloadCommand = new ReactiveCommand();
            ReloadCommand.Subscribe(_ => SelectCancel());
            SelectEndCommand = new ReactiveCommand();
            SelectEndCommand.Subscribe(_ => SelectEnd());

            MaterialList = new ReactiveProperty<List<MaterialModel>>();
            MaterialList.Value = new List<MaterialModel>();
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            if (navigationContext.Parameters.ContainsKey("Target"))
            {
                Target = (string)navigationContext.Parameters["Target"];
            }

            if (navigationContext.Parameters.ContainsKey("Type"))
            {
                Type = (string)navigationContext.Parameters["Type"];
                MaterialList.Value = getMaterialList(Type);
            }

            if (navigationContext.Parameters.ContainsKey("Material"))
            {
                SelectedMaterial = (List<UseMaterialModel>)navigationContext.Parameters["Material"];

                foreach (var Material in MaterialList.Value)
                {
                    if (SelectedMaterial != null && SelectedMaterial.Exists(x => x.ID == Material.ID))
                    {
                        Material.IsSelected.Value = true;
                    }
                    else
                    {
                        Material.IsSelected.Value = false;
                    }
                }
            }

            if (navigationContext.Parameters.ContainsKey("Skill"))
            {
                var selectedskill = (string)navigationContext.Parameters["Skill"];

                foreach (var Material in MaterialList.Value)
                {
                    if (selectedskill == Material.ID)
                    {
                        Material.IsSelected.Value = true;
                    }
                    else
                    {
                        Material.IsSelected.Value = false;
                    }
                }
            }


        }

        private void SelectCancel()
        {
            RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(Views.ViewA));
        }

        private void Reload()
        {
            
        }

        private void SelectEnd()
        {
            var param = new NavigationParameters();
            param.Add("Target", Target);
            switch (Type)
            {
                case "Material":
                    var naviParamMaterial = getUseMaterialModelList(MaterialList.Value);
                    param.Add("Materials", naviParamMaterial);
                    break;
                case "Skill":
                    var naviParamSkill = getSelectedSkill(MaterialList.Value);
                    param.Add("Skill", naviParamSkill);
                    break;
                default:
                    break;
            }

            RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(Views.ViewA), param);
        }

        private List<MaterialModel> getMaterialList(string type)
        {
            List<MaterialModel> returnlist = new List<MaterialModel>();

            string targetdir = string.Empty;
            switch (Type)
            {
                case "Material":
                    targetdir = Consts.MaterialIconFolder;
                    break;
                case "Skill":
                    targetdir = Consts.SkillIconFolder;
                    break;
                default:
                    break;
            }

            var Files = Directory.GetFiles(targetdir);
            foreach (var file in Files)
            {
                returnlist.Add(new MaterialModel(file));
            }

            return returnlist;
        }

        private List<UseMaterialModel> getUseMaterialModelList(List<MaterialModel> materials)
        {
            List<UseMaterialModel> returnList = new List<UseMaterialModel>();

            foreach (var material in materials.Where(x => x.IsSelected.Value))
            {
                string qty = "1";
                var bkMaterial = SelectedMaterial.Where(x => x.ID == material.ID).FirstOrDefault();
                if (bkMaterial != null)
                {
                    qty = bkMaterial.Quantity;
                }

                returnList.Add(new UseMaterialModel(material.ID, material.FilePath, qty));
            }

            return returnList;
        }

        private string getSelectedSkill(List<MaterialModel> materials)
        {
            string returntext = string.Empty;

            foreach (var material in materials.Where(x => x.IsSelected.Value))
            {
                returntext = material.ID;
            }

            return returntext;
        }
    }
}
