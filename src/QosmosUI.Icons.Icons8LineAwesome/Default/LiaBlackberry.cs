// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaBlackberry : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 3 C 8.832031 3 3 8.832031 3 16 C 3 23.167969 8.832031 29 16 29 C 23.167969 29 29 23.167969 29 16 C 29 8.832031 23.167969 3 16 3 Z M 16 5 C 22.085938 5 27 9.914063 27 16 C 27 22.085938 22.085938 27 16 27 C 9.914063 27 5 22.085938 5 16 C 5 9.914063 9.914063 5 16 5 Z M 9.71875 11 L 9.125 13.6875 L 11.28125 13.6875 C 12.953125 13.6875 13.4375 12.921875 13.4375 12.1875 C 13.4375 11.667969 13.117188 11 11.78125 11 Z M 15.25 11 L 14.65625 13.6875 L 16.8125 13.6875 C 18.484375 13.6875 18.96875 12.921875 18.96875 12.1875 C 18.96875 11.667969 18.644531 11 17.3125 11 Z M 20.3125 13.40625 L 19.71875 16.125 L 21.84375 16.125 C 23.515625 16.125 24 15.332031 24 14.59375 C 24 14.074219 23.675781 13.40625 22.34375 13.40625 Z M 8.96875 15.0625 L 8.40625 17.78125 L 10.53125 17.78125 C 12.203125 17.78125 12.6875 16.984375 12.6875 16.25 C 12.6875 15.730469 12.367188 15.0625 11.03125 15.0625 Z M 14.5 15.0625 L 13.9375 17.78125 L 16.0625 17.78125 C 17.734375 17.78125 18.21875 16.984375 18.21875 16.25 C 18.21875 15.730469 17.894531 15.0625 16.5625 15.0625 Z M 19.5 17.65625 L 18.90625 20.34375 L 21.0625 20.34375 C 22.734375 20.34375 23.1875 19.546875 23.1875 18.8125 C 23.1875 18.292969 22.894531 17.65625 21.5625 17.65625 Z M 13.71875 19.3125 L 13.125 22 L 15.28125 22 C 16.953125 22 17.40625 21.203125 17.40625 20.46875 C 17.40625 19.949219 17.113281 19.3125 15.78125 19.3125 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
