// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoColorFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M416,480c-35.29,0-64-29.11-64-64.88,0-33.29,28.67-65.4,44.08-82.64,1.87-2.1,3.49-3.91,4.68-5.31a19.94,19.94,0,0,1,30.55,0c1.13,1.31,2.63,3,4.36,4.93,15.5,17.3,44.33,49.51,44.33,83.05C480,450.89,451.29,480,416,480Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M398.23,276.64,166.89,47.22a52.1,52.1,0,0,0-73.6,0l-4.51,4.51A53.2,53.2,0,0,0,72.89,89.06,51.66,51.66,0,0,0,88.14,126l41.51,41.5L45,252a44.52,44.52,0,0,0-13,32,42.81,42.81,0,0,0,13.5,30.84l131.24,126a44,44,0,0,0,61.08-.18L361.93,320.38a15.6,15.6,0,0,1,8.23-4.29,69.21,69.21,0,0,1,11.93-.86h.3a22.53,22.53,0,0,0,15.84-38.59ZM152.29,144.85l-41.53-41.52a20,20,0,0,1,0-28.34l5.16-5.15a20.07,20.07,0,0,1,28.39,0L186,111.21Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
