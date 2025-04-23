// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiDelta : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M24 13.455h-.689l-.288-.739h-1.2l-.289.739h-.644l1.233-2.96h.666zm-1.16-1.233l-.411-1.044-.411 1.044zm-4.315 1.233h.66v-2.438h.995v-.51h-2.644v.51h.989zm-3.826 0h1.927v-.511H15.36v-2.438h-.661zm-3.282-2.438h1.416v-.51h-2.077v2.948h2.121v-.511h-1.46v-.766h1.25v-.511h-1.25zm-4.981 2.438h1.038c1.072 0 1.71-.555 1.71-1.472 0-.916-.638-1.471-1.71-1.471H6.436zm.655-2.438h.383c.694 0 1.044.344 1.044.96 0 .617-.344.961-1.044.961h-.383zm-2.277 2.155a.15.15 0 0 1 .15.15.15.15 0 0 1-.15.15.15.15 0 0 1-.15-.15.15.15 0 0 1 .15-.15m0 .277a.13.13 0 0 0 .134-.127c0-.073-.056-.128-.134-.128a.126.126 0 0 0-.127.128c0 .072.055.127.127.127m-.033-.039H4.76v-.177h.067c.038 0 .055.016.055.05 0 .033-.022.044-.044.05l.055.077h-.028l-.05-.077h-.033zm0-.1h.028c.022 0 .05 0 .05-.027 0-.022-.022-.028-.039-.028h-.039zM0 13.85h4.626l-2.31-.978zm.172-.395l2.144-1.033 2.143 1.033-2.143-3.304Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
