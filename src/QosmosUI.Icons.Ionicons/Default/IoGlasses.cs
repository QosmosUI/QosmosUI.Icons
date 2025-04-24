// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoGlasses : ComponentBase
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
		builder.AddAttribute(14, "d", "M464,184H453.1a78.72,78.72,0,0,0-16-7.18C419.5,171,396.26,168,368,168s-51.5,3-69.06,8.82c-14.06,4.69-20.25,9.86-22.25,11.87h0a47.94,47.94,0,0,0-41.36,0h0c-2-2-8.19-7.18-22.25-11.87C195.5,171,172.26,168,144,168s-51.5,3-69.06,8.82a78.72,78.72,0,0,0-16,7.18H48a16,16,0,0,0,0,32h.17c1,45.46,6.44,72.78,18.11,92.23a66.78,66.78,0,0,0,31.92,28c12.23,5.24,27.22,7.79,45.8,7.79,24.15,0,58.48-3.71,77.72-35.77,9.68-16.14,15.09-37.69,17.21-70.52A16,16,0,0,0,240,232a16,16,0,0,1,32,0,16,16,0,0,0,1.07,5.71c2.12,32.83,7.53,54.38,17.21,70.52a66.78,66.78,0,0,0,31.92,28c12.23,5.24,27.22,7.79,45.8,7.79,24.15,0,58.48-3.71,77.72-35.77,11.67-19.45,17.13-46.77,18.11-92.23H464a16,16,0,0,0,0-32Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
