// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiTShirtLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M14.5135 5.00008L17.1201 2.39348C17.5106 2.00295 18.1438 2.00295 18.5343 2.39348L22.777 6.63612C23.1675 7.02664 23.1675 7.65981 22.777 8.05033L18.9988 11.8285V21.0001C18.9988 21.5524 18.5511 22.0001 17.9988 22.0001H5.9988C5.44652 22.0001 4.9988 21.5524 4.9988 21.0001V11.8285L1.22063 8.05033C0.830103 7.65981 0.830103 7.02664 1.22063 6.63612L5.46327 2.39348C5.85379 2.00295 6.48696 2.00295 6.87748 2.39348L9.48408 5.00008H14.5135ZM15.3419 7.00008H8.65566L6.17037 4.5148L3.34195 7.34323L6.9988 11.0001V20.0001H16.9988V11.0001L20.6557 7.34323L17.8272 4.5148L15.3419 7.00008Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
