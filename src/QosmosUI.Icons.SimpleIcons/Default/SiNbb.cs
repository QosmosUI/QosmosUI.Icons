// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiNbb : ComponentBase
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
		builder.AddAttribute(15, "d", "M2.714 11.176h.02l.167 4.327h2.105L6.5 8.482H4.652l-.915 4.288h-.02L3.63 8.482H1.495L0 15.503h1.79zm7.254.649l.01-.02c.462-.098 1.219-.481 1.453-1.583.248-1.16-.362-1.74-1.59-1.74H7.007l-1.494 7.02h2.94c1.209 0 2.153-.619 2.458-2.025.295-1.416-.549-1.613-.944-1.652zm-1.052 1.504c-.099.462-.354.757-.787.757h-.345l.334-1.602h.354c.454 0 .542.373.444.845zm.472-2.753c-.108.511-.452.669-.708.669h-.295l.285-1.347h.266c.403 0 .55.225.452.678zm6.83 2.901c.295-1.416-.55-1.613-.944-1.652l.01-.02c.462-.098 1.219-.481 1.453-1.583.248-1.16-.362-1.74-1.591-1.74h-2.831l-1.495 7.02h2.94c1.21 0 2.153-.619 2.458-2.025zm-1.996-.148c-.098.462-.354.757-.787.757h-.344l.335-1.602h.354c.452 0 .54.373.442.845zm.472-2.753c-.108.511-.453.669-.708.669h-.294l.285-1.347h.266c.402 0 .55.225.45.678zm4.97-2.094h-2.951c.75.615.51 1.669.51 1.669H19.2l2.338 1.857-2.167 1.834h-2.72c-.117.568-.712 1.424-1.125 1.676h4.148L24 12.01z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
