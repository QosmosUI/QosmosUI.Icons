// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiClothespin : ComponentBase
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
		builder.AddAttribute(14, "d", "M144.4 21.08c-7-.01-13 7.72-8.1 17.19l77.2 148.63c10.3-1.7 21.2 1.5 29 9.3 4.2 4.2 7.1 9.4 8.6 14.8h.1l.4 2.3c.1.5.2.9.2 1.4l6.3 35.4 33.7 34s22.8-9.2 29.4-1.9c5.9 6.5-4.5 25.9-4.5 25.9l38 38c28.8 2.2 58.6 17.3 51.1 54.5l12.1 12c64.3 4.4 85-1 66.6-20.9L383.1 282s-12.8 1.6-20-6.1c-6.5-7.1.5-19.8.5-19.8l-211-231.11c-2.5-2.73-5.4-3.91-8.2-3.91zM31.32 134.5c-9.22.1-14.22 10.9-6.33 18.1l231.11 211s1.3-.7 3.3-1.5l-20.2-114.8-.8-.8c-12.8 8.9-30.8 7.4-42.2-4-7.8-7.8-11-18.7-9.3-29L38.28 136.3c-2.47-1.3-4.83-1.8-6.96-1.8zm187.78 69.8c-3.8-.1-7.6 1.4-10.5 4.3-5.8 5.8-5.8 15.1.3 21.2s15.4 6.1 21.2.3c5.8-5.8 5.8-15.1-.3-21.2-3-3-6.9-4.6-10.7-4.6zm42.4 65.1l17 96.9c4.7 7.3 3.5 16.8 3.5 16.8l109.7 101.4c19.9 18.4 25.3-2.3 20.9-66.6l-12-12.1c-37.2 7.5-52.3-22.3-54.5-51.1l-38-38s-19.4 10.4-25.9 4.5c-7.3-6.6 1.9-29.4 1.9-29.4l-22.6-22.4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
