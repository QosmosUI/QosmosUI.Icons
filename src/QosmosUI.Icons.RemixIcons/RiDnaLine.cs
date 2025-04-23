// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiDnaLine : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M18 1C18 1.71561 17.9359 2.37948 17.8155 3H8.23193C8.41382 3.72694 8.69997 4.38283 9.08066 5H17.1807C16.132 7.31672 14.1871 8.99371 12 10.7267C8.72906 8.13494 6 5.66845 6 1H4C4 6.46624 7.21013 9.46355 10.3863 12C7.21013 14.5365 4 17.5338 4 23H6C6 18.0404 9.08011 15.566 12.6178 12.7863L12.7096 12.7142C16.149 10.0123 20 6.98705 20 1H18ZM17.8155 21.0002H8.23193C8.41382 20.2733 8.69997 19.6174 9.08066 19.0002H17.1807C16.3939 17.262 15.1026 15.8839 13.583 14.5721C14.1162 14.1516 14.6526 13.7351 15.1811 13.3086C17.7659 15.5981 20 18.44 20 23.0002H18C18 22.2846 17.9359 21.6207 17.8155 21.0002Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
