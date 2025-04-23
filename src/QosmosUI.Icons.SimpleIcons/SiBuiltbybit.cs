// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiBuiltbybit : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.877.032 1.252 5.885a.253.253 0 0 0 .003.446l5.679 3.02c.077.041.17.04.246-.004l4.694-2.697a.254.254 0 0 1 .253 0l4.692 2.697a.253.253 0 0 0 .246.004l5.682-3.021a.253.253 0 0 0 .003-.446L12.122.031a.254.254 0 0 0-.245 0ZM6.924 10.898l-5.71-3.036a.254.254 0 0 0-.373.224V18.25c0 .093.05.178.131.222l9.976 5.495a.254.254 0 0 0 .376-.222v-6.053a.255.255 0 0 0-.127-.22l-4.012-2.305a.252.252 0 0 1-.127-.22v-3.825a.253.253 0 0 0-.135-.224Zm10.152 0 5.71-3.035a.254.254 0 0 1 .373.224v10.164c0 .093-.05.178-.131.222l-9.976 5.495a.254.254 0 0 1-.376-.222v-6.053c0-.091.049-.175.127-.22l4.012-2.305a.252.252 0 0 0 .127-.22v-3.825c0-.094.052-.18.135-.224Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
