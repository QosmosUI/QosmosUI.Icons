// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaWheelchairSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 20 3 C 18.355469 3 17 4.355469 17 6 C 17 7.644531 18.355469 9 20 9 C 21.644531 9 23 7.644531 23 6 C 23 4.355469 21.644531 3 20 3 Z M 20 5 C 20.5625 5 21 5.4375 21 6 C 21 6.5625 20.5625 7 20 7 C 19.4375 7 19 6.5625 19 6 C 19 5.4375 19.4375 5 20 5 Z M 14.53125 7.78125 L 10.9375 8.1875 C 10.34375 8.253906 9.824219 8.589844 9.5 9.09375 L 7 12.96875 L 8.6875 14.03125 L 11.1875 10.1875 L 13.46875 9.9375 L 12 14.09375 C 8.617188 14.582031 6 17.484375 6 21 C 6 24.855469 9.144531 28 13 28 C 16.855469 28 20 24.855469 20 21 C 20 20.660156 19.953125 20.328125 19.90625 20 L 21.1875 20 L 22.53125 26.09375 L 24.46875 25.65625 L 23.15625 19.5625 C 22.957031 18.648438 22.121094 18 21.1875 18 L 19.3125 18 C 18.914063 17.160156 18.339844 16.429688 17.65625 15.8125 L 18.8125 12.59375 C 19.316406 11.199219 18.710938 9.636719 17.40625 8.9375 L 15.71875 8 L 15.71875 8.03125 C 15.359375 7.839844 14.933594 7.734375 14.53125 7.78125 Z M 15.53125 10.1875 L 16.46875 10.6875 C 16.914063 10.925781 17.109375 11.433594 16.9375 11.90625 L 15.9375 14.65625 C 15.359375 14.386719 14.742188 14.195313 14.09375 14.09375 Z M 13 16 C 15.773438 16 18 18.226563 18 21 C 18 23.773438 15.773438 26 13 26 C 10.226563 26 8 23.773438 8 21 C 8 18.226563 10.226563 16 13 16 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
