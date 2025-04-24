// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoGift : ComponentBase
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
		builder.AddAttribute(14, "d", "M200,144h40V104a40,40,0,1,0-40,40Z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M352,104a40,40,0,0,0-80,0v40h40A40,40,0,0,0,352,104Z");
		builder.AddAttribute(18, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M80,416a64,64,0,0,0,64,64h92a4,4,0,0,0,4-4V292a4,4,0,0,0-4-4H88a8,8,0,0,0-8,8Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M240,252V144h32V252a4,4,0,0,0,4,4H416a47.93,47.93,0,0,0,16-2.75h0A48.09,48.09,0,0,0,464,208V192a48,48,0,0,0-48-48H375.46a2,2,0,0,1-1.7-3A72,72,0,0,0,256,58.82,72,72,0,0,0,138.24,141a2,2,0,0,1-1.7,3H96a48,48,0,0,0-48,48v16a48.09,48.09,0,0,0,32,45.25h0A47.93,47.93,0,0,0,96,256H236A4,4,0,0,0,240,252Zm32-148a40,40,0,1,1,40,40H272ZM197.14,64.1A40,40,0,0,1,240,104v40H200a40,40,0,0,1-2.86-79.89Z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M276,480h92a64,64,0,0,0,64-64V296a8,8,0,0,0-8-8H276a4,4,0,0,0-4,4V476A4,4,0,0,0,276,480Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
