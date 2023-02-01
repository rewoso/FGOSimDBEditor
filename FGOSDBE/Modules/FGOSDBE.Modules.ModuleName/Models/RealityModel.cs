using System;
using System.Collections.Generic;
using System.Text;
using FGOSDBE.Models.SDBEModel;

namespace FGOSDBE.Modules.ModuleName.Models
{
    public class RealityModel
    {
        public Consts.Reality Value { get; }
        public string ValueString { get; }
        public string DisplayText { get; }

        public RealityModel()
        {

        }

        public RealityModel(Consts.Reality reality)
        {
            Value = reality;
            ValueString = ((int)reality).ToString();
            switch (Value)
            {
                case Consts.Reality.Star1:
                    DisplayText = Consts.RealityTextStar1;
                    break;
                case Consts.Reality.Star2:
                    DisplayText = Consts.RealityTextStar2;
                    break;
                case Consts.Reality.Star3:
                    DisplayText = Consts.RealityTextStar3;
                    break;
                case Consts.Reality.Star4:
                    DisplayText = Consts.RealityTextStar4;
                    break;
                case Consts.Reality.Star5:
                    DisplayText = Consts.RealityTextStar5;
                    break;
                default:
                    DisplayText = string.Empty;
                    break;
            }
        }
    }
}
