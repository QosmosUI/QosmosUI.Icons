// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiGitconnected : ComponentBase
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
		builder.AddAttribute(15, "d", "M6.734 5.42C2.865 5.42 0 8.405 0 12.035c0 3.607 2.842 6.545 6.688 6.545 3.859 0 6.708-2.936 6.755-6.58l.002-.08c.03-2.19 1.504-3.967 3.797-3.967 2.268 0 3.87 1.838 3.87 4.082 0 2.222-1.483 4.037-3.823 4.037-1.334 0-2.43-.657-3.107-1.656a7.557 7.557 0 0 1-1.41 2.53c1.163 1.013 2.71 1.634 4.47 1.634 3.893 0 6.758-2.986 6.758-6.592 0-3.63-2.841-6.568-6.71-6.568-3.828 0-6.672 2.922-6.733 6.5-.015.04 0 .101 0 .115 0 2.222-1.482 4.037-3.823 4.037-2.244 0-3.845-1.84-3.845-4.084 0-2.221 1.482-4.035 3.799-4.035 1.232 0 2.254.554 2.943 1.41l1.385-2.449A6.75 6.75 0 0 0 6.734 5.42Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
