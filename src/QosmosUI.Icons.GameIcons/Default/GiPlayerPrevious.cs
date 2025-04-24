// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiPlayerPrevious : ComponentBase
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
		builder.AddAttribute(14, "d", "M208 16l-64 64 64 64V96h160V64H208V16zm-83.7 111.9c-17.9 2.3-34.14 23.2-34.14 50.4 0 14.8 5.2 28 12.84 37.2l9 10.8-13.94 2.6c-9.8 2-17 7.1-23.2 15.6-6.2 8.5-10.9 20.3-14.2 33.9-6 24.6-7.3 54.7-7.5 81.3h32.7l9 120.5c22.84 5.2 47.14 5 69.14 0l7.9-120.5h31.2c0-26.9-.4-57.4-5.8-82.3-3-13.6-7.5-25.4-13.8-33.8-6.2-8.4-13.8-13.5-24.8-15.3l-14.3-2.2 9.1-11.2c7.2-9.1 12.1-22.1 12.1-36.6 0-29-18.1-50.3-37.6-50.3l-3.7-.1zm256 0c-17.9 2.3-34.1 23.2-34.1 50.4 0 14.8 5.2 28 12.8 37.2l9 10.8-13.9 2.6c-9.8 2-17 7.1-23.2 15.6-6.2 8.5-10.9 20.3-14.2 33.9-6 24.6-7.3 54.7-7.5 81.3h32.7l9 120.5c22.8 5.2 47.1 5 69.1 0l7.9-120.5h31.2c0-26.9-.4-57.4-5.8-82.3-3-13.6-7.5-25.4-13.8-33.8-6.2-8.4-13.8-13.5-24.8-15.3l-14.3-2.2 9.1-11.2c7.2-9.1 12.1-22.1 12.1-36.6 0-29-18.1-50.3-37.6-50.3l-3.7-.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
