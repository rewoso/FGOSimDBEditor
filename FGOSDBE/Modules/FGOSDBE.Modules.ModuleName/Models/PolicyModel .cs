using System;
using System.Collections.Generic;
using System.Text;
using FGOSDBE.Models.SDBEModel;

namespace FGOSDBE.Modules.ModuleName.Models
{
    public class PolicyModel
    {
        public Consts.Policy Value { get; }
        public string ValueString { get; }
        public string DisplayText { get; }

        public PolicyModel()
        {

        }

        public PolicyModel(Consts.Policy Policy)
        {
            Value = Policy;
            switch (Value)
            {
                case Consts.Policy.Law:
                    ValueString = Consts.PolicyDBValueLaw;
                    DisplayText = Consts.PolicyTextLaw;
                    break;
                case Consts.Policy.Neutral:
                    ValueString = Consts.PolicyDBValueNeutral;
                    DisplayText = Consts.PolicyTextNeutral;
                    break;
                case Consts.Policy.Chaos:
                    ValueString = Consts.PolicyDBValueChaos;
                    DisplayText = Consts.PolicyTextChaos;
                    break;
                default:
                    ValueString = string.Empty;
                    DisplayText = string.Empty;
                    break;
            }
        }
    }
}
