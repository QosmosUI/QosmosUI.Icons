// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaCloudSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 7 C 13.351563 7 11.050781 8.238281 9.40625 10.0625 C 9.269531 10.046875 9.148438 10 9 10 C 6.800781 10 5 11.800781 5 14 C 3.269531 15.054688 2 16.835938 2 19 C 2 22.300781 4.699219 25 8 25 L 24 25 C 27.300781 25 30 22.300781 30 19 C 30 15.84375 27.511719 13.316406 24.40625 13.09375 C 23.183594 9.574219 19.925781 7 16 7 Z M 16 9 C 19.277344 9 22.011719 11.253906 22.78125 14.28125 L 22.96875 15.0625 L 23.8125 15.03125 C 24.023438 15.019531 24.070313 15 24 15 C 26.21875 15 28 16.78125 28 19 C 28 21.21875 26.21875 23 24 23 L 8 23 C 5.78125 23 4 21.21875 4 19 C 4 17.339844 5.007813 15.921875 6.4375 15.3125 L 7.125 15.03125 L 7.03125 14.28125 C 7.011719 14.117188 7 14.023438 7 14 C 7 12.882813 7.882813 12 9 12 C 9.140625 12 9.296875 12.019531 9.46875 12.0625 L 10.09375 12.21875 L 10.46875 11.71875 C 11.75 10.074219 13.75 9 16 9 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
