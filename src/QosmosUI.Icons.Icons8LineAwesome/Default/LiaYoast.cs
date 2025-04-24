// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaYoast : ComponentBase
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
		builder.AddAttribute(14, "d", "M 20.800781 4 L 15.800781 17.5 L 13 10 L 10 10 L 14 19.5 C 14 19.5 14.200781 20.099609 14.300781 20.599609 L 14.300781 21.300781 C 14.300781 21.500781 14.199609 21.8 14.099609 22 C 13.499609 23.2 12.399609 23.900391 11.099609 23.900391 L 11.099609 26.900391 C 13.799609 26.900391 16.199609 25.199219 17.099609 22.699219 L 24 4 L 20.800781 4 z M 9 7 C 6.8 7 5 8.8 5 11 L 5 21 C 5 23.2 6.8 25 9 25 L 9.9003906 25 L 9.9003906 24 L 9 24 C 7.3 24 6 22.6 6 21 L 6 11 C 6 9.3 7.3 8 9 8 L 18.099609 8 L 18.5 7 L 9 7 z M 24 7.0996094 L 23.699219 8.0996094 C 24.999219 8.3996094 26 9.6 26 11 L 26 24 L 17.699219 24 C 17.499219 24.3 17.299609 24.7 17.099609 25 L 27 25 L 27 11 C 27 9.1 25.7 7.5996094 24 7.0996094 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
