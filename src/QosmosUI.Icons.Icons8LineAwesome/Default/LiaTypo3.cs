// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaTypo3 : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M11.7 6.5C11.8 9 13.2 13 14.6 16c1.8 3.8 3.4 5.6 4.7 6.5C17 25.6 15 27 14.4 27s-2.6-1.5-5-6.3C7.4 16.8 6 12.4 6 9.9 6 9.4 6.1 9.1 6.1 9 6.9 8.2 9 7.2 11.7 6.5M14.4 4C10.5 4.5 6 5.9 4.5 7.8 4.2 8.2 4 8.9 4 9.9 4 15.7 10 29 14.4 29c2 0 5.5-3.4 8.3-7.9-.4.1-.7.1-1.1.1-3.2 0-7.9-11.3-7.9-15C13.7 4.8 14 4.4 14.4 4L14.4 4zM20.3 6c4.4 0 5.5.8 5.7 1 0 3.3-1.7 6.7-2.6 7.8C22.1 13.6 20 9 20 6 20.1 6 20.2 6 20.3 6M20.3 4C18.6 4 18 4.3 18 6c0 3.7 3 11 5.6 11 1.5 0 4.4-5.5 4.4-10.1C28 4.6 24.3 4 20.3 4L20.3 4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
