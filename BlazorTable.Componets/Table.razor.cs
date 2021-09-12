using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace BlazorTable.Componets
{
    partial class Table<T> : ComponentBase
    {
        [Parameter]
        public IEnumerable<T> Items { get; set; }
        [Parameter]
        public RenderFragment Head { get; set; }
        [Parameter]
        public RenderFragment<T> Body { get; set; }
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AdditionalAttributes { get; set; }
        MarkupString DefaultHead;
        MarkupString DefaultBody;
        private readonly string DefaultCSSClass =
            "table table-bordered table-striped table-hover table-sm";
        protected override void OnParametersSet()
        {
            if (AdditionalAttributes == null)
            {
                AdditionalAttributes = new Dictionary<string, object>();
            }
            if (!AdditionalAttributes.ContainsKey("class"))
            {
                AdditionalAttributes.Add("class", DefaultCSSClass);
            }
            var Properties = typeof(T).GetProperties(
                BindingFlags.Public|
                BindingFlags.Instance);
            StringBuilder SB;
            if (Head == null)
            {
                SB = new StringBuilder();
                foreach (var Property in Properties)
                {
                    var Alias =
                        Attribute.GetCustomAttribute(Property,
                        typeof(DisplayAttribute));
                    var Header = Alias == null ? Property.Name :
                        ((DisplayAttribute)Alias).GetName();
                    SB.Append($"<th>{Header}</th>");
                }
                DefaultHead = new MarkupString(SB.ToString());
            }
            if (Body == null)
            { 
                SB = new StringBuilder();
                foreach (var Item in Items)
                {
                    SB.Append("<tr>");
                    foreach (var Property in Properties)
                    {
                        var Value = Property.GetValue(Item);
                        SB.Append($"<td>{Value}</td>");
                    }
                    SB.Append("</tr>");
                }
                DefaultBody = new MarkupString(SB.ToString());
            }
        }
    }
}
