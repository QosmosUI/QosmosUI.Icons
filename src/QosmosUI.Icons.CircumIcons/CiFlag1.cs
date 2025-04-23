// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiFlag1 : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Flag_1");
		builder.AddAttribute(15, "data-name", "Flag 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M20.565,3.18a.809.809,0,0,0-.81-.02l-1.13.56c-1.63.87-3.82.83-6.5-.13a9.141,9.141,0,0,0-7.3.52l-.76.41V3.56a.5.5,0,0,0-1,0V20.44a.5.5,0,0,0,1,0V15.9a.836.836,0,0,0,.2-.08l1.03-.55a8.163,8.163,0,0,1,6.5-.46c2.95,1.06,5.41,1.08,7.3.07l1.44-.72a.759.759,0,0,0,.4-.66V3.82A.751.751,0,0,0,20.565,3.18Zm-.63,10.16-1.31.66c-1.63.87-3.82.83-6.5-.13a9.141,9.141,0,0,0-7.3.52l-.76.4V5.65L5.3,4.99a8.122,8.122,0,0,1,6.5-.46c2.95,1.06,5.41,1.08,7.29.08l.85-.43Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
