// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiKatana : ComponentBase
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
		builder.AddAttribute(14, "d", "M482.403 42.826c-10.537-8.76-24.84-4.167-43.264 11.643-76.1 65.307-202.78 179.14-282.432 269.103l21.07 21.07c82.21-87.285 203.37-205.524 304.625-301.817zm-338.477 293.42l-17.17 17.028 22.302 22.303c5.313-5.817 10.787-11.75 16.41-17.79zm-56.796.03l-12.728 12.728 79.196 79.196 12.728-12.728zm2.942 54.185l-60.475 60.475c.372 11.49 10.708 22.336 22.628 22.627l60.474-60.474-8.137-8.136c2.657 4.264 2.84 8.705.457 11.097-3.124 3.123-9.554 1.758-14.363-3.05 4.808 4.808 6.174 11.24 3.05 14.363-3.125 3.124-9.555 1.76-14.364-3.05 4.81 4.81 6.174 11.24 3.05 14.363-3.124 3.125-9.555 1.76-14.363-3.05 4.808 4.81 6.173 11.24 3.05 14.364-3.125 3.124-9.556 1.76-14.364-3.05 4.808 4.81 6.174 11.24 3.05 14.364-3.125 3.124-9.555 1.76-14.364-3.05-4.808-4.808-6.173-11.24-3.05-14.363 3.125-3.123 9.556-1.758 14.364 3.05-4.808-4.808-6.173-11.238-3.05-14.362 3.125-3.125 9.555-1.76 14.364 3.05-4.81-4.81-6.174-11.24-3.05-14.364 3.125-3.124 9.555-1.76 14.363 3.05-4.808-4.81-6.173-11.24-3.05-14.364 3.125-3.124 9.556-1.76 14.364 3.05-4.808-4.81-6.173-11.24-3.05-14.364 2.39-2.383 6.828-2.202 11.09.45z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
