// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaAffiliatetheme : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 12.103516 5 C 10.236794 5.0156311 7.3762969 6.9496406 5.0371094 9.9550781 C 2.1581094 13.654078 1.14725 17.559313 2.78125 18.695312 C 4.41525 19.821312 8.0838906 17.733156 10.962891 14.035156 C 13.841891 10.336156 14.85275 6.4326406 13.21875 5.3066406 C 12.912375 5.0955156 12.534298 4.9963928 12.103516 5 z M 29.984375 11 C 26.183375 17.359 20.088375 20.541625 16.359375 18.265625 C 15.075375 17.479625 14.285141 15.815 13.994141 14 C 12.018141 17.66 8.208 20.903 4 22 C 6.681 25.188 10.838453 27 15.314453 27 C 23.401453 27 29.960937 20.378172 29.960938 12.201172 C 29.970937 11.742172 30.027375 11.437 29.984375 11 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
