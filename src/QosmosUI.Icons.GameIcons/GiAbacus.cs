// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiAbacus : ComponentBase
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
		builder.AddAttribute(14, "d", "M37 73v382h18V73zm418.045 0l1.91 382h18l-1.91-382zM105 160c-14.638 0-27.157 9.715-31.43 23-2.405 6.634-1.479 14.38-.574 18 3.61 14.3 16.641 25 32.004 25 14.17 0 26.36-9.102 31-21.736C140.64 216.898 152.83 226 167 226c15.363 0 28.394-10.7 32.004-25h238.682l-.09-18H198.43c-4.273-13.285-16.792-23-31.43-23-14.17 0-26.36 9.102-31 21.736C131.36 169.102 119.17 160 105 160zm0 18c8.39 0 15 6.61 15 15s-6.61 15-15 15-15-6.61-15-15 6.61-15 15-15zm62 0c8.39 0 17 6.61 17 15s-8.61 15-17 15-15-6.61-15-15 6.61-15 15-15zm33 45c-15.002 0-27.775 10.206-31.729 24H73v18h95.271c3.954 13.794 16.727 24 31.729 24 15.002 0 27.775-10.206 31.729-24h206.277l-.092-18H231.73c-3.954-13.794-16.727-24-31.729-24zm0 18c8.39 0 15 6.61 15 15s-6.61 15-15 15-15-6.61-15-15 6.61-15 15-15zm83 47c-14.638 0-27.157 9.715-31.43 23H73v18h177.996c3.61 14.3 16.641 25 32.004 25 14.17 0 26.36-9.102 31-21.736C318.64 344.898 330.83 354 345 354c14.17 0 26.36-9.102 31-21.736C380.64 344.898 392.83 354 407 354c15.363 0 28.394-10.7 32.004-25 1.31-3.077.621-13.458-.77-18C432 294.406 418.467 288.286 407 288c-14.17 0-26.36 9.102-31 21.736C371.36 297.102 359.17 288 345 288c-14.17 0-26.36 9.102-31 21.736C309.36 297.102 297.17 288 283 288zm62 66c-13.892 0-25.874 8.752-30.71 21H73v18h239.564c2.853 15.29 16.366 27 32.436 27s29.583-11.71 32.436-27h61.209l-.09-18H375.71c-4.837-12.248-16.819-21-30.711-21zm-62-48c8.39 0 15 6.61 15 15s-6.61 15-15 15-15-6.61-15-15 6.61-15 15-15zm62 0c8.39 0 15 6.61 15 15s-6.61 15-15 15-15-6.61-15-15 6.61-15 15-15zm62 0c8.39 0 15 6.61 15 15s-6.61 15-15 15-15-6.61-15-15 6.61-15 15-15zm-62 66c8.39 0 15 6.61 15 15s-6.61 15-15 15-15-6.61-15-15 6.61-15 15-15zM25 473v16h462v-16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
