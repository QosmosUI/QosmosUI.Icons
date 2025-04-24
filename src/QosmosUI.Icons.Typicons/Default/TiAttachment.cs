// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiAttachment : ComponentBase
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
		builder.AddAttribute(14, "d", "M18.364 6.635c-1.561-1.559-4.1-1.559-5.658 0l-4.534 4.535c-.473.473-.733 1.1-.733 1.77 0 .668.261 1.295.732 1.768.487.486 1.128.73 1.769.73.64 0 1.279-.242 1.767-.73l2.122-2.121c.391-.395.586-.904.586-1.414 0-.512-.195-1.023-.586-1.414l-3.536 3.535c-.193.195-.511.195-.708-.002-.127-.127-.146-.275-.146-.352 0-.078.019-.227.146-.354l4.535-4.537c.778-.779 2.048-.779 2.83 0 .779.779.779 2.049 0 2.828l-4.537 4.537-2.535 2.535c-.779.779-2.049.779-2.828 0-.78-.779-.78-2.049 0-2.828l.095-.096c-.451-.6-.702-1.359-.702-2.125l-.807.807c-1.56 1.559-1.56 4.098 0 5.656.779.779 1.804 1.17 2.828 1.17s2.049-.391 2.828-1.17l7.072-7.072c1.56-1.559 1.56-4.096 0-5.656z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
