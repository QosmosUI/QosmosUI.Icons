// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiCarWashingFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M19 21H5V22C5 22.5523 4.55228 23 4 23H3C2.44772 23 2 22.5523 2 22V13L4.4174 8.97099C4.77884 8.36858 5.42986 7.99998 6.13238 7.99998H17.8676C18.5701 7.99998 19.2212 8.36858 19.5826 8.97099L22 13V22C22 22.5523 21.5523 23 21 23H20C19.4477 23 19 22.5523 19 22V21ZM4.33238 13H19.6676L17.8676 9.99998H6.13238L4.33238 13ZM6.5 18C7.32843 18 8 17.3284 8 16.5C8 15.6716 7.32843 15 6.5 15C5.67157 15 5 15.6716 5 16.5C5 17.3284 5.67157 18 6.5 18ZM17.5 18C18.3284 18 19 17.3284 19 16.5C19 15.6716 18.3284 15 17.5 15C16.6716 15 16 15.6716 16 16.5C16 17.3284 16.6716 18 17.5 18ZM5.43934 3.43932L6.5 2.37866L7.56066 3.43932C7.83211 3.71077 8 4.08577 8 4.49998C8 5.32841 7.32843 5.99998 6.5 5.99998C5.67157 5.99998 5 5.32841 5 4.49998C5 4.08577 5.16789 3.71077 5.43934 3.43932ZM10.9393 3.43932L12 2.37866L13.0607 3.43932C13.3321 3.71077 13.5 4.08577 13.5 4.49998C13.5 5.32841 12.8284 5.99998 12 5.99998C11.1716 5.99998 10.5 5.32841 10.5 4.49998C10.5 4.08577 10.6679 3.71077 10.9393 3.43932ZM16.4393 3.43932L17.5 2.37866L18.5607 3.43932C18.8321 3.71077 19 4.08577 19 4.49998C19 5.32841 18.3284 5.99998 17.5 5.99998C16.6716 5.99998 16 5.32841 16 4.49998C16 4.08577 16.1679 3.71077 16.4393 3.43932Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
