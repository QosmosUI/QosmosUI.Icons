// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiRoots : ComponentBase
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
		builder.AddAttribute(15, "d", "M8.513 12.27L2.6 18.177a.244.244 0 0 1-.174.072l-.02-.001a.248.248 0 0 1-.178-.102 11.973 11.973 0 0 1-.889-1.452.247.247 0 0 1 .045-.287l5.638-5.628a9.403 9.403 0 0 0 2.776-6.694.245.245 0 0 1 .49 0v3.911a6 6 0 0 1-1.774 4.274zM18 .842a.242.242 0 0 0-.245 0 .246.246 0 0 0-.122.212v10.855a6 6 0 0 0 1.773 4.273l1.997 1.995a.246.246 0 0 0 .173.072l.021-.001a.256.256 0 0 0 .18-.102A11.902 11.902 0 0 0 24 11.21c0-4.255-2.298-8.228-6-10.367zM6.367 4.085V1.054A.244.244 0 0 0 6 .842C2.3 2.982 0 6.954 0 11.21c0 .34.018.705.056 1.115.01.094.072.174.161.208a.294.294 0 0 0 .084.014.245.245 0 0 0 .172-.071l4.123-4.118a5.999 5.999 0 0 0 1.771-4.273zm10.614 14.52a9.402 9.402 0 0 1-2.778-6.696V7.996a.245.245 0 1 0-.489 0 9.401 9.401 0 0 1-2.776 6.696l-5.915 5.905a.244.244 0 0 0-.071.193.243.243 0 0 0 .102.18A11.929 11.929 0 0 0 12 23.192a11.93 11.93 0 0 0 6.947-2.222.237.237 0 0 0 .1-.18.239.239 0 0 0-.068-.193l-1.998-1.992Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
