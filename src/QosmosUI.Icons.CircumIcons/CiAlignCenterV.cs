// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiAlignCenterV : ComponentBase
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
		builder.AddAttribute(14, "id", "Align_Center-V");
		builder.AddAttribute(15, "data-name", "Align Center-V");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M20.446,11.5h-.51V9.07a2.5,2.5,0,0,0-2.5-2.5h-2.43a2.5,2.5,0,0,0-2.5,2.5V11.5H11.5V6.58A2.5,2.5,0,0,0,9,4.08H6.566a2.5,2.5,0,0,0-2.5,2.5V11.5h-.52a.5.5,0,0,0,0,1h.52v4.92a2.5,2.5,0,0,0,2.5,2.5H9a2.5,2.5,0,0,0,2.5-2.5V12.5h1.01v2.43a2.5,2.5,0,0,0,2.5,2.5h2.43a2.5,2.5,0,0,0,2.5-2.5V12.5h.51A.5.5,0,0,0,20.446,11.5ZM10.5,17.42A1.5,1.5,0,0,1,9,18.92H6.566a1.5,1.5,0,0,1-1.5-1.5V12.5H10.5Zm0-5.92H5.066V6.58a1.5,1.5,0,0,1,1.5-1.5H9a1.5,1.5,0,0,1,1.5,1.5Zm8.44,3.43a1.5,1.5,0,0,1-1.5,1.5h-2.43a1.5,1.5,0,0,1-1.5-1.5V12.5h5.43Zm0-3.43h-5.43V9.07a1.5,1.5,0,0,1,1.5-1.5h2.43a1.5,1.5,0,0,1,1.5,1.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
