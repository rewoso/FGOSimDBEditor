using System;
using System.Collections.Generic;
using System.Text;
using FGOSDBE.Models.SDBEModel;

namespace FGOSDBE.Modules.ModuleName.Models
{
    public class UseMaterialModel
    {
        public string ID { get; set; }
        public string Quantity { get; set; }
        public string IconPath { get; set; }
        public string DBText
        {
            get
            {
                return ID.Replace("item_", "") + ":" + Quantity;
            }
        }

        public UseMaterialModel()
        {

        }

        public UseMaterialModel(string id, string iconpath, string quantity = "1")
        {
            ID = id;
            IconPath = iconpath;
            Quantity = quantity;
        }

    }
}
