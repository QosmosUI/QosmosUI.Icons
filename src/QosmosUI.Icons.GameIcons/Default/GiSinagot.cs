// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSinagot : ComponentBase
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
		builder.AddAttribute(14, "d", "M117.3 41.08c4.5 117.22-11 230.92-33.94 343.02 48.74 1.5 94.14-1.7 140.64-9 4.3-16.6 8.2-35.8 11.5-56.5-2.3-54.1-12.5-109.7-19.3-168.5zm69.6 15.03l.1 35.03L205.1 111l-.2-54.89zM264 123.6c4.5 93.3-5.8 198.4-25.1 265l116.2-12.5c3.3-60.6.3-114.4-6.3-174.3zm54.4 2.5v23.2l18 16.6v-39.8zm154.2 262.2c-53.5 11.2-87.7 15.4-136.2 22.4v-14.5l-18 1.9v15c-36.4 4.4-74.2 6.9-112.5 8.2l-.1-25.3c-6 .8-12 1.5-18 2.2l.1 23.6c-54.7 1.4-110.49.5-164.98-.3 14.72 13.6 24.36 31.5 46.67 43.8 101.81 9.9 200.41 4.6 299.21 0l22.4-46 97.9-17z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
