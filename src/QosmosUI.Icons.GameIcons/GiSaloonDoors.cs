// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSaloonDoors : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M247 73.098c-54.26 1.974-69.31 21.918-90.365 44.886-21.25 23.18-48.362 48.605-115.635 50.71v78.208h16v98H41v94h206V73.098zm18 0v365.804h206v-94h-16v-98h16v-78.207c-67.273-2.106-94.386-27.53-115.635-50.71C334.31 95.014 319.26 75.07 265 73.097zm-87 45.804h54v18h-54v-18zm102 0h54v18h-54v-18zm-136 32h88v18h-88v-18zm136 0h88v18h-88v-18zm-216 32h168v18H64v-18zm216 0h168v18H280v-18zm-216 32h168v18H64v-18zm216 0h168v18H280v-18zm-208 32h160v18H72v-18zm208 0h160v18H280v-18zm-255 18v62h14v-62H25zm448 0v62h14v-62h-14zm-401 14h160v18H72v-18zm208 0h160v18H280v-18zm-208 32h160v18H72v-18zm208 0h160v18H280v-18zm-208 32h160v18H64l8-18zm208 0h160l8 18H280v-18zm-216 32h168v18H64v-18zm216 0h168v18H280v-18zm-216 32h168v18H64v-18zm216 0h168v18H280v-18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
