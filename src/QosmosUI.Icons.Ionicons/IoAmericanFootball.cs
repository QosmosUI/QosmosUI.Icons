// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoAmericanFootball : ComponentBase
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
		builder.AddAttribute(14, "d", "M122.06,122.06c-44.37,44.37-66.71,100.61-78,145.28L244.66,467.9c44.67-11.25,100.91-33.59,145.28-78s66.71-100.61,78-145.28L267.34,44.1C222.67,55.35,166.43,77.69,122.06,122.06ZM378.79,378.78h0ZM300.65,189,323,166.71A15.78,15.78,0,0,1,345.29,189L323,211.35l11.16,11.17a15.78,15.78,0,0,1-22.32,22.32l-11.16-11.16L278.32,256l11.16,11.16a15.78,15.78,0,1,1-22.32,22.32L256,278.32l-22.32,22.33,11.16,11.16a15.78,15.78,0,1,1-22.32,22.32L211.35,323,189,345.29A15.78,15.78,0,0,1,166.71,323L189,300.65l-11.16-11.17a15.78,15.78,0,0,1,22.32-22.32l11.16,11.16L233.68,256l-11.16-11.16a15.78,15.78,0,1,1,22.32-22.32L256,233.68l22.32-22.33-11.16-11.16a15.78,15.78,0,0,1,22.32-22.32Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M476.57,199.63c7.31-54.53,4-120.26-20-144.21s-89.68-27.3-144.21-20c-2.51.34-5.16.72-7.91,1.15l171,171C475.85,204.79,476.23,202.14,476.57,199.63Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M35.43,312.37c-7.31,54.53-4,120.26,20,144.21C72.17,473.33,109.34,480,148.84,480a387,387,0,0,0,50.79-3.43c2.51-.34,5.16-.72,7.91-1.15l-171-171C36.15,307.21,35.77,309.86,35.43,312.37Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
