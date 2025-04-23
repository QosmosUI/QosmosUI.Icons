// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaCutSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 19.65625 4.3125 C 18.882813 4.40625 18.195313 4.953125 17.96875 5.75 L 15.3125 15.0625 L 11.96875 16.03125 C 11.730469 14.335938 10.257813 13 8.5 13 C 6.578125 13 5 14.578125 5 16.5 C 5 18.421875 6.578125 20 8.5 20 C 9.789063 20 10.925781 19.269531 11.53125 18.21875 L 14.65625 17.34375 L 13.78125 20.46875 C 12.730469 21.074219 12 22.210938 12 23.5 C 12 25.421875 13.578125 27 15.5 27 C 17.421875 27 19 25.421875 19 23.5 C 19 21.742188 17.664063 20.269531 15.96875 20.03125 L 20.4375 4.375 C 20.171875 4.300781 19.914063 4.28125 19.65625 4.3125 Z M 27.625 11.5625 L 18.90625 14.03125 L 18.25 16.3125 L 26.25 14.03125 C 27.3125 13.726563 27.929688 12.625 27.625 11.5625 Z M 8.5 15 C 9.339844 15 10 15.660156 10 16.5 C 10 17.339844 9.339844 18 8.5 18 C 7.660156 18 7 17.339844 7 16.5 C 7 15.660156 7.660156 15 8.5 15 Z M 15.5 22 C 16.339844 22 17 22.660156 17 23.5 C 17 24.339844 16.339844 25 15.5 25 C 14.660156 25 14 24.339844 14 23.5 C 14 22.660156 14.660156 22 15.5 22 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
