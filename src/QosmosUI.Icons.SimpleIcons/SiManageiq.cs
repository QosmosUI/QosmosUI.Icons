// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiManageiq : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12.095.1C5.718.094.544 5.26.538 11.637v.022c0 2.069.547 4.005 1.496 5.683l2.869-2.868a7.685 7.685 0 0 1-.54-2.815c0-4.262 3.47-7.73 7.732-7.73s7.732 3.468 7.732 7.73-3.47 7.732-7.732 7.732a7.685 7.685 0 0 1-2.6-.46L6.596 21.83a11.515 11.515 0 0 0 5.499 1.388c2.316 0 4.467-.686 6.275-1.856l2.393 2.392L24 20.512l-2.349-2.349c1.262-1.852 2-4.09 2-6.505C23.66 5.269 18.452.078 12.096.101L12.095.1zm0 9.34c-1.225 0-2.214.991-2.214 2.217s.989 2.215 2.214 2.215a2.216 2.216 0 1 0 0-4.432zm-4.24 3.368C7.57 13.09.273 20.39 0 20.662L3.24 23.9l7.855-7.855-3.24-3.238v.001z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
