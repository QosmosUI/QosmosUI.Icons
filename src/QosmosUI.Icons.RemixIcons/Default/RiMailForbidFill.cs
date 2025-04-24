// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiMailForbidFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M15.2657 11.5541L19.6544 7.75616L18.3456 6.24384L12.0606 11.6829L5.64722 6.2377L4.35278 7.7623L12.0554 14.3021C11.3865 15.3751 11 16.6424 11 18C11 19.0736 11.2417 20.0907 11.6736 21H3C2.44772 21 2 20.5523 2 20V4C2 3.44772 2.44772 3 3 3H21C21.5523 3 22 3.44772 22 4V12.2547C20.8662 11.4638 19.4872 11 18 11C17.0298 11 16.1057 11.1974 15.2657 11.5541ZM16.7066 20.7076C17.0982 20.895 17.5369 21 18 21C19.6569 21 21 19.6569 21 18C21 17.5369 20.895 17.0982 20.7076 16.7066L16.7066 20.7076ZM15.2924 19.2934L19.2934 15.2924C18.9018 15.105 18.4631 15 18 15C16.3431 15 15 16.3431 15 18C15 18.4631 15.105 18.9018 15.2924 19.2934ZM18 23C15.2386 23 13 20.7614 13 18C13 15.2386 15.2386 13 18 13C20.7614 13 23 15.2386 23 18C23 20.7614 20.7614 23 18 23Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
