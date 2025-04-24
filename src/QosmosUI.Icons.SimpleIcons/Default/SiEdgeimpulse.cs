// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiEdgeimpulse : ComponentBase
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
		builder.AddAttribute(15, "d", "M16.008 10.287h4.51l1.348 3.53h-5.858c-.979 0-1.772-.79-1.772-1.766s.793-1.766 1.772-1.766v.002ZM.677 12.049a1.77 1.77 0 0 1 1.773-1.766h8.597a1.77 1.77 0 0 1 1.772 1.766c0 .976-.793 1.766-1.772 1.766H2.45c-.98 0-1.773-.79-1.773-1.766ZM24 19.613H4.448a2.515 2.515 0 0 1-1.93.899A2.514 2.514 0 0 1 0 18.002a2.514 2.514 0 0 1 2.518-2.509c.775 0 1.467.351 1.93.899h18.321L24 19.613ZM19.594 7.655H4.404a2.51 2.51 0 0 1-1.886.852A2.514 2.514 0 0 1 0 5.998a2.514 2.514 0 0 1 2.518-2.51c.797 0 1.506.371 1.967.946h13.878l1.231 3.221Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
