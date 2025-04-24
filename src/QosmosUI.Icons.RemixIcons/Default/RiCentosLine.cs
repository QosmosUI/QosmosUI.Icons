// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiCentosLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M12 2L16.292 6.292L17.353 5.232L16.1207 3.99968L20 4L19.9997 7.87868L18.767 6.646L17.707 7.707L22 12L17.708 16.293L18.767 17.352L19.9997 16.1207L20 20L16.1207 19.9997L17.352 18.767L16.293 17.707L12 22L7.707 17.707L6.646 18.767L7.87868 19.9997L4 20L3.99968 16.1207L5.231 17.352L6.292 16.292L2 12L6.293 7.707L5.231 6.646L3.99968 7.87868L4 4L7.87868 3.99968L6.646 5.231L7.708 6.293L12 2ZM12 13.4128L9.12 16.292L12 19.1716L14.879 16.292L12 13.4128ZM7.707 9.121L4.82843 12L7.706 14.878L10.5858 11.9986L7.707 9.121ZM16.292 9.121L13.4149 11.9993L16.293 14.878L19.1716 12L16.292 9.121ZM12 4.82843L9.122 7.707L12.0007 10.5851L14.878 7.706L12 4.82843Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
