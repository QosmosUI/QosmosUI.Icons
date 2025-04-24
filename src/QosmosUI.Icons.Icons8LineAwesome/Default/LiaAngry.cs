// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaAngry : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4 C 9.382813 4 4 9.382813 4 16 C 4 22.617188 9.382813 28 16 28 C 22.617188 28 28 22.617188 28 16 C 28 9.382813 22.617188 4 16 4 Z M 16 6 C 21.535156 6 26 10.464844 26 16 C 26 21.535156 21.535156 26 16 26 C 10.464844 26 6 21.535156 6 16 C 6 10.464844 10.464844 6 16 6 Z M 10.6875 12 C 10.265625 12.425781 10 13.007813 10 13.65625 C 10 14.949219 11.050781 16 12.34375 16 C 12.988281 16 13.578125 15.738281 14 15.3125 Z M 21.3125 12 L 18 15.3125 C 18.421875 15.738281 19.011719 16 19.65625 16 C 20.949219 16 22 14.949219 22 13.65625 C 22 13.011719 21.738281 12.421875 21.3125 12 Z M 18.5625 17.84375 C 18.417969 17.847656 18.265625 17.855469 18.125 17.875 C 17.003906 18.042969 16.15625 18.65625 15.40625 19.15625 C 14.65625 19.65625 13.996094 20.046875 13.5 20.125 C 13.003906 20.203125 12.558594 20.125 11.71875 19.28125 L 10.28125 20.71875 C 11.414063 21.859375 12.703125 22.269531 13.8125 22.09375 C 14.921875 21.917969 15.753906 21.308594 16.5 20.8125 C 17.246094 20.316406 17.886719 19.953125 18.40625 19.875 C 18.925781 19.796875 19.4375 19.863281 20.3125 20.71875 L 21.6875 19.28125 C 20.664063 18.28125 19.574219 17.828125 18.5625 17.84375 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
