// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiPickerHalf : ComponentBase
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
		builder.AddAttribute(14, "id", "Picker_Half");
		builder.AddAttribute(15, "data-name", "Picker Half");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M20.936,5.889a2.825,2.825,0,0,0-4.81-2.02l-2.21,2.22-.75-.75a.771.771,0,0,0-.55-.22.8.8,0,0,0-.55.22.785.785,0,0,0,0,1.1l.75.75-8.76,8.76a3.154,3.154,0,0,0-.92,2.13l-.07,1.52a1.316,1.316,0,0,0,1.28,1.35h.06l1.52-.07a3.21,3.21,0,0,0,2.13-.93l8.76-8.76.75.75a.8.8,0,0,0,1.1,0,.785.785,0,0,0,0-1.1l-.75-.75,2.18-2.18A2.845,2.845,0,0,0,20.936,5.889Zm-8.56,8.33H7.2l6.33-6.32,2.59,2.59ZM19.4,7.2l-2.18,2.19L14.626,6.8l2.21-2.22a1.823,1.823,0,0,1,2.56,0,1.859,1.859,0,0,1,0,2.62Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
