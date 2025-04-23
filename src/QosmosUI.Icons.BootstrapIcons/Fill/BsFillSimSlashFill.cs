// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BootstrapIcons.Fill;

public class BsFillSimSlashFill : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "m11.646.44.897.896-1.703 1.703A1.5 1.5 0 0 0 10.5 3h-5A1.5 1.5 0 0 0 4 4.5v5.379l-2 2V1.5A1.5 1.5 0 0 1 3.5 0h7.086a1.5 1.5 0 0 1 1.06.44M8.5 5.378 9.879 4H8.5zM5 8.879 6.879 7H5zm6-1.758L9.121 9H11zm-3.5 3.5L6.121 12H7.5zM5.5 13q-.175 0-.34-.039L2.502 15.62c.265.236.615.38.998.38h9a1.5 1.5 0 0 0 1.5-1.5V4.121l-2 2V11.5a1.5 1.5 0 0 1-1.5 1.5zM5 4.5a.5.5 0 0 1 .5-.5h2v2H5zM8.5 10H11v1.5a.5.5 0 0 1-.5.5h-2zm6.354-8.146a.5.5 0 0 0-.708-.708l-13 13a.5.5 0 0 0 .708.708z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
