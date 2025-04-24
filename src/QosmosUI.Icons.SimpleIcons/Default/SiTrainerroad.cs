// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiTrainerroad : ComponentBase
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
		builder.AddAttribute(15, "d", "M20.289 14.039c.157-.064.44-.199.51-.234 1.105-.56 1.92-1.222 2.42-1.966.527-.756.8-1.658.78-2.579 0-1.253-.456-2.193-1.398-2.874-.922-.668-2.225-.971-3.874-1.012H1.357L0 8.421h5.528c.014 0 .028.005.038.016a.02.02 0 01.004.019L2.785 16.85h3.668c.063 0 .12-.041.14-.102l2.759-8.303a.043.043 0 01.042-.024l2.823.001c.014 0 .028.005.038.015a.02.02 0 01.004.019L9.473 16.85h3.669c.064 0 .12-.042.14-.103l.742-2.26a.043.043 0 01.042-.024s2.452.005 2.452.003c.864 1.363 1.807 2.878 2.616 4.16l3.844-.002c.118 0 .19-.13.125-.229l-2.832-4.321c-.01-.022.013-.025.018-.035zm-.45-3.355c-.437.412-1.185.612-2.163.612h-2.583l.952-2.874 2.353.001c1.14.017 1.826.514 1.838 1.337.007.35-.138.688-.397.924z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
