using System;
using System.Collections.Generic;
using System.Text;
using FGOSDBE.Models.SDBEModel;
using Reactive.Bindings;

namespace FGOSDBE.Modules.ModuleName.Models
{
    public class MaterialModel
    {
        public ReactiveProperty<bool> IsSelected { get; }
        public string FilePath { get; }
        public string FileName
        {
            get
            {
                return System.IO.Path.GetFileName(FilePath);
            }
        }
        public string ID
        {
            get
            {
                return System.IO.Path.GetFileNameWithoutExtension(FilePath).Replace("item_", "");
            }
        }

        public MaterialModel(string filepath)
        {
            IsSelected = new ReactiveProperty<bool>(false);
            FilePath = filepath;
        }
    }
}
