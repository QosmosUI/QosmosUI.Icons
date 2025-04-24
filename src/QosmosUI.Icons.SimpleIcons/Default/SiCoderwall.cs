// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCoderwall : ComponentBase
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
		builder.AddAttribute(15, "d", "M21.354 18.708c1.46 0 2.646 1.185 2.646 2.646C24 22.814 22.814 24 21.354 24s-2.646-1.186-2.646-2.646c0-1.458 1.185-2.646 2.646-2.646zM12 9.354c1.46 0 2.646 1.186 2.646 2.646S13.46 14.646 12 14.646 9.354 13.46 9.354 12 10.54 9.354 12 9.354zm9.354 0C22.814 9.354 24 10.54 24 12s-1.186 2.646-2.646 2.646S18.708 13.46 18.708 12s1.185-2.646 2.646-2.646zM12 0c1.46 0 2.646 1.185 2.646 2.646 0 1.46-1.186 2.646-2.646 2.646S9.354 4.106 9.354 2.646 10.54 0 12 0zM2.646 0c1.46 0 2.646 1.185 2.646 2.646 0 1.46-1.186 2.646-2.646 2.646S0 4.106 0 2.646 1.186 0 2.646 0zm18.708 0C22.814 0 24 1.185 24 2.646c0 1.46-1.186 2.646-2.646 2.646s-2.646-1.186-2.646-2.646S19.893 0 21.354 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
