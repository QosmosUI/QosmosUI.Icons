// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiAmmoBox : ComponentBase
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
		builder.AddAttribute(14, "d", "M166 16c-7.844 0-15 7.353-15 15v30h15v30h-60c-68.24 0-75.004 53.136-75 75v270c.002 11.74-15 30-15 30v30h480v-30s-15.002-18.26-15-30V166c.004-21.864-6.76-75-75-75h-60V61h15V31c0-7.647-7.156-15-15-15H166zm72.03 45c1.045-.007 2.032 0 2.97 0h30c15 0 45 0 45 30H196c0-28.125 26.376-29.89 42.03-30zM121 151h270c19.21 0 30 10.98 30 30v240c0 8.467-7.733 15-15 15H106c-7.267 0-15-6.533-15-15V181c0-19.02 10.79-30 30-30zm30 30s-30 21.842-30 60v105h60V241c0-38.158-30-60-30-60zm105 0s-30 21.842-30 60v105h60V241c0-38.158-30-60-30-60zm105 0s-30 21.842-30 60v105h60V241c0-38.158-30-60-30-60zM121 361v30h60v-30h-60zm105 0v30h60v-30h-60zm105 0v30h60v-30h-60z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
