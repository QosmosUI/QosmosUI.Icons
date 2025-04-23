// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaMehRollingEyes : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 3 C 8.832 3 3 8.832 3 16 C 3 23.168 8.832 29 16 29 C 23.168 29 29 23.168 29 16 C 29 8.832 23.168 3 16 3 z M 16 5 C 22.065 5 27 9.935 27 16 C 27 22.065 22.065 27 16 27 C 9.935 27 5 22.065 5 16 C 5 9.935 9.935 5 16 5 z M 11 10 C 8.794 10 7 11.794 7 14 C 7 16.206 8.794 18 11 18 C 13.206 18 15 16.206 15 14 C 15 11.794 13.206 10 11 10 z M 21 10 C 18.794 10 17 11.794 17 14 C 17 16.206 18.794 18 21 18 C 23.206 18 25 16.206 25 14 C 25 11.794 23.206 10 21 10 z M 10.019531 12.267578 A 1.5 1.5 0 0 0 11.5 14 A 1.5 1.5 0 0 0 12.826172 13.195312 C 12.935451 13.442238 13 13.713012 13 14 C 13 15.103 12.103 16 11 16 C 9.897 16 9 15.103 9 14 C 9 13.255097 9.4141487 12.611734 10.019531 12.267578 z M 21.980469 12.267578 C 22.585851 12.611734 23 13.255097 23 14 C 23 15.103 22.103 16 21 16 C 19.897 16 19 15.103 19 14 C 19 13.713012 19.064549 13.442238 19.173828 13.195312 A 1.5 1.5 0 0 0 20.5 14 A 1.5 1.5 0 0 0 21.980469 12.267578 z M 12 20 L 12 22 L 20 22 L 20 20 L 12 20 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
