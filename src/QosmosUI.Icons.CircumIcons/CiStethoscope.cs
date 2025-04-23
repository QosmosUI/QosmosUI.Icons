// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiStethoscope : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Stethoscope");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M18.185,9.256a2.748,2.748,0,0,0-.5,5.45v2.31a2.923,2.923,0,0,1-2.92,2.92h-2.78a2.923,2.923,0,0,1-2.92-2.92v-.98a5.5,5.5,0,0,0,5-5.47V5.286a1.483,1.483,0,0,0-1.03-1.42l-2.31-.78a.5.5,0,0,0-.63.32.491.491,0,0,0,.31.63l2.32.78a.486.486,0,0,1,.34.47v5.28a4.5,4.5,0,0,1-9,0V5.286a.486.486,0,0,1,.34-.47l2.32-.78a.491.491,0,0,0,.31-.63.5.5,0,0,0-.63-.32l-2.31.78a1.483,1.483,0,0,0-1.03,1.42v5.28a5.5,5.5,0,0,0,5,5.47v.98a3.926,3.926,0,0,0,3.92,3.92h2.78a3.926,3.926,0,0,0,3.92-3.92v-2.31a2.748,2.748,0,0,0-.5-5.45Zm0,4.5a1.75,1.75,0,1,1,1.75-1.75A1.758,1.758,0,0,1,18.185,13.756Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
