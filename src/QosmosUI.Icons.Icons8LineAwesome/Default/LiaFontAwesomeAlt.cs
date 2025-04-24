// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaFontAwesomeAlt : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 27 L 27 27 L 27 5 L 5 5 z M 7 7 L 25 7 L 25 25 L 7 25 L 7 7 z M 12.5 9 A 1.5 1.5 0 0 0 11.001953 10.5 C 11.001953 10.5 11 10.5 11 10.5 L 11 22 C 11 22.552 11.448 23 12 23 C 12.552 23 13 22.552 13 22 L 13 17.744141 C 13.781734 17.455705 14.645201 17.234375 15.478516 17.234375 C 17.057516 17.234375 17.669375 18.050781 18.984375 18.050781 C 19.923375 18.050781 20.798234 17.732859 21.615234 17.380859 C 21.820234 17.292859 21.996094 17.205 21.996094 17 L 22.001953 17 L 22.001953 11.380859 C 22.001953 11.175859 21.795547 11 21.560547 11 C 21.266547 11 20.039687 11.787109 18.929688 11.787109 C 18.699688 11.787109 18.494062 11.757922 18.289062 11.669922 C 17.296062 11.292922 16.420547 11 15.310547 11 C 14.820777 11 14.31913 11.077205 13.828125 11.195312 A 1.5 1.5 0 0 0 12.5 9 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
