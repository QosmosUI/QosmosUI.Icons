// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaFeatherAltSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 27 4 C 18.197 4 13.798547 8.7946094 11.685547 11.099609 L 8.6367188 14.175781 C 6.9357187 15.874781 6 18.134063 6 20.539062 L 6 22 L 8.0273438 19.972656 C 8.1593437 18.316656 8.862875 16.775797 10.046875 15.591797 L 13.160156 12.451172 C 14.996156 10.449172 18.728609 6.3784375 25.974609 6.0234375 C 25.75316 10.544739 24.085863 13.696801 22.376953 15.875 L 19 17 L 21.417969 17 C 20.723657 17.756409 20.066554 18.365046 19.548828 18.839844 L 18.568359 19.810547 L 15 21 L 17.367188 21 L 16.410156 21.947266 C 15.088156 23.269266 13.330937 23.998047 11.460938 23.998047 L 9.4160156 23.998047 L 18.707031 14.707031 L 17.292969 13.292969 L 4 26.585938 L 5.4140625 28 L 7.4160156 25.998047 L 11.460938 25.998047 C 13.864937 25.998047 16.125125 25.061422 17.828125 23.357422 L 20.898438 20.3125 C 23.203437 18.2015 28 13.804 28 5 L 28 4 L 27 4 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
