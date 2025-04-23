// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiCnet : ComponentBase
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
		builder.AddAttribute(15, "d", "M1.89 9.262C.664 9.262 0 9.8 0 10.865v2.268c0 1.066.664 1.604 1.891 1.604h3.583v-2.353h-.293c-.13 1.365-.731 1.941-1.914 1.941h-.74c-.576 0-.856-.287-.856-.854v-2.944c0-.567.28-.854.856-.854h.74c1.2 0 1.791.544 1.914 1.867h.293V9.262H1.89Zm7.522 0v.275c1.274.127 1.856.668 1.856 2.102v1.716L7.905 9.262H6.229v5.475H8.55v-.275c-1.307-.143-1.886-.678-1.886-2.121v-1.963l3.582 4.359h1.457V9.262H9.412Zm3.06 0v5.475h5.475v-2.352h-.293c-.13 1.369-.731 1.947-1.914 1.947h-1.647v-2.233h.558c.933 0 1.328.415 1.421 1.316h.298v-3.009h-.298c-.094.896-.49 1.314-1.421 1.314h-.558V9.667h1.646c1.201 0 1.791.545 1.915 1.873h.293V9.262h-5.475Zm6.053 0v2.278h.294c.126-1.253.65-1.835 1.633-1.941v3.85c0 .669-.236.937-1.099.993v.295h3.82v-.295c-.864-.056-1.1-.324-1.1-.993v-3.85c.983.106 1.507.688 1.634 1.941H24V9.262h-5.475Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
