// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaGlobeEuropeSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 3 C 8.832 3 3 8.832 3 16 C 3 23.168 8.832 29 16 29 C 23.168 29 29 23.168 29 16 C 29 8.832 23.168 3 16 3 z M 16 5 C 18.103 5 20.063328 5.6048125 21.736328 6.6328125 L 21.5 7.1992188 L 22.675781 8.375 L 21.574219 9.4746094 L 20 8 L 18 8 L 16 10.5 L 17 12.699219 L 18 12 L 18 11 L 19 11 L 20.099609 11.900391 L 19 13 L 15 15 L 14 15 L 14 17 L 15 17 L 17 16 L 18 17 L 20 17 L 20 16 L 20.800781 14.800781 L 23 14 L 23 16 L 21 16 L 21 17 L 23 17 L 25 20 L 26 19 L 26 18 L 25 18 L 25 17 L 26 17 L 26.960938 16.792969 C 26.814937 18.834969 26.113 20.720688 25 22.304688 L 25 22 L 23.900391 22 L 21.5 18 L 19 19 L 16 18 L 13 19 L 12 22 L 13 24 L 15 24 L 16 23 L 17 24 L 17 26.949219 C 16.67 26.979219 16.338 27 16 27 C 9.935 27 5 22.065 5 16 C 5 15.073 5.1287031 14.177406 5.3457031 13.316406 L 5.9003906 13 L 7 13 L 7 9.6953125 C 7.167 9.4583125 7.3374844 9.223 7.5214844 9 L 8.4199219 9 L 8.8574219 7.6503906 C 9.4854219 7.1123906 10.172156 6.6448125 10.910156 6.2578125 L 10 9 L 12 9 L 14 7 L 14 6 L 13 6 L 12 7 L 12 5.7636719 C 13.242 5.2766719 14.588 5 16 5 z M 14 11 L 14 13 L 15 13 L 15 11 L 14 11 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
