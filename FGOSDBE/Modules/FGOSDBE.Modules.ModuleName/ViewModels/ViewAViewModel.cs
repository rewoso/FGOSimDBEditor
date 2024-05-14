using FGOSDBE.Core;
using FGOSDBE.Core.Mvvm;
using FGOSDBE.Models.SDBEModel;
using FGOSDBE.Modules.ModuleName.Models;
using FGOSDBE.Services.Interfaces;
using Prism.Regions;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace FGOSDBE.Modules.ModuleName.ViewModels
{
    public class ViewAViewModel : RegionViewModelBase
    {
        private const string naviTargetServantDBInput = "ServantDBInput";
        private const string UseMaterialTargetSkill1Icon = "Skill1Icon";
        private const string UseMaterialTargetSkill2Icon = "Skill2Icon";
        private const string UseMaterialTargetSkill3Icon = "Skill3Icon";
        private const string UseMaterialTargetAdAgain1 = "AdAgain1";
        private const string UseMaterialTargetAdAgain2 = "AdAgain2";
        private const string UseMaterialTargetAdAgain3 = "AdAgain3";
        private const string UseMaterialTargetAdAgain4 = "AdAgain4";
        private const string UseMaterialTargetSkill1 = "Skill1";
        private const string UseMaterialTargetSkill2 = "Skill2";
        private const string UseMaterialTargetSkill3 = "Skill3";
        private const string UseMaterialTargetSkill4 = "Skill4";
        private const string UseMaterialTargetSkill5 = "Skill5";
        private const string UseMaterialTargetSkill6 = "Skill6";
        private const string UseMaterialTargetSkill7 = "Skill7";
        private const string UseMaterialTargetSkill8 = "Skill8";
        private const string UseMaterialTargetASkill1 = "ASkill1";
        private const string UseMaterialTargetASkill2 = "ASkill2";
        private const string UseMaterialTargetASkill3 = "ASkill3";
        private const string UseMaterialTargetASkill4 = "ASkill4";
        private const string UseMaterialTargetASkill5 = "ASkill5";
        private const string UseMaterialTargetASkill6 = "ASkill6";
        private const string UseMaterialTargetASkill7 = "ASkill7";
        private const string UseMaterialTargetASkill8 = "ASkill8";

        IDBEditorService DBEditorService { get; set; } = null;

        /// <summary>
        /// サーヴァントDB内のID
        /// </summary>
        public ReactiveProperty<string> ID { get; }
        /// <summary>
        /// サーヴァントアイコン
        /// </summary>
        public ReactiveProperty<string> ServantIcon { get; }
        /// <summary>
        /// サーヴァント名（日本語）
        /// </summary>
        public ReactiveProperty<string> NameJP { get; }
        /// <summary>
        /// サーヴァント名（英語）
        /// </summary>
        public ReactiveProperty<string> NameEN { get; }

        /// <summary>
        /// レアリティ一覧
        /// </summary>
        public ReactiveProperty<List<RealityModel>> RealityList { get; }
        /// <summary>
        /// 選択したレアリティ
        /// </summary>
        public ReactiveProperty<RealityModel> SelectedReality { get; }

        /// <summary>
        /// クラス一覧
        /// </summary>
        public ReactiveProperty<List<ServantClassModel>> ServantClassList { get; }
        /// <summary>
        /// 選択したクラス
        /// </summary>
        public ReactiveProperty<ServantClassModel> SelectedServantClass { get; }

        /// <summary>
        /// イベント鯖かどうか
        /// </summary>
        public ReactiveProperty<bool> GetFromEvent { get; }

        /// <summary>
        /// スキル１のアイコン
        /// </summary>
        public ReactiveProperty<string> Skill1Icon { get; }
        /// <summary>
        /// スキル１のアイコン画像パス
        /// </summary>
        public ReactiveProperty<string> Skill1IconPath { get; }
        /// <summary>
        /// スキル２のアイコン
        /// </summary>
        public ReactiveProperty<string> Skill2Icon { get; }
        /// <summary>
        /// スキル２のアイコン画像パス
        /// </summary>
        public ReactiveProperty<string> Skill2IconPath { get; }
        /// <summary>
        /// スキル３のアイコン
        /// </summary>
        public ReactiveProperty<string> Skill3Icon { get; }
        /// <summary>
        /// スキル３のアイコン画像パス
        /// </summary>
        public ReactiveProperty<string> Skill3IconPath { get; }

        /// <summary>
        /// 宝具タイプ一覧
        /// </summary>
        public ReactiveProperty<List<NPTypeModel>> NPTypeList { get; }
        /// <summary>
        /// 選択した宝具タイプ
        /// </summary>
        public ReactiveProperty<NPTypeModel> SelectedNPType { get; }

        /// <summary>
        /// 宝具対象一覧
        /// </summary>
        public ReactiveProperty<List<NPTargetModel>> NPTargetList { get; }
        /// <summary>
        /// 選択した宝具対象
        /// </summary>
        public ReactiveProperty<NPTargetModel> SelectedNPTarget { get; }

        /// <summary>
        /// 方針一覧
        /// </summary>
        public ReactiveProperty<List<PolicyModel>> PolicyList { get; }
        /// <summary>
        /// 選択した方針
        /// </summary>
        public ReactiveProperty<PolicyModel> SelectedPolicy { get; }

        /// <summary>
        /// 性格一覧
        /// </summary>
        public ReactiveProperty<List<PersonalityModel>> PersonalityList { get; }
        /// <summary>
        /// 選択した性格
        /// </summary>
        public ReactiveProperty<PersonalityModel> SelectedPersonality { get; }

        /// <summary>
        /// 属性一覧
        /// </summary>
        public ReactiveProperty<List<AttributeModel>> AttributeList { get; }
        /// <summary>
        /// 選択した属性
        /// </summary>
        public ReactiveProperty<AttributeModel> SelectedAttribute { get; }

        /// <summary>
        /// 特性一覧
        /// </summary>
        public ReactiveProperty<List<TraitModel>> TraitList { get; }

        /// <summary>
        /// 霊基再臨１
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> AdAgain1 { get; }

        /// <summary>
        /// 霊基再臨２
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> AdAgain2 { get; }

        /// <summary>
        /// 霊基再臨３
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> AdAgain3 { get; }

        /// <summary>
        /// 霊基再臨４
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> AdAgain4 { get; }

        /// <summary>
        /// スキル強化１
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> Skill1 { get; }
        /// <summary>
        /// スキル強化２
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> Skill2 { get; }
        /// <summary>
        /// スキル強化３
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> Skill3 { get; }
        /// <summary>
        /// スキル強化４
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> Skill4 { get; }
        /// <summary>
        /// スキル強化５
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> Skill5 { get; }
        /// <summary>
        /// スキル強化６
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> Skill6 { get; }
        /// <summary>
        /// スキル強化７
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> Skill7 { get; }
        /// <summary>
        /// スキル強化８
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> Skill8 { get; }
        /// <summary>
        /// スキル強化９
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> Skill9 { get; }

        /// <summary>
        /// アペンドスキル強化１
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> ASkill1 { get; }
        /// <summary>
        /// アペンドスキル強化２
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> ASkill2 { get; }
        /// <summary>
        /// アペンドスキル強化３
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> ASkill3 { get; }
        /// <summary>
        /// アペンドスキル強化４
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> ASkill4 { get; }
        /// <summary>
        /// アペンドスキル強化５
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> ASkill5 { get; }
        /// <summary>
        /// アペンドスキル強化６
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> ASkill6 { get; }
        /// <summary>
        /// アペンドスキル強化７
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> ASkill7 { get; }
        /// <summary>
        /// アペンドスキル強化８
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> ASkill8 { get; }
        /// <summary>
        /// アペンドスキル強化９
        /// </summary>
        public ReactiveProperty<List<UseMaterialModel>> ASkill9 { get; }

        public ReactiveCommand naviSkill1IconCommand { get; }
        public ReactiveCommand naviSkill2IconCommand { get; }
        public ReactiveCommand naviSkill3IconCommand { get; }

        public ReactiveCommand naviAdAgain1Command { get; }
        public ReactiveCommand naviAdAgain2Command { get; }
        public ReactiveCommand naviAdAgain3Command { get; }
        public ReactiveCommand naviAdAgain4Command { get; }

        public ReactiveCommand naviSkill1Command { get; }
        public ReactiveCommand naviSkill2Command { get; }
        public ReactiveCommand naviSkill3Command { get; }
        public ReactiveCommand naviSkill4Command { get; }
        public ReactiveCommand naviSkill5Command { get; }
        public ReactiveCommand naviSkill6Command { get; }
        public ReactiveCommand naviSkill7Command { get; }
        public ReactiveCommand naviSkill8Command { get; }

        public ReactiveCommand naviASkill1Command { get; }
        public ReactiveCommand naviASkill2Command { get; }
        public ReactiveCommand naviASkill3Command { get; }
        public ReactiveCommand naviASkill4Command { get; }
        public ReactiveCommand naviASkill5Command { get; }
        public ReactiveCommand naviASkill6Command { get; }
        public ReactiveCommand naviASkill7Command { get; }
        public ReactiveCommand naviASkill8Command { get; }

        public ReactiveCommand GenerateDBTextCommand { get; }
        public ReactiveCommand DisplayClearCommand { get; }
        public ReactiveCommand naviDataInputCommand { get; }
        public ReactiveCommand copyClipBoardCommand { get; }


        /// <summary>
        /// サーヴァントDBにコピペする用のテキスト
        /// </summary>
        public ReactiveProperty<string> ServantDBText { get; }


        public ViewAViewModel(IRegionManager regionManager, IDBEditorService dbeditorservice) : base(regionManager)
        {
            DBEditorService = dbeditorservice;

            ID = new ReactiveProperty<string>("0");
            ServantIcon = new ReactiveProperty<string>("");
            NameJP = new ReactiveProperty<string>(string.Empty);
            NameEN = new ReactiveProperty<string>(string.Empty);
            RealityList = new ReactiveProperty<List<RealityModel>>();
            RealityList.Value = getRealityList();
            SelectedReality = new ReactiveProperty<RealityModel>();
            SelectedReality.Value = RealityList.Value.FirstOrDefault();
            ServantClassList = new ReactiveProperty<List<ServantClassModel>>();
            ServantClassList.Value = getServantClassList();
            SelectedServantClass = new ReactiveProperty<ServantClassModel>();
            SelectedServantClass.Value = ServantClassList.Value.FirstOrDefault();
            GetFromEvent = new ReactiveProperty<bool>(false);
            Skill1Icon = new ReactiveProperty<string>("0");
            Skill1IconPath = new ReactiveProperty<string>("");
            Skill2Icon = new ReactiveProperty<string>("0");
            Skill2IconPath = new ReactiveProperty<string>("");
            Skill3Icon = new ReactiveProperty<string>("0");
            Skill3IconPath = new ReactiveProperty<string>("");
            NPTypeList = new ReactiveProperty<List<NPTypeModel>>();
            NPTypeList.Value = getNPType();
            SelectedNPType = new ReactiveProperty<NPTypeModel>();
            SelectedNPType.Value = NPTypeList.Value.FirstOrDefault();
            NPTargetList = new ReactiveProperty<List<NPTargetModel>>();
            NPTargetList.Value = getNPTarget();
            SelectedNPTarget = new ReactiveProperty<NPTargetModel>();
            SelectedNPTarget.Value = NPTargetList.Value.FirstOrDefault();
            PolicyList = new ReactiveProperty<List<PolicyModel>>();
            PolicyList.Value = getPolicy();
            SelectedPolicy = new ReactiveProperty<PolicyModel>();
            SelectedPolicy.Value = PolicyList.Value.FirstOrDefault();
            PersonalityList = new ReactiveProperty<List<PersonalityModel>>();
            PersonalityList.Value = getPersonality();
            SelectedPersonality = new ReactiveProperty<PersonalityModel>();
            SelectedPersonality.Value = PersonalityList.Value.FirstOrDefault();
            AttributeList = new ReactiveProperty<List<AttributeModel>>();
            AttributeList.Value = getAttribute();
            SelectedAttribute = new ReactiveProperty<AttributeModel>();
            SelectedAttribute.Value = AttributeList.Value.FirstOrDefault();
            TraitList = new ReactiveProperty<List<TraitModel>>();
            TraitList.Value = getTraitList();
            AdAgain1 = new ReactiveProperty<List<UseMaterialModel>>();
            AdAgain2 = new ReactiveProperty<List<UseMaterialModel>>();
            AdAgain3 = new ReactiveProperty<List<UseMaterialModel>>();
            AdAgain4 = new ReactiveProperty<List<UseMaterialModel>>();
            Skill1 = new ReactiveProperty<List<UseMaterialModel>>();
            Skill2 = new ReactiveProperty<List<UseMaterialModel>>();
            Skill3 = new ReactiveProperty<List<UseMaterialModel>>();
            Skill4 = new ReactiveProperty<List<UseMaterialModel>>();
            Skill5 = new ReactiveProperty<List<UseMaterialModel>>();
            Skill6 = new ReactiveProperty<List<UseMaterialModel>>();
            Skill7 = new ReactiveProperty<List<UseMaterialModel>>();
            Skill8 = new ReactiveProperty<List<UseMaterialModel>>();
            Skill9 = new ReactiveProperty<List<UseMaterialModel>>();
            Skill1.Value = new List<UseMaterialModel>();
            Skill2.Value = new List<UseMaterialModel>();
            Skill3.Value = new List<UseMaterialModel>();
            Skill4.Value = new List<UseMaterialModel>();
            Skill5.Value = new List<UseMaterialModel>();
            Skill6.Value = new List<UseMaterialModel>();
            Skill7.Value = new List<UseMaterialModel>();
            Skill8.Value = new List<UseMaterialModel>();
            Skill9.Value = new List<UseMaterialModel> { new UseMaterialModel("800", "") };
            ASkill1 = new ReactiveProperty<List<UseMaterialModel>>();
            ASkill2 = new ReactiveProperty<List<UseMaterialModel>>();
            ASkill3 = new ReactiveProperty<List<UseMaterialModel>>();
            ASkill4 = new ReactiveProperty<List<UseMaterialModel>>();
            ASkill5 = new ReactiveProperty<List<UseMaterialModel>>();
            ASkill6 = new ReactiveProperty<List<UseMaterialModel>>();
            ASkill7 = new ReactiveProperty<List<UseMaterialModel>>();
            ASkill8 = new ReactiveProperty<List<UseMaterialModel>>();
            ASkill9 = new ReactiveProperty<List<UseMaterialModel>>();
            ASkill1.Value = new List<UseMaterialModel>();
            ASkill2.Value = new List<UseMaterialModel>();
            ASkill3.Value = new List<UseMaterialModel>();
            ASkill4.Value = new List<UseMaterialModel>();
            ASkill5.Value = new List<UseMaterialModel>();
            ASkill6.Value = new List<UseMaterialModel>();
            ASkill7.Value = new List<UseMaterialModel>();
            ASkill8.Value = new List<UseMaterialModel>();
            ASkill9.Value = new List<UseMaterialModel> { new UseMaterialModel("800", "") };

            naviSkill1IconCommand = new ReactiveCommand();
            naviSkill1IconCommand.Subscribe(_ => naviMaterialSelecter("Skill1Icon", "Skill", null, Skill1Icon.Value));
            naviSkill2IconCommand = new ReactiveCommand();
            naviSkill2IconCommand.Subscribe(_ => naviMaterialSelecter("Skill2Icon", "Skill", null, Skill2Icon.Value));
            naviSkill3IconCommand = new ReactiveCommand();
            naviSkill3IconCommand.Subscribe(_ => naviMaterialSelecter("Skill3Icon", "Skill", null, Skill3Icon.Value));
            naviAdAgain1Command = new ReactiveCommand();
            naviAdAgain1Command.Subscribe(_ => naviMaterialSelecter("AdAgain1", "Material", AdAgain1.Value, null));
            naviAdAgain2Command = new ReactiveCommand();
            naviAdAgain2Command.Subscribe(_ => naviMaterialSelecter("AdAgain2", "Material", AdAgain2.Value, null));
            naviAdAgain3Command = new ReactiveCommand();
            naviAdAgain3Command.Subscribe(_ => naviMaterialSelecter("AdAgain3", "Material", AdAgain3.Value, null));
            naviAdAgain4Command = new ReactiveCommand();
            naviAdAgain4Command.Subscribe(_ => naviMaterialSelecter("AdAgain4", "Material", AdAgain4.Value, null));
            naviSkill1Command = new ReactiveCommand();
            naviSkill1Command.Subscribe(_ => naviMaterialSelecter("Skill1", "Material", Skill1.Value, null));
            naviSkill2Command = new ReactiveCommand();
            naviSkill2Command.Subscribe(_ => naviMaterialSelecter("Skill2", "Material", Skill2.Value, null));
            naviSkill3Command = new ReactiveCommand();
            naviSkill3Command.Subscribe(_ => naviMaterialSelecter("Skill3", "Material", Skill3.Value, null));
            naviSkill4Command = new ReactiveCommand();
            naviSkill4Command.Subscribe(_ => naviMaterialSelecter("Skill4", "Material", Skill4.Value, null));
            naviSkill5Command = new ReactiveCommand();
            naviSkill5Command.Subscribe(_ => naviMaterialSelecter("Skill5", "Material", Skill5.Value, null));
            naviSkill6Command = new ReactiveCommand();
            naviSkill6Command.Subscribe(_ => naviMaterialSelecter("Skill6", "Material", Skill6.Value, null));
            naviSkill7Command = new ReactiveCommand();
            naviSkill7Command.Subscribe(_ => naviMaterialSelecter("Skill7", "Material", Skill7.Value, null));
            naviSkill8Command = new ReactiveCommand();
            naviSkill8Command.Subscribe(_ => naviMaterialSelecter("Skill8", "Material", Skill8.Value, null));
            naviASkill1Command = new ReactiveCommand();
            naviASkill1Command.Subscribe(_ => naviMaterialSelecter("ASkill1", "Material", ASkill1.Value, null));
            naviASkill2Command = new ReactiveCommand();
            naviASkill2Command.Subscribe(_ => naviMaterialSelecter("ASkill2", "Material", ASkill2.Value, null));
            naviASkill3Command = new ReactiveCommand();
            naviASkill3Command.Subscribe(_ => naviMaterialSelecter("ASkill3", "Material", ASkill3.Value, null));
            naviASkill4Command = new ReactiveCommand();
            naviASkill4Command.Subscribe(_ => naviMaterialSelecter("ASkill4", "Material", ASkill4.Value, null));
            naviASkill5Command = new ReactiveCommand();
            naviASkill5Command.Subscribe(_ => naviMaterialSelecter("ASkill5", "Material", ASkill5.Value, null));
            naviASkill6Command = new ReactiveCommand();
            naviASkill6Command.Subscribe(_ => naviMaterialSelecter("ASkill6", "Material", ASkill6.Value, null));
            naviASkill7Command = new ReactiveCommand();
            naviASkill7Command.Subscribe(_ => naviMaterialSelecter("ASkill7", "Material", ASkill7.Value, null));
            naviASkill8Command = new ReactiveCommand();
            naviASkill8Command.Subscribe(_ => naviMaterialSelecter("ASkill8", "Material", ASkill8.Value, null));
            DisplayClearCommand = new ReactiveCommand();
            DisplayClearCommand.Subscribe(_ => DisplayClear());
            naviDataInputCommand = new ReactiveCommand();
            naviDataInputCommand.Subscribe(_ => naviServantDBInput());
            copyClipBoardCommand = new ReactiveCommand();
            copyClipBoardCommand.Subscribe(_ => copyClipBoard());
            GenerateDBTextCommand = new ReactiveCommand();
            GenerateDBTextCommand.Subscribe(_ => ServantDBText.Value = getServantDBText());

            ID.Subscribe(_ => ID_Changed());
            SelectedServantClass.Subscribe(_ => InitMaterial());
            SelectedReality.Subscribe(_ => InitMaterial());

            ServantDBText = new ReactiveProperty<string>();

        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            if (navigationContext.Parameters.ContainsKey("Target"))
            {
                switch (navigationContext.Parameters["Target"])
                {
                    case UseMaterialTargetSkill1Icon:
                        setParamTargetTypeSkill(navigationContext.Parameters["Skill"], Skill1Icon, Skill1IconPath);
                        break;
                    case UseMaterialTargetSkill2Icon:
                        setParamTargetTypeSkill(navigationContext.Parameters["Skill"], Skill2Icon, Skill2IconPath);
                        break;
                    case UseMaterialTargetSkill3Icon:
                        setParamTargetTypeSkill(navigationContext.Parameters["Skill"], Skill3Icon, Skill3IconPath);
                        break;
                    case UseMaterialTargetAdAgain1:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], AdAgain1);
                        break;
                    case UseMaterialTargetAdAgain2:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], AdAgain2);
                        break;
                    case UseMaterialTargetAdAgain3:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], AdAgain3);
                        break;
                    case UseMaterialTargetAdAgain4:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], AdAgain4);
                        break;
                    case UseMaterialTargetSkill1:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], Skill1);
                        break;
                    case UseMaterialTargetSkill2:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], Skill2);
                        break;
                    case UseMaterialTargetSkill3:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], Skill3);
                        break;
                    case UseMaterialTargetSkill4:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], Skill4, Skill5);
                        break;
                    case UseMaterialTargetSkill5:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], Skill5);
                        break;
                    case UseMaterialTargetSkill6:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], Skill6, Skill7);
                        break;
                    case UseMaterialTargetSkill7:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], Skill7, Skill8);
                        break;
                    case UseMaterialTargetSkill8:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], Skill8);
                        break;
                    case UseMaterialTargetASkill1:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], ASkill1);
                        break;
                    case UseMaterialTargetASkill2:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], ASkill2);
                        break;
                    case UseMaterialTargetASkill3:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], ASkill3);
                        break;
                    case UseMaterialTargetASkill4:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], ASkill4, ASkill5);
                        break;
                    case UseMaterialTargetASkill5:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], ASkill5);
                        break;
                    case UseMaterialTargetASkill6:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], ASkill6, ASkill7);
                        break;
                    case UseMaterialTargetASkill7:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], ASkill7, ASkill8);
                        break;
                    case UseMaterialTargetASkill8:
                        setParamTargetTypeMaterial(navigationContext.Parameters["Materials"], ASkill8);
                        break;
                    case naviTargetServantDBInput:
                        setServantData(navigationContext.Parameters["ServantDBText"].ToString());
                        break;
                    default:
                        break;
                }
            }

            ServantDBText.Value = getServantDBText();
        }

        private void setParamTargetTypeSkill(object param, ReactiveProperty<string> id, ReactiveProperty<string> path)
        {
            var skill = (string)param;
            id.Value = skill;
            path.Value = Path.Combine(Consts.SkillIconFolder, skill + ".jpg");
        }

        private void setParamTargetTypeMaterial(object param, ReactiveProperty<List<UseMaterialModel>> usematerials, ReactiveProperty<List<UseMaterialModel>> usematerials2 = null)
        {
            var materials = (List<UseMaterialModel>)param;

            //基本の７クラスの場合
            if (Consts.ServantClassBasic.Contains(SelectedServantClass.Value.Value))
            {
                usematerials.Value = materials;

                if (usematerials2 != null && usematerials2.Value.Count < 2)
                {
                    var newMaterial2 = new List<UseMaterialModel>();
                    foreach (var item in usematerials2.Value)
                    {
                        newMaterial2.Add(item);
                    }

                    foreach (var item in usematerials.Value)
                    {
                        if (int.Parse(item.ID) >= 300)
                        {
                            if ((usematerials2 == Skill8 && !Skill6.Value.Exists(x => x.ID == item.ID))
                                || (usematerials2 == ASkill8 && !ASkill6.Value.Exists(x => x.ID == item.ID))
                                || (usematerials2 != Skill8 && usematerials2 != ASkill8)
                                )
                            {
                                newMaterial2.Add(new UseMaterialModel(item.ID, item.IconPath, item.Quantity));
                            }
                        }
                    }
                    usematerials2.Value = newMaterial2;
                }
            }

            //エクストラクラスの場合
            if (Consts.ServantClassExtra.Contains(SelectedServantClass.Value.Value))
            {

                switch (SelectedServantClass.Value.Value)
                {
                    case Consts.ServantClass.Ruler:
                    case Consts.ServantClass.MoonCancer:
                    case Consts.ServantClass.AlterEgo:
                        //再臨１を選択された時だけ初期設定する
                        if (usematerials == AdAgain1)
                        {
                            InitMaterialExtraClassTypeOneTime(materials);
                        }
                        else
                        {
                            //再臨１意外の場合は選択されたものをそのまま設定
                            usematerials.Value = materials;
                        }
                        break;
                    case Consts.ServantClass.Avenger:
                    case Consts.ServantClass.Shielder:
                    case Consts.ServantClass.Foreigner:
                    case Consts.ServantClass.Pretender:
                    case Consts.ServantClass.Beast:
                        InitMaterialExtraClassTypeEvery(materials, usematerials);
                        break;
                    default:
                        break;
                }
            }
        }

        private List<RealityModel> getRealityList()
        {
            List<RealityModel> returnList = new List<RealityModel>();

            foreach (var value in Enum.GetValues(typeof(Consts.Reality)))
            {
                returnList.Add(new RealityModel((Consts.Reality)value));
            }

            return returnList;
        }

        private List<ServantClassModel> getServantClassList()
        {
            List<ServantClassModel> returnList = new List<ServantClassModel>();

            foreach (var value in Enum.GetValues(typeof(Consts.ServantClass)))
            {
                returnList.Add(new ServantClassModel((Consts.ServantClass)value));
            }

            return returnList;
        }

        private List<NPTypeModel> getNPType()
        {
            List<NPTypeModel> returnList = new List<NPTypeModel>();

            foreach (var value in Enum.GetValues(typeof(Consts.NPType)))
            {
                returnList.Add(new NPTypeModel((Consts.NPType)value));
            }

            return returnList;
        }

        private List<PolicyModel> getPolicy()
        {
            List<PolicyModel> returnList = new List<PolicyModel>();

            foreach (var value in Enum.GetValues(typeof(Consts.Policy)))
            {
                returnList.Add(new PolicyModel((Consts.Policy)value));
            }

            return returnList;
        }

        private List<PersonalityModel> getPersonality()
        {
            List<PersonalityModel> returnList = new List<PersonalityModel>();

            foreach (var value in Enum.GetValues(typeof(Consts.Personality)))
            {
                returnList.Add(new PersonalityModel((Consts.Personality)value));
            }

            return returnList;
        }

        private List<AttributeModel> getAttribute()
        {
            List<AttributeModel> returnList = new List<AttributeModel>();

            foreach (var value in Enum.GetValues(typeof(Consts.Attribute)))
            {
                returnList.Add(new AttributeModel((Consts.Attribute)value));
            }

            return returnList;
        }

        private List<TraitModel> getTraitList()
        {
            List<TraitModel> returnList = new List<TraitModel>();

            foreach (var value in Enum.GetValues(typeof(Consts.Trait)))
            {
                returnList.Add(new TraitModel((Consts.Trait)value));
            }

            return returnList;
        }

        private List<NPTargetModel> getNPTarget()
        {
            List<NPTargetModel> returnList = new List<NPTargetModel>();

            foreach (var value in Enum.GetValues(typeof(Consts.NPTarget)))
            {
                returnList.Add(new NPTargetModel((Consts.NPTarget)value));
            }

            return returnList;
        }

        private string getUseMaterialALL(List<UseMaterialModel> usematerials)
        {
            string returntext = string.Empty;

            if (usematerials != null && usematerials.Count != 0)
            {
                int counter = 0;
                foreach (var usematerial in usematerials)
                {
                    if (counter == 0)
                    {
                        returntext += usematerial.DBText;
                    }
                    else
                    {
                        returntext += ", " + usematerial.DBText;
                    }

                    counter++;
                }
            }

            return returntext;
        }


        private void naviMaterialSelecter(string target, string type, List<UseMaterialModel> material, string materialid)
        {
            var param = new NavigationParameters();
            param.Add("Target", target);
            param.Add("Type", type);
            if (type == "Skill")
            {
                param.Add("Skill", materialid);
            }
            else
            {
                param.Add("Material", material);
            }

            RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(Views.MaterialSelecterView), param);
        }

        private void ID_Changed()
        {
            ServantIcon.Value = Path.Combine(Consts.ServantIconFolder, ID.Value + ".jpg");
        }

        private void InitMaterial()
        {
            if (SelectedReality.Value == null) return;
            if (SelectedServantClass.Value == null) return;

            var qty1 = "0";
            var qty2 = "0";

            switch (SelectedReality.Value.Value)
            {
                case Consts.Reality.Star1:
                    qty1 = "2";
                    qty2 = "4";
                    break;
                case Consts.Reality.Star2:
                    qty1 = "3";
                    qty2 = "6";
                    break;
                case Consts.Reality.Star3:
                    qty1 = "4";
                    qty2 = "8";
                    break;
                case Consts.Reality.Star4:
                    qty1 = "4";
                    qty2 = "10";
                    break;
                case Consts.Reality.Star5:
                    qty1 = "5";
                    qty2 = "12";
                    break;
                default:
                    break;
            }

            string materialAdAgain1, materialAdAgain2, materialSkill1, materialSkill2, materialSkill3;

            switch (SelectedServantClass.Value.Value)
            {
                case Consts.ServantClass.Saber:
                    materialAdAgain1 = "100";
                    materialAdAgain2 = "110";
                    materialSkill1 = "200";
                    materialSkill2 = "210";
                    materialSkill3 = "220";

                    Set7ClassMaterial(materialAdAgain1, materialAdAgain2, materialSkill1, materialSkill2, materialSkill3, qty1, qty2);
                    break;
                case Consts.ServantClass.Archer:
                    materialAdAgain1 = "101";
                    materialAdAgain2 = "111";
                    materialSkill1 = "201";
                    materialSkill2 = "211";
                    materialSkill3 = "221";

                    Set7ClassMaterial(materialAdAgain1, materialAdAgain2, materialSkill1, materialSkill2, materialSkill3, qty1, qty2);
                    break;
                case Consts.ServantClass.Lancer:
                    materialAdAgain1 = "102";
                    materialAdAgain2 = "112";
                    materialSkill1 = "202";
                    materialSkill2 = "212";
                    materialSkill3 = "222";

                    Set7ClassMaterial(materialAdAgain1, materialAdAgain2, materialSkill1, materialSkill2, materialSkill3, qty1, qty2);
                    break;
                case Consts.ServantClass.Rider:
                    materialAdAgain1 = "103";
                    materialAdAgain2 = "113";
                    materialSkill1 = "203";
                    materialSkill2 = "213";
                    materialSkill3 = "223";

                    Set7ClassMaterial(materialAdAgain1, materialAdAgain2, materialSkill1, materialSkill2, materialSkill3, qty1, qty2);
                    break;
                case Consts.ServantClass.Caster:
                    materialAdAgain1 = "104";
                    materialAdAgain2 = "114";
                    materialSkill1 = "204";
                    materialSkill2 = "214";
                    materialSkill3 = "224";

                    Set7ClassMaterial(materialAdAgain1, materialAdAgain2, materialSkill1, materialSkill2, materialSkill3, qty1, qty2);
                    break;
                case Consts.ServantClass.Assassin:
                    materialAdAgain1 = "105";
                    materialAdAgain2 = "115";
                    materialSkill1 = "205";
                    materialSkill2 = "215";
                    materialSkill3 = "225";

                    Set7ClassMaterial(materialAdAgain1, materialAdAgain2, materialSkill1, materialSkill2, materialSkill3, qty1, qty2);
                    break;
                case Consts.ServantClass.Berserker:
                    materialAdAgain1 = "106";
                    materialAdAgain2 = "116";
                    materialSkill1 = "206";
                    materialSkill2 = "216";
                    materialSkill3 = "226";

                    Set7ClassMaterial(materialAdAgain1, materialAdAgain2, materialSkill1, materialSkill2, materialSkill3, qty1, qty2);
                    break;
                case Consts.ServantClass.Ruler:
                case Consts.ServantClass.Avenger:
                case Consts.ServantClass.Shielder:
                case Consts.ServantClass.MoonCancer:
                case Consts.ServantClass.AlterEgo:
                case Consts.ServantClass.Foreigner:
                case Consts.ServantClass.Pretender:
                default:
                    //素材が決まってないので初期化する
                    AdAgain1.Value = new List<UseMaterialModel>();
                    AdAgain2.Value = new List<UseMaterialModel>();
                    AdAgain3.Value = new List<UseMaterialModel>();
                    AdAgain4.Value = new List<UseMaterialModel>();
                    Skill1.Value = new List<UseMaterialModel>();
                    Skill2.Value = new List<UseMaterialModel>();
                    Skill3.Value = new List<UseMaterialModel>();
                    Skill4.Value = new List<UseMaterialModel>();
                    Skill5.Value = new List<UseMaterialModel>();
                    Skill6.Value = new List<UseMaterialModel>();
                    ASkill1.Value = new List<UseMaterialModel>();
                    ASkill2.Value = new List<UseMaterialModel>();
                    ASkill3.Value = new List<UseMaterialModel>();
                    ASkill4.Value = new List<UseMaterialModel>();
                    ASkill5.Value = new List<UseMaterialModel>();
                    ASkill6.Value = new List<UseMaterialModel>();
                    break;
            }

        }

        private void Set7ClassMaterial(string adagain1, string adagain2, string skill1, string skill2, string skill3, string qty1, string qty2)
        {
            AdAgain1.Value = new List<UseMaterialModel> { SetUserMaterialModel(adagain1, qty1) };
            AdAgain2.Value = new List<UseMaterialModel> { SetUserMaterialModel(adagain1, qty2) };
            AdAgain3.Value = new List<UseMaterialModel> { SetUserMaterialModel(adagain2, qty1) };
            AdAgain4.Value = new List<UseMaterialModel> { SetUserMaterialModel(adagain2, qty2) };
            Skill1.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill1, qty1) };
            Skill2.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill1, qty2) };
            Skill3.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill2, qty1) };
            Skill4.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill2, qty2) };
            Skill5.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill3, qty1) };
            Skill6.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill3, qty2) };
            ASkill1.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill1, qty1) };
            ASkill2.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill1, qty2) };
            ASkill3.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill2, qty1) };
            ASkill4.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill2, qty2) };
            ASkill5.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill3, qty1) };
            ASkill6.Value = new List<UseMaterialModel> { SetUserMaterialModel(skill3, qty2) };
        }

        private void InitMaterialExtraClassTypeOneTime(List<UseMaterialModel> selectedmaterial)
        {
            if (SelectedReality.Value == null) return;
            if (SelectedServantClass.Value == null) return;

            var qty1 = "0";
            var qty2 = "0";

            switch (SelectedReality.Value.Value)
            {
                case Consts.Reality.Star1:
                    qty1 = "2";
                    qty2 = "4";
                    break;
                case Consts.Reality.Star2:
                    qty1 = "3";
                    qty2 = "6";
                    break;
                case Consts.Reality.Star3:
                    qty1 = "4";
                    qty2 = "8";
                    break;
                case Consts.Reality.Star4:
                    qty1 = "4";
                    qty2 = "10";
                    break;
                case Consts.Reality.Star5:
                    qty1 = "5";
                    qty2 = "12";
                    break;
                default:
                    break;
            }

            var TempAdAgain1 = new List<UseMaterialModel>();
            var TempAdAgain2 = new List<UseMaterialModel>();
            var TempAdAgain3 = new List<UseMaterialModel>();
            var TempAdAgain4 = new List<UseMaterialModel>();
            var TempSkill1 = new List<UseMaterialModel>();
            var TempSkill2 = new List<UseMaterialModel>();
            var TempSkill3 = new List<UseMaterialModel>();
            var TempSkill4 = new List<UseMaterialModel>();
            var TempSkill5 = new List<UseMaterialModel>();
            var TempSkill6 = new List<UseMaterialModel>();
            var TempASkill1 = new List<UseMaterialModel>();
            var TempASkill2 = new List<UseMaterialModel>();
            var TempASkill3 = new List<UseMaterialModel>();
            var TempASkill4 = new List<UseMaterialModel>();
            var TempASkill5 = new List<UseMaterialModel>();
            var TempASkill6 = new List<UseMaterialModel>();

            switch (SelectedServantClass.Value.Value)
            {
                case Consts.ServantClass.Ruler:
                    foreach (var MaterialByClassUnit in Consts.MaterialByClass)
                    {
                        if (selectedmaterial.Any(x => MaterialByClassUnit.Contains(x.ID)))
                        {
                            TempAdAgain1.Add(SetUserMaterialModel(MaterialByClassUnit[0], qty1));
                            TempAdAgain3.Add(SetUserMaterialModel(MaterialByClassUnit[1], qty1));
                            TempSkill1.Add(SetUserMaterialModel(MaterialByClassUnit[2], qty1));
                            TempSkill3.Add(SetUserMaterialModel(MaterialByClassUnit[3], qty1));
                            TempSkill5.Add(SetUserMaterialModel(MaterialByClassUnit[4], qty1));
                            TempASkill1.Add(SetUserMaterialModel(MaterialByClassUnit[2], qty1));
                            TempASkill3.Add(SetUserMaterialModel(MaterialByClassUnit[3], qty1));
                            TempASkill5.Add(SetUserMaterialModel(MaterialByClassUnit[4], qty1));
                        }
                        else
                        {
                            TempAdAgain2.Add(SetUserMaterialModel(MaterialByClassUnit[0], qty1));
                            TempAdAgain4.Add(SetUserMaterialModel(MaterialByClassUnit[1], qty1));
                            TempSkill2.Add(SetUserMaterialModel(MaterialByClassUnit[2], qty1));
                            TempSkill4.Add(SetUserMaterialModel(MaterialByClassUnit[3], qty1));
                            TempSkill6.Add(SetUserMaterialModel(MaterialByClassUnit[4], qty1));
                            TempASkill2.Add(SetUserMaterialModel(MaterialByClassUnit[2], qty1));
                            TempASkill4.Add(SetUserMaterialModel(MaterialByClassUnit[3], qty1));
                            TempASkill6.Add(SetUserMaterialModel(MaterialByClassUnit[4], qty1));
                        }
                    }

                    break;

                case Consts.ServantClass.MoonCancer:
                case Consts.ServantClass.AlterEgo:

                    foreach (var MaterialByClassUnit in Consts.MaterialByClass)
                    {
                        if (selectedmaterial.Any(x => MaterialByClassUnit.Contains(x.ID)))
                        {
                            TempAdAgain1.Add(SetUserMaterialModel(MaterialByClassUnit[0], qty1));
                            TempAdAgain2.Add(SetUserMaterialModel(MaterialByClassUnit[0], qty2));
                            TempAdAgain3.Add(SetUserMaterialModel(MaterialByClassUnit[1], qty1));
                            TempAdAgain4.Add(SetUserMaterialModel(MaterialByClassUnit[1], qty2));
                            TempSkill1.Add(SetUserMaterialModel(MaterialByClassUnit[2], qty1));
                            TempSkill2.Add(SetUserMaterialModel(MaterialByClassUnit[2], qty2));
                            TempSkill3.Add(SetUserMaterialModel(MaterialByClassUnit[3], qty1));
                            TempSkill4.Add(SetUserMaterialModel(MaterialByClassUnit[3], qty2));
                            TempSkill5.Add(SetUserMaterialModel(MaterialByClassUnit[4], qty1));
                            TempSkill6.Add(SetUserMaterialModel(MaterialByClassUnit[4], qty2));
                            TempASkill1.Add(SetUserMaterialModel(MaterialByClassUnit[2], qty1));
                            TempASkill2.Add(SetUserMaterialModel(MaterialByClassUnit[2], qty2));
                            TempASkill3.Add(SetUserMaterialModel(MaterialByClassUnit[3], qty1));
                            TempASkill4.Add(SetUserMaterialModel(MaterialByClassUnit[3], qty2));
                            TempASkill5.Add(SetUserMaterialModel(MaterialByClassUnit[4], qty1));
                            TempASkill6.Add(SetUserMaterialModel(MaterialByClassUnit[4], qty2));
                        }
                    }

                    break;

                case Consts.ServantClass.Avenger:
                case Consts.ServantClass.Foreigner:
                case Consts.ServantClass.Pretender:
                case Consts.ServantClass.Shielder:
                default:
                    //ここはまた処理が違うので放置
                    break;
            }

            AdAgain1.Value = TempAdAgain1;
            AdAgain2.Value = TempAdAgain2;
            AdAgain3.Value = TempAdAgain3;
            AdAgain4.Value = TempAdAgain4;
            Skill1.Value = TempSkill1;
            Skill2.Value = TempSkill2;
            Skill3.Value = TempSkill3;
            Skill4.Value = TempSkill4;
            Skill5.Value = TempSkill5;
            Skill6.Value = TempSkill6;
            ASkill1.Value = TempASkill1;
            ASkill2.Value = TempASkill2;
            ASkill3.Value = TempASkill3;
            ASkill4.Value = TempASkill4;
            ASkill5.Value = TempASkill5;
            ASkill6.Value = TempASkill6;

        }

        private void InitMaterialExtraClassTypeEvery(List<UseMaterialModel> selectedmaterials, ReactiveProperty<List<UseMaterialModel>> usematerials)
        {
            if (SelectedReality.Value == null) return;
            if (SelectedServantClass.Value == null) return;

            var qty1 = "0";
            var qty2 = "0";
            var qty3 = "0";

            switch (SelectedReality.Value.Value)
            {
                case Consts.Reality.Star1:
                case Consts.Reality.Star2:
                    //不明
                    break;
                case Consts.Reality.Star3:
                case Consts.Reality.Star4:
                    qty1 = "8";
                    qty2 = "10";
                    qty3 = "12";
                    break;
                case Consts.Reality.Star5:
                    qty1 = "10";
                    qty2 = "12";
                    qty3 = "15";
                    break;
                default:
                    break;
            }

            var Tempusematerials = new List<UseMaterialModel>();

            switch (SelectedServantClass.Value.Value)
            {
                case Consts.ServantClass.Avenger:
                case Consts.ServantClass.Foreigner:
                case Consts.ServantClass.Pretender:
                case Consts.ServantClass.Beast:

                    foreach (var selectedmaterial in selectedmaterials)
                    {
                        if (usematerials == Skill3 || usematerials == Skill4 || usematerials == Skill5 
                            || usematerials == ASkill3 || usematerials == ASkill4 || usematerials == ASkill5
                            )
                        {
                            Tempusematerials.Add(SetUserMaterialModel(selectedmaterial.ID, qty2));
                        }
                        else if (usematerials == Skill6 || usematerials == Skill7 || usematerials == Skill8
                                || usematerials == ASkill6 || usematerials == ASkill7 || usematerials == ASkill8
                                )
                        {
                            Tempusematerials.Add(SetUserMaterialModel(selectedmaterial.ID, qty3));
                        }
                        else
                        {
                            Tempusematerials.Add(SetUserMaterialModel(selectedmaterial.ID, qty1));
                        }
                    }

                    usematerials.Value = Tempusematerials;

                    break;
                case Consts.ServantClass.Ruler:
                case Consts.ServantClass.MoonCancer:
                case Consts.ServantClass.AlterEgo:
                case Consts.ServantClass.Shielder:
                default:
                    //ここはまた処理が違うので放置
                    break;
            }

        }

        private UseMaterialModel SetUserMaterialModel(string materialID, string count)
        {
            return new UseMaterialModel(materialID, Path.Combine(Consts.MaterialIconFolder, "item_" + materialID + ".jpg"), count);
        }

        private void DisplayClear()
        {
            ID.Value = "0";
            ServantIcon.Value = string.Empty;
            NameJP.Value = string.Empty;
            NameEN.Value = string.Empty;
            SelectedReality.Value = RealityList.Value.FirstOrDefault();
            SelectedServantClass.Value = ServantClassList.Value.FirstOrDefault();
            GetFromEvent.Value = false;
            Skill1Icon.Value = "0";
            Skill1IconPath.Value = string.Empty;
            Skill2Icon.Value = "0";
            Skill2IconPath.Value = string.Empty;
            Skill3Icon.Value = "0";
            Skill3IconPath.Value = string.Empty;
            SelectedNPType.Value = NPTypeList.Value.FirstOrDefault();
            SelectedNPTarget.Value = NPTargetList.Value.FirstOrDefault();
            SelectedPolicy.Value = PolicyList.Value.FirstOrDefault();
            SelectedPersonality.Value = PersonalityList.Value.FirstOrDefault();
            SelectedAttribute.Value = AttributeList.Value.FirstOrDefault();
            foreach (var item in TraitList.Value)
            {
                item.IsSelected.Value = false;
            }
            AdAgain1.Value = new List<UseMaterialModel>();
            AdAgain2.Value = new List<UseMaterialModel>();
            AdAgain3.Value = new List<UseMaterialModel>();
            AdAgain4.Value = new List<UseMaterialModel>();
            Skill1.Value = new List<UseMaterialModel>();
            Skill2.Value = new List<UseMaterialModel>();
            Skill3.Value = new List<UseMaterialModel>();
            Skill4.Value = new List<UseMaterialModel>();
            Skill5.Value = new List<UseMaterialModel>();
            Skill6.Value = new List<UseMaterialModel>();
            Skill7.Value = new List<UseMaterialModel>();
            Skill8.Value = new List<UseMaterialModel>();
            Skill9.Value = new List<UseMaterialModel> { new UseMaterialModel("800", "") };
            ASkill1.Value = new List<UseMaterialModel>();
            ASkill2.Value = new List<UseMaterialModel>();
            ASkill3.Value = new List<UseMaterialModel>();
            ASkill4.Value = new List<UseMaterialModel>();
            ASkill5.Value = new List<UseMaterialModel>();
            ASkill6.Value = new List<UseMaterialModel>();
            ASkill7.Value = new List<UseMaterialModel>();
            ASkill8.Value = new List<UseMaterialModel>();
            ASkill9.Value = new List<UseMaterialModel> { new UseMaterialModel("800", "") };

            ServantDBText.Value = getServantDBText();
        }

        private void naviServantDBInput()
        {
            var param = new NavigationParameters();
            param.Add("Target", "ServantDBInput");

            RegionManager.RequestNavigate(RegionNames.ContentRegion, nameof(Views.ServantDBInput), param);
        }

        private void setServantData(string servantdbtext)
        {
            int linecount = 0;
            var dbtextlinearray = servantdbtext.Split("\r\n");
            foreach (var dbtextline in dbtextlinearray)
            {
                if (dbtextline.Trim().Length == 0)
                {
                    continue;
                }

                linecount++;

                if (linecount <= 7)
                {
                    var dataarray = dbtextline.Trim().Split(",", StringSplitOptions.RemoveEmptyEntries);
                    foreach (var data in dataarray)
                    {
                        if (linecount == 7)
                        {
                            var trait = TraitList.Value.Where(x => x.ValueString == data.Trim()).FirstOrDefault();
                            trait.IsSelected.Value = true;
                        }
                        else
                        {
                            if (data.Trim().StartsWith("id:"))
                            {
                                ID.Value = data.Split(":")[1].Trim();
                            }
                            else if (data.Trim().StartsWith("text:"))
                            {
                                NameJP.Value = data.Split(":")[1].Replace("\"", "").Trim();
                            }
                            else if (data.Trim().StartsWith("text2:"))
                            {
                                NameEN.Value = data.Split(":")[1].Replace("\"", "").Trim();
                            }
                            else if (data.Trim().StartsWith("value:"))
                            {
                                SelectedReality.Value = RealityList.Value.Find(x => x.ValueString == data.Split(":")[1].Trim());
                            }
                            else if (data.Trim().StartsWith("kind:"))
                            {
                                SelectedServantClass.Value = ServantClassList.Value.Find(x => x.ValueString == data.Split(":")[1].Trim());
                            }
                            else if (data.Trim().StartsWith("event:"))
                            {
                                GetFromEvent.Value = data.Split(":")[1].Trim() == "1";
                            }
                            else if (data.Trim().StartsWith("icon1:"))
                            {
                                setParamTargetTypeSkill(data.Split(":")[1].Trim(), Skill1Icon, Skill1IconPath);
                            }
                            else if (data.Trim().StartsWith("icon2:"))
                            {
                                setParamTargetTypeSkill(data.Split(":")[1].Trim(), Skill2Icon, Skill2IconPath);
                            }
                            else if (data.Trim().StartsWith("icon3:"))
                            {
                                setParamTargetTypeSkill(data.Split(":")[1].Trim(), Skill3Icon, Skill3IconPath);
                            }
                            else if (data.Trim().StartsWith("nptype"))
                            {
                                SelectedNPType.Value = NPTypeList.Value.Find(x => x.ValueString == data.Trim());
                            }
                            else if (data.Trim().StartsWith("npeffect"))
                            {
                                SelectedNPTarget.Value = NPTargetList.Value.Find(x => x.ValueString == data.Trim());
                            }
                            else if (data.Trim().StartsWith("policy"))
                            {
                                SelectedPolicy.Value = PolicyList.Value.Find(x => x.ValueString == data.Trim());
                            }
                            else if (data.Trim().StartsWith("personal"))
                            {
                                SelectedPersonality.Value = PersonalityList.Value.Find(x => x.ValueString == data.Trim());
                            }
                            else if (data.Trim().StartsWith("attrbute"))
                            {
                                SelectedAttribute.Value = AttributeList.Value.Find(x => x.ValueString == data.Trim());
                            }
                            else if (data.Trim().StartsWith("attrbute"))
                            {
                                SelectedAttribute.Value = AttributeList.Value.Find(x => x.ValueString == data.Trim());
                            }
                        }
                    }
                }
                else
                {
                    string materialstext = dbtextline.Substring(dbtextline.IndexOf("{") + 1, dbtextline.IndexOf("}") - dbtextline.IndexOf("{") - 1).Trim();
                    if (dbtextline.Trim().StartsWith("AdAgain1"))
                    {
                        setUseMaterial(AdAgain1, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("AdAgain2"))
                    {
                        setUseMaterial(AdAgain2, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("AdAgain3"))
                    {
                        setUseMaterial(AdAgain3, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("AdAgain4"))
                    {
                        setUseMaterial(AdAgain4, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("skill1"))
                    {
                        setUseMaterial(Skill1, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("skill2"))
                    {
                        setUseMaterial(Skill2, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("skill3"))
                    {
                        setUseMaterial(Skill3, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("skill4"))
                    {
                        setUseMaterial(Skill4, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("skill5"))
                    {
                        setUseMaterial(Skill5, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("skill6"))
                    {
                        setUseMaterial(Skill6, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("skill7"))
                    {
                        setUseMaterial(Skill7, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("skill8"))
                    {
                        setUseMaterial(Skill8, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("askill1"))
                    {
                        setUseMaterial(ASkill1, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("askill2"))
                    {
                        setUseMaterial(ASkill2, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("askill3"))
                    {
                        setUseMaterial(ASkill3, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("askill4"))
                    {
                        setUseMaterial(ASkill4, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("askill5"))
                    {
                        setUseMaterial(ASkill5, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("askill6"))
                    {
                        setUseMaterial(ASkill6, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("askill7"))
                    {
                        setUseMaterial(ASkill7, materialstext);
                    }
                    else if (dbtextline.Trim().StartsWith("askill8"))
                    {
                        setUseMaterial(ASkill8, materialstext);
                    }
                }
            }
        }

        private void setUseMaterial(ReactiveProperty<List<UseMaterialModel>> usematerials, string targetmaterials)
        {
            usematerials.Value = new List<UseMaterialModel>();

            var materialsarray = targetmaterials.Split(",");
            foreach (var materials in materialsarray)
            {
                var materialpartsarray = materials.Split(":");
                usematerials.Value.Add(SetUserMaterialModel(materialpartsarray[0].Trim(), materialpartsarray[1].Trim()));
            }
        }

        private string getServantDBText()
        {
            string returntext = string.Empty;

            string isGetFromEvent = GetFromEvent.Value ? "1" : "0";
            string Traits = string.Empty;
            if (TraitList.Value.Exists(x => x.IsSelected.Value))
            {
                foreach (var item in TraitList.Value.Where(x => x.IsSelected.Value))
                {
                    Traits += item.ValueString + ", ";
                }
            }

            returntext += "," + "\r\n";
            returntext += "{" + "\r\n";
            returntext += "\t" + "id:" + ID.Value + ", text:\"" + NameJP.Value + "\",\r\n";
            returntext += "\t" + "text2:\"" + NameEN.Value + "\",\r\n";
            returntext += "\t" + "value:" + SelectedReality.Value.ValueString + ", kind:" + SelectedServantClass.Value.ValueString + ", event:" + isGetFromEvent + ",\r\n";
            returntext += "\t" + "icon1:" + Skill1Icon.Value + ", icon2:" + Skill2Icon.Value + ", icon3:" + Skill3Icon.Value + ",\r\n";
            returntext += "\t" + SelectedNPType.Value.ValueString + ", " + SelectedNPTarget.Value.ValueString + ",\r\n";
            returntext += "\t" + SelectedPolicy.Value.ValueString + ", " + SelectedPersonality.Value.ValueString + ", " + SelectedAttribute.Value.ValueString + ",\r\n";
            if (Traits != string.Empty)
            {
                returntext += "\t" + Traits + "\r\n";
            }
            returntext += "\t" + "AdAgain1:{ " + getUseMaterialALL(AdAgain1.Value) + " },\r\n";
            returntext += "\t" + "AdAgain2:{ " + getUseMaterialALL(AdAgain2.Value) + " },\r\n";
            returntext += "\t" + "AdAgain3:{ " + getUseMaterialALL(AdAgain3.Value) + " },\r\n";
            returntext += "\t" + "AdAgain4:{ " + getUseMaterialALL(AdAgain4.Value) + " },\r\n";
            returntext += "\t" + "skill1:{ " + getUseMaterialALL(Skill1.Value) + " },\r\n";
            returntext += "\t" + "skill2:{ " + getUseMaterialALL(Skill2.Value) + " },\r\n";
            returntext += "\t" + "skill3:{ " + getUseMaterialALL(Skill3.Value) + " },\r\n";
            returntext += "\t" + "skill4:{ " + getUseMaterialALL(Skill4.Value) + " },\r\n";
            returntext += "\t" + "skill5:{ " + getUseMaterialALL(Skill5.Value) + " },\r\n";
            returntext += "\t" + "skill6:{ " + getUseMaterialALL(Skill6.Value) + " },\r\n";
            returntext += "\t" + "skill7:{ " + getUseMaterialALL(Skill7.Value) + " },\r\n";
            returntext += "\t" + "skill8:{ " + getUseMaterialALL(Skill8.Value) + " },\r\n";
            returntext += "\t" + "skill9:{ " + getUseMaterialALL(Skill9.Value) + " },\r\n";
            returntext += "\t" + "askill1:{ " + getUseMaterialALL(ASkill1.Value) + " },\r\n";
            returntext += "\t" + "askill2:{ " + getUseMaterialALL(ASkill2.Value) + " },\r\n";
            returntext += "\t" + "askill3:{ " + getUseMaterialALL(ASkill3.Value) + " },\r\n";
            returntext += "\t" + "askill4:{ " + getUseMaterialALL(ASkill4.Value) + " },\r\n";
            returntext += "\t" + "askill5:{ " + getUseMaterialALL(ASkill5.Value) + " },\r\n";
            returntext += "\t" + "askill6:{ " + getUseMaterialALL(ASkill6.Value) + " },\r\n";
            returntext += "\t" + "askill7:{ " + getUseMaterialALL(ASkill7.Value) + " },\r\n";
            returntext += "\t" + "askill8:{ " + getUseMaterialALL(ASkill8.Value) + " },\r\n";
            returntext += "\t" + "askill9:{ " + getUseMaterialALL(ASkill9.Value) + " }\r\n";
            returntext += "}";

            return returntext;
        }

        private void copyClipBoard()
        {
            Clipboard.SetData(DataFormats.Text, (Object)ServantDBText.Value);
        }
    }
}
