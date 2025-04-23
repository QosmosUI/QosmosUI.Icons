// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaUserClockSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 5.0996094 C 12.1 5.0996094 9 8.1996094 9 12.099609 C 9 14.499609 10.199609 16.700391 12.099609 17.900391 C 8.4996094 19.300391 6 22.9 6 27 L 8 27 C 8 22.6 11.6 19 16 19 C 16.6 19 17.099609 19.099219 17.599609 19.199219 C 17.646404 19.136826 17.706916 19.082754 17.755859 19.021484 C 16.660748 20.390674 16 22.12088 16 24 C 16 28.4 19.6 32 24 32 C 28.4 32 32 28.4 32 24 C 32 19.6 28.4 16 24 16 C 23.11185 16 22.258916 16.153497 21.458984 16.423828 C 22.422482 15.232493 23 13.666939 23 12.099609 C 23 8.1996094 19.9 5.0996094 16 5.0996094 z M 16 7 C 18.8 7 21 9.2 21 12 C 21 14.8 18.8 17 16 17 C 13.2 17 11 14.8 11 12 C 11 9.2 13.2 7 16 7 z M 19.275391 17.566406 C 19.246884 17.587431 19.217672 17.607515 19.189453 17.628906 C 19.218092 17.607757 19.246393 17.587198 19.275391 17.566406 z M 24 18 C 27.3 18 30 20.7 30 24 C 30 27.3 27.3 30 24 30 C 20.7 30 18 27.3 18 24 C 18 20.7 20.7 18 24 18 z M 18.498047 18.214844 C 18.374817 18.332124 18.256243 18.453318 18.140625 18.578125 C 18.256435 18.453832 18.37293 18.332436 18.498047 18.214844 z M 23 20 L 23 24.599609 L 21.300781 26.300781 L 22.699219 27.699219 L 25 25.400391 L 25 20 L 23 20 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
