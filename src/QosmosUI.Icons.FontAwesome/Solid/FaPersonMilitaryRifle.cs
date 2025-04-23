// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaPersonMilitaryRifle : ComponentBase
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
		builder.AddAttribute(14, "d", "M160 39c0-13 10-23.8 22.9-24.9L334.7 1.4C344 .7 352 8 352 17.4L352 48c0 8.8-7.2 16-16 16L185 64c-13.8 0-25-11.2-25-25zm17.6 57l156.8 0c1 5.2 1.6 10.5 1.6 16c0 44.2-35.8 80-80 80s-80-35.8-80-80c0-5.5 .6-10.8 1.6-16zm228 364.3L352 369.7 352 480c0 1.3-.1 2.5-.2 3.8L177.5 234.9c16.6-7.1 34.6-10.9 53.3-10.9l50.4 0c15.9 0 31.3 2.8 45.8 7.9L421.9 67.7c-7.7-4.4-10.3-14.2-5.9-21.9s14.2-10.3 21.9-5.9l13.9 8 13.9 8c7.7 4.4 10.3 14.2 5.9 21.9L416 173.9l1.6 .9c15.3 8.8 20.6 28.4 11.7 43.7L392.6 282c2 2.8 3.9 5.8 5.7 8.8l76.1 128.8c11.2 19 4.9 43.5-14.1 54.8s-43.5 4.9-54.8-14.1zM320 512l-128 0c-17.7 0-32-14.3-32-32l0-110.3-53.6 90.6c-11.2 19-35.8 25.3-54.8 14.1s-25.3-35.8-14.1-54.8l76.1-128.8c9.4-15.8 21.7-29.3 36-40L331.1 510c-3.5 1.3-7.2 2-11.1 2zM296 320a24 24 0 1 0 0-48 24 24 0 1 0 0 48z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
