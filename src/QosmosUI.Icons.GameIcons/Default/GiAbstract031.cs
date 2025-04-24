// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiAbstract031 : ComponentBase
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
		builder.AddAttribute(14, "d", "m21,21c0,85.0552 45.1233,159.5271 112.8,200.7782 11.7998-42.2279 44.8672-75.5397 86.95-87.6844v-113.0938h-199.75zm270.25,0v113.0938c42.0829,12.1447 75.1502,45.4565 86.95,87.6844 67.6767-41.251 112.8-115.7229 112.8-200.7782h-199.75zm-35.25,166.8501c-37.6381,0-68.1501,30.5118-68.1501,68.15s30.5119,68.15 68.1501,68.15 68.15-30.5118 68.15-68.15-30.5119-68.15-68.15-68.15zm-122.2001,102.3718c-67.6766,41.251-112.8,115.7229-112.8,200.7781h199.75v-113.0937c-42.0828-12.1447-75.1502-45.4565-86.95-87.6844zm244.4001,0c-11.7998,42.2279-44.8671,75.5397-86.95,87.6844v113.0937h199.75c0-85.0552-45.1232-159.5271-112.8-200.7781z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
