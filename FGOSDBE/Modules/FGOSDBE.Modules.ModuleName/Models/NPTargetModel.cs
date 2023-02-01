using System;
using System.Collections.Generic;
using System.Text;
using FGOSDBE.Models.SDBEModel;

namespace FGOSDBE.Modules.ModuleName.Models
{
    public class NPTargetModel
    {
        public Consts.NPTarget Value { get; }
        public string ValueString { get; }
        public string DisplayText { get; }

        public NPTargetModel()
        {

        }

        public NPTargetModel(Consts.NPTarget NPTarget)
        {
            Value = NPTarget;
            switch (Value)
            {
                case Consts.NPTarget.All:
                    ValueString = Consts.NPTargetDBValueAll;
                    DisplayText = Consts.NPTargetTextAll;
                    break;
                case Consts.NPTarget.One:
                    ValueString = Consts.NPTargetDBValueOne;
                    DisplayText = Consts.NPTargetTextOne;
                    break;
                case Consts.NPTarget.Support:
                    ValueString = Consts.NPTargetDBValueSupport;
                    DisplayText = Consts.NPTargetTextSupport;
                    break;
                default:
                    ValueString = string.Empty;
                    DisplayText = string.Empty;
                    break;
            }
        }
    }
}
