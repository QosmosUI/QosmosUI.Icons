// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiKnifeBloodLine : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "d", "M4.34315 1.4082L22.3744 19.4394C22.9602 20.0252 22.9602 20.975 22.3744 21.5607C21.7886 22.1465 20.8388 22.1465 20.253 21.5607L15.6569 16.9646L12.1213 20.5001L8.001 16.3792L8.00129 19.0001C8.00129 19.5524 7.55358 20.0001 7.00129 20.0001C6.44901 20.0001 6.00129 19.5524 6.00129 19.0001V15.0001C6.00129 14.4478 5.55358 14.0001 5.00129 14.0001C4.48846 14.0001 4.06578 14.3861 4.00802 14.8835L4.00129 15.0001V16.0001C4.00129 16.5524 3.55358 17.0001 3.00129 17.0001C2.44901 17.0001 2.00129 16.5524 2.00129 16.0001L2.00138 7.21394C1.96402 5.19447 2.68678 3.16356 4.16964 1.58709L4.34315 1.4082ZM4.58437 4.47838L4.5329 4.58823C4.22968 5.2577 4.05601 5.97117 4.01149 6.69097L4.00129 7.00009L4.00024 7.1196C4.01358 8.55874 4.54144 9.9933 5.58066 11.1234L5.75736 11.3077L12.1207 17.6716L14.9491 14.8431L4.58437 4.47838Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
