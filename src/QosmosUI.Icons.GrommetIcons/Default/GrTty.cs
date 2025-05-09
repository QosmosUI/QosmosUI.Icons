// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrTty : ComponentBase
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
		builder.AddAttribute(15, "stroke-linecap", "round");
		builder.AddAttribute(16, "stroke-width", "2");
		builder.AddAttribute(17, "d", "M7,19 L17,19 L17,19 C17.5522847,19 18,19.4477153 18,20 L18,20 L18,20 C18,20.5522847 17.5522847,21 17,21 L7,21 L7,21 C6.44771525,21 6,20.5522847 6,20 L6,20 L6,20 C6,19.4477153 6.44771525,19 7,19 Z M7,10 C7.55228475,10 8,9.55228475 8,9 C8,8.44771525 7.55228475,8 7,8 C6.44771525,8 6,8.44771525 6,9 C6,9.55228475 6.44771525,10 7,10 Z M7,5 C7.55228475,5 8,4.55228475 8,4 C8,3.44771525 7.55228475,3 7,3 C6.44771525,3 6,3.44771525 6,4 C6,4.55228475 6.44771525,5 7,5 Z M7,15 C7.55228475,15 8,14.5522847 8,14 C8,13.4477153 7.55228475,13 7,13 C6.44771525,13 6,13.4477153 6,14 C6,14.5522847 6.44771525,15 7,15 Z M12,10 C12.5522847,10 13,9.55228475 13,9 C13,8.44771525 12.5522847,8 12,8 C11.4477153,8 11,8.44771525 11,9 C11,9.55228475 11.4477153,10 12,10 Z M12,5 C12.5522847,5 13,4.55228475 13,4 C13,3.44771525 12.5522847,3 12,3 C11.4477153,3 11,3.44771525 11,4 C11,4.55228475 11.4477153,5 12,5 Z M12,15 C12.5522847,15 13,14.5522847 13,14 C13,13.4477153 12.5522847,13 12,13 C11.4477153,13 11,13.4477153 11,14 C11,14.5522847 11.4477153,15 12,15 Z M17,10 C17.5522847,10 18,9.55228475 18,9 C18,8.44771525 17.5522847,8 17,8 C16.4477153,8 16,8.44771525 16,9 C16,9.55228475 16.4477153,10 17,10 Z M17,5 C17.5522847,5 18,4.55228475 18,4 C18,3.44771525 17.5522847,3 17,3 C16.4477153,3 16,3.44771525 16,4 C16,4.55228475 16.4477153,5 17,5 Z M17,15 C17.5522847,15 18,14.5522847 18,14 C18,13.4477153 17.5522847,13 17,13 C16.4477153,13 16,13.4477153 16,14 C16,14.5522847 16.4477153,15 17,15 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
