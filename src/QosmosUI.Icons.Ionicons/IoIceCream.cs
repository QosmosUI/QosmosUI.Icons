// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoIceCream : ComponentBase
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
		builder.AddAttribute(14, "d", "M183,352c-21.84-.52-39-18.9-39-40.74V277.19a8,8,0,0,0-6-7.74C104.25,260.6,80,229.74,80,192a80.14,80.14,0,0,1,66.27-78.82,8,8,0,0,0,6.62-6.83,104,104,0,0,1,206.22,0,8,8,0,0,0,6.62,6.83A80,80,0,0,1,352,272a74.33,74.33,0,0,1-47.45-17.41,7.93,7.93,0,0,0-9.92-.14A62.89,62.89,0,0,1,256,268a80.47,80.47,0,0,1-21.8-3.18,8,8,0,0,0-10.2,7.69V312A40,40,0,0,1,183,352Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M263.39,299.7a8,8,0,0,0-7.39,7.91V312a72.11,72.11,0,0,1-50.69,68.76,8,8,0,0,0-4.91,10.78l40.91,94.8A16,16,0,0,0,256,496h0a16,16,0,0,0,14.69-9.7l73.78-172.15a8,8,0,0,0-6.2-11.07,106.31,106.31,0,0,1-35.9-11.59,8,8,0,0,0-7.13-.2A95,95,0,0,1,263.39,299.7Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
