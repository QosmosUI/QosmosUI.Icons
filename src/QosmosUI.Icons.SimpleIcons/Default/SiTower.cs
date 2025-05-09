// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiTower : ComponentBase
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
		builder.AddAttribute(15, "d", "M19.733 11.831c.324 0 .442.028.564.084a.732.732 0 0 1 .3.249c.077.11.126.22.186.538l.265 1.415.015.081H2.937l.015-.08.265-1.416c.06-.318.109-.429.186-.538a.732.732 0 0 1 .3-.25c.122-.055.24-.083.564-.083zm1.149 3.052-1.227 1.743c-.174.246-.248.325-.343.401a.894.894 0 0 1-.315.163c-.117.034-.224.05-.525.05H5.528c-.301 0-.408-.016-.525-.05a.894.894 0 0 1-.315-.163c-.095-.076-.169-.155-.343-.401l-1.227-1.743-.007-.01h17.778a1.073 1.073 0 0 1-.007.01zM2.232 0h19.536c.482 0 .657.05.834.144a.983.983 0 0 1 .408.41c.095.176.145.35.145.833v.945c0 .482-.05.657-.145.833a.983.983 0 0 1-.408.409c-.177.094-.352.144-.834.144H2.232c-.482 0-.657-.05-.834-.144a.983.983 0 0 1-.408-.41c-.095-.175-.145-.35-.145-.832v-.945C.845.904.895.73.99.553a.983.983 0 0 1 .408-.409C1.575.05 1.75 0 2.232 0Zm5.273 4.733 1.028 6.422H4.637L2.75 4.731Zm8.651 0-1.088 6.422H9.209L8.121 4.732Zm5.094.002-1.88 6.422H15.74l1.025-6.423zM8.106 18.254a17.992 17.992 0 0 1 1.567 5.45.338.338 0 0 0 .335.296h3.972c.17 0 .313-.127.334-.296a17.993 17.993 0 0 1 1.567-5.45z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
