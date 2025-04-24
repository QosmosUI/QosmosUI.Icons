// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrBus : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M3,12 L21,12 L21,20 L3,20 L3,12 Z M3,3.99961498 C3,2.89525812 3.8926228,2 4.99508929,2 L19.0049107,2 C20.1067681,2 21,2.88743329 21,3.99961498 L21,12 L3,12 L3,3.99961498 Z M3,20 L6,20 L6,22.0010434 C6,22.5527519 5.55733967,23 5.00104344,23 L3.99895656,23 C3.44724809,23 3,22.5573397 3,22.0010434 L3,20 Z M18,20 L21,20 L21,22.0010434 C21,22.5527519 20.5573397,23 20.0010434,23 L18.9989566,23 C18.4472481,23 18,22.5573397 18,22.0010434 L18,20 Z M7,17 C7.55228475,17 8,16.5522847 8,16 C8,15.4477153 7.55228475,15 7,15 C6.44771525,15 6,15.4477153 6,16 C6,16.5522847 6.44771525,17 7,17 Z M17,17 C17.5522847,17 18,16.5522847 18,16 C18,15.4477153 17.5522847,15 17,15 C16.4477153,15 16,15.4477153 16,16 C16,16.5522847 16.4477153,17 17,17 Z M12,6 L12,12 M1,5 L1,13 M23,5 L23,13 M10,16 L14,16 M3,5.99975586 L21,6");
		builder.CloseElement();
		builder.CloseElement();
    }
}
