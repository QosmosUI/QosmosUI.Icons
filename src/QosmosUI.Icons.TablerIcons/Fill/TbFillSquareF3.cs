// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillSquareF3 : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "d", "M18.333 2c1.96 0 3.56 1.537 3.662 3.472l.005 .195v12.666c0 1.96 -1.537 3.56 -3.472 3.662l-.195 .005h-12.666a3.667 3.667 0 0 1 -3.662 -3.472l-.005 -.195v-12.666c0 -1.96 1.537 -3.56 3.472 -3.662l.195 -.005h12.666zm-3.833 6h-1l-.144 .007a1.5 1.5 0 0 0 -1.356 1.493a1 1 0 0 0 1 1l.117 -.007a1 1 0 0 0 .727 -.457l.02 -.036h.636l.09 .008a.5 .5 0 0 1 0 .984l-.09 .008h-.5l-.133 .007c-1.156 .124 -1.156 1.862 0 1.986l.133 .007h.5l.09 .008a.5 .5 0 0 1 .41 .492l-.008 .09a.5 .5 0 0 1 -.492 .41h-.635l-.02 -.036a1 1 0 0 0 -1.845 .536a1.5 1.5 0 0 0 1.5 1.5h1l.164 -.005a2.5 2.5 0 0 0 2.336 -2.495l-.005 -.164a2.487 2.487 0 0 0 -.477 -1.312l-.019 -.024l.126 -.183a2.5 2.5 0 0 0 -2.125 -3.817zm-4.5 0h-2l-.117 .007a1 1 0 0 0 -.883 .993v6l.007 .117a1 1 0 0 0 .993 .883l.117 -.007a1 1 0 0 0 .883 -.993v-2h1l.117 -.007a1 1 0 0 0 -.117 -1.993h-1v-1h1l.117 -.007a1 1 0 0 0 -.117 -1.993z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
