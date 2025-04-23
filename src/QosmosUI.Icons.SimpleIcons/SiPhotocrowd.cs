// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiPhotocrowd : ComponentBase
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
		builder.AddAttribute(15, "d", "M2.182 0C.977 0 0 1.058 0 2.364v19.462C0 23.026.977 24 2.182 24h19.636A2.179 2.179 0 0 0 24 21.826V2.364C24 1.058 23.023 0 21.818 0zM12 3.49a1.022 1.022 0 1 1 0 2.045 1.022 1.022 0 0 1 0-2.044zM8.326 4.498a1.022 1.022 0 1 1-.142 2.039 1.022 1.022 0 0 1 .142-2.04zm7.347 0a1.02 1.02 0 0 1 .955 1.529 1.021 1.021 0 1 1-.955-1.53zm-10.23 2.74a1.02 1.02 0 1 1 .145 2.037 1.02 1.02 0 0 1-.145-2.036zm13.113 0a1.02 1.02 0 1 1-.142 2.036 1.02 1.02 0 0 1 .142-2.035zm-7.497.116a1.021 1.021 0 1 1 .119 2.039 1.021 1.021 0 0 1-.12-2.04zm3.687.88a1.021 1.021 0 1 1 .001 2.042 1.021 1.021 0 0 1 0-2.043zm-6.308 1.864a1.02 1.02 0 1 1-.119 2.04 1.02 1.02 0 0 1 .12-2.04zm3.561.88a1.023 1.023 0 1 1-.001 2.047 1.023 1.023 0 0 1 .001-2.047zm-7.488.002a1.022 1.022 0 1 1-.001 2.044 1.022 1.022 0 0 1 0-2.044zm14.977 0a1.02 1.02 0 1 1-.001 2.042 1.02 1.02 0 0 1 0-2.042zm-3.793.881a1.02 1.02 0 1 1-.119 2.038 1.02 1.02 0 0 1 .12-2.038zm-6.442 1.866a1.021 1.021 0 1 1-.001 2.042 1.021 1.021 0 0 1 0-2.042zm3.568.883a1.02 1.02 0 1 1 .12 2.038 1.02 1.02 0 0 1-.12-2.038zm-7.235.116a1.02 1.02 0 0 1 .44 1.904 1.022 1.022 0 1 1-.44-1.904zm12.827 0a1.022 1.022 0 1 1 .142 2.038 1.022 1.022 0 0 1-.142-2.038zm-10.229 2.74a1.021 1.021 0 1 1 .142 2.038 1.021 1.021 0 0 1-.142-2.038zm7.63 0a1.02 1.02 0 0 1 .44 1.904 1.022 1.022 0 1 1-.44-1.904zM12 18.463a1.022 1.022 0 1 1 0 2.045 1.022 1.022 0 0 1 0-2.045z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
