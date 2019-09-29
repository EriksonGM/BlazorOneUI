using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorOneUI.Models
{
    public class Component
    {
        public string Display { get; set; }

        public int ComponentType { get; set; }

        public string Value { get; set; } = "";

        public string Pattern { get; set; }

        public bool IsRequired { get; set; }

    }

    public enum ComponentTypeEnum
    {
        Textbox = 1,
        CheckBox,
        DropDown,
    }
}
