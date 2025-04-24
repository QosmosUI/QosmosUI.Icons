// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiZiggo : ComponentBase
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
		builder.AddAttribute(15, "d", "M18.555 18.69a3 3 0 0 0-2.52-2.865h-6.3l7.26-6.945a2.145 2.145 0 0 0 .495-2.34 2.1 2.1 0 0 0-2.205-1.23h-9a2.79 2.79 0 0 0 2.19 2.895h5.175L6 15.375a2.01 2.01 0 0 0-.42 2.13 1.965 1.965 0 0 0 2.115 1.185zM2.85 18.6a2.535 2.535 0 0 0 2.55 2.535h13.2a2.536 2.537 0 0 0 2.55-2.535V7.92A2.865 2.865 0 0 1 24 5.31V18.6a5.385 5.385 0 0 1-5.4 5.4H5.4A5.385 5.385 0 0 1 0 18.6V5.4A5.385 5.385 0 0 1 5.4 0h13.2a5.595 5.595 0 0 1 2.07.405A5.235 5.235 0 0 1 22.635 1.8a1.5 1.5 0 0 1 .42 1.005 1.41 1.41 0 0 1-.42 1.02 1.5 1.5 0 0 1-2.025 0A2.685 2.685 0 0 0 19.59 3a2.43 2.43 0 0 0-.99-.195H5.4A2.505 2.505 0 0 0 2.865 5.4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
