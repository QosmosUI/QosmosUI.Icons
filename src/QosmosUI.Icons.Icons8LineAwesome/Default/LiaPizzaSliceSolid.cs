// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaPizzaSliceSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 12.375 3.8125 L 12.0625 4.65625 L 4.0625 26.5625 L 3.84375 27.15625 L 4.84375 28.15625 L 5.4375 27.9375 L 27.34375 19.9375 L 28.1875 19.625 L 27.96875 18.75 C 27.96875 18.75 26.558594 13.121094 22.71875 9.28125 C 18.878906 5.441406 13.25 4.03125 13.25 4.03125 Z M 13.59375 6.28125 C 14.730469 6.632813 18.429688 7.867188 21.28125 10.71875 C 24.132813 13.570313 25.367188 17.269531 25.71875 18.40625 L 24.1875 18.96875 C 24.085938 18.566406 23.964844 18.097656 23.75 17.5625 C 23.140625 16.050781 22.003906 14.066406 19.96875 12.03125 C 17.933594 9.996094 15.949219 8.890625 14.4375 8.28125 C 13.898438 8.066406 13.4375 7.921875 13.03125 7.8125 Z M 12.375 9.6875 C 12.710938 9.777344 13.140625 9.90625 13.6875 10.125 C 14.976563 10.644531 16.734375 11.609375 18.5625 13.4375 C 19.097656 13.972656 19.539063 14.488281 19.9375 15 C 18.863281 15.035156 18 15.917969 18 17 C 18 18.105469 18.894531 19 20 19 C 20.738281 19 21.371094 18.597656 21.71875 18 C 21.761719 18.101563 21.835938 18.214844 21.875 18.3125 C 22.101563 18.875 22.222656 19.320313 22.3125 19.65625 L 12.3125 23.28125 C 12.058594 22.8125 11.570313 22.5 11 22.5 C 10.171875 22.5 9.5 23.171875 9.5 24 C 9.5 24.105469 9.511719 24.214844 9.53125 24.3125 L 6.625 25.375 L 10.125 15.78125 C 10.390625 15.910156 10.683594 16 11 16 C 12.105469 16 13 15.105469 13 14 C 13 13.066406 12.363281 12.285156 11.5 12.0625 Z M 14 17.5 C 13.171875 17.5 12.5 18.171875 12.5 19 C 12.5 19.828125 13.171875 20.5 14 20.5 C 14.828125 20.5 15.5 19.828125 15.5 19 C 15.5 18.171875 14.828125 17.5 14 17.5 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
